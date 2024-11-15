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
        protected bool _disposed;
        public bool IsConnected { get; }
        public abstract bool Connect(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);
        public abstract bool Disconnect();
        public abstract Task StartCamera(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);
        public abstract bool StopCamera();
        public abstract bool SaveImage(Bitmap bmp);
        public abstract Bitmap GetImage(string cameraName);
        public abstract Bitmap GetImage(InspectionLocation inspectionLocation);
        public abstract bool ApplyCameraSettings(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict);

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing){}

                try
                {
                    Disconnect();
                }
                catch (Exception) { }

                _disposed = true;
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
