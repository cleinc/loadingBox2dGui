using CoPick.Logging;
using CoPick.Robot;
using CoPick.Setting;
using loadingBox2dGui.models;
using loadingBox2dGui.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loadingBox2dGui.presenters
{
    public class OfflineMainPresenter
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        private readonly OfflineImageHandler _offlineImageHandler;
        private readonly ICargoBox2DInspectionEngine _engine;
        private readonly IOfflineCargoBox2DView _view;
        private readonly MasterDataManager _masterDataManager;
        private readonly CargoBox2DSettingManagerPresenter _settingManager;
        private Config _config;

        #region Inspection Data Fields
        private readonly InspectionLocation[] _inspectingLocations = new InspectionLocation[] { InspectionLocation.LH, InspectionLocation.RH };
        private Dictionary<int, CargoBox2DConfig> _modelParameterDict = new Dictionary<int, CargoBox2DConfig>();
        private int _currentCar = -1;
        private const int ArUcoCartype = int.MaxValue;
        #endregion

        #region Model Checker Fields
        private string _modelFilePath;
        #endregion

        public OfflineMainPresenter(ICargoBox2DInspectionEngine engine, IOfflineCargoBox2DView view,
            CargoBox2DSettingManagerPresenter cargoBox2DSettingManagerPresenter,
            Config config)
        {
            _offlineImageHandler = new OfflineImageHandler();
            _engine = engine;
            _masterDataManager = new MasterDataManager(true, _engine);
            _settingManager = cargoBox2DSettingManagerPresenter;
            _view = view;
            _engine.SetCallbackWriteLog(Logger.WriteLog);
            _config = config;

            _view.InspectionRecordFromPathRequested += View_InspectionRecordFromPathRequested;
            _view.OfflineFormReady += View_OfflineFormReady;
            _view.OfflineFormCloseRequested += View_OfflineFormCloseRequested;
            _view.OfflineImageAlignmentRequested += View_OfflineImageAlignmentRequested;
            _view.ModelFilesFromPathRequested += View_ModelFilesFromPathRequested;
            _view.LoadModelFromPathRequested += View_LoadModelFromPathRequested;
            _view.CheckModelImageRequested += View_CheckModelImageRequested;
            _view.CarTypeChangeRequested += View_CarTypeChanged;
            _view.ModelSourceImageFromPathRequested += View_ModelSourceImageFromPathRequested;
            _view.ShowSettingManagerRequested += View_ShowSettingManagerRequested;
            _view.SetEngineVerbosity += View_SetEngineVerbosity;
            _settingManager.SettingChangeConfirmed += SettingManager_SettingChangeConfirmed;
            _settingManager.UpdateMasterDataFromConfigPathRequested += SettingManager_UpdateMasterDataFromConfigPathRequested;
        }



        #region UI Events
        private void View_ModelSourceImageFromPathRequested(object sender, DataPathChangeEventArgs e)
        {
            var sourceImages = FileHelper.RecursivelyRetrieveFiles(e.NewPath, "*.png");
            _view.SetModelSourceImagesList(sourceImages);
        }

        private async void SettingManager_SettingChangeConfirmed(object sender, EventArgs e)
        {
            var configCandidate = _settingManager.ConfigCandidate;
            var isPathModified = _settingManager.ModifiedDataPaths;
            _config = configCandidate;
            SaveConfig();
            UpdateModelParametersFromConfig();
            if (isPathModified)
            {
                _masterDataManager.LoadMasterDataset(_config.GetMasterDataPathsDict());
                await _masterDataManager.InitializeMasterData();
            }
        }

        private async void SettingManager_UpdateMasterDataFromConfigPathRequested(object sender, EventArgs e)
        {
            var masterDataPathDict = _settingManager.ConfigCandidate.GetMasterDataPathsDict();
            _masterDataManager.LoadMasterDataset(masterDataPathDict);
            await _masterDataManager.InitializeMasterData();
        }

        private void View_ShowSettingManagerRequested(object sender, EventArgs e)
        {
            _settingManager.Start();
        }

        private void View_LoadModelFromPathRequested(object sender, DataPathChangeEventArgs e)
        {
            if (_engine.CheckModelPath(e.NewPath))
            {
                _modelFilePath = e.NewPath.Replace("\\", "/");
            }
            else
            {
                _modelFilePath = "";
                Logger.Error($"Model From Path {e.NewPath} is Invalid!");
            }
        }

        private void View_SetEngineVerbosity(object sender, EventArgs e)
        {
            _engine.SetEngineVerbosity(_view.EngineVerbosityLogLvl, _view.EngineVerbosityImgLvl);
        }

        private void View_ModelFilesFromPathRequested(object sender, DataPathChangeEventArgs e)
        {
            var retrievedModelFiles = FileHelper.RecursivelyRetrieveFiles(e.NewPath);
            _view.LoadModelFromPathRequested -= View_LoadModelFromPathRequested;
            _view.SetModelList(new BindingList<RetrievedFile>(retrievedModelFiles));
            _view.LoadModelFromPathRequested += View_LoadModelFromPathRequested;
        }

        private async void View_OfflineImageAlignmentRequested(object sender, string[] e)
        {
            if (e.Length != 2 || e[0] == null || e[1] == null)
            {
                Logger.Error("Invalid File Path for Offline Image Alignment");
                return;
            }
            if (_currentCar < 0)
            {
                Logger.Error("Car Type is not set, Please Select Car Type First");
                return;
            }
            ResetUi();

            var lhImagePath = e[0];
            var rhImagePath = e[1];
            var calculatedPose = await CalculateShiftPointAsync(lhImagePath, rhImagePath);
            if (calculatedPose != null)
            {
                _view.DisplayVisionResult(CoPick.Plc.VisionStatus.OK);
            }
            else
            {
                _view.DisplayVisionResult(CoPick.Plc.VisionStatus.NG);
            }
        }

        private void View_OfflineFormCloseRequested(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to Exit OFFLINE Program?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //_config.DarkMode = _view.DarkModeChecked;
                ConfigFileManager.SaveToFile(_config, FileHelper.GetOfflineConfigFilePath());
                //Process[] procs = Process.GetProcessesByName("ProductionRecordManager");
                //if (procs.Length > 0)
                //{
                //    procs[0].Kill();
                //}
                Logger.Debug("Program Exited");
            }
            else
            {
                e.Cancel = true;
            }
        }

        private async void View_OfflineFormReady(object sender, EventArgs e)
        {
            _engine.SetEngineVerbosity(0,0);
            _view.EngineVerbosityImgLvl = 0;
            _view.EngineVerbosityLogLvl = 0;

            if (_config != null)
            {
                ConfigureArUcoCartype();
                _view.ConfigPath = FileHelper.GetOfflineConfigFilePath();
                _view.SetCarTypeList(_config.GetCarTypeAndNameList());
                _masterDataManager.LoadMasterDataset(_config.GetMasterDataPathsDict());
                await _masterDataManager.InitializeMasterData();
                UpdateModelParametersFromConfig();
            }
        }

        private void View_InspectionRecordFromPathRequested(object sender, DataPathChangeEventArgs e)
        {
            var OfflineImages = FileHelper.FindInspectionImages(e.NewPath);
            if (OfflineImages != null && OfflineImages.Count > 0)
            {
                _view.SetOfflineImagesOnDataGrid(new BindingSource { DataSource = OfflineImages });
            }
        }
        
        private void View_CheckModelImageRequested(object sender, DataPathChangeEventArgs e)
        {
            if (string.IsNullOrEmpty(_modelFilePath))
            {
                Logger.Error("Model File Path is Empty, Please Select Model First");
                return;
            }
            _offlineImageHandler.LoadBitMapFromPath(e.NewPath);
            var imgStruct = _offlineImageHandler.ConvertBitMapToImgStruct(e.NewPath);
            if (imgStruct != null)
            {
                var imgStructValue = imgStruct.Value;
                _engine.CheckModelImage(ref imgStructValue, _modelFilePath, out int detectedRefHoleCount, out float modelConfidenceScore);

                var bitmap = _offlineImageHandler.ConvertLockedBitmapDataToBitmap(e.NewPath);

                _view.SetModelInferredImage(bitmap);
                _view.SetModelPerformance(modelConfidenceScore, detectedRefHoleCount);
                _offlineImageHandler.ClearBmpData();
            }
            else
            {
                Logger.Error($"Failed Converting Bitmap and or image struct from path: {e.NewPath}");
            }
        }

        private async Task<RobotPose> CalculateShiftPointAsync(string LHImagePath, string RHImagePath)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            _offlineImageHandler.LoadBitMapFromPath(InspectionLocation.LH, LHImagePath);
            _offlineImageHandler.LoadBitMapFromPath(InspectionLocation.RH, RHImagePath);
            _offlineImageHandler.SetCarType(_currentCar);

            UpdateUiByInspection(_offlineImageHandler);
            
            if (!_masterDataManager.InitializeTransformationMatrices(_currentCar))
            {
                Logger.Error("Failed Initializing Scan Settings");
                return null;
            }

            var structForShiftValueArray = _offlineImageHandler?.GetImageStructsArray(InspectionLocation.LH, InspectionLocation.RH);
            bool calculatePoseSuccess = false, modelValidated = false, calculationValidated = false;
            float minConfidenceScore = 0, maxMasterToSrcSizeRatioDiff = 0;
            int maxRefHoleCount = 0;
            calculatePoseSuccess = await Task.Run(() =>
            {
                return _engine.PoseAdjustmentCargoBox2D
                (structForShiftValueArray, structForShiftValueArray.Count(), 
                out minConfidenceScore, out maxMasterToSrcSizeRatioDiff, out maxRefHoleCount);
            });

            _offlineImageHandler.ClearBmpData();
            Logger.Info($"Calculate Shift Value Complete, Took {stopwatch.Elapsed}");
            if (calculatePoseSuccess)
            {
                var calculatedPose = structForShiftValueArray[0].GetRobotPose();
                foreach (ImageStruct imgStruct in structForShiftValueArray)
                {
                    Logger.Info($"Computed Shift Value: Location: {imgStruct.CameraLocation}, Pose: {imgStruct.Shift6D}");
                }
                _view.SetAlignmentModelPerformance(minConfidenceScore, maxMasterToSrcSizeRatioDiff, maxRefHoleCount);
                _view.SetCalculatedShiftValue(calculatedPose.Tx, calculatedPose.Ty, calculatedPose.Rz);
                (modelValidated, calculationValidated) = ValidateCalculationAndModelPerformance(calculatedPose, minConfidenceScore, maxMasterToSrcSizeRatioDiff, maxRefHoleCount);
                if (modelValidated && calculationValidated)
                {
                    return calculatedPose;
                }
            }

            Logger.Error($"Calculating Pose Success: {calculatePoseSuccess}. Calculation Validated: {calculationValidated}. Model Validated: {modelValidated}.");
            return null;
        }

        private void View_CarTypeChanged(object sender, EventArgs e)
        {
            if (_currentCar != _view.CarType)
            {
                ChangeCarType(_view.CarType);
            }
        }
        #endregion

        #region Utils
        private bool ChangeCarType(int carType)
        {
            if (_config.GetCarTypeList().Contains(carType))
            {
                _currentCar = carType;
                _view.CarType = carType;
                _config.RecentlyUsedCar = _currentCar;
                Logger.Info($"Lang.Msgs.CarTypeChanged: {carType}");
                return true;
            }
            else
            {
                Logger.Warning($"Lang.Msgs.InvalidCarType: ({carType})");
                return false;
            }
        }
        private bool ValidateCalculatedResult(CargoBox2DConfig modelConfig, RobotPose calculatedPose)
        {
            if (calculatedPose is null)
            {
                return false;
            }

            if (modelConfig.MaxTranslationX < Math.Abs(calculatedPose.Tx)
                || modelConfig.MaxTranslationY < Math.Abs(calculatedPose.Ty)
                || modelConfig.MaxTranslationZ < Math.Abs(calculatedPose.Tz)
                || modelConfig.MaxRotationZ < Math.Abs(calculatedPose.Rz))
            {
                Logger.Error($"Calculated Value Exceeds current threshold, " +
                    $"Tx: {modelConfig.MaxTranslationX} Ty: {modelConfig.MaxTranslationY} Tz: {modelConfig.MaxTranslationZ}. " +
                    $"Rz: {modelConfig.MaxRotationZ} Calculated Pose: {calculatedPose}");
                return false;
            }
            return true;
        }

        private bool ValidateModelPerformance(CargoBox2DConfig modelConfig, float minConfidenceScore, float maxMasterToSrcSizeRatioDiff, int maxRefHoleCount)
        {
            if (_currentCar == ArUcoCartype)
            {
                return true;
            }
            if (modelConfig.ConfidenceThreshold > minConfidenceScore)
            {
                Logger.Error($"Computed Confidence {minConfidenceScore} is lower than threshold. {modelConfig.ConfidenceThreshold}");
                return false;
            }
            if (modelConfig.SizeRatioDifferenceToSrcThreshold < Math.Abs(1 - maxMasterToSrcSizeRatioDiff))
            {
                Logger.Error($"Computed Size Difference {Math.Abs(1 - maxMasterToSrcSizeRatioDiff)} is higher than threshold. {modelConfig.SizeRatioDifferenceToSrcThreshold}");
                return false;
            }
            if (maxRefHoleCount != 1)
            {
                Logger.Error($"Computed Max Ref Hole Count {maxRefHoleCount} is not 1");
                return false;
            }
            return true;
        }

        private (bool, bool) ValidateCalculationAndModelPerformance(RobotPose calculatedPose, float minConfidenceScore, float maxMasterToSrcSizeRatioDiff, int maxRefHoleCount)
        {
                var modelConfig = _modelParameterDict[_currentCar];
                bool calculationValidated = ValidateCalculatedResult(modelConfig, calculatedPose);
                bool modelPerformanceValidated = ValidateModelPerformance(modelConfig, minConfidenceScore, maxMasterToSrcSizeRatioDiff, maxRefHoleCount);
                return (calculationValidated, modelPerformanceValidated);
        }

        private void UpdateUiByInspection(IImageProvider<InspectionLocation> providerByLoc)
        {
            try
            {
                var locImgs = providerByLoc?.GetAllBitmaps();
                Console.WriteLine($"Images, Count: {locImgs?.Length}");
                foreach (var locImg in locImgs)
                {
                    _view.SetInspectionImage(locImg.Item1, locImg.Item2?.Clone() as Image);
                }
            }
            catch (Exception) { }
        }

        private void SaveConfig()
        {
            try
            {
                ConfigFileManager.SaveToFile(_config, FileHelper.GetOfflineConfigFilePath());
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
        private void UpdateModelParametersFromConfig()
        {
            foreach (var kvp in _config.ConfigDict)
            {
                _modelParameterDict[kvp.Key] = kvp.Value;
            }
        }
        private void ResetUi()
        {
            _view.DisplayVisionResult(CoPick.Plc.VisionStatus.NONE);
            _view.SetAlignmentModelPerformance(0, 0, 0);
            _view.SetCalculatedShiftValue(0, 0, 0);
            _view.SetInspectionImage(InspectionLocation.LH, null);
            _view.SetInspectionImage(InspectionLocation.RH, null);
        }
        private void ConfigureArUcoCartype()
        {
            if (!_config.ConfigDict.TryGetValue(ArUcoCartype, out var _))
            {
                var arUcoCartypeConfig = new CargoBox2DConfig
                {
                    CarName = "ArUco",
                    Robot = _config.RobotConfigs.FirstOrDefault().Key,
                    Camera = _config.CameraConfigs.FirstOrDefault().Key
                };
                _config.ConfigDict[ArUcoCartype] = arUcoCartypeConfig;
                SaveConfig();
            }
        }
        #endregion
    }
}
