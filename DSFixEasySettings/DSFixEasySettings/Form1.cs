using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSFixEasySettings
{
    public partial class DSFixEasySettings : Form
    {
        public DSFixEasySettings()
        {
            InitializeComponent();
            DSFix_ini_contents.SetDefaultSettings();
            UpdateSettingsDisplay();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            HelpWindow help = new HelpWindow();
            help.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DSFix_ini_contents.SetDefaultSettings();
            UpdateSettingsDisplay();
        }

        public void UpdateSettingsDisplay()
        {
            DSFix_ini_contents.UpdateListBox();
            string completeSetting = "";
            settingsListBox.Clear();
            foreach (var setting in DSFix_ini_contents.CompleteSettingsList)
            {
                completeSetting += setting + "\r\n";
            }
            settingsListBox.Text = completeSetting;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ResolutionBox.Text)
            {
                case "800 x 600":
                    DSFix_ini_contents.renderWidth = "800";
                    DSFix_ini_contents.renderHeight = "600";
                    break;
                case "1024 x 768":
                    DSFix_ini_contents.renderWidth = "1024";
                    DSFix_ini_contents.renderHeight = "768";
                    break;
                case "1280 x 720":
                    DSFix_ini_contents.renderWidth = "1280";
                    DSFix_ini_contents.renderHeight = "720";
                    break;
                case "1440 x 900":
                    DSFix_ini_contents.renderWidth = "1440";
                    DSFix_ini_contents.renderHeight = "900";
                    break;
                case "1920 x 1080":
                    DSFix_ini_contents.renderWidth = "1920";
                    DSFix_ini_contents.renderHeight = "1080";
                    break;
                case "2560 x 1440":
                    DSFix_ini_contents.renderWidth = "2560";
                    DSFix_ini_contents.renderHeight = "1440";
                    break;
                case "3840 x 2160":
                    DSFix_ini_contents.renderWidth = "3840";
                    DSFix_ini_contents.renderHeight = "2160";
                    break;
                default:
                    break;
            }
                        UpdateSettingsDisplay();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AAQuality.Text)
            {
                case "0":
                    DSFix_ini_contents.aaQuality = "0";
                    break;
                case "1":
                    DSFix_ini_contents.aaQuality = "1";
                    break;
                case "2":
                    DSFix_ini_contents.aaQuality = "2";
                    break;
                case "3":
                    DSFix_ini_contents.aaQuality = "3";
                    break;
                case "4":
                    DSFix_ini_contents.aaQuality = "4";
                    break;
                default:
                    break;
            }
            UpdateSettingsDisplay();
        }

        private void AAType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AAType.Text)
            {
                case "SMAA":
                    DSFix_ini_contents.aaType = "SMAA";
                    break;
                case "FXAA":
                    DSFix_ini_contents.aaType = "FXAA";
                    break;
                default:
                    break;
            }
            UpdateSettingsDisplay();
        }

        private void SSAOStrength_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SSAOStrength.Text)
            {
                case "0":
                    DSFix_ini_contents.ssaoStrength = "0";
                    break;
                case "1":
                    DSFix_ini_contents.ssaoStrength = "1";
                    break;
                case "2":
                    DSFix_ini_contents.ssaoStrength = "2";
                    break;
                case "3":
                    DSFix_ini_contents.ssaoStrength = "3";
                    break;
                default:
                    break;
            }
            UpdateSettingsDisplay();
        }

        private void SSAOScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SSAOScale.Text)
            {
                case "1":
                    DSFix_ini_contents.ssaoScale = "1";
                    break;
                case "2":
                    DSFix_ini_contents.ssaoScale = "2";
                    break;
                case "3":
                    DSFix_ini_contents.ssaoScale = "3";
                    break;
                default:
                    break;
            }
            UpdateSettingsDisplay();
        }

        private void SSAOType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SSAOType.Text)
            {
                case "VSSAO":
                    DSFix_ini_contents.ssaoType = "VSSAO";
                    break;
                case "VSSAO2":
                    DSFix_ini_contents.ssaoType = "VSSAO2";
                    break;
                case "HBAO":
                    DSFix_ini_contents.ssaoType = "HBAO";
                    break;
                case "SCAO":
                    DSFix_ini_contents.ssaoType = "SCAO";
                    break;
                default:
                    break;
            }
            UpdateSettingsDisplay();
        }
    }
}
