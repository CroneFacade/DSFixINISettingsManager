namespace DSFixEasySettings
{
    partial class DSFixEasySettings
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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.settingsListBox = new System.Windows.Forms.TextBox();
            this.ResolutionBox = new System.Windows.Forms.ComboBox();
            this.AAQuality = new System.Windows.Forms.ComboBox();
            this.AAType = new System.Windows.Forms.ComboBox();
            this.SSAOStrength = new System.Windows.Forms.ComboBox();
            this.SSAOScale = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(217, 541);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(136, 541);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset Default";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // settingsListBox
            // 
            this.settingsListBox.Location = new System.Drawing.Point(136, 12);
            this.settingsListBox.Multiline = true;
            this.settingsListBox.Name = "settingsListBox";
            this.settingsListBox.Size = new System.Drawing.Size(175, 523);
            this.settingsListBox.TabIndex = 4;
            // 
            // ResolutionBox
            // 
            this.ResolutionBox.FormattingEnabled = true;
            this.ResolutionBox.Items.AddRange(new object[] {
            "800 x 600",
            "1024 x 768",
            "1280 x 720",
            "1440 x 900",
            "1920 x 1080",
            "2560 x 1440",
            "3840 x 2160",
            "7680 x 4320"});
            this.ResolutionBox.Location = new System.Drawing.Point(9, 13);
            this.ResolutionBox.Name = "ResolutionBox";
            this.ResolutionBox.Size = new System.Drawing.Size(121, 21);
            this.ResolutionBox.TabIndex = 5;
            this.ResolutionBox.Text = "Resolution";
            this.ResolutionBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AAQuality
            // 
            this.AAQuality.FormattingEnabled = true;
            this.AAQuality.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.AAQuality.Location = new System.Drawing.Point(9, 41);
            this.AAQuality.Name = "AAQuality";
            this.AAQuality.Size = new System.Drawing.Size(121, 21);
            this.AAQuality.TabIndex = 6;
            this.AAQuality.Text = "AntiAliasing Quality";
            this.AAQuality.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AAType
            // 
            this.AAType.FormattingEnabled = true;
            this.AAType.Items.AddRange(new object[] {
            "SMAA",
            "FXAA"});
            this.AAType.Location = new System.Drawing.Point(9, 69);
            this.AAType.Name = "AAType";
            this.AAType.Size = new System.Drawing.Size(121, 21);
            this.AAType.TabIndex = 7;
            this.AAType.Text = "AntiAliasting Type";
            this.AAType.SelectedIndexChanged += new System.EventHandler(this.AAType_SelectedIndexChanged);
            // 
            // SSAOStrength
            // 
            this.SSAOStrength.FormattingEnabled = true;
            this.SSAOStrength.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.SSAOStrength.Location = new System.Drawing.Point(9, 97);
            this.SSAOStrength.Name = "SSAOStrength";
            this.SSAOStrength.Size = new System.Drawing.Size(121, 21);
            this.SSAOStrength.TabIndex = 8;
            this.SSAOStrength.Text = "SSAO Strength";
            this.SSAOStrength.SelectedIndexChanged += new System.EventHandler(this.SSAOStrength_SelectedIndexChanged);
            // 
            // SSAOScale
            // 
            this.SSAOScale.FormattingEnabled = true;
            this.SSAOScale.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.SSAOScale.Location = new System.Drawing.Point(9, 125);
            this.SSAOScale.Name = "SSAOScale";
            this.SSAOScale.Size = new System.Drawing.Size(121, 21);
            this.SSAOScale.TabIndex = 9;
            this.SSAOScale.Text = "SSAO Scale";
            this.SSAOScale.SelectedIndexChanged += new System.EventHandler(this.SSAOScale_SelectedIndexChanged);
            // 
            // DSFixEasySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 576);
            this.Controls.Add(this.SSAOScale);
            this.Controls.Add(this.SSAOStrength);
            this.Controls.Add(this.AAType);
            this.Controls.Add(this.AAQuality);
            this.Controls.Add(this.ResolutionBox);
            this.Controls.Add(this.settingsListBox);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonHelp);
            this.Name = "DSFixEasySettings";
            this.Text = "DSFix Easy Settings Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox settingsListBox;
        private System.Windows.Forms.ComboBox ResolutionBox;
        private System.Windows.Forms.ComboBox AAQuality;
        private System.Windows.Forms.ComboBox AAType;
        private System.Windows.Forms.ComboBox SSAOStrength;
        private System.Windows.Forms.ComboBox SSAOScale;
    }
}

