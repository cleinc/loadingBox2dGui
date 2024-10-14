using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public interface ICameraCommunicator : IDisposable
    {
        bool Connect();
        bool DisConnect();
        Task<(Bitmap, Bitmap)> StartCamera();
        bool StopCamera();
        bool SaveImage(Bitmap bmp);
    }
}
