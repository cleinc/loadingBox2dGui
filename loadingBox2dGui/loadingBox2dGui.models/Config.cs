using CoPick.Logging;
using CoPick.Plc;
using CoPick.Setting;
using CoPick.Robot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace loadingBox2dGui.models
{
    [Serializable]
    public class Config
    {
        public Dictionary<string, Dictionary<PlcAttribute, string>> PlcConfigs { get; set; }
        public Dictionary<string, Dictionary<LightAttribute, string>> LightConfigs { get; set;}
        public Dictionary<string, Dictionary<RobotAttribute, string>> RobotConfigs { get; set;}
        public Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> CameraConfigs { get; set; }
        public Dictionary<int, CargoBox2DConfig> ConfigDict { get; set; } = new Dictionary<int, CargoBox2DConfig>();
        public string Plc { get; set; } = "undefined";
        public string Light { get; set; } = "undefined";
        public string Camera { get; set; } = "undefined";
        public int RecentlyUsedCar { get; set; } = 0;
        public string Language { get; set; } = "ko-KR";
        public TaskType TaskType { get; set; } = TaskType.Cargo;
        public LogLevel MinimumFileLogLevel { get; set; } = LogLevel.Debug;
        public LogLevel MinimumUiLogLevel { get; set; } = LogLevel.Debug;
        private string _logPath = Path.GetFullPath("D:/log");
        public string LogPath
        {
            get => _logPath;
            set
            {
                try
                {
                    Path.GetFullPath(value);
                    _logPath = value;
                }
                catch (Exception) { }
            }
        }
        public string IntrinsicCalibrationDataRootPath { get; set; } = "undefined";
        public string ZRotationPerLocationDataFilePath { get; set; } = "currentUnusedUtilizedByInspectionEngine";
        public string ExtrinsicCalibrationDataFilePath { get; set; } = "undefined";
        public OperationMode StartMode { get; set; } = OperationMode.Auto;
        public DateTime StartTimeToGetNgList { get; set; } = DateTime.Now;
        public Config()
        {
            Plc = "Tk1MelsecCommunicator";
            Camera = "PylonCameraCommunicator";
            Light = "ModbusLightCommunicator";

            PlcConfigs = new Dictionary<string, Dictionary<PlcAttribute, string>>()
            {
                ["Tk1MelsecCommunicator"] = DefaultSettingLoader.Plcs[PlcModel.MELSEC]()
            };
            CameraConfigs = new Dictionary<string, Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>> ()
            {
                ["Unknown"] = DefaultSettingLoader.CameraBundle[Camera2DMaker.BASLER]()
            };
            LightConfigs = new Dictionary<string, Dictionary<LightAttribute, string>>()
            {
                ["ModbusLightCommunicator"] = DefaultSettingLoader.Lights[LightMaker.MODBUS]()
            };
            RobotConfigs = new Dictionary<string, Dictionary<RobotAttribute, string>>()
            {
                ["Install"] = DefaultSettingLoader.Robots[RobotMaker.YASKAWA]()
            };

            ConfigDict[0] = new CargoBox2DConfig();
        }
        public bool Delete(int k)
        {
            return ConfigDict.Remove(k);
        }
        public List<int> GetCarTypeList()
        {
            return ConfigDict.Keys.ToList();
        }
        public List<string> GetCarTypeStringList()
        {
            return ConfigDict.Keys.Select(k => k.ToString()).ToList();
        }
        public BindingList<CarTypeAndName> GetCarTypeAndNameList()
        {
            return new BindingList<CarTypeAndName>(ConfigDict.Select(x => new CarTypeAndName(x.Key, x.Value.CarName)).ToList());
        }
        public List<string> GetCamSetList()
        {
            return CameraConfigs.Keys.ToList();
        }
        public List<string> GetRobotList()
        {
            return RobotConfigs.Keys?.ToList();
        }
        public CargoBox2DConfig this[int key]
        {
            get
            {
                if (key == -1)
                {
                    key = RecentlyUsedCar;
                }

                if (!ConfigDict.TryGetValue(key, out CargoBox2DConfig config))
                {
                    config = default;
                }
                return config;
            }

            set
            {
                if (key == -1)
                {
                    key = RecentlyUsedCar;
                }

                ConfigDict[key] = value;
            }
        }
        public void LockCarType()
        {
            try
            {
                var carList = GetPermittedCarTypeList();
                var invalidList = ConfigDict.Keys.Where(k => !carList.Contains(k)).ToArray();
                foreach (var carType in invalidList)
                {
                    ConfigDict.Remove(carType);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public List<int> GetPermittedCarTypeList()
        {
            List<int> permittedCarTypeList = new List<int>();
            try
            {
                string carString = Encoding.UTF8.GetString(Convert.FromBase64String(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "msg_format.dat"))));
                permittedCarTypeList = carString.Replace("C", "").Replace("L", "").Split('E').Select(c => Convert.ToInt32(c)).ToList();
                return permittedCarTypeList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return permittedCarTypeList;
            }
        }
        public Dictionary<int, Dictionary<DataType, string>> GetMasterDataPathsDict()
        {
            Dictionary<int, Dictionary<DataType, string>> masterDataPathsDict = new Dictionary<int, Dictionary<DataType, string>>();
            foreach (var carKvP in ConfigDict)
            {
                masterDataPathsDict[carKvP.Key] = new Dictionary<DataType, string>()
                {
                    [DataType.MasterImage] = carKvP.Value.MasterImageRootFolderPath,
                    [DataType.RobotPose] = carKvP.Value.RobotPoseRootFolderPath,
                    [DataType.CheckerBoard] = carKvP.Value.CheckerBoardRootFolderPath,
                    [DataType.ShiftModel] = carKvP.Value.ShiftModelPath,
                    [DataType.IntrinsicCalibration] = IntrinsicCalibrationDataRootPath,
                    [DataType.ExtrinsicCalibration] = ExtrinsicCalibrationDataFilePath
                };
            }
            return masterDataPathsDict;
        }
    }

    public static class DefaultSettingLoader
    {
        public static Dictionary<PlcModel, Func<Dictionary<PlcAttribute, string>>> Plcs = new Dictionary<PlcModel, Func<Dictionary<PlcAttribute, string>>>()
        {
            [PlcModel.MELSEC] = GetMelsecSettings,
        };

        private static Dictionary<PlcAttribute, string> GetMelsecSettings()
        {
            return new Dictionary<PlcAttribute, string>()
            {
                [PlcAttribute.LOGICAL_STATION] = "1"
            };
        }

        public static Dictionary<LightMaker, Func<Dictionary<LightAttribute, string>>> Lights = new Dictionary<LightMaker, Func<Dictionary<LightAttribute, string>>>()
        {
            [LightMaker.MODBUS] = GetModbusLightSettings,
        };

        public static Dictionary<LightAttribute, string> GetModbusLightSettings()
        {
            return new Dictionary<LightAttribute, string>()
            {
                [LightAttribute.IPAdr] = "192.168.2.3",
                [LightAttribute.PortNo] = "502",
                [LightAttribute.StateRegister] = "0",
            };
        }

        public static Dictionary<Camera2DMaker, Func<Dictionary<Camera2DAttribute, string>>> Camera = new Dictionary<Camera2DMaker, Func<Dictionary<Camera2DAttribute, string>>>()
        {
            [Camera2DMaker.BASLER] = GetBaslerSettings,
        };

        public static Dictionary<Camera2DMaker, Func<Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>>> CameraBundle = new Dictionary<Camera2DMaker, Func<Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>>>()
        {
            [Camera2DMaker.BASLER] = GetBaslerCamSettings,
            [Camera2DMaker.IDS] = GetIDSCamSettings
        };

        private static Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>> GetBaslerCamSettings()
        {
            return new Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>()
            {
                [InspectionLocation.LH] = GetBaslerSettings(),
                [InspectionLocation.RH] = GetBaslerSettings(),
            };
        }

        private static Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>> GetIDSCamSettings()
        {
            return new Dictionary<InspectionLocation, Dictionary<Camera2DAttribute, string>>()
            {
                [InspectionLocation.LH] = GetIDSSettings(),
                [InspectionLocation.RH] = GetIDSSettings(),
            };
        }

        private static Dictionary<Camera2DAttribute, string> GetBaslerSettings()
        {
            return new Dictionary<Camera2DAttribute, string>()
            {
                [Camera2DAttribute.IPAdr] = "192.168.10.201",
                [Camera2DAttribute.CameraResolutionRoiTopLeftX] = "8",
                [Camera2DAttribute.CameraResolutionRoiTopLeftY] = "4",
                [Camera2DAttribute.CameraResolutionRoiWidth] = "2048",
                [Camera2DAttribute.CameraResolutionRoiHeight] = "2448",
                [Camera2DAttribute.Exposure] = "20000",
                [Camera2DAttribute.MaxFPS] = "30",
                [Camera2DAttribute.Gain] = "1",
                [Camera2DAttribute.FPS] = "30"
            };
        }

        private static Dictionary<Camera2DAttribute, string> GetIDSSettings()
        {
            return new Dictionary<Camera2DAttribute, string>()
            { 
                [Camera2DAttribute.IPAdr] = "192.168.100.3",
                [Camera2DAttribute.CameraResolutionRoiTopLeftX] = "0",
                [Camera2DAttribute.CameraResolutionRoiTopLeftY] = "0",
                [Camera2DAttribute.CameraResolutionRoiWidth] = "2560",
                [Camera2DAttribute.CameraResolutionRoiHeight] = "1920",
                [Camera2DAttribute.Exposure] = "20000",
                [Camera2DAttribute.Gain] = "1",
                [Camera2DAttribute.MaxFPS] = "15",
            };
        }

        public static Dictionary<RobotMaker, Func<Dictionary<RobotAttribute, string>>> Robots = new Dictionary<RobotMaker, Func<Dictionary<RobotAttribute, string>>>()
        {
            [RobotMaker.YASKAWA] = GetYaskawaSettings,
            [RobotMaker.KAWASAKI] = GetKawasakiSettings,
            [RobotMaker.FANUC] = GetFanucSettings,
            [RobotMaker.HYUNDAI] = GetHyundaiSettings
        };

        public static Dictionary<RobotAttribute, string> GetYaskawaSettings()
        {
            return new Dictionary<RobotAttribute, string>()
            {
                [RobotAttribute.Maker] = RobotMaker.YASKAWA.ToString(),
                [RobotAttribute.Ip] = "",
                [RobotAttribute.Port] = "",
                [RobotAttribute.YrcCoordinateSystem] = YrcCoordinateSystem.BASE.ToString(),
                [RobotAttribute.VehicleInstallVars] = "",
                [RobotAttribute.GapScanPoseVars] = "",
                [RobotAttribute.VehicleShiftVars] = ""
            };
        }

        public static Dictionary<RobotAttribute, string> GetKawasakiSettings()
        {
            return new Dictionary<RobotAttribute, string>()
            {
                [RobotAttribute.Maker] = RobotMaker.KAWASAKI.ToString(),
                [RobotAttribute.Ip] = "",
                [RobotAttribute.Port] = "",
                [RobotAttribute.WheelHubInstallVars] = "",
                [RobotAttribute.WheelHubShiftVars] = "",
                [RobotAttribute.MaxNumberOfTrials] = "",
                [RobotAttribute.HasR7] = "False"
            };
        }

        public static Dictionary<RobotAttribute, string> GetFanucSettings()
        {
            return new Dictionary<RobotAttribute, string>()
            {
                [RobotAttribute.Maker] = RobotMaker.FANUC.ToString(),
                [RobotAttribute.Ip] = "",
                [RobotAttribute.Port] = "",
                [RobotAttribute.ReadPRs] = "1,2,3",
                [RobotAttribute.WritePRs] = "11,12,13",
                [RobotAttribute.UserFrame] = FanucUserFrame.WORLD.ToString()
            };
        }

        public static Dictionary<RobotAttribute, string> GetHyundaiSettings()
        {
            return new Dictionary<RobotAttribute, string>()
            {
                [RobotAttribute.Maker] = RobotMaker.HYUNDAI.ToString(),
                [RobotAttribute.Ip] = "192.168.178.206",
                [RobotAttribute.ClientIp] = "192.168.178.102",
                [RobotAttribute.HrCoordinateSystem] = HrCoordinateSystem.BASE.ToString()
            };
        }
    }
    public class CarTypeAndName
    {
        public int CarType { get; private set; }
        public string CarName { get; private set; }

        public CarTypeAndName(int carType, string carName)
        {
            CarType = carType;
            CarName = carName;
        }
    }
}
