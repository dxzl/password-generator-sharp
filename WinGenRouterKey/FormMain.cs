using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        const int DEF_MAXCHARLENGTH = int.MaxValue;

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
            // 1) get the range from each field if it's "on" and "include"
            //
            // 2) assign each include field a weight based on the % of the overall range of all fields
            //
            // 3) get the # of chars in the total length of the password that should be assigned to each field
            //    based on the % of the total range the particular field represents
            //
            // 4) make a List the length of the password to be generated and select x chars from field 1,
            //    y chars from field 2, Etc. and add the # of chars for that field to the list.
            //
            // 5) now randomly select indices from the list to populate the password box - Voila!

            try { pwLength = Convert.ToInt32(textBoxLength.Text); }
            catch { pwLength = -1; }

            if (pwLength < 1 || pwLength > DEF_MAXLENGTH)
            {
                MessageBox.Show("Length " + pwLength.ToString() + " is not allowed!");
                pwLength = DEF_LENGTH;
                textBoxLength.Text = pwLength.ToString();
            }

            string sKey = "";
            int iTotalRange = 0;
            int iBiggestRange = 0;
            CheckBoxVars cbv = null;

            // Check limits of enabled fields
            for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
            {
                string sCheckBox = "checkBox" + (ii + 1).ToString();
                CheckBox checkBox = (CheckBox)panel1.Controls.Find(sCheckBox, true)[0];

                if (checkBox.CheckState == CheckState.Unchecked)
                    continue;

                var v = (CheckBoxVars)checkBox.Tag;

                int iMin, iMax;

                try { iMin = Convert.ToInt32(v.minBox.Text); }
                catch { iMin = -1; }

                if (iMin < 1 || iMin > DEF_MAXCHARLENGTH)
                {
                    MessageBox.Show("Min character at (" + iMin.ToString() + ") at " + (ii + 1).ToString() + " is not allowed!");
                    return;
                }

                try { iMax = Convert.ToInt32(v.maxBox.Text); }
                catch { iMax = -1; }

                if (iMax < 1 || iMax > DEF_MAXCHARLENGTH)
                {
                    MessageBox.Show("Max character (" + iMax.ToString() + ") at " + (ii + 1).ToString() + " is not allowed!");
                    return;
                }

                if (iMin > iMax)
                {
                    MessageBox.Show("Min (" + iMin.ToString() + ") is > Max (" + iMax.ToString() + ") at " + (ii + 1).ToString() + "!");
                    return;
                }

                // set and display
                v.Min = iMin;
                v.Max = iMax;

                v.range = v.Max - v.Min;
                iTotalRange += v.range;

                // save reference to our vars with the most range
                if (v.range > iBiggestRange)
                {
                    iBiggestRange = v.range;
                    cbv = v; // have our vars handy for use (below)!
                }
            }

            var l = new List<Char>();
            var r = new Random();
            int iRetries = 0;

            // get the range deltas for included fields
            for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
            {
                string sCheckBox = "checkBox" + (ii + 1).ToString();
                CheckBox checkBox = (CheckBox)panel1.Controls.Find(sCheckBox, true)[0];

                if (checkBox.CheckState != CheckState.Checked)
                    continue;

                var v = (CheckBoxVars)checkBox.Tag;

                v.fraction = v.range/(double)iTotalRange;
                v.numChars = (int)Math.Round(v.fraction * pwLength);

                for (int jj = 0; jj < v.numChars; jj++)
                {
                    if (l.Count < pwLength)
                    {
                        if (v.Min <= v.Max + 1)
                        {
                            Char c = (Char)r.Next(v.Min, v.Max + 1);
                            if (!IsExcluded(c))
                                l.Add(c);
                            else
                            {
                                if (++iRetries > pwLength * DEF_RETRIES)
                                {
                                    MessageBox.Show("Unable to generate key with current settings (1).");
                                    return;
                                }

                                jj--; // continue on and retry for a non-excluded char
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Min is < Max at: " + (ii+1).ToString());
                            break;
                        }
                    }
                }
            }

            iRetries = 0;

            // this is sort of a fudge for padding out the password, if needed.
            // cbv is set above...
            if (cbv != null)
            {
                while (l.Count < pwLength)
                {
                    Char c = (Char)r.Next(cbv.Min, cbv.Max+1);
                    if (!IsExcluded(c))
                        l.Add(c);
                    else
                    {
                        if (++iRetries > pwLength * DEF_RETRIES)
                        {
                            MessageBox.Show("Unable to generate key with current settings (2).");
                            return;
                        }
                    }
                }
            }

            while (l.Count > 0)
            {
                int idx = r.Next(l.Count);
                sKey += l[idx];
                l.RemoveAt(idx);
            }

            textBoxKey.Text = sKey;
        }

        //---------------------------------------------------------------------------
        private bool IsExcluded(Char c)
        {
            // Check limits of enabled fields
            for (int ii = 0; ii < DEF_FIELD_COUNT; ii++)
            {
                string sCheckBox = "checkBox" + (ii + 1).ToString();
                CheckBox checkBox = (CheckBox)panel1.Controls.Find(sCheckBox, true)[0];

                if (checkBox.CheckState != CheckState.Indeterminate)
                    continue;

                var v = (CheckBoxVars)checkBox.Tag;

                if (c >= v.Min && c <= v.Max)
                    return true;
            }

            return false;
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
                var c = (CheckBox)sender;
                var v = (CheckBoxVars)c.Tag;
                if (v == null) return;
                v.checkState = v.checkBox.CheckState;
            }
        }
        //---------------------------------------------------------------------------
        private void TextBox_MinTextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var t = (TextBox)sender;
                var v = (CheckBoxVars)t.Tag;
                if (v == null) return;

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
                var t = (TextBox)sender;
                var v = (CheckBoxVars)t.Tag;
                if (v == null) return;

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
            RegistryRead(); // read in the registry values

            labelPh.Text = "(For Netgear AC750, user pass max length is 32 chars, wifi pass max length is 64, min char is 33, max char is 126.\n" +
                "We suggest 32 chars max wifi password length as some wifi cameras have 32 max unicode characters.)";
            labelMin.Text = "Min (1-" + DEF_MAXCHARLENGTH.ToString() + ")";
            labelMax.Text = "Max (1-" + DEF_MAXCHARLENGTH.ToString() + ")";
        }
        //---------------------------------------------------------------------------
        void RegistryRead()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY, false))
            {
                if (key != null)
                {
                    try
                    {
                        int min = (int)key.GetValue("iMin1", DEF_MINCHAR1);
                        int max = (int)key.GetValue("iMax1", DEF_MAXCHAR1);
                        CheckState checkState = IntToCheckState((int)key.GetValue("checkState1", CheckStateToInt(DEF_CHECKSTATE1)));
                        t[0] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR1, DEF_MAXCHAR1, DEF_CHECKSTATE1, checkBox1, labelMin1, labelMax1, textBoxMin1, textBoxMax1);
                        t[0].DisplayVals();

                        min = (int)key.GetValue("iMin2", DEF_MINCHAR2);
                        max = (int)key.GetValue("iMax2", DEF_MAXCHAR2);
                        checkState = IntToCheckState((int)key.GetValue("checkState2", CheckStateToInt(DEF_CHECKSTATE2)));
                        t[1] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR2, DEF_MAXCHAR2, DEF_CHECKSTATE2, checkBox2, labelMin2, labelMax2, textBoxMin2, textBoxMax2);
                        t[1].DisplayVals();

                        min = (int)key.GetValue("iMin3", DEF_MINCHAR3);
                        max = (int)key.GetValue("iMax3", DEF_MAXCHAR3);
                        checkState = IntToCheckState((int)key.GetValue("checkState3", CheckStateToInt(DEF_CHECKSTATE3)));
                        t[2] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR3, DEF_MAXCHAR3, DEF_CHECKSTATE3, checkBox3, labelMin3, labelMax3, textBoxMin3, textBoxMax3);
                        t[2].DisplayVals();

                        min = (int)key.GetValue("iMin4", DEF_MINCHAR4);
                        max = (int)key.GetValue("iMax4", DEF_MAXCHAR4);
                        checkState = IntToCheckState((int)key.GetValue("checkState4", CheckStateToInt(DEF_CHECKSTATE4)));
                        t[3] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR4, DEF_MAXCHAR4, DEF_CHECKSTATE4, checkBox4, labelMin4, labelMax4, textBoxMin4, textBoxMax4);
                        t[3].DisplayVals();

                        min = (int)key.GetValue("iMin5", DEF_MINCHAR5);
                        max = (int)key.GetValue("iMax5", DEF_MAXCHAR5);
                        checkState = IntToCheckState((int)key.GetValue("checkState5", CheckStateToInt(DEF_CHECKSTATE5)));
                        t[4] = new CheckBoxVars(min, max, checkState, DEF_MINCHAR5, DEF_MAXCHAR5, DEF_CHECKSTATE5, checkBox5, labelMin5, labelMax5, textBoxMin5, textBoxMax5);
                        t[4].DisplayVals();

                        pwLength = (int)key.GetValue("iLength", DEF_LENGTH);
                        textBoxLength.Text = pwLength.ToString();
                    }
                    catch { }
                }
            }
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
                        key.SetValue("iMin" + (ii + 1).ToString(), t[ii].Min);
                        key.SetValue("iMax" + (ii + 1).ToString(), t[ii].Max);
                        key.SetValue("checkState" + (ii + 1).ToString(), CheckStateToInt(t[ii].checkState));
                    }

                    key.SetValue("iLength", pwLength);
                }
                catch
                {
                    return false;
                }
            }
            return true;
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
            if(hexBox != null)
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
