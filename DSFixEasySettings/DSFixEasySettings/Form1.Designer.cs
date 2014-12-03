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
            this.components = new System.ComponentModel.Container();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.settingsListBox = new System.Windows.Forms.TextBox();
            this.ResolutionBox = new System.Windows.Forms.ComboBox();
            this.AAQuality = new System.Windows.Forms.ComboBox();
            this.AAType = new System.Windows.Forms.ComboBox();
            this.SSAOStrength = new System.Windows.Forms.ComboBox();
            this.SSAOScale = new System.Windows.Forms.ComboBox();
            this.SSAOType = new System.Windows.Forms.ComboBox();
            this.HudModOnOff = new System.Windows.Forms.ComboBox();
            this.HudModMinimal = new System.Windows.Forms.ComboBox();
            this.HudScale = new System.Windows.Forms.ComboBox();
            this.HudOpacity = new System.Windows.Forms.ComboBox();
            this.ScreenSetting = new System.Windows.Forms.ComboBox();
            this.DisableCursor = new System.Windows.Forms.ComboBox();
            this.SkipIntro = new System.Windows.Forms.ComboBox();
            this.Vsync = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelPresets = new System.Windows.Forms.Label();
            this.buttonLow = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonHigh = new System.Windows.Forms.Button();
            this.buttonUltra = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(75, 582);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(57, 23);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(11, 582);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(58, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset Default";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // settingsListBox
            // 
            this.settingsListBox.Location = new System.Drawing.Point(161, 12);
            this.settingsListBox.Multiline = true;
            this.settingsListBox.Name = "settingsListBox";
            this.settingsListBox.Size = new System.Drawing.Size(175, 544);
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
            this.ResolutionBox.Location = new System.Drawing.Point(11, 12);
            this.ResolutionBox.Name = "ResolutionBox";
            this.ResolutionBox.Size = new System.Drawing.Size(121, 21);
            this.ResolutionBox.TabIndex = 5;
            this.ResolutionBox.Text = "Resolution";
            this.toolTip.SetToolTip(this.ResolutionBox, "This option sets your games resolution");
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
            this.AAQuality.Location = new System.Drawing.Point(11, 131);
            this.AAQuality.Name = "AAQuality";
            this.AAQuality.Size = new System.Drawing.Size(121, 21);
            this.AAQuality.TabIndex = 6;
            this.AAQuality.Text = "AntiAliasing Quality";
            this.toolTip.SetToolTip(this.AAQuality, "AA quality, 0 is off");
            this.AAQuality.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AAType
            // 
            this.AAType.FormattingEnabled = true;
            this.AAType.Items.AddRange(new object[] {
            "SMAA",
            "FXAA"});
            this.AAType.Location = new System.Drawing.Point(11, 104);
            this.AAType.Name = "AAType";
            this.AAType.Size = new System.Drawing.Size(121, 21);
            this.AAType.TabIndex = 7;
            this.AAType.Text = "AntiAliasting Type";
            this.toolTip.SetToolTip(this.AAType, "Which type of AA you want");
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
            this.SSAOStrength.Location = new System.Drawing.Point(11, 212);
            this.SSAOStrength.Name = "SSAOStrength";
            this.SSAOStrength.Size = new System.Drawing.Size(121, 21);
            this.SSAOStrength.TabIndex = 8;
            this.SSAOStrength.Text = "SSAO Strength";
            this.toolTip.SetToolTip(this.SSAOStrength, "SSAO Strength, 0 is off");
            this.SSAOStrength.SelectedIndexChanged += new System.EventHandler(this.SSAOStrength_SelectedIndexChanged);
            // 
            // SSAOScale
            // 
            this.SSAOScale.FormattingEnabled = true;
            this.SSAOScale.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.SSAOScale.Location = new System.Drawing.Point(11, 185);
            this.SSAOScale.Name = "SSAOScale";
            this.SSAOScale.Size = new System.Drawing.Size(121, 21);
            this.SSAOScale.TabIndex = 9;
            this.SSAOScale.Text = "SSAO Scale";
            this.toolTip.SetToolTip(this.SSAOScale, "SSAO Scale");
            this.SSAOScale.SelectedIndexChanged += new System.EventHandler(this.SSAOScale_SelectedIndexChanged);
            // 
            // SSAOType
            // 
            this.SSAOType.FormattingEnabled = true;
            this.SSAOType.Items.AddRange(new object[] {
            "VSSAO",
            "VSSAO2",
            "HBAO",
            "SCAO"});
            this.SSAOType.Location = new System.Drawing.Point(11, 158);
            this.SSAOType.Name = "SSAOType";
            this.SSAOType.Size = new System.Drawing.Size(121, 21);
            this.SSAOType.TabIndex = 10;
            this.SSAOType.Text = "SSAO Type";
            this.toolTip.SetToolTip(this.SSAOType, "Determine the type of AO used");
            this.SSAOType.SelectedIndexChanged += new System.EventHandler(this.SSAOType_SelectedIndexChanged);
            // 
            // HudModOnOff
            // 
            this.HudModOnOff.FormattingEnabled = true;
            this.HudModOnOff.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.HudModOnOff.Location = new System.Drawing.Point(11, 321);
            this.HudModOnOff.Name = "HudModOnOff";
            this.HudModOnOff.Size = new System.Drawing.Size(121, 21);
            this.HudModOnOff.TabIndex = 11;
            this.HudModOnOff.Text = "Enable Hud Mods";
            this.toolTip.SetToolTip(this.HudModOnOff, "Enable hud, This needs to be on for the hud mods below to work");
            this.HudModOnOff.SelectedIndexChanged += new System.EventHandler(this.HudModOnOff_SelectedIndexChanged);
            // 
            // HudModMinimal
            // 
            this.HudModMinimal.FormattingEnabled = true;
            this.HudModMinimal.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.HudModMinimal.Location = new System.Drawing.Point(11, 349);
            this.HudModMinimal.Name = "HudModMinimal";
            this.HudModMinimal.Size = new System.Drawing.Size(121, 21);
            this.HudModMinimal.TabIndex = 12;
            this.HudModMinimal.Text = "Minimal Hud";
            this.toolTip.SetToolTip(this.HudModMinimal, "Minimal Hud, this option removes your weapon icons from the hud which is generall" +
        "y unnecessary and in the way");
            this.HudModMinimal.SelectedIndexChanged += new System.EventHandler(this.HudModMinimal_SelectedIndexChanged);
            // 
            // HudScale
            // 
            this.HudScale.FormattingEnabled = true;
            this.HudScale.Items.AddRange(new object[] {
            "1.75",
            "1.50",
            "1.25",
            "1",
            "0.75",
            "0.50",
            "0.25"});
            this.HudScale.Location = new System.Drawing.Point(11, 377);
            this.HudScale.Name = "HudScale";
            this.HudScale.Size = new System.Drawing.Size(121, 21);
            this.HudScale.TabIndex = 13;
            this.HudScale.Text = "Hud Scale";
            this.toolTip.SetToolTip(this.HudScale, "Hud Scale");
            this.HudScale.SelectedIndexChanged += new System.EventHandler(this.HudScale_SelectedIndexChanged);
            // 
            // HudOpacity
            // 
            this.HudOpacity.FormattingEnabled = true;
            this.HudOpacity.Items.AddRange(new object[] {
            "1.0f",
            "0.9f",
            "0.8f",
            "0.7f",
            "0.6f",
            "0.5f",
            "0.4f"});
            this.HudOpacity.Location = new System.Drawing.Point(11, 405);
            this.HudOpacity.Name = "HudOpacity";
            this.HudOpacity.Size = new System.Drawing.Size(121, 21);
            this.HudOpacity.TabIndex = 14;
            this.HudOpacity.Text = "Hud Opacity";
            this.toolTip.SetToolTip(this.HudOpacity, "Hud Opacity");
            this.HudOpacity.SelectedIndexChanged += new System.EventHandler(this.HudOpacity_SelectedIndexChanged);
            // 
            // ScreenSetting
            // 
            this.ScreenSetting.FormattingEnabled = true;
            this.ScreenSetting.Items.AddRange(new object[] {
            "Fullscreen",
            "Windowed",
            "BorderlessFullscreen"});
            this.ScreenSetting.Location = new System.Drawing.Point(11, 39);
            this.ScreenSetting.Name = "ScreenSetting";
            this.ScreenSetting.Size = new System.Drawing.Size(121, 21);
            this.ScreenSetting.TabIndex = 15;
            this.ScreenSetting.Text = "Screen Setting";
            this.toolTip.SetToolTip(this.ScreenSetting, "Screen Setting");
            this.ScreenSetting.SelectedIndexChanged += new System.EventHandler(this.ScreenSetting_SelectedIndexChanged);
            // 
            // DisableCursor
            // 
            this.DisableCursor.FormattingEnabled = true;
            this.DisableCursor.Items.AddRange(new object[] {
            "Cursor Enabled",
            "Cursor Disabled"});
            this.DisableCursor.Location = new System.Drawing.Point(11, 252);
            this.DisableCursor.Name = "DisableCursor";
            this.DisableCursor.Size = new System.Drawing.Size(121, 21);
            this.DisableCursor.TabIndex = 16;
            this.DisableCursor.Text = "Disable Cursor";
            this.toolTip.SetToolTip(this.DisableCursor, "Disable Cursor Option");
            this.DisableCursor.SelectedIndexChanged += new System.EventHandler(this.DisableCursor_SelectedIndexChanged);
            // 
            // SkipIntro
            // 
            this.SkipIntro.FormattingEnabled = true;
            this.SkipIntro.Items.AddRange(new object[] {
            "Skip",
            "Do Not Skip"});
            this.SkipIntro.Location = new System.Drawing.Point(11, 280);
            this.SkipIntro.Name = "SkipIntro";
            this.SkipIntro.Size = new System.Drawing.Size(121, 21);
            this.SkipIntro.TabIndex = 17;
            this.SkipIntro.Text = "Skip Intro Option";
            this.toolTip.SetToolTip(this.SkipIntro, "Skip Intro Option (highly recommended) This will only skip company logos in the i" +
        "ntro, not the cutscene");
            this.SkipIntro.SelectedIndexChanged += new System.EventHandler(this.SkipIntro_SelectedIndexChanged);
            // 
            // Vsync
            // 
            this.Vsync.FormattingEnabled = true;
            this.Vsync.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.Vsync.Location = new System.Drawing.Point(11, 66);
            this.Vsync.Name = "Vsync";
            this.Vsync.Size = new System.Drawing.Size(121, 21);
            this.Vsync.TabIndex = 18;
            this.Vsync.Text = "Vsync";
            this.toolTip.SetToolTip(this.Vsync, "Vsync, this reduces screen tearing, but you get a lower FPS");
            this.Vsync.SelectedIndexChanged += new System.EventHandler(this.Vsync_SelectedIndexChanged);
            // 
            // labelPresets
            // 
            this.labelPresets.AutoSize = true;
            this.labelPresets.Location = new System.Drawing.Point(50, 436);
            this.labelPresets.Name = "labelPresets";
            this.labelPresets.Size = new System.Drawing.Size(42, 13);
            this.labelPresets.TabIndex = 19;
            this.labelPresets.Text = "Presets";
            // 
            // buttonLow
            // 
            this.buttonLow.Location = new System.Drawing.Point(11, 455);
            this.buttonLow.Name = "buttonLow";
            this.buttonLow.Size = new System.Drawing.Size(121, 23);
            this.buttonLow.TabIndex = 20;
            this.buttonLow.Text = "Low";
            this.buttonLow.UseVisualStyleBackColor = true;
            this.buttonLow.Click += new System.EventHandler(this.buttonLow_Click);
            // 
            // buttonMedium
            // 
            this.buttonMedium.Location = new System.Drawing.Point(11, 485);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(121, 23);
            this.buttonMedium.TabIndex = 21;
            this.buttonMedium.Text = "Medium";
            this.buttonMedium.UseVisualStyleBackColor = true;
            this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
            // 
            // buttonHigh
            // 
            this.buttonHigh.Location = new System.Drawing.Point(11, 515);
            this.buttonHigh.Name = "buttonHigh";
            this.buttonHigh.Size = new System.Drawing.Size(121, 23);
            this.buttonHigh.TabIndex = 22;
            this.buttonHigh.Text = "High";
            this.buttonHigh.UseVisualStyleBackColor = true;
            this.buttonHigh.Click += new System.EventHandler(this.buttonHigh_Click);
            // 
            // buttonUltra
            // 
            this.buttonUltra.Location = new System.Drawing.Point(11, 545);
            this.buttonUltra.Name = "buttonUltra";
            this.buttonUltra.Size = new System.Drawing.Size(121, 23);
            this.buttonUltra.TabIndex = 23;
            this.buttonUltra.Text = "Ultra";
            this.buttonUltra.UseVisualStyleBackColor = true;
            this.buttonUltra.Click += new System.EventHandler(this.buttonUltra_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(161, 563);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(175, 42);
            this.buttonDone.TabIndex = 24;
            this.buttonDone.Text = "Done";
            this.toolTip.SetToolTip(this.buttonDone, "Click here when you are done with your settings. The program will save your chang" +
        "es to DSFix.ini and then close");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // DSFixEasySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 614);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonUltra);
            this.Controls.Add(this.buttonHigh);
            this.Controls.Add(this.buttonMedium);
            this.Controls.Add(this.buttonLow);
            this.Controls.Add(this.labelPresets);
            this.Controls.Add(this.Vsync);
            this.Controls.Add(this.SkipIntro);
            this.Controls.Add(this.DisableCursor);
            this.Controls.Add(this.ScreenSetting);
            this.Controls.Add(this.HudOpacity);
            this.Controls.Add(this.HudScale);
            this.Controls.Add(this.HudModMinimal);
            this.Controls.Add(this.HudModOnOff);
            this.Controls.Add(this.SSAOType);
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
        private System.Windows.Forms.ComboBox SSAOType;
        private System.Windows.Forms.ComboBox HudModOnOff;
        private System.Windows.Forms.ComboBox HudModMinimal;
        private System.Windows.Forms.ComboBox HudScale;
        private System.Windows.Forms.ComboBox HudOpacity;
        private System.Windows.Forms.ComboBox ScreenSetting;
        private System.Windows.Forms.ComboBox DisableCursor;
        private System.Windows.Forms.ComboBox SkipIntro;
        private System.Windows.Forms.ComboBox Vsync;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelPresets;
        private System.Windows.Forms.Button buttonLow;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonHigh;
        private System.Windows.Forms.Button buttonUltra;
        private System.Windows.Forms.Button buttonDone;
    }
}

