using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public enum PlcSignalForLoadingBox 
    {
        VISION_START = 0x0010_0000,
        VISION_RESET = 0x0020_0000,
        VISION_UPDATE = 0x0040_0000,
        VISION_END = 0x0080_0000,

        VISION_PASS = 0x0100_0000,
        P1 = 0x0200_0000,
        P2 = 0x0400_0000,

        CAR_TYPE = 0x0001_0000,
        CAR_SEQ = 0x0002_0000,
        BODY_NO = 0x0004_0000,

        P1_COMPLETED = 0x0000_0010,
        P2_COMPLETED = 0x0000_0020,

        VISION_OK = 0x0000_0001,
        VISION_NG = 0x0000_0002,
        VISION_ERROR = 0x0000_0004,

        SHIFT_TX = 0x0000_0100,
        SHIFT_TY = 0x0000_0200,
        SHIFT_TZ = 0x0000_0400,
        SHIFT_RX = 0x0000_0800,

        SHIFT_RY = 0x0000_1000,
        SHIFT_RZ = 0x0000_2000,
        FRONT = 0x0000_4000,
        REAR = 0x0000_8000,

        VALUE = 0x4000_0000
    }
}
