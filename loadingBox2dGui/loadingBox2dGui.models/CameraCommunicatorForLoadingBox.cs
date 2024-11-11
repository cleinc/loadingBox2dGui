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
    public abstract class CameraCommunicatorForLoadingBox : ICameraCommunicator, IDisposable
    {
        private bool disposedValue;
        public bool IsConnected { get; }
        public abstract bool Connect(Dictionary<InspectionLocation, string> locationToConfigDict);
        public abstract bool Disconnect();
        public abstract Task StartCamera(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);
        public abstract bool StopCamera();
        public abstract bool SaveImage(Bitmap bmp);
        public abstract Bitmap GetImage(string cameraName);
        public abstract Bitmap GetImage(InspectionLocation inspectionLocation);
        public abstract bool SetCameraSettings(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing){}

                try
                {
                    Disconnect();
                }
                catch (Exception) { }

                disposedValue = true;
            }
        }
        ~CameraCommunicatorForLoadingBox()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
