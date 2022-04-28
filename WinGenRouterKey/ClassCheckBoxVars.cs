using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32; // used for registry access...
using System.Windows.Forms;

namespace WinGenRouterKey
{
    // Instantiated object references to this class are stored in the Tag attribute of the checkboxes
    // on panel1 of the FormMain design view.
    public class CheckBoxVars
    {
        public int defMin, defMax, range, numChars;
        public double fraction;
        public TextBox minBox, maxBox;
        public Label minLabel, maxLabel;
        public CheckBox checkBox;
        public CheckState checkState, defCheckState;

        private int min;
        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                min = value;

                if (minBox != null)
                {
                    minBox.Text = min.ToString();
                    minLabel.Text = ((Char)min).ToString();
                    MinHint = min.ToString("X4");
                }
            }
        }

        private int max;
        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                max = value;

                if (maxBox != null)
                {
                    maxBox.Text = max.ToString();
                    maxLabel.Text = ((Char)max).ToString();
                    MaxHint = max.ToString("X4");
                }
            }
        }

        private ToolTip minToolTip;
        public string MinHint
        {
            set
            {
                if (minToolTip != null)
                    minToolTip.SetToolTip(this.minBox, value);
            }
        }

        private ToolTip maxToolTip;
        public string MaxHint
        {
            set
            {
                if (maxToolTip != null)
                    maxToolTip.SetToolTip(this.maxBox, value);
            }
        }

        public CheckBoxVars(int min, int max, CheckState checkState, int defMin, int defMax, CheckState defCheckState, CheckBox checkBox, Label minLabel, Label maxLabel, TextBox minBox, TextBox maxBox)
        {
            this.checkBox = checkBox;
            this.minLabel = minLabel;
            this.maxLabel = maxLabel;
            this.minBox = minBox;
            this.maxBox = maxBox;

            // used in event-processing for text-changed, Etc.
            minLabel.Tag = this;
            maxLabel.Tag = this;
            minBox.Tag = this;
            maxBox.Tag = this;
            checkBox.Tag = this;

            this.min = min;
            string sFmt = (min <= short.MaxValue) ? "X4" : "X8";
            MinHint = min.ToString(sFmt);
            this.max = max;
            sFmt = (max <= short.MaxValue) ? "X4" : "X8";
            MaxHint = max.ToString(sFmt);
            this.defMin = defMin;
            this.defMax = defMax;
            this.checkState = checkState;
            this.defCheckState = defCheckState;

            minToolTip = new ToolTip();
            minToolTip.ShowAlways = true;
            minToolTip.AutoPopDelay = 0;
            minToolTip.ReshowDelay = 10;
            minToolTip.InitialDelay = 10;

            maxToolTip = new ToolTip();
            maxToolTip.ShowAlways = true;
            maxToolTip.AutoPopDelay = 2000;
            maxToolTip.ReshowDelay = 10;
            maxToolTip.InitialDelay = 10;
        }
        public void Restore()
        {
            min = defMin;
            max = defMax;
            checkState = defCheckState;
        }
        public bool DisplayVals()
        {
            if (checkBox == null || minBox == null || maxBox == null || minLabel == null || maxLabel == null)
                return false;

            minBox.Text = min.ToString();
            maxBox.Text = max.ToString();
            minLabel.Text = ((Char)min).ToString();
            maxLabel.Text = ((Char)max).ToString();
            checkBox.CheckState = checkState;

            // set hex-number hints (tool-tips)
            string sFmt = (min <= short.MaxValue) ? "X4" : "X8";
            MinHint = min.ToString(sFmt);
            sFmt = (max <= short.MaxValue) ? "X4" : "X8";
            MaxHint = max.ToString(sFmt);

            return true;
        }
    }
}
