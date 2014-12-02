using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSFixEasySettings
{
    public static class DSFix_ini_contents
    {
        public static List<String> CompleteSettingsList { get; set; }
        public static string renderWidth { get; set; }
        public static string renderHeight { get; set; }
        public static string presentWidth { get; set; }
        public static string presentHeight { get; set; }
        public static string aaQuality { get; set; }
        public static string aaType { get; set; }
        public static string ssaoStrength { get; set; }
        public static string ssaoScale { get; set; }
        public static string ssaoType { get; set; }
        public static string dofOverrideResolution { get; set; }
        public static string disableDofScaling { get; set; }
        public static string dofBlurAmount { get; set; }
        public static string unlockFPS { get; set; }
        public static string FPSLimit { get; set; }
        public static string FPSThreshold { get; set; }
        public static string filteringOverride { get; set; }
        public static string enableHudMod { get; set; }
        public static string enableMinimalHud { get; set; }
        public static string hudScaleFactor { get; set; }
        public static string hudTopLeftOpacity { get; set; }
        public static string hudBottomLeftOpacity { get; set; }
        public static string hudBottomRightOpacity { get; set; }
        public static string borderlessFullscreen { get; set; }
        public static string disableCursor { get; set; }
        public static string captureCursor { get; set; }
        public static string enableBackups { get; set; }
        public static string backupInterval { get; set; }
        public static string maxBackups { get; set; }
        public static string enableTextureDumping { get; set; }
        public static string enableTextureOverride { get; set; }
        public static string skipIntro { get; set; }
        public static string screenshotDir { get; set; }
        public static string overrideLanguage { get; set; }
        public static string dinput8dllWrapper { get; set; }
        public static string d3dAdapterOverride { get; set; }
        public static string logLevel { get; set; }
        public static string forceWindowed { get; set; }
        public static string forceFullscreen { get; set; }
        public static string enableVsync { get; set; }
        public static string fullscreenHz { get; set; }
        public static void SetDefaultSettings()
        {
            CompleteSettingsList = new List<string>();
            renderWidth = "1920";
            renderHeight = "1080";
            presentWidth = "0";
            presentHeight = "0";
            aaQuality = "2";
            aaType = "SMAA";
            ssaoStrength = "3";
            ssaoScale = "1";
            ssaoType = "SCAO";
            dofOverrideResolution = "540";
            disableDofScaling = "0";
            dofBlurAmount = "1";
            unlockFPS = "0";
            FPSLimit = "60";
            FPSThreshold = "28";
            filteringOverride = "0";
            enableHudMod = "0";
            enableMinimalHud = "1";
            hudScaleFactor = "1";
            hudTopLeftOpacity = "0.8f";
            hudBottomLeftOpacity = "0.75f";
            hudBottomRightOpacity = "0.5f";
            borderlessFullscreen = "0";
            disableCursor = "1";
            captureCursor = "0";
            enableBackups = "1";
            backupInterval = "1500";
            maxBackups = "10";
            enableTextureDumping = "0";
            enableTextureOverride = "0";
            skipIntro = "1";
            screenshotDir = ".";
            overrideLanguage = "none";
            dinput8dllWrapper = "none";
            d3dAdapterOverride = "-1";
            logLevel = "0";
            forceWindowed = "0";
            forceFullscreen = "0";
            enableVsync = "0";
            fullscreenHz = "60";
            UpdateListBox();

        }

        public static void UpdateListBox()
        {
            CompleteSettingsList.Clear();
            CompleteSettingsList.Add("renderWidth " + renderWidth);
            CompleteSettingsList.Add("renderHeight " + renderHeight);
            CompleteSettingsList.Add("presentWidth " + presentWidth);
            CompleteSettingsList.Add("presentHeight " + presentHeight);
            CompleteSettingsList.Add("aaQuality " + aaQuality);
            CompleteSettingsList.Add("aaType " + aaType);
            CompleteSettingsList.Add("ssaoStrength " + ssaoStrength);
            CompleteSettingsList.Add("ssaoScale " + ssaoScale);
            CompleteSettingsList.Add("ssaoType " + ssaoType);
            CompleteSettingsList.Add("dofOverrideResolution " + dofOverrideResolution);
            CompleteSettingsList.Add("disableDofScaling " + disableDofScaling);
            CompleteSettingsList.Add("dofBlurAmount " + dofBlurAmount);
            CompleteSettingsList.Add("unlockFPS " + unlockFPS);
            CompleteSettingsList.Add("FPSLimit " + FPSLimit);
            CompleteSettingsList.Add("FPSThreshold " + FPSThreshold);
            CompleteSettingsList.Add("filteringOverride " + filteringOverride);
            CompleteSettingsList.Add("enableHudMod " + enableHudMod);
            CompleteSettingsList.Add("enableMinimalHud " + enableMinimalHud);
            CompleteSettingsList.Add("hudScaleFactor " + hudScaleFactor);
            CompleteSettingsList.Add("hudTopLeftOpacity " + hudTopLeftOpacity);
            CompleteSettingsList.Add("hudBottomLeftOpacity " + hudBottomLeftOpacity);
            CompleteSettingsList.Add("hudBottomRightOpacity " + hudBottomRightOpacity);
            CompleteSettingsList.Add("borderlessFullscreen " + borderlessFullscreen);
            CompleteSettingsList.Add("disableCursor " + disableCursor);
            CompleteSettingsList.Add("captureCursor " + captureCursor);
            CompleteSettingsList.Add("enableBackups " + enableBackups);
            CompleteSettingsList.Add("backupInterval " + backupInterval);
            CompleteSettingsList.Add("maxBackups " + maxBackups);
            CompleteSettingsList.Add("enableTextureDumping " + enableTextureDumping);
            CompleteSettingsList.Add("enableTextureOverride " + enableTextureOverride);
            CompleteSettingsList.Add("skipIntro " + skipIntro);
            CompleteSettingsList.Add("screenshotDir " + screenshotDir);
            CompleteSettingsList.Add("overrideLanguage " + overrideLanguage);
            CompleteSettingsList.Add("dinput8dllWrapper " + dinput8dllWrapper);
            CompleteSettingsList.Add("d3dAdapterOverride " + d3dAdapterOverride);
            CompleteSettingsList.Add("logLevel " + logLevel);
            CompleteSettingsList.Add("forceWindowed " + forceWindowed);
            CompleteSettingsList.Add("forceFullscreen " + forceFullscreen);
            CompleteSettingsList.Add("enableVsync " + enableVsync);
            CompleteSettingsList.Add("fullscreenHz " + fullscreenHz);
        }
    }
}
