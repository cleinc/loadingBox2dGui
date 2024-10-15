using CoPick.Plc;
using CoPick.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    [Serializable]
    public class Config
    {
        public Dictionary<string, Dictionary<PlcAttribute, string>> PlcConfig { get; set; }
        public Dictionary<string, Dictionary<ModbusAttribute, string>> LightConfig { get; set;}
        public Dictionary<string, Dictionary<Camera2DAttribute, string>> CameraConfigs { get; set; }

        public string Plc { get; set; }
        public string Light { get; set; }
        public string Camera { get; set; }
        public int RecentlyUsedCar { get; set; } = 0;
        public string Language { get; set; } = "ko-KR";

        public Config()
        {
            Plc = "Tk1MelsecCommunicator";
            Camera = "PylonCameraCommunicator";
            Light = "ModbusLightCommunicator";

            PlcConfig = new Dictionary<string, Dictionary<PlcAttribute, string>>()
            {
                ["Tk1MelsecCommunicator"] = DefaultSettingLoader.Plcs[PlcModel.MELSEC]()
            };
            CameraConfigs = new Dictionary<string, Dictionary<Camera2DAttribute, string>> ()
            {
                ["Camera1"] = DefaultSettingLoader.Cameras[Camera2DMaker.BASLER](),
                ["Camera2"] = DefaultSettingLoader.Cameras[Camera2DMaker.BASLER]()
            };
            LightConfig = new Dictionary<string, Dictionary<ModbusAttribute, string>>()
            {
                ["ModbusLightCommunicator"] = DefaultSettingLoader.Lights[LightMaker.NOATHCH]()
            };
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

        public static Dictionary<LightMaker, Func<Dictionary<ModbusAttribute, string>>> Lights = new Dictionary<LightMaker, Func<Dictionary<ModbusAttribute, string>>>()
        {
            [LightMaker.NOATHCH] = GetNoatechSettings,
        };

        public static Dictionary<ModbusAttribute, string> GetNoatechSettings()
        {
            return new Dictionary<ModbusAttribute, string>()
            {
                [ModbusAttribute.IpAddr] = "192.168.2.3",
                [ModbusAttribute.Port] = "502",
                [ModbusAttribute.Model] = "Modbus",
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
                [Camera2DAttribute.ImageFolderPath] = "",
                [Camera2DAttribute.FPS] = "30"
            };
        }
    }
}
