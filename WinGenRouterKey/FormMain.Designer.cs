namespace WinGenRouterKey
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonGen = new System.Windows.Forms.Button();
            textBoxKey = new System.Windows.Forms.TextBox();
            buttonClose = new System.Windows.Forms.Button();
            textBoxLength = new System.Windows.Forms.TextBox();
            labelMin = new System.Windows.Forms.Label();
            labelMax = new System.Windows.Forms.Label();
            labelLength = new System.Windows.Forms.Label();
            labelPh = new System.Windows.Forms.Label();
            buttonCopyToClipboard = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            azAZ09ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            base64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1 = new System.Windows.Forms.Panel();
            groupBox5 = new System.Windows.Forms.GroupBox();
            checkBox5 = new System.Windows.Forms.CheckBox();
            labelMax5 = new System.Windows.Forms.Label();
            labelMin5 = new System.Windows.Forms.Label();
            textBoxMin5 = new System.Windows.Forms.TextBox();
            textBoxMax5 = new System.Windows.Forms.TextBox();
            groupBox4 = new System.Windows.Forms.GroupBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            labelMax4 = new System.Windows.Forms.Label();
            labelMin4 = new System.Windows.Forms.Label();
            textBoxMin4 = new System.Windows.Forms.TextBox();
            textBoxMax4 = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            labelMax3 = new System.Windows.Forms.Label();
            labelMin3 = new System.Windows.Forms.Label();
            textBoxMin3 = new System.Windows.Forms.TextBox();
            textBoxMax3 = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            labelMax2 = new System.Windows.Forms.Label();
            labelMin2 = new System.Windows.Forms.Label();
            textBoxMin2 = new System.Windows.Forms.TextBox();
            textBoxMax2 = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            labelMax1 = new System.Windows.Forms.Label();
            labelMin1 = new System.Windows.Forms.Label();
            textBoxMin1 = new System.Windows.Forms.TextBox();
            textBoxMax1 = new System.Windows.Forms.TextBox();
            cbUseOnlyOnce = new System.Windows.Forms.CheckBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGen
            // 
            buttonGen.Location = new System.Drawing.Point(14, 189);
            buttonGen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonGen.Name = "buttonGen";
            buttonGen.Size = new System.Drawing.Size(240, 27);
            buttonGen.TabIndex = 0;
            buttonGen.Text = "&Generate Key";
            buttonGen.UseVisualStyleBackColor = true;
            buttonGen.Click += buttonGen_Click;
            // 
            // textBoxKey
            // 
            textBoxKey.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxKey.Location = new System.Drawing.Point(0, 24);
            textBoxKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new System.Drawing.Size(819, 23);
            textBoxKey.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonClose.Location = new System.Drawing.Point(14, 308);
            buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(240, 27);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Cl&ose";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textBoxLength
            // 
            textBoxLength.Location = new System.Drawing.Point(83, 89);
            textBoxLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new System.Drawing.Size(84, 23);
            textBoxLength.TabIndex = 5;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new System.Drawing.Point(360, 70);
            labelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMin.Name = "labelMin";
            labelMin.Size = new System.Drawing.Size(106, 15);
            labelMin.TabIndex = 6;
            labelMin.Text = "Min Char (1-nnnn)";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new System.Drawing.Point(524, 70);
            labelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMax.Name = "labelMax";
            labelMax.Size = new System.Drawing.Size(107, 15);
            labelMax.TabIndex = 7;
            labelMax.Text = "Max Char (1-nnnn)";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new System.Drawing.Point(79, 70);
            labelLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLength.Name = "labelLength";
            labelLength.Size = new System.Drawing.Size(90, 15);
            labelLength.TabIndex = 8;
            labelLength.Text = "Length (1-2048)";
            // 
            // labelPh
            // 
            labelPh.AutoSize = true;
            labelPh.Location = new System.Drawing.Point(14, 373);
            labelPh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPh.Name = "labelPh";
            labelPh.Size = new System.Drawing.Size(551, 15);
            labelPh.TabIndex = 9;
            labelPh.Text = "A blank checkbox = off, a grey box means \"exclude\" the range, a plain check means \"include\" the range";
            // 
            // buttonCopyToClipboard
            // 
            buttonCopyToClipboard.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonCopyToClipboard.Location = new System.Drawing.Point(14, 240);
            buttonCopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            buttonCopyToClipboard.Size = new System.Drawing.Size(240, 27);
            buttonCopyToClipboard.TabIndex = 10;
            buttonCopyToClipboard.Text = "&Copy to clipboard";
            buttonCopyToClipboard.UseVisualStyleBackColor = true;
            buttonCopyToClipboard.Click += buttonCopyToClipboard_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { presetsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(819, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // presetsToolStripMenuItem
            // 
            presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { azAZ09ToolStripMenuItem, base64ToolStripMenuItem });
            presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            presetsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            presetsToolStripMenuItem.Text = "&Presets";
            // 
            // azAZ09ToolStripMenuItem
            // 
            azAZ09ToolStripMenuItem.Name = "azAZ09ToolStripMenuItem";
            azAZ09ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            azAZ09ToolStripMenuItem.Text = "a-z A-Z 0-9";
            azAZ09ToolStripMenuItem.ToolTipText = "Genetates a 63-character password for most routers";
            azAZ09ToolStripMenuItem.Click += AzAZ09ToolStripMenuItem_Click;
            // 
            // base64ToolStripMenuItem
            // 
            base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            base64ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            base64ToolStripMenuItem.Text = "Web-Safe Base 64";
            base64ToolStripMenuItem.ToolTipText = "Generates a web-safe base-64 random table";
            base64ToolStripMenuItem.Click += base64ToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            helpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new System.Drawing.Point(282, 89);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(418, 246);
            panel1.TabIndex = 12;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkBox5);
            groupBox5.Controls.Add(labelMax5);
            groupBox5.Controls.Add(labelMin5);
            groupBox5.Controls.Add(textBoxMin5);
            groupBox5.Controls.Add(textBoxMax5);
            groupBox5.Location = new System.Drawing.Point(4, 200);
            groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox5.Size = new System.Drawing.Size(411, 42);
            groupBox5.TabIndex = 34;
            groupBox5.TabStop = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox5.Location = new System.Drawing.Point(28, 12);
            checkBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new System.Drawing.Size(32, 19);
            checkBox5.TabIndex = 30;
            checkBox5.Text = "5";
            checkBox5.ThreeState = true;
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckStateChanged += CheckBox_CheckStateChanged;
            // 
            // labelMax5
            // 
            labelMax5.AutoSize = true;
            labelMax5.Location = new System.Drawing.Point(342, 13);
            labelMax5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMax5.Name = "labelMax5";
            labelMax5.Size = new System.Drawing.Size(38, 15);
            labelMax5.TabIndex = 29;
            labelMax5.Text = "label1";
            // 
            // labelMin5
            // 
            labelMin5.AutoSize = true;
            labelMin5.Location = new System.Drawing.Point(178, 13);
            labelMin5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMin5.Name = "labelMin5";
            labelMin5.Size = new System.Drawing.Size(38, 15);
            labelMin5.TabIndex = 28;
            labelMin5.Text = "label1";
            // 
            // textBoxMin5
            // 
            textBoxMin5.Location = new System.Drawing.Point(86, 9);
            textBoxMin5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMin5.Name = "textBoxMin5";
            textBoxMin5.Size = new System.Drawing.Size(84, 23);
            textBoxMin5.TabIndex = 27;
            textBoxMin5.Text = "48";
            textBoxMin5.TextChanged += TextBox_MinTextChanged;
            // 
            // textBoxMax5
            // 
            textBoxMax5.Location = new System.Drawing.Point(250, 9);
            textBoxMax5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMax5.Name = "textBoxMax5";
            textBoxMax5.Size = new System.Drawing.Size(84, 23);
            textBoxMax5.TabIndex = 26;
            textBoxMax5.Text = "57";
            textBoxMax5.TextChanged += TextBox_MaxTextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBox4);
            groupBox4.Controls.Add(labelMax4);
            groupBox4.Controls.Add(labelMin4);
            groupBox4.Controls.Add(textBoxMin4);
            groupBox4.Controls.Add(textBoxMax4);
            groupBox4.Location = new System.Drawing.Point(4, 151);
            groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox4.Size = new System.Drawing.Size(411, 42);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox4.Location = new System.Drawing.Point(28, 12);
            checkBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(32, 19);
            checkBox4.TabIndex = 30;
            checkBox4.Text = "4";
            checkBox4.ThreeState = true;
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckStateChanged += CheckBox_CheckStateChanged;
            // 
            // labelMax4
            // 
            labelMax4.AutoSize = true;
            labelMax4.Location = new System.Drawing.Point(342, 13);
            labelMax4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMax4.Name = "labelMax4";
            labelMax4.Size = new System.Drawing.Size(38, 15);
            labelMax4.TabIndex = 29;
            labelMax4.Text = "label1";
            // 
            // labelMin4
            // 
            labelMin4.AutoSize = true;
            labelMin4.Location = new System.Drawing.Point(178, 13);
            labelMin4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMin4.Name = "labelMin4";
            labelMin4.Size = new System.Drawing.Size(38, 15);
            labelMin4.TabIndex = 28;
            labelMin4.Text = "label1";
            // 
            // textBoxMin4
            // 
            textBoxMin4.Location = new System.Drawing.Point(86, 9);
            textBoxMin4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMin4.Name = "textBoxMin4";
            textBoxMin4.Size = new System.Drawing.Size(84, 23);
            textBoxMin4.TabIndex = 27;
            textBoxMin4.Text = "48";
            textBoxMin4.TextChanged += TextBox_MinTextChanged;
            // 
            // textBoxMax4
            // 
            textBoxMax4.Location = new System.Drawing.Point(250, 9);
            textBoxMax4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMax4.Name = "textBoxMax4";
            textBoxMax4.Size = new System.Drawing.Size(84, 23);
            textBoxMax4.TabIndex = 26;
            textBoxMax4.Text = "57";
            textBoxMax4.TextChanged += TextBox_MaxTextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(labelMax3);
            groupBox3.Controls.Add(labelMin3);
            groupBox3.Controls.Add(textBoxMin3);
            groupBox3.Controls.Add(textBoxMax3);
            groupBox3.Location = new System.Drawing.Point(4, 100);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(411, 44);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox3.Location = new System.Drawing.Point(28, 12);
            checkBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(32, 19);
            checkBox3.TabIndex = 30;
            checkBox3.Text = "3";
            checkBox3.ThreeState = true;
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckStateChanged += CheckBox_CheckStateChanged;
            // 
            // labelMax3
            // 
            labelMax3.AutoSize = true;
            labelMax3.Location = new System.Drawing.Point(342, 13);
            labelMax3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMax3.Name = "labelMax3";
            labelMax3.Size = new System.Drawing.Size(38, 15);
            labelMax3.TabIndex = 29;
            labelMax3.Text = "label1";
            // 
            // labelMin3
            // 
            labelMin3.AutoSize = true;
            labelMin3.Location = new System.Drawing.Point(178, 13);
            labelMin3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMin3.Name = "labelMin3";
            labelMin3.Size = new System.Drawing.Size(38, 15);
            labelMin3.TabIndex = 28;
            labelMin3.Text = "label1";
            // 
            // textBoxMin3
            // 
            textBoxMin3.Location = new System.Drawing.Point(86, 9);
            textBoxMin3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMin3.Name = "textBoxMin3";
            textBoxMin3.Size = new System.Drawing.Size(84, 23);
            textBoxMin3.TabIndex = 27;
            textBoxMin3.Text = "48";
            textBoxMin3.TextChanged += TextBox_MinTextChanged;
            // 
            // textBoxMax3
            // 
            textBoxMax3.Location = new System.Drawing.Point(250, 9);
            textBoxMax3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMax3.Name = "textBoxMax3";
            textBoxMax3.Size = new System.Drawing.Size(84, 23);
            textBoxMax3.TabIndex = 26;
            textBoxMax3.Text = "57";
            textBoxMax3.TextChanged += TextBox_MaxTextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(labelMax2);
            groupBox2.Controls.Add(labelMin2);
            groupBox2.Controls.Add(textBoxMin2);
            groupBox2.Controls.Add(textBoxMax2);
            groupBox2.Location = new System.Drawing.Point(4, 52);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(411, 42);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox2.Location = new System.Drawing.Point(28, 12);
            checkBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(32, 19);
            checkBox2.TabIndex = 30;
            checkBox2.Text = "2";
            checkBox2.ThreeState = true;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckStateChanged += CheckBox_CheckStateChanged;
            // 
            // labelMax2
            // 
            labelMax2.AutoSize = true;
            labelMax2.Location = new System.Drawing.Point(342, 13);
            labelMax2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMax2.Name = "labelMax2";
            labelMax2.Size = new System.Drawing.Size(38, 15);
            labelMax2.TabIndex = 29;
            labelMax2.Text = "label1";
            // 
            // labelMin2
            // 
            labelMin2.AutoSize = true;
            labelMin2.Location = new System.Drawing.Point(178, 13);
            labelMin2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMin2.Name = "labelMin2";
            labelMin2.Size = new System.Drawing.Size(38, 15);
            labelMin2.TabIndex = 28;
            labelMin2.Text = "label1";
            // 
            // textBoxMin2
            // 
            textBoxMin2.Location = new System.Drawing.Point(86, 9);
            textBoxMin2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMin2.Name = "textBoxMin2";
            textBoxMin2.Size = new System.Drawing.Size(84, 23);
            textBoxMin2.TabIndex = 27;
            textBoxMin2.Text = "48";
            textBoxMin2.TextChanged += TextBox_MinTextChanged;
            // 
            // textBoxMax2
            // 
            textBoxMax2.Location = new System.Drawing.Point(250, 9);
            textBoxMax2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMax2.Name = "textBoxMax2";
            textBoxMax2.Size = new System.Drawing.Size(84, 23);
            textBoxMax2.TabIndex = 26;
            textBoxMax2.Text = "57";
            textBoxMax2.TextChanged += TextBox_MaxTextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(labelMax1);
            groupBox1.Controls.Add(labelMin1);
            groupBox1.Controls.Add(textBoxMin1);
            groupBox1.Controls.Add(textBoxMax1);
            groupBox1.Location = new System.Drawing.Point(4, 3);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(411, 42);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            checkBox1.Location = new System.Drawing.Point(28, 12);
            checkBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(32, 19);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "1";
            checkBox1.ThreeState = true;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += CheckBox_CheckStateChanged;
            // 
            // labelMax1
            // 
            labelMax1.AutoSize = true;
            labelMax1.Location = new System.Drawing.Point(342, 13);
            labelMax1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMax1.Name = "labelMax1";
            labelMax1.Size = new System.Drawing.Size(38, 15);
            labelMax1.TabIndex = 29;
            labelMax1.Text = "label1";
            // 
            // labelMin1
            // 
            labelMin1.AutoSize = true;
            labelMin1.Location = new System.Drawing.Point(178, 13);
            labelMin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMin1.Name = "labelMin1";
            labelMin1.Size = new System.Drawing.Size(38, 15);
            labelMin1.TabIndex = 28;
            labelMin1.Text = "label1";
            // 
            // textBoxMin1
            // 
            textBoxMin1.Location = new System.Drawing.Point(86, 9);
            textBoxMin1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMin1.Name = "textBoxMin1";
            textBoxMin1.Size = new System.Drawing.Size(84, 23);
            textBoxMin1.TabIndex = 27;
            textBoxMin1.Text = "48";
            textBoxMin1.TextChanged += TextBox_MinTextChanged;
            // 
            // textBoxMax1
            // 
            textBoxMax1.Location = new System.Drawing.Point(250, 9);
            textBoxMax1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxMax1.Name = "textBoxMax1";
            textBoxMax1.Size = new System.Drawing.Size(84, 23);
            textBoxMax1.TabIndex = 26;
            textBoxMax1.Text = "57";
            textBoxMax1.TextChanged += TextBox_MaxTextChanged;
            // 
            // cbUseOnlyOnce
            // 
            cbUseOnlyOnce.AutoSize = true;
            cbUseOnlyOnce.Location = new System.Drawing.Point(33, 129);
            cbUseOnlyOnce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbUseOnlyOnce.Name = "cbUseOnlyOnce";
            cbUseOnlyOnce.Size = new System.Drawing.Size(154, 19);
            cbUseOnlyOnce.TabIndex = 13;
            cbUseOnlyOnce.Text = "Use each char only once";
            cbUseOnlyOnce.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(819, 433);
            Controls.Add(cbUseOnlyOnce);
            Controls.Add(panel1);
            Controls.Add(buttonCopyToClipboard);
            Controls.Add(labelPh);
            Controls.Add(labelLength);
            Controls.Add(labelMax);
            Controls.Add(labelMin);
            Controls.Add(textBoxLength);
            Controls.Add(buttonClose);
            Controls.Add(textBoxKey);
            Controls.Add(buttonGen);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(835, 472);
            Name = "FormMain";
            Text = "Password Generator Sharp 3.3";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            KeyDown += FormMain_KeyDown;
            KeyUp += FormMain_KeyUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelPh;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azAZ09ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label labelMax5;
        private System.Windows.Forms.Label labelMin5;
        private System.Windows.Forms.TextBox textBoxMin5;
        private System.Windows.Forms.TextBox textBoxMax5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label labelMax4;
        private System.Windows.Forms.Label labelMin4;
        private System.Windows.Forms.TextBox textBoxMin4;
        private System.Windows.Forms.TextBox textBoxMax4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label labelMax3;
        private System.Windows.Forms.Label labelMin3;
        private System.Windows.Forms.TextBox textBoxMin3;
        private System.Windows.Forms.TextBox textBoxMax3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label labelMax2;
        private System.Windows.Forms.Label labelMin2;
        private System.Windows.Forms.TextBox textBoxMin2;
        private System.Windows.Forms.TextBox textBoxMax2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelMax1;
        private System.Windows.Forms.Label labelMin1;
        private System.Windows.Forms.TextBox textBoxMin1;
        private System.Windows.Forms.TextBox textBoxMax1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbUseOnlyOnce;
        private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
    }
}

