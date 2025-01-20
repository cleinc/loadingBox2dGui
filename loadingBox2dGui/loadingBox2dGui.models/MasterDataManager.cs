using CoPick.Logging;
using CoPick.Robot;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using System.Drawing;
using System.Drawing.Imaging;

namespace loadingBox2dGui.models
{
    public class MasterDataManager
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        private readonly ICargoBox2DInspectionEngine _engine;
        private readonly bool _offlineMode = false;
        private bool _updateMasterDataRequested = false;
        private readonly InspectionLocation[] InspectionLocations = new InspectionLocation[] { InspectionLocation.LH, InspectionLocation.RH };
        private readonly SemaphoreSlim _masterDataAccessLock = new SemaphoreSlim(1,1);

        private Dictionary<int, Dictionary<DataType, List<MasterPathStruct>>> _carTypeToMasterDataset =  new Dictionary<int, Dictionary<DataType, List<MasterPathStruct>>>();
        private Dictionary<int, TCP> _carTypeToMasterInstallPose = new Dictionary<int, TCP>();
        private Dictionary<int, TCP> _carTypeToMasterScanPose = new Dictionary<int, TCP>();
        private Dictionary<InspectionLocation, TCP> _locToMasterExtrinsicCalibrationTCP = new Dictionary<InspectionLocation, TCP>();
        
        #region Master Data File Info
        public static string MasterInstallPoseTcpFile = "MasterInstallPoseTcp.yml";
        public static string MasterScanPoseTcpFile = "MasterScanPoseTcp.yml";
        public static string ScanPoseTcpFile = "scanPoseTcp.yml";
        private const string _defaultMasterDataRootPath = "C:\\Data";
        #endregion

        public MasterDataManager(bool isOffline, ICargoBox2DInspectionEngine engine)
        {
            _offlineMode = isOffline;
            _engine = engine;
        }

        public bool SaveMasterRobotScanPose(RobotPose pose, int carType, string masterDataRootPath = _defaultMasterDataRootPath)
        {
            TCP masterScanPoseTCP = TCP.GetTCPFromRobotPose(pose);
            if (!TrySerializeYaml(Path.Combine(masterDataRootPath, GenerateMasterDataPath(DataType.RobotPose, carType, masterDataRootPath)), 
                MasterScanPoseTcpFile, masterScanPoseTCP))
            {
                return false; 
            }
            return true;
        }

        public bool SaveMasterRobotInstallPose(RobotPose pose, int carType, string masterDataRootPath = _defaultMasterDataRootPath)
        {
            TCP masterInstallPoseTCP = TCP.GetTCPFromRobotPose(pose);
            if (!TrySerializeYaml(Path.Combine(masterDataRootPath, GenerateMasterDataPath(DataType.RobotPose, carType, masterDataRootPath)), 
                MasterInstallPoseTcpFile, masterInstallPoseTCP))
            {
                return false; 
            }
            return true;
        }

        public async Task SaveMasterImage(IImageProvider<InspectionLocation> imageProvider, int cartype, string masterDataRootPath = _defaultMasterDataRootPath)
        {
            var locImages = imageProvider.GetAllBitmaps();
            if (locImages != null)
            {
                List<Task> saveImageTasks = new List<Task>();
                foreach (var locImg in locImages)
                {
                    saveImageTasks.Add(Task.Run(() =>
                        SaveBitmap(locImg.Item1, locImg.Item2,
                        GenerateMasterDataPath(DataType.MasterImage, cartype, masterDataRootPath),
                        ImageFormat.Png)));
                }
                await Task.WhenAll(saveImageTasks);
            }
        }

        public bool LoadMasterDataset(Dictionary<int, Dictionary<DataType, string>> configMasterDataPathsDict)
        {
            Stopwatch sw = Stopwatch.StartNew();
            _masterDataAccessLock.Wait();
            try
            {
                foreach (var cartypeToMasterDataDict in configMasterDataPathsDict)
                {
                    string masterImageRootPath = cartypeToMasterDataDict.Value[DataType.MasterImage];
                    bool getMasterImageFilePathsSucceed = TryGetLocToFilePathsDictFromDirectory(masterImageRootPath, out var locToMasterImagePaths);

                    string checkerBoardRootPath = cartypeToMasterDataDict.Value[DataType.CheckerBoard];
                    bool getCheckerBoardFilePathsSucceed = TryGetLocToFilePathsDictFromDirectory(checkerBoardRootPath, out var locToCheckerBoardfiles);

                    string robotPoseRootPath = cartypeToMasterDataDict.Value[DataType.RobotPose];
                    bool getInstallPoseFilePathsSucceed = TryDeserializeYaml<TCP>(Path.Combine(robotPoseRootPath, MasterInstallPoseTcpFile), out var masterInstallPose);
                    bool getScanPoseFilePathsSucceed = TryDeserializeYaml<TCP>(Path.Combine(robotPoseRootPath, MasterScanPoseTcpFile), out var masterScanPose);

                    string calibrationDataPath = cartypeToMasterDataDict.Value[DataType.IntrinsicCalibration];
                    bool getCalibrationFilePathsSucceed = TryGetLocToFilePathsDictFromDirectory(calibrationDataPath, out var locToCalibrationFiles);

                    string masterCameraTcpPath = cartypeToMasterDataDict.Value[DataType.ExtrinsicCalibration];
                    bool getMasterCameraTcpFilePathsSucceed = TryDeserializeYaml<HandEyeCalibrationData>(masterCameraTcpPath, out var handEyeCalibrationData);

                    if (!getMasterImageFilePathsSucceed || !getCheckerBoardFilePathsSucceed || !getCalibrationFilePathsSucceed
                        || !getMasterCameraTcpFilePathsSucceed || !getInstallPoseFilePathsSucceed ||!getScanPoseFilePathsSucceed)
                    {
                        Logger.Error($"Failed Refreshing Master Dataset. Master Image : {getMasterImageFilePathsSucceed}. \n" +
                                    $"CheckerBoard : {getCheckerBoardFilePathsSucceed}. Calibration : {getCalibrationFilePathsSucceed}.\n + " +
                                    $"InstallPose :{getInstallPoseFilePathsSucceed}. ScanPose : {getScanPoseFilePathsSucceed}");
                        return false;
                    }
                    string shiftModelFilePath = cartypeToMasterDataDict.Value[DataType.ShiftModel];
                    int carType = cartypeToMasterDataDict.Key;
                    if (!_carTypeToMasterDataset.ContainsKey(carType))
                    {
                        _carTypeToMasterDataset[carType] = new Dictionary<DataType, List<MasterPathStruct>>()
                        { 
                            [DataType.MasterImage] = new List<MasterPathStruct>(),
                            [DataType.CheckerBoard] = new List<MasterPathStruct>()
                        };
                    }

                    List<MasterPathStruct> masterImageStructs = new List<MasterPathStruct>();
                    List<MasterPathStruct> checkerBoardStructs = new List<MasterPathStruct>();
                    foreach (InspectionLocation registeredLoc in InspectionLocations)
                    {
                        if (TryDeserializeYaml<CalibrationData>(locToCalibrationFiles[registeredLoc], out var calibrationData))
                        {
                            masterImageStructs.Add(MasterPathStruct.MasterImageStruct(carType, locToMasterImagePaths[registeredLoc], shiftModelFilePath, registeredLoc, 
                            calibrationData)); 
                            checkerBoardStructs.Add(MasterPathStruct.CharucoImageStruct(carType, locToCheckerBoardfiles[registeredLoc], shiftModelFilePath, registeredLoc, 
                            calibrationData));
                        }
                        else
                        {
                            Logger.Error($"Failed Refreshing Master Dataset. Failed while parsing Calibration Data From Path : {locToCalibrationFiles[registeredLoc]}");
                            return false;
                        }
                    }

                    _locToMasterExtrinsicCalibrationTCP[InspectionLocation.LH] = new TCP { TcpMatrix = handEyeCalibrationData.Lh.Data.ToArray() };
                    _locToMasterExtrinsicCalibrationTCP[InspectionLocation.RH] = new TCP { TcpMatrix = handEyeCalibrationData.Rh.Data.ToArray() };
                    
                    _carTypeToMasterInstallPose[carType] = masterInstallPose;
                    _carTypeToMasterScanPose[carType] = masterScanPose;

                    _carTypeToMasterDataset[carType][DataType.MasterImage] = masterImageStructs;
                    _carTypeToMasterDataset[carType][DataType.CheckerBoard] = checkerBoardStructs;
                }
            }
            finally
            {
                _masterDataAccessLock.Release();
            }
            Logger.Info($"Loading Master Data From File Path Complete, Took {sw.Elapsed}");
            _updateMasterDataRequested = true;
            return true;
        }

        public async Task<bool> InitializeMasterData(int timeOutMilliseconds = 250)
        {
            if (!_updateMasterDataRequested)
            {
                Logger.Debug($"Update Master Data From Path Set to False. Check to see if Loading Master Data from Config Path Failed");
                return true;
            }

            Stopwatch sw = Stopwatch.StartNew();
            if (!await _masterDataAccessLock.WaitAsync(timeOutMilliseconds))
            {
                Logger.Error($"Failed to load MasterPathStructs to InspectionEngine, due to TimeOut: {timeOutMilliseconds} ms");
                return false;
            }

            try
            {
                foreach (int carType in _carTypeToMasterDataset.Keys)
                {
                    var checkerBoardImageStructs = _carTypeToMasterDataset[carType][DataType.CheckerBoard].ToArray();
                    _engine.LoadCharucoBoardConfig(checkerBoardImageStructs, checkerBoardImageStructs.Length);
                    var masterImageStructs = _carTypeToMasterDataset[carType][DataType.MasterImage].ToArray();
                    _engine.LoadMasterImage(masterImageStructs, masterImageStructs.Length);
                }

                if (await Task.Run(() => _engine.InitializeMaster()))
                {
                    _updateMasterDataRequested = false;
                    Logger.Info($"Initializing Model Finished. Succeeded, Took {sw.Elapsed}");
                    return true;
                }
                else
                {
                    Logger.Error($"Initializing Master Data Settings Failed");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error while Initializing Master Data to Inspection Engine. Error : {ex}");
                return false;
            }
            finally
            {
                _masterDataAccessLock.Release();
            }
        }

        public bool InitializeTransformationMatrices(int carType, RobotPose readScanPose, RobotPose readInstallPose, bool compareMaster = true)
        {
            if (_locToMasterExtrinsicCalibrationTCP.Count != 2)
            {
                Logger.Info($"Extrinsic Calibration TCP Not set, Update Master Data Set");
                return false;
            }
            if (!_carTypeToMasterInstallPose.TryGetValue(carType, out var masterInstallPoseTCP) || 
                !_carTypeToMasterScanPose.TryGetValue(carType, out var masterScanPoseTCP))
            {
                Logger.Info($"Master Install Pose or Scan Pose not set, Update Master Data Set");
                return false;
            }
            var readScanPoseTCP = TCP.GetTCPFromRobotPose(readScanPose);
            var readInstallPoseTCP = TCP.GetTCPFromRobotPose(readInstallPose);

            if (compareMaster)
            {
                if (!EqualTCP(readScanPoseTCP, masterScanPoseTCP))
                {
                    Logger.Warning($"Read Scan Pose is Different to Registered Master Scan Pose on Cartype: {carType}, Applying Read Robot Pose. Read Scan Pose: {masterScanPoseTCP}, Registered Pose: {readScanPoseTCP}");
                    masterScanPoseTCP = readScanPoseTCP;
                }
                if (!EqualTCP(readInstallPoseTCP, masterInstallPoseTCP))
                {
                    Logger.Warning($"Read Install Pose is Different to Registered Master Install Pose on Cartype: {carType}, Applying Read Robot Pose. Read Install Pose: {masterInstallPoseTCP}, Registered Pose: {readInstallPoseTCP}");
                    masterInstallPoseTCP = readInstallPoseTCP;
                }
            }

            Logger.Info($"Scan Pose TCP: {masterScanPoseTCP} \t Install Pose TCP: {masterInstallPoseTCP}");
            bool ret = _engine.LoadTransformationMatrix(masterScanPoseTCP, masterInstallPoseTCP,
                _locToMasterExtrinsicCalibrationTCP[InspectionLocation.LH], _locToMasterExtrinsicCalibrationTCP[InspectionLocation.RH]);
            if (!ret)
            {
                Logger.Error($"Failed Loading Scan Settings to Engine. loadTransformMat API Failed");
                return false;
            }

            return true;
        }

        public bool InitializeTransformationMatrices(int carType)
        {
            if (_locToMasterExtrinsicCalibrationTCP.Count != 2)
            {
                Logger.Info($"Extrinsic Calibration TCP Not set, Update Master Data Set");
                return false;
            }
            if (!_carTypeToMasterInstallPose.TryGetValue(carType, out var masterScanPoseTCP) || 
                !_carTypeToMasterScanPose.TryGetValue(carType, out var masterInstallPoseTCP))
            {
                Logger.Info($"Master Install Pose or Scan Pose not set, Update Master Data Set");
                return false;
            }
            
            Logger.Info($"Scan Pose TCP: {masterScanPoseTCP} \t Install Pose TCP: {masterInstallPoseTCP}");
            bool ret = _engine.LoadTransformationMatrix(masterScanPoseTCP, masterInstallPoseTCP,
                _locToMasterExtrinsicCalibrationTCP[InspectionLocation.LH], _locToMasterExtrinsicCalibrationTCP[InspectionLocation.RH]);
            if (!ret)
            {
                Logger.Error($"Failed Loading Scan Settings to Engine. loadTransformMat API Failed");
                return false;
            }

            return true;
        }
        #region Utils
        private bool SaveBitmap(InspectionLocation location, Bitmap bitmap, string saveRootPath, ImageFormat imageFormat)
        {
            try
            {
                string fileName = $"{location}.{imageFormat}";
                string fullPath = Path.Combine(saveRootPath, location.ToString(), fileName);
                if (!Directory.Exists(Path.GetDirectoryName(fullPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
                }
                bitmap.Save(fullPath, imageFormat);
                Logger.Info($"SaveComplte, ID: {location} on path {fullPath}");
                return true;
            }
            catch(Exception ex)
            {
                Logger.Error($"Failed to save Bitmap to Path: {saveRootPath}, Error: {ex.Message}");
                return false;
            }
        }

        private bool TryGetLocToFilePathsDictFromDirectory (string folderPath, out Dictionary<InspectionLocation, string> locToFilePaths)
        {
            if (!Directory.Exists(folderPath))
            {
                Logger.Error($"Failed getting file path from given folder path : {folderPath}");
                locToFilePaths = null;
                return false;
            }

            string[] folderPaths;
            try
            {
                folderPaths = Directory.GetDirectories(folderPath);
            }
            catch (Exception e)
            {
                Logger.Error($"Getting Folder Paths from {folderPath} Failed. Error : {e.Message}");
                locToFilePaths = null;
                return false;
            }

            Dictionary<InspectionLocation, string> foundLocToFilePaths = new Dictionary<InspectionLocation, string>();
            foreach (string folder in folderPaths)
            {
                string folderName = Path.GetFileName(folder).Trim();
                if (Enum.TryParse(folderName, true, out InspectionLocation location))
                {
                    string[] file = Directory.GetFiles(folder);
                    if (file.Length == 0)
                    {
                        Logger.Error($"Found no files on Path {folder}");
                        locToFilePaths = null;
                        return false;
                    }
                    else if (file.Length > 1)
                    {
                        Logger.Error($"Multiple files found on path {folder}, setting first as file path {file[0]}");
                        foundLocToFilePaths[location] = file[0].Replace('\\', '/');
                    }
                    else
                    {
                        foundLocToFilePaths[location] = file[0].Replace('\\', '/');
                    }
                    Console.WriteLine($"Path : {file[0]}");
                }
                else
                {
                    Logger.Error($"Invalid Folder Path found on RootPath: {folderPath}, Invalid Path : {folder}");
                }
            }

            locToFilePaths = foundLocToFilePaths;
            return true;
        }

        private bool TryDeserializeYaml<T>(string path, out T deserializedInstance)
        {
            string yamlContent;
            try
            {
                yamlContent = File.ReadAllText(path);
                yamlContent = yamlContent.Replace("\uFEFF", "").Trim();

                if (yamlContent.StartsWith("%YAML"))
                {
                    int firstNewLineIndex = yamlContent.IndexOf('\n');
                    yamlContent = firstNewLineIndex >= 0
                    ? yamlContent.Substring(firstNewLineIndex).Trim()
                    : yamlContent;
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error reading file from path : {path}, Error: {ex.Message}");
                deserializedInstance = default;
                return false;
            }

            var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .WithTagMapping("tag:yaml.org,2002:opencv-matrix", typeof(Matrix))
            .Build();

            T data;
            try 
            {
                data = deserializer.Deserialize<T>(yamlContent);
            }
            catch (Exception ex)
            {
                Logger.Error($"Error while deserializing calibration data from path : {path}, Error: {ex}");
                deserializedInstance = default;
                return false;
            }
            deserializedInstance = data;
            return true;
        }

        private bool TrySerializeYaml<T>(string path, string fileName, T data)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string fullPath = Path.Combine(path, fileName);

                var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

                string yaml = serializer.Serialize(data);

                File.WriteAllText(fullPath, yaml);

                return true;
            }
            catch (Exception ex)
            {
                Logger.Error($"Failed to serialize to {path}: {ex.Message}");
                return false; 
            }
        }

        private string GenerateMasterDataPath(DataType dataType, string rootPath = _defaultMasterDataRootPath)
        {
            return Path.Combine(rootPath, dataType.ToString(), DateTime.Now.ToString("yyMMdd"));
        }

        private string GenerateMasterDataPath(DataType dataType, int carType, string rootPath = _defaultMasterDataRootPath)
        {
            return Path.Combine(rootPath, dataType.ToString(), carType.ToString(), DateTime.Now.ToString("yyMMdd"));
        }

        private bool EqualTCP(TCP tcp1, TCP tcp2)
        {
            if (tcp1.TcpMatrix == null || tcp2.TcpMatrix == null)
            {
                return false;
            }

            if (tcp1.TcpMatrix.Length != tcp2.TcpMatrix.Length)
            {
                return false;
            }

            for (int i = 0; i < tcp1.TcpMatrix.Length; i++)
            {
                if (Math.Abs(tcp1.TcpMatrix[i] - tcp2.TcpMatrix[i]) > 0.0001)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}