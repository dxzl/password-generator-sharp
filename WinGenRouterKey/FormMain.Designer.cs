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
            this.buttonGen = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelPh = new System.Windows.Forms.Label();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azAZ09ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.labelMax5 = new System.Windows.Forms.Label();
            this.labelMin5 = new System.Windows.Forms.Label();
            this.textBoxMin5 = new System.Windows.Forms.TextBox();
            this.textBoxMax5 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.labelMax4 = new System.Windows.Forms.Label();
            this.labelMin4 = new System.Windows.Forms.Label();
            this.textBoxMin4 = new System.Windows.Forms.TextBox();
            this.textBoxMax4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.labelMax3 = new System.Windows.Forms.Label();
            this.labelMin3 = new System.Windows.Forms.Label();
            this.textBoxMin3 = new System.Windows.Forms.TextBox();
            this.textBoxMax3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.labelMax2 = new System.Windows.Forms.Label();
            this.labelMin2 = new System.Windows.Forms.Label();
            this.textBoxMin2 = new System.Windows.Forms.TextBox();
            this.textBoxMax2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelMax1 = new System.Windows.Forms.Label();
            this.labelMin1 = new System.Windows.Forms.Label();
            this.textBoxMin1 = new System.Windows.Forms.TextBox();
            this.textBoxMax1 = new System.Windows.Forms.TextBox();
            this.cbUseOnlyOnce = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(12, 164);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(206, 23);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "&Generate Key";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKey.Location = new System.Drawing.Point(0, 24);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(702, 20);
            this.textBoxKey.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(12, 267);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(206, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Cl&ose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(71, 77);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(73, 20);
            this.textBoxLength.TabIndex = 5;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(309, 61);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(91, 13);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "Min Char (1-nnnn)";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(449, 61);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(94, 13);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max Char (1-nnnn)";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(68, 61);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(82, 13);
            this.labelLength.TabIndex = 8;
            this.labelLength.Text = "Length (1-2048)";
            // 
            // labelPh
            // 
            this.labelPh.AutoSize = true;
            this.labelPh.Location = new System.Drawing.Point(12, 323);
            this.labelPh.Name = "labelPh";
            this.labelPh.Size = new System.Drawing.Size(503, 13);
            this.labelPh.TabIndex = 9;
            this.labelPh.Text = "A blank checkbox = off, a grey box means \"exclude\" the range, a plain check means" +
    " \"include\" the range";
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(12, 208);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(206, 23);
            this.buttonCopyToClipboard.TabIndex = 10;
            this.buttonCopyToClipboard.Text = "&Copy to clipboard";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azAZ09ToolStripMenuItem,
            this.base64ToolStripMenuItem});
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.presetsToolStripMenuItem.Text = "&Presets";
            // 
            // azAZ09ToolStripMenuItem
            // 
            this.azAZ09ToolStripMenuItem.Name = "azAZ09ToolStripMenuItem";
            this.azAZ09ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.azAZ09ToolStripMenuItem.Text = "a-z A-Z 0-9";
            this.azAZ09ToolStripMenuItem.ToolTipText = "Genetates a 63-character password for most routers";
            this.azAZ09ToolStripMenuItem.Click += new System.EventHandler(this.AzAZ09ToolStripMenuItem_Click);
            // 
            // base64ToolStripMenuItem
            // 
            this.base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            this.base64ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.base64ToolStripMenuItem.Text = "Web-Safe Base 64";
            this.base64ToolStripMenuItem.ToolTipText = "Generates a web-safe base-64 random table";
            this.base64ToolStripMenuItem.Click += new System.EventHandler(this.base64ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(242, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 213);
            this.panel1.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Controls.Add(this.labelMax5);
            this.groupBox5.Controls.Add(this.labelMin5);
            this.groupBox5.Controls.Add(this.textBoxMin5);
            this.groupBox5.Controls.Add(this.textBoxMax5);
            this.groupBox5.Location = new System.Drawing.Point(3, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(352, 36);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Location = new System.Drawing.Point(24, 10);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 30;
            this.checkBox5.Text = "5";
            this.checkBox5.ThreeState = true;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // labelMax5
            // 
            this.labelMax5.AutoSize = true;
            this.labelMax5.Location = new System.Drawing.Point(293, 11);
            this.labelMax5.Name = "labelMax5";
            this.labelMax5.Size = new System.Drawing.Size(35, 13);
            this.labelMax5.TabIndex = 29;
            this.labelMax5.Text = "label1";
            // 
            // labelMin5
            // 
            this.labelMin5.AutoSize = true;
            this.labelMin5.Location = new System.Drawing.Point(153, 11);
            this.labelMin5.Name = "labelMin5";
            this.labelMin5.Size = new System.Drawing.Size(35, 13);
            this.labelMin5.TabIndex = 28;
            this.labelMin5.Text = "label1";
            // 
            // textBoxMin5
            // 
            this.textBoxMin5.Location = new System.Drawing.Point(74, 8);
            this.textBoxMin5.Name = "textBoxMin5";
            this.textBoxMin5.Size = new System.Drawing.Size(73, 20);
            this.textBoxMin5.TabIndex = 27;
            this.textBoxMin5.Text = "48";
            this.textBoxMin5.TextChanged += new System.EventHandler(this.TextBox_MinTextChanged);
            // 
            // textBoxMax5
            // 
            this.textBoxMax5.Location = new System.Drawing.Point(214, 8);
            this.textBoxMax5.Name = "textBoxMax5";
            this.textBoxMax5.Size = new System.Drawing.Size(73, 20);
            this.textBoxMax5.TabIndex = 26;
            this.textBoxMax5.Text = "57";
            this.textBoxMax5.TextChanged += new System.EventHandler(this.TextBox_MaxTextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Controls.Add(this.labelMax4);
            this.groupBox4.Controls.Add(this.labelMin4);
            this.groupBox4.Controls.Add(this.textBoxMin4);
            this.groupBox4.Controls.Add(this.textBoxMax4);
            this.groupBox4.Location = new System.Drawing.Point(3, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 36);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Location = new System.Drawing.Point(24, 10);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 30;
            this.checkBox4.Text = "4";
            this.checkBox4.ThreeState = true;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // labelMax4
            // 
            this.labelMax4.AutoSize = true;
            this.labelMax4.Location = new System.Drawing.Point(293, 11);
            this.labelMax4.Name = "labelMax4";
            this.labelMax4.Size = new System.Drawing.Size(35, 13);
            this.labelMax4.TabIndex = 29;
            this.labelMax4.Text = "label1";
            // 
            // labelMin4
            // 
            this.labelMin4.AutoSize = true;
            this.labelMin4.Location = new System.Drawing.Point(153, 11);
            this.labelMin4.Name = "labelMin4";
            this.labelMin4.Size = new System.Drawing.Size(35, 13);
            this.labelMin4.TabIndex = 28;
            this.labelMin4.Text = "label1";
            // 
            // textBoxMin4
            // 
            this.textBoxMin4.Location = new System.Drawing.Point(74, 8);
            this.textBoxMin4.Name = "textBoxMin4";
            this.textBoxMin4.Size = new System.Drawing.Size(73, 20);
            this.textBoxMin4.TabIndex = 27;
            this.textBoxMin4.Text = "48";
            this.textBoxMin4.TextChanged += new System.EventHandler(this.TextBox_MinTextChanged);
            // 
            // textBoxMax4
            // 
            this.textBoxMax4.Location = new System.Drawing.Point(214, 8);
            this.textBoxMax4.Name = "textBoxMax4";
            this.textBoxMax4.Size = new System.Drawing.Size(73, 20);
            this.textBoxMax4.TabIndex = 26;
            this.textBoxMax4.Text = "57";
            this.textBoxMax4.TextChanged += new System.EventHandler(this.TextBox_MaxTextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.labelMax3);
            this.groupBox3.Controls.Add(this.labelMin3);
            this.groupBox3.Controls.Add(this.textBoxMin3);
            this.groupBox3.Controls.Add(this.textBoxMax3);
            this.groupBox3.Location = new System.Drawing.Point(3, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 38);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(24, 10);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.Text = "3";
            this.checkBox3.ThreeState = true;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // labelMax3
            // 
            this.labelMax3.AutoSize = true;
            this.labelMax3.Location = new System.Drawing.Point(293, 11);
            this.labelMax3.Name = "labelMax3";
            this.labelMax3.Size = new System.Drawing.Size(35, 13);
            this.labelMax3.TabIndex = 29;
            this.labelMax3.Text = "label1";
            // 
            // labelMin3
            // 
            this.labelMin3.AutoSize = true;
            this.labelMin3.Location = new System.Drawing.Point(153, 11);
            this.labelMin3.Name = "labelMin3";
            this.labelMin3.Size = new System.Drawing.Size(35, 13);
            this.labelMin3.TabIndex = 28;
            this.labelMin3.Text = "label1";
            // 
            // textBoxMin3
            // 
            this.textBoxMin3.Location = new System.Drawing.Point(74, 8);
            this.textBoxMin3.Name = "textBoxMin3";
            this.textBoxMin3.Size = new System.Drawing.Size(73, 20);
            this.textBoxMin3.TabIndex = 27;
            this.textBoxMin3.Text = "48";
            this.textBoxMin3.TextChanged += new System.EventHandler(this.TextBox_MinTextChanged);
            // 
            // textBoxMax3
            // 
            this.textBoxMax3.Location = new System.Drawing.Point(214, 8);
            this.textBoxMax3.Name = "textBoxMax3";
            this.textBoxMax3.Size = new System.Drawing.Size(73, 20);
            this.textBoxMax3.TabIndex = 26;
            this.textBoxMax3.Text = "57";
            this.textBoxMax3.TextChanged += new System.EventHandler(this.TextBox_MaxTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.labelMax2);
            this.groupBox2.Controls.Add(this.labelMin2);
            this.groupBox2.Controls.Add(this.textBoxMin2);
            this.groupBox2.Controls.Add(this.textBoxMax2);
            this.groupBox2.Location = new System.Drawing.Point(3, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 36);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(24, 10);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 30;
            this.checkBox2.Text = "2";
            this.checkBox2.ThreeState = true;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // labelMax2
            // 
            this.labelMax2.AutoSize = true;
            this.labelMax2.Location = new System.Drawing.Point(293, 11);
            this.labelMax2.Name = "labelMax2";
            this.labelMax2.Size = new System.Drawing.Size(35, 13);
            this.labelMax2.TabIndex = 29;
            this.labelMax2.Text = "label1";
            // 
            // labelMin2
            // 
            this.labelMin2.AutoSize = true;
            this.labelMin2.Location = new System.Drawing.Point(153, 11);
            this.labelMin2.Name = "labelMin2";
            this.labelMin2.Size = new System.Drawing.Size(35, 13);
            this.labelMin2.TabIndex = 28;
            this.labelMin2.Text = "label1";
            // 
            // textBoxMin2
            // 
            this.textBoxMin2.Location = new System.Drawing.Point(74, 8);
            this.textBoxMin2.Name = "textBoxMin2";
            this.textBoxMin2.Size = new System.Drawing.Size(73, 20);
            this.textBoxMin2.TabIndex = 27;
            this.textBoxMin2.Text = "48";
            this.textBoxMin2.TextChanged += new System.EventHandler(this.TextBox_MinTextChanged);
            // 
            // textBoxMax2
            // 
            this.textBoxMax2.Location = new System.Drawing.Point(214, 8);
            this.textBoxMax2.Name = "textBoxMax2";
            this.textBoxMax2.Size = new System.Drawing.Size(73, 20);
            this.textBoxMax2.TabIndex = 26;
            this.textBoxMax2.Text = "57";
            this.textBoxMax2.TextChanged += new System.EventHandler(this.TextBox_MaxTextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.labelMax1);
            this.groupBox1.Controls.Add(this.labelMin1);
            this.groupBox1.Controls.Add(this.textBoxMin1);
            this.groupBox1.Controls.Add(this.textBoxMax1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 36);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(24, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "1";
            this.checkBox1.ThreeState = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // labelMax1
            // 
            this.labelMax1.AutoSize = true;
            this.labelMax1.Location = new System.Drawing.Point(293, 11);
            this.labelMax1.Name = "labelMax1";
            this.labelMax1.Size = new System.Drawing.Size(35, 13);
            this.labelMax1.TabIndex = 29;
            this.labelMax1.Text = "label1";
            // 
            // labelMin1
            // 
            this.labelMin1.AutoSize = true;
            this.labelMin1.Location = new System.Drawing.Point(153, 11);
            this.labelMin1.Name = "labelMin1";
            this.labelMin1.Size = new System.Drawing.Size(35, 13);
            this.labelMin1.TabIndex = 28;
            this.labelMin1.Text = "label1";
            // 
            // textBoxMin1
            // 
            this.textBoxMin1.Location = new System.Drawing.Point(74, 8);
            this.textBoxMin1.Name = "textBoxMin1";
            this.textBoxMin1.Size = new System.Drawing.Size(73, 20);
            this.textBoxMin1.TabIndex = 27;
            this.textBoxMin1.Text = "48";
            this.textBoxMin1.TextChanged += new System.EventHandler(this.TextBox_MinTextChanged);
            // 
            // textBoxMax1
            // 
            this.textBoxMax1.Location = new System.Drawing.Point(214, 8);
            this.textBoxMax1.Name = "textBoxMax1";
            this.textBoxMax1.Size = new System.Drawing.Size(73, 20);
            this.textBoxMax1.TabIndex = 26;
            this.textBoxMax1.Text = "57";
            this.textBoxMax1.TextChanged += new System.EventHandler(this.TextBox_MaxTextChanged);
            // 
            // cbUseOnlyOnce
            // 
            this.cbUseOnlyOnce.AutoSize = true;
            this.cbUseOnlyOnce.Location = new System.Drawing.Point(28, 112);
            this.cbUseOnlyOnce.Name = "cbUseOnlyOnce";
            this.cbUseOnlyOnce.Size = new System.Drawing.Size(145, 17);
            this.cbUseOnlyOnce.TabIndex = 13;
            this.cbUseOnlyOnce.Text = "Use each char only once";
            this.cbUseOnlyOnce.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 375);
            this.Controls.Add(this.cbUseOnlyOnce);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCopyToClipboard);
            this.Controls.Add(this.labelPh);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonGen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(718, 414);
            this.Name = "FormMain";
            this.Text = "Password Generator Sharp 3.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

