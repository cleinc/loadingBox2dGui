using CoPick;
using CoPick.Logging;
using CoPick.Setting;
using loadingBox2dGui.models;
using loadingBox2dGui.presenters;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui
{
    internal static class Program
    {
        private static readonly LogHelper Logger = LogHelper.Logger;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Red700, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);

            Config config;
            try
            {
                config = ConfigFileManager.LoadFromFile<Config>(ConfigFileManager.GetConfigFilePath());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lang.MsgBoxFineLo.LoadingConfigError ({ex.Message})", "Lang.MsgBoxFineLo.WarningTitle");
                return;
            }

            Logger.Configure(config.LogPath, config.MinimumUiLogLevel, config.MinimumFileLogLevel);
            FontManager.SetCustomFont("./Resources/NanumSquareRoundB.ttf");
            var mainForm = new MainForm();
            var mainPresenter = new MainPresenter(mainForm, config);
            Application.Run(mainForm);
        }
    }
}
