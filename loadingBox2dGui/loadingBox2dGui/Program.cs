using CoPick;
using CoPick.Logging;
using CoPick.Plc.Setting;
using CoPick.Robot.Setting;
using CoPick.Setting;
using CoPick.Setting.Presenters;
using loadingBox2dGui.models;
using loadingBox2dGui.models.ProductionRecord;
using loadingBox2dGui.presenters;
using loadingBox2dGui.presenters.SettingManagerPresenters;
using loadingBox2dGui.SettingManagerForm;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace loadingBox2dGui
{
    internal static class Program
    {
        private static readonly LogHelper Logger = LogHelper.Logger;

        [STAThread]
        static void Main()
        {
            if (System.Diagnostics.Process.GetProcessesByName("loadingBox2dGui").Length > 1)
            {
                MessageBox.Show("Program is already running.", "WARNING");
                return;
            }

            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException, false);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = (Exception)e.ExceptionObject;
                Logger.Fatal($"Caught by unhandled exception.. ({ex.Message}){Environment.NewLine}{ex.StackTrace}");
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Red700, Primary.BlueGrey500, Accent.Red200, TextShade.WHITE);

            Config config;
            try
            {
                config = ConfigFileManager.LoadFromFile<Config>(ConfigFileManager.GetConfigFilePath());
                config.LockCarType();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lang.MsgBox.LoadingConfigError ({ex.Message})", "Lang.MsgBox.WarningTitle");
                return;
            }

            Logger.Configure(config.LogPath, config.MinimumUiLogLevel, config.MinimumFileLogLevel);
            Logger.Info($"Program Started");
            ProductionRecordRepositoryMariaDb mariaDbRecordRepository;
            string retrievedConnectionString = ProductionRecordRepositoryMariaDb.GetConnectionString();
            if (retrievedConnectionString != null)
            {
                mariaDbRecordRepository = new ProductionRecordRepositoryMariaDb(retrievedConnectionString);
                mariaDbRecordRepository.CreateDatabaseIfNotExists();
                if (mariaDbRecordRepository.CreateTableProductionRecordIfNotExistsForProductionRecord() == 0)
                {
                    Logger.Debug("Connected to the MariaDB Production Record");
                }
                else
                {
                    mariaDbRecordRepository = null;
                    Logger.Warning("Could not create a table or connect to the MariaDB Production Record"); 
                }
            }
            else
            {
                mariaDbRecordRepository = null;
                Logger.Warning("Could not connect to the MariaDB Production Record");
            }

            FontManager.SetCustomFont("./Resources/NanumSquareRoundB.ttf");
            var robotSettingManagerForm = new RobotSettingManagerView();
            var camera2DSettingManagerForm = new Camera2DSettingManagerView();
            var plcSettingManagerForm = new PlcSettingManagerView();
            var lightSettingManagerForm = new LightSettingManagerView();
            var copyLightConfigsForm = new CopyConfigsMaterialForm_();
            var addNewLightForm = new AddLightConfigForm();
            var addRobotConfigForm = new AddRobotConfigForm_();
            var copyRobotConfigForm = new CopyConfigsForm_();
            var addCam2DConfigForm = new AddCamera2DForm_();
            var copyCamConfigForm = new CopyConfigsForm_();
            var copyCarTypeConfigForm = new CopyConfigsForm_();
            var addCarTypeForm = new AddCarTypeForm_();

            var settingForm = new CargoBox2DSettingManagerForm_(robotSettingManagerForm,
                                                                        plcSettingManagerForm,
                                                                        lightSettingManagerForm,
                                                                        camera2DSettingManagerForm);
            SettingChangeTracker settingChangeTracker = new SettingChangeTracker();
            var addRobotConfigPresenter = new AddRobotConfigPresenter(addRobotConfigForm, DefaultSettingLoader.Robots);
            var copyRobotConfigPresenter = new CopyRobotConfigPresenter(copyRobotConfigForm);
            var robotSettingManagerPresenter = new RobotSettingManagerPresenter(robotSettingManagerForm,
                                                                                addRobotConfigPresenter, copyRobotConfigPresenter,
                                                                                settingChangeTracker);
            var addCamera2DConfigPresenter = new AddCamera2DBundleConfigPresenter(addCam2DConfigForm, DefaultSettingLoader.CameraBundle);
            var copyCamera2DConfigPresenter = new CopyCamera2DBundleConfigPresenter(copyCamConfigForm);
            var cameraSettingManagerPresenter = new Camera2DBundleSettingManagerPresenter(camera2DSettingManagerForm,
                                                                                    addCamera2DConfigPresenter, copyCamera2DConfigPresenter,
                                                                                    config.CameraConfigs,
                                                                                    DefaultSettingLoader.Camera, settingChangeTracker);
            
            var addLightConfigPresenter = new AddLightConfigPresenter(addNewLightForm, DefaultSettingLoader.Lights);
            var copyLightConfigPresenter = new CopyLightConfigPresenter(copyLightConfigsForm);
            var lightSettingManagerPresenter = new LightSettingManagerPresenter(lightSettingManagerForm, addLightConfigPresenter, copyLightConfigPresenter, settingChangeTracker);
            
            var plcSettingManagerPresenter = new PlcSettingManagerPresenter(plcSettingManagerForm, settingChangeTracker, DefaultSettingLoader.Plcs);
            var copyCarTypeConfigPresenter = new CopyCarTypeConfigPresenter(copyCarTypeConfigForm);
            var addCarTypePresenter = new AddCarTypePresenter(addCarTypeForm);
            var engine = new CargoBox2DInspectionEngine(config);
            var settingManagerPresenter = new CargoBox2DSettingManagerPresenter(settingForm,
                                                               robotSettingManagerPresenter, cameraSettingManagerPresenter, plcSettingManagerPresenter, copyCarTypeConfigPresenter,
                                                               addCarTypePresenter, lightSettingManagerPresenter, new List<string> { "en-US" }, settingChangeTracker, engine);
            var mainForm = new MainForm(config.StartMode);
            var mainPresenter = new MainPresenter(mainForm, settingManagerPresenter, config, engine, mariaDbRecordRepository);
            Application.Run(mainForm);
        }
    }
}
