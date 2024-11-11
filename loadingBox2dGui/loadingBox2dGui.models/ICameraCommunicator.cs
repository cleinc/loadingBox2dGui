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

        bool Connect(Dictionary<InspectionLocation, string> locationToConfigDict);
        bool Disconnect();
        Task StartCamera(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);
        bool StopCamera();
        bool SaveImage(Bitmap bmp);
        Bitmap GetImage(string cameraName);
        Bitmap GetImage(InspectionLocation inspectionLocation);
        bool SetCameraSettings(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);
    }

    

    public enum CameraState
    {
        Undefined,
        Disconnected,
        Reconnecting, 
        Connected, 
        Grabbing,
    }
}
