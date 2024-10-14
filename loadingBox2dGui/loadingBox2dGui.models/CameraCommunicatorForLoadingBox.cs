using System;
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
        public abstract bool Connect();
        public abstract bool DisConnect();
        public abstract Task<(Bitmap, Bitmap)> StartCamera();
        public abstract bool StopCamera();
        public abstract bool SaveImage(Bitmap bmp);

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing){}
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
