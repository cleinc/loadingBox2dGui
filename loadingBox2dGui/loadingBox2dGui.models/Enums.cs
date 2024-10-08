using CoPick.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public enum PlcSignalForLoadingBox 
    {
        GLASS = 0x1000_0000,
        BODY = 0x0100_0000,
        VISION_LIVE_BIT = 0x0010_0000,

        VALUE = 0x4000_0000,

        VISION_UPDATE = 0x4000,
        CAR_TYPE = 0x5000,
        CAR_SEQ1 = 0x6000,
        CAR_SEQ2 = 0x7000,
        CAR_SEQ = 0x8000,
        BODY_NO1 = 0x9000,
        BODY_NO2 = 0xA000,
        BODY_NO3 = 0xB000,
        BODY_NO4 = 0xC000,

        VISION_START = 0x100,
        VISION_RESET = 0x200,
        VISION_END = 0x300,
        VISION_READY = 0x500,
        VISION_PASS = 0x600,

        P1 = 0x10,
        P2 = 0x20,

        VISION_OK = 0x0001,
        VISION_NG = 0x0002,
        SCAN_POSE_SENT = 0x0004,

        P1_COMPLETED = 0x0400,
        P2_COMPLETED = 0x0800,
        PLC_PASS = 0x3000,
        CLEAR = 0,
            
        SHIFT_X = 0x0001_0000,
        SHIFT_Y = 0x0002_0000,
        SHIFT_Z = 0x0003_0000,
        SHIFT_RX = 0x0004_0000,
        SHIFT_RY = 0x0005_0000,
        SHIFT_RZ = 0x0006_0000,

        GAP_1 = 0x0007_0000,
        GAP_2 = 0x0008_0000,
        GAP_3 = 0x0009_0000,
        GAP_4 = 0x000A_0000,
        VISION_ERROR = 0x4000_4001,
    }

    public enum LightAttribute
    {
        [ReadOnly(true)]
        [LocalizedCategory("CategoryPlc")]
        [LocalizedDescription("DescPlcModel")]
        Model,
        [LocalizedCategory("CategoryPlc")]
        [LocalizedDescription("DescPlcIp")]
        [ValidatorType(ValidatorType.Ip, new object[] { })]
        IP,
    }
}
