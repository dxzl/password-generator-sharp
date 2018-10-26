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
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGen
            // 
            this.buttonGen.Location = new System.Drawing.Point(12, 38);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(260, 23);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "Generate Key";
            this.buttonGen.UseVisualStyleBackColor = true;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKey.Location = new System.Drawing.Point(0, 0);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(612, 20);
            this.textBoxKey.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(12, 67);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(260, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(296, 64);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(73, 20);
            this.textBoxMin.TabIndex = 3;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(405, 64);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(73, 20);
            this.textBoxMax.TabIndex = 4;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(515, 64);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(73, 20);
            this.textBoxLength.TabIndex = 5;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(293, 48);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(103, 13);
            this.labelMin.TabIndex = 6;
            this.labelMin.Text = "Min Char (1-65,535):";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(402, 48);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(106, 13);
            this.labelMax.TabIndex = 7;
            this.labelMax.Text = "Max Char (1-65,535):";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(514, 48);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(85, 13);
            this.labelLength.TabIndex = 8;
            this.labelLength.Text = "Length (1-2048):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "(For Netgear AC750, user pass max length is 32 chars, wifi pass max length is 64," +
    " min char is 33, max char is 126)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 121);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Router Key Generator 1.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label label1;
    }
}

