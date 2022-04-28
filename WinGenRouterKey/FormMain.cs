using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32; // used for registry access...

/// <summary>
///  https://www.fileformat.info/info/charset/UTF-16/list.htm
/// </summary>
namespace WinGenRouterKey
{
    public partial class FormMain : Form
    {
        internal const string REGISTRY_KEY = @"SOFTWARE\Discrete-Time Systems\PassGen";

        public const int DEF_FIELD_COUNT = 5; // number of checkbox fields

        public const int DEF_MINCHAR1 = 33;
        public const int DEF_MAXCHAR1 = 47;
        public const CheckState DEF_CHECKSTATE1 = CheckState.Unchecked;

        public const int DEF_MINCHAR2 = 48;
        public const int DEF_MAXCHAR2 = 57;
        public const CheckState DEF_CHECKSTATE2 = CheckState.Checked;

        public const int DEF_MINCHAR3 = 58;
        public const int DEF_MAXCHAR3 = 64;
        public const CheckState DEF_CHECKSTATE3 = CheckState.Unchecked;

        public const int DEF_MINCHAR4 = 65;
        public const int DEF_MAXCHAR4 = 90;
        public const CheckState DEF_CHECKSTATE4 = CheckState.Checked;

        public const int DEF_MINCHAR5 = 97;
        public const int DEF_MAXCHAR5 = 122;
        public const CheckState DEF_CHECKSTATE5 = CheckState.Checked;

        const int DEF_LENGTH = 32; // Netgear user pass max is 32, wifi pass is 64 but wifi camera max is 32 unicode chars...
        const int DEF_MAXLENGTH = 2048;
        const int DEF_MAXCHARLENGTH = 65535;

        const int DEF_RETRIES = 10; // try again 10 * pwLength

        CheckBoxVars[] t = new CheckBoxVars[DEF_FIELD_COUNT];

        int pwLength;

        string sHexStr = "";
        TextBox hexBox = null;

        //---------------------------------------------------------------------------
        public FormMain()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------------------
        private void buttonGen_Click(object sender, EventArgs e)
        {
            // strategy:
            // 1) check the min and max ranges for each field.
            // 2) add each field to a HashSet and then UnionWith if checkbox for field is checked
            //    or ExceptWith if checkbox is greyed.
            // 3) convert global HashSet to a List then randomly select and add entries to the output key,
            //    deleting entries from the list if user checks "use each char only once".
            // 4) If the password is short of the key and UseOnlyOnce is checked, print message and truncate Max Keylength

            try { pwLength = Convert.ToInt32(textBoxLength.Text); }
            catch { pwLength = -1; }

            if (pwLength < 1 || pwLength > DEF_MAXLENGTH)
            {
                MessageBox.Show("Length " + pwLength.ToString() + " is not allowed!");
                pwLength = DEF_LENGTH;
                textBoxLength.Text = pwLength.ToString();
            }

            string sKey = "";
            var ghashSet = new HashSet<UInt16>();

            // Check limits of enabled fields
            for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
            {
                //string sCheckBox = "checkBox" + (ii + 1).ToString();
                //CheckBox checkBox = panel1.Controls.Find(sCheckBox, true)[0] as CheckBox;

                CheckBoxVars v = t[ii];

                if (v.checkState != CheckState.Checked)
                    continue;

                int min = v.Min;
                int max = v.Max;

                if (min < 1 || max > DEF_MAXCHARLENGTH)
                {
                    MessageBox.Show("Min character (" + min.ToString() + ") at " + (ii + 1).ToString() + " is not allowed!");
                    return;
                }

                if (max < 1 || max > DEF_MAXCHARLENGTH)
                {
                    MessageBox.Show("Max character (" + max.ToString() + ") at " + (ii + 1).ToString() + " is not allowed!");
                    return;
                }

                if (min > max)
                {
                    MessageBox.Show("Min (" + v.Min.ToString() + ") is > Max (" + max.ToString() + ") at " + (ii + 1).ToString() + "!");
                    return;
                }

                var lhashSet = new HashSet<UInt16>();
                for (int jj = min; jj <= max; jj++)
                    lhashSet.Add((UInt16)jj);
                ghashSet.UnionWith(lhashSet);
            }

            for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
            {
                CheckBoxVars v = t[ii];
                if (v.checkState == CheckState.Indeterminate)
                {
                    var lhashSet = new HashSet<UInt16>();
                    int max = v.Max;
                    for (int jj = v.Min; jj <= max; jj++)
                        lhashSet.Add((UInt16)jj);
                    ghashSet.ExceptWith(lhashSet);
                }
            }

            List<UInt16> pwList = ghashSet.ToList();
            var r = new Random();
            bool bRemove = cbUseOnlyOnce.CheckState == CheckState.Checked;

            for (int ii = 0; ii < pwLength && pwList.Count > 0; ii++)
            {
                int idx = r.Next(pwList.Count);
                sKey += (Char)pwList[idx];
                if (bRemove)
                    pwList.RemoveAt(idx);
            }

            if (sKey.Length < pwLength)
                textBoxLength.Text = sKey.Length.ToString();

            textBoxKey.Text = sKey;
        }
        //---------------------------------------------------------------------------
        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (textBoxKey.Text.Length > 0)
            {
                try { Clipboard.SetText(textBoxKey.Text); }
                catch { MessageBox.Show("Unable to copy key to your Windows clipboard... please try again."); }
            }
        }
        //---------------------------------------------------------------------------
        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                var c = sender as CheckBox;
                if (c == null || c.Tag == null) return;
                var v = c.Tag as CheckBoxVars;
                v.checkState = v.checkBox.CheckState;
            }
        }
        //---------------------------------------------------------------------------
        private void TextBox_MinTextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var t = sender as TextBox;
                if (t == null || t.Tag == null) return;
                var v = t.Tag as CheckBoxVars;

                long iC = -1;

                try { iC = Convert.ToInt32(t.Text); }
                catch { iC = -1; }

                if (iC > DEF_MAXCHARLENGTH)
                    t.Text = DEF_MAXCHARLENGTH.ToString(); // retriggers this call to set v.max!
                else if (iC >= 0)
                    v.Min = (int)iC; // set and display
                else if (t.Text.Length > 0) // if not a number
                {
                    // get the most recent char and clear the box - put that char in the
                    // label field and compute the decimal number for it to put in this box
                    var c = (Char)t.Text[t.Text.Length - 1];
                    t.Text = ((int)c).ToString(); // triggers this routine again!
                }
            }
        }
        //---------------------------------------------------------------------------
        private void TextBox_MaxTextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var t = sender as TextBox;
                if (t == null || t.Tag == null) return;
                var v = t.Tag as CheckBoxVars;

                long iC = -1;

                // this is useful knowledge for use elsewhere someday! :-)
                //if (ModifierKeys.HasFlag(Keys.Control))
                //if (ModifierKeys.HasFlag(Keys.Alt))

                try { iC = Convert.ToInt32(t.Text); }
                catch { iC = -1; }

                if (iC > DEF_MAXCHARLENGTH)
                    t.Text = DEF_MAXCHARLENGTH.ToString(); // retriggers this call to set v.max!
                else if (iC >= 0)
                    v.Max = (int)iC; // set and display
                else if (t.Text.Length > 0) // if not a number
                {
                    // get the most recent char and clear the box - put that char in the
                    // label field and compute the decimal number for it to put in this box
                    var c = (Char)t.Text[t.Text.Length - 1];
                    t.Text = ((int)c).ToString(); // triggers this routine again!
                }
            }
        }
        //---------------------------------------------------------------------------
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save settings
            RegistryWrite();
        }

        //---------------------------------------------------------------------------
        private void AzAZ09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetBoxes();
        }
        //---------------------------------------------------------------------------
        private void FormMain_Load(object sender, EventArgs e)
        {
            // read in the registry values and load defaults if exception thrown (non-existent key)
            RegistryRead();

            labelPh.Text = "A randomly generated password is taken from the union of checkmarked fields minus the characters from range-fields \n" +
                "with a black square. The black square in a checkbox means \"exclude this range of characters from the password.\"";
            labelMin.Text = "Min (1-" + DEF_MAXCHARLENGTH.ToString() + ")";
            labelMax.Text = "Max (1-" + DEF_MAXCHARLENGTH.ToString() + ")";
        }
        //---------------------------------------------------------------------------
        bool RegistryRead()
        {
            bool bRet = false;

            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY))
            {
                if (key != null)
                {
                    try
                    {
                        int min = RegGetInt(key, "iMin0001", DEF_MINCHAR1);
                        int max = RegGetInt(key, "iMax0001", DEF_MAXCHAR1);
                        CheckState checkState = IntToCheckState(RegGetInt(key, "checkState0001", CheckStateToInt(DEF_CHECKSTATE1)));
                        t[0] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR1, DEF_MAXCHAR1, DEF_CHECKSTATE1, checkBox1, labelMin1, labelMax1, textBoxMin1, textBoxMax1);
                        t[0].DisplayVals();

                        min = RegGetInt(key, "iMin0002", DEF_MINCHAR2);
                        max = RegGetInt(key, "iMax0002", DEF_MAXCHAR2);
                        checkState = IntToCheckState(RegGetInt(key, "checkState0002", CheckStateToInt(DEF_CHECKSTATE2)));
                        t[1] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR2, DEF_MAXCHAR2, DEF_CHECKSTATE2, checkBox2, labelMin2, labelMax2, textBoxMin2, textBoxMax2);
                        t[1].DisplayVals();

                        min = RegGetInt(key, "iMin0003", DEF_MINCHAR3);
                        max = RegGetInt(key, "iMax0003", DEF_MAXCHAR3);
                        checkState = IntToCheckState(RegGetInt(key, "checkState0003", CheckStateToInt(DEF_CHECKSTATE3)));
                        t[2] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR3, DEF_MAXCHAR3, DEF_CHECKSTATE3, checkBox3, labelMin3, labelMax3, textBoxMin3, textBoxMax3);
                        t[2].DisplayVals();

                        min = RegGetInt(key, "iMin0004", DEF_MINCHAR4);
                        max = RegGetInt(key, "iMax0004", DEF_MAXCHAR4);
                        checkState = IntToCheckState(RegGetInt(key, "checkState0004", CheckStateToInt(DEF_CHECKSTATE4)));
                        t[3] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR4, DEF_MAXCHAR4, DEF_CHECKSTATE4, checkBox4, labelMin4, labelMax4, textBoxMin4, textBoxMax4);
                        t[3].DisplayVals();

                        min = RegGetInt(key, "iMin0005", DEF_MINCHAR5);
                        max = RegGetInt(key, "iMax0005", DEF_MAXCHAR5);
                        checkState = IntToCheckState(RegGetInt(key, "checkState0005", CheckStateToInt(DEF_CHECKSTATE5)));
                        t[4] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR5, DEF_MAXCHAR5, DEF_CHECKSTATE5, checkBox5, labelMin5, labelMax5, textBoxMin5, textBoxMax5);
                        t[4].DisplayVals();

                        pwLength = RegGetInt(key, "iLength000", DEF_LENGTH);
                        textBoxLength.Text = pwLength.ToString();

                        bRet = true;
                    }
                    catch { }
                }
            }
            return bRet;
        }
        //---------------------------------------------------------------------------
        private int RegGetInt(RegistryKey key, string sKey, int iDef)
        {
            try
            {
                return (int)key.GetValue(sKey);
            }
            catch
            {
                return iDef;
            }
        }
        //---------------------------------------------------------------------------
        private bool RegistryWrite()
        {
            RegistryKey key;

            using (key = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY, true))
            {
                if ((key = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY)) == null)
                    return false;

                try
                {
                    for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
                    {
                        key.SetValue("iMin000" + (ii + 1).ToString(), t[ii].Min);
                        key.SetValue("iMax000" + (ii + 1).ToString(), t[ii].Max);
                        key.SetValue("checkState000" + (ii + 1).ToString(), CheckStateToInt(t[ii].checkState));
                    }

                    key.SetValue("iLength000", pwLength);
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        //---------------------------------------------------------------------------
        private CheckState IntToCheckState(int i)
        {
            if (i == 1)
                return CheckState.Checked;
            if (i == 2)
                return CheckState.Indeterminate;
            return CheckState.Unchecked;
        }
        //---------------------------------------------------------------------------
        private int CheckStateToInt(CheckState cs)
        {
            if (cs == CheckState.Checked)
                return 1;
            if (cs == CheckState.Indeterminate)
                return 2;
            return 0; // unchecked
        }
        //---------------------------------------------------------------------------
        private void ResetBoxes()
        {
            for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
                t[ii].Restore();

            pwLength = DEF_LENGTH;

            DisplayBoxes();
        }
        //---------------------------------------------------------------------------
        private void DisplayBoxes()
        {
            for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
                t[ii].DisplayVals();

            textBoxLength.Text = pwLength.ToString();
        }
        //---------------------------------------------------------------------------
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string s = "To enter a unicode character in hex:\n" +
            //    "Type 0x followed by the hex digits.";
            string s = "To enter a unicode character in hex:\n\n" +
                "Click the box you want.\n" +
                "Press and hold the ALT key.\n" +
                "Type the hex digits that represent the character (a-f, 0-9).\n" +
                "Release the ALT key.\n\n" +
                "Unchecked = The range is turned off and will not affect the generated password.\n" +
                "Checked = The range is included in the generated password.\n" +
                "Indeterminate = The range is excluded from the generated password.\n";
            MessageBox.Show(s);
        }
        //---------------------------------------------------------------------------
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            Control c = FindFocusedControl(this);

            if (!(c is TextBox) || !e.Alt)
            {
                EndHexMode();
                return;
            }

            bool bMin = c.Name.Contains("Min");
            bool bMax = c.Name.Contains("Max");

            if (!bMin && !bMax)
            {
                EndHexMode();
                return;
            }

            Keys k = e.KeyCode;
            if (hexBox == null)
            {
                hexBox = c as TextBox;
                sHexStr = "";
            }

            //MessageBox.Show("here");

            Char ch = (Char)e.KeyValue;

            if (Char.IsLetterOrDigit(ch))
            {
                if ((ch >= 'a' && ch <= 'f') || (ch >= 'A' && ch <= 'F') || (ch >= '0' && ch <= '9'))
                {
                    if (sHexStr.Length < 8)
                    {
                        sHexStr += ch;
                        var v = hexBox.Tag as CheckBoxVars;
                        if (v != null)
                        {
                            var l = bMin ? v.minLabel : v.maxLabel;
                            if (l != null)
                                l.Text = sHexStr;
                        }
                    }
                    else
                        EndHexMode();
                }
            }
            e.SuppressKeyPress = true;
            return;
        }
        //---------------------------------------------------------------------------
        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (!e.Alt && hexBox != null)
            {
                // process entered hex string
                var v = hexBox.Tag as CheckBoxVars;
                if (v != null)
                {
                    long n;

                    //MessageBox.Show(sHexStr);

                    try { n = Int64.Parse(sHexStr, System.Globalization.NumberStyles.HexNumber); }
                    catch { n = -1; }

                    if (n >= 0)
                    {
                        if (n > int.MaxValue)
                            n = int.MaxValue;

                        if (hexBox.Name.Contains("Min"))
                            v.Min = (int)n; // set and display
                        else
                            v.Max = (int)n; // set and display
                    }
                }

                // EndHexMode()
                hexBox = null;
                sHexStr = "";
            }
        }
        //---------------------------------------------------------------------------
        private void EndHexMode()
        {
            if (hexBox != null)
            {
                var v = hexBox.Tag as CheckBoxVars;

                if (v != null)
                    v.DisplayVals();

                hexBox = null;
                sHexStr = "";
            }
        }
        //---------------------------------------------------------------------------
        public static Control FindFocusedControl(Control control)
        {
            var container = control as IContainerControl;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as IContainerControl;
            }
            return control;
        }
    }
}
