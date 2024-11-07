using CoPick.Logging;
using CoPick.Plc;
using CoPick.Setting;
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
        public Dictionary<string, Dictionary<Camera2DAttribute, string>> CameraConfigs { get; set; }
        public Dictionary<int, CargoBox2DConfig> ConfigDict { get; set; } = new Dictionary<int, CargoBox2DConfig>();
        public string Plc { get; set; }
        public string Light { get; set; }
        public string Camera { get; set; }
        public int RecentlyUsedCar { get; set; } = 0;
        public string Language { get; set; } = "ko-KR";

        public LogLevel MinimumFileLogLevel { get; set; } = LogLevel.Debug;
        public LogLevel MinimumUiLogLevel { get; set; } = LogLevel.Info;
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

        public Config()
        {
            Plc = "Tk1MelsecCommunicator";
            Camera = "PylonCameraCommunicator";
            Light = "ModbusLightCommunicator";

            PlcConfigs = new Dictionary<string, Dictionary<PlcAttribute, string>>()
            {
                ["Tk1MelsecCommunicator"] = DefaultSettingLoader.Plcs[PlcModel.MELSEC]()
            };
            CameraConfigs = new Dictionary<string, Dictionary<Camera2DAttribute, string>> ()
            {
                ["Camera1"] = DefaultSettingLoader.Cameras[Camera2DMaker.BASLER](),
                ["Camera2"] = DefaultSettingLoader.Cameras[Camera2DMaker.BASLER]()
            };
            LightConfigs = new Dictionary<string, Dictionary<LightAttribute, string>>()
            {
                ["ModbusLightCommunicator"] = DefaultSettingLoader.Lights[LightMaker.MODBUS]()
            };
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
                string carString = Encoding.UTF8.GetString(Convert.FromBase64String(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "msg_format.dat"))));
                var carList = carString.Replace("C", "").Replace("L", "").Split('E').Select(c => Convert.ToInt32(c)).ToArray();
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
    }

    [Serializable]
    public class CargoBox2DConfig : ICustomTypeDescriptor
    {
        [NonSerialized]
        private PropertyDescriptorCollection _pdColl;
        [NonSerialized]
        private Dictionary<string, int> _registeredCameraDevices = new Dictionary<string, int>();
        [LocalizedCategory("CategoryGeneral", 1, 3)]
        [LocalizedDescription("DescCarName")]
        public string CarName { get; set; } = "unknown";

        #region LH Inspection Settings
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        [LocalizedDescription("DescSelectedDevice")]
        public string LHCamera { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        [LocalizedDescription("DescModelPath")]
        public string LHModelPath { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        [LocalizedDescription("DescExposureTime")]
        public int LHExposureTime { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        [LocalizedDescription("DescGain")]
        public int LHGain { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        [LocalizedDescription("DescMaxFPS")]
        public int LHMaxFPS { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        [LocalizedDescription("DescCameraMaker")]
        public Camera2DMaker LHCameraMaker { get; set; } = Camera2DMaker.BASLER;
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        public int LHCameraRoiX { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        public int LHCameraRoiY { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        public int LHCameraRoiWidth { get; set; }
        [LocalizedCategory("CategoryInspectLH", 2, 3)]
        public int LHCameraRoiHeight { get; set; }
        #endregion

        #region RH Inspection Settings
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public string RHCamera { get; set; }
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public string RHModelPath { get; set; }
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public int RHExposureTime { get; set; }
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public int RHGain { get; set; }
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public int RHMaxFPS { get; set; }
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public Camera2DMaker RHCameraMaker { get; set; } = Camera2DMaker.BASLER;
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public int RHCameraRoiX { get; set; } = 0;
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public int RHCameraRoiY { get; set; } = 0;
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public int RHCameraRoiWidth { get; set; } = 2560;
        [LocalizedCategory("CategoryInspectRH", 3, 3)]
        public int RHCameraRoiHeight { get; set; } = 1920;
        #endregion


        public CargoBox2DConfig()
        {
            UpdatePropertyDescriptors();
        }

        public void UpdatePropertyDescriptors()
        {
            PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties(this);
            PropertyDescriptor[] propertyDescriptorArray = typeof(CargoBox2DConfig).GetProperties()
                .Select(m => new CargoBox2DConfigPropertyDescriptor(pdc[m.Name], m.GetCustomAttributes(false).Cast<Attribute>().ToArray()))
                .ToArray();
            _pdColl = new PropertyDescriptorCollection(propertyDescriptorArray);
        }

        public AttributeCollection GetAttributes() => TypeDescriptor.GetAttributes(this, true);
        public string GetClassName() => TypeDescriptor.GetClassName(this, true);
        public string GetComponentName() => TypeDescriptor.GetComponentName(this, true);
        public TypeConverter GetConverter() => TypeDescriptor.GetConverter(this, true);
        public EventDescriptor GetDefaultEvent() => TypeDescriptor.GetDefaultEvent(this, true);
        public PropertyDescriptor GetDefaultProperty() => TypeDescriptor.GetDefaultProperty(this, true);
        public object GetEditor(Type editorBaseType) => TypeDescriptor.GetEditor(this, editorBaseType, true);
        public EventDescriptorCollection GetEvents() => TypeDescriptor.GetEvents(this, true);
        public EventDescriptorCollection GetEvents(Attribute[] attributes) => TypeDescriptor.GetEvents(this, attributes, true);
        public PropertyDescriptorCollection GetProperties() => _pdColl;
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes) => _pdColl;
        public object GetPropertyOwner(PropertyDescriptor pd) => this;
    }

    public class CargoBox2DConfigPropertyDescriptor : PropertyDescriptor
    {
        private PropertyDescriptor _originalPd;

        public CargoBox2DConfigPropertyDescriptor(PropertyDescriptor pd, Attribute[] attrs)
            : base(pd, attrs)
        {
            _originalPd = pd;
        }

        public override Type ComponentType
        {
            get => _originalPd.ComponentType;
        }
        public override bool IsReadOnly
        {
            get => _originalPd.IsReadOnly;
        }

        public override Type PropertyType
        {
            get => _originalPd.PropertyType;
        }

        public override bool CanResetValue(object component) => _originalPd.CanResetValue(component);
        public override object GetValue(object component) => _originalPd.GetValue(component);
        public override void ResetValue(object component) => _originalPd.ResetValue(component);
        public override void SetValue(object component, object value) => _originalPd.SetValue(component, value);
        public override bool ShouldSerializeValue(object component) => _originalPd.ShouldSerializeValue(component);
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

        public static Dictionary<Camera2DMaker, Func<Dictionary<Camera2DAttribute, string>>> Cameras = new Dictionary<Camera2DMaker, Func<Dictionary<Camera2DAttribute, string>>>()
        {
            [Camera2DMaker.BASLER] = GetBaslerSettings,
        };

        private static Dictionary<Camera2DAttribute, string> GetBaslerSettings()
        {
            return new Dictionary<Camera2DAttribute, string>()
            {
                [Camera2DAttribute.IPAdr] = "000.000.000.000",
                [Camera2DAttribute.CameraResolutionRoiTopLeftX] = "0",
                [Camera2DAttribute.CameraResolutionRoiTopLeftY] = "0",
                [Camera2DAttribute.CameraResolutionRoiWidth] = "658",
                [Camera2DAttribute.CameraResolutionRoiHeight] = "492",
                [Camera2DAttribute.Exposure] = "3000",
                [Camera2DAttribute.MaxFPS] = "30",
                [Camera2DAttribute.FPS] = "30"
            };
        }
    }
}
