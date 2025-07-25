using CoPick.Setting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public interface ICameraCommunicator : IDisposable
    {
        bool IsConnected { get; }
        bool Connect(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);
        bool Disconnect();
        Task StartCamera(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict, int shotAttempt);
        bool StopCamera();
        bool SaveImage(InspectionLocation loc, Bitmap bmp);
        Bitmap GetImage(string cameraName);
        Bitmap GetImage(InspectionLocation inspectionLocation);
        bool ApplyCameraSettings(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);
        ImageStruct[] GetImageStructArray(int carType);
        bool ClearBmpData();
    }
}
