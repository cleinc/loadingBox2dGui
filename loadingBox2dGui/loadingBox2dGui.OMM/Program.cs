using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoPick;
using CoPick.Logging;
using CoPick.Setting;
using loadingBox2dGui;
using loadingBox2dGui.models;
using loadingBox2dGui.presenters;

namespace loadingBox2dGui.OMM
{
    internal static class Program
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException, false);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = (Exception)e.ExceptionObject;
                Logger.Fatal($"Caught by unhandled exception.. ({ex.Message}){Environment.NewLine}{ex.StackTrace}");
            };
            Config config;
            try
            {
                config = ConfigFileManager.LoadFromFile<Config>(FileHelper.GetOfflineConfigFilePath());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lang.MsgBox.LoadingConfigError ({ex.Message})", "Lang.MsgBoxFineLo.WarningTitle");
                return;
            }
            Logger.Info($"Program Started");
            Logger.Configure(config.LogPath, config.MinimumUiLogLevel, config.MinimumFileLogLevel);
            var engine = new CargoBox2DInspectionEngine();
            var offlineForm = new OfflineMainForm();
            var offlineSettingManagerView = new CargoBox2DSettingManagerForm_();
            SettingChangeTracker settingChangeTracker = new SettingChangeTracker();
            var settingManagerPresenter = new CargoBox2DSettingManagerPresenter(offlineSettingManagerView, 
                new List<string> { "en-US" }, settingChangeTracker, engine);
            var offlinePresenter = new OfflineMainPresenter(engine, offlineForm, settingManagerPresenter, config);
            Application.Run(offlineForm);
        }
    }
}