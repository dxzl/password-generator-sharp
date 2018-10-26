using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinGenRouterKey
{
    public partial class FormMain : Form
    {
        const int DEF_MINCHAR = 33; // '!' (32, space char does not work on all routers)
        const int DEF_MAXCHAR = 126;
        const int DEF_LENGTH = 64; // Netgear user pass max is 32, wifi pass is 64

        int Min, Max, Length;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            // Check limits
            try { Min = Convert.ToInt32(textBoxMin.Text); }
            catch { Min = -1; }

            if (Min < 1 || Min > 65535)
            {
                MessageBox.Show("Min character " + Min.ToString() + " is not allowed!");
                Min = DEF_MINCHAR;
                textBoxMin.Text = Min.ToString();
            }

            try { Max = Convert.ToInt32(textBoxMax.Text); }
            catch { Max = -1; }

            if (Max < 1 || Max > 65535 || Max < Min)
            {
                MessageBox.Show("Max character " + Max.ToString() + " is not allowed!");
                Max = DEF_MAXCHAR;
                textBoxMax.Text = Max.ToString();
            }

            try { Length = Convert.ToInt32(textBoxLength.Text); }
            catch { Length = -1; }

            if (Length < 1 || Length > 2048)
            {
                MessageBox.Show("Length " + Length.ToString() + " is not allowed!");
                Length = DEF_LENGTH;
                textBoxLength.Text = Length.ToString();
            }

            string sKey = "";
            Random r = new Random();

            for (int ii = 0; ii < Length; ii++)
                sKey += (Char)r.Next(Min, Max);

            //TextDataFormat
            Clipboard.SetText(sKey);
            textBoxKey.Text = Clipboard.GetText();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Min = DEF_MINCHAR;
            Max = DEF_MAXCHAR;
            Length = DEF_LENGTH;

            textBoxMin.Text = Min.ToString();
            textBoxMax.Text = Max.ToString();
            textBoxLength.Text = Length.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
