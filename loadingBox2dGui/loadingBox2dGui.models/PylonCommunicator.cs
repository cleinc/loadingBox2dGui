using Basler.Pylon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public class PylonCommunicator
    {
        private Camera _camera1;
        private Camera _camera2;
        private PixelDataConverter _converter;
        private string _camera1Ip = "192.168.10.201";
        private string _camera2Ip = "192.168.10.202";

        public PylonCommunicator()
        {
            ICameraInfo cameraInfo1 = CameraFinder.Enumerate().Find(info => info[CameraInfoKey.DeviceIpAddress] == _camera1Ip);
            ICameraInfo cameraInfo2 = CameraFinder.Enumerate().Find(info => info[CameraInfoKey.DeviceIpAddress] == _camera2Ip);

            _camera1 = new Camera(cameraInfo1);
            _camera2 = new Camera(cameraInfo2);

            _converter = new PixelDataConverter();
        }
        public bool ConnectCamera()
        {
            _camera1.Open();
            _camera2.Open();
            return true;
        }
        public bool SetCameraSettings(Camera camera)
        {
            return true;
        }
        public bool StartCamera()
        {
            _camera1.StreamGrabber.Start();
            IGrabResult grabResult1 = _camera1.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
            if (grabResult1.GrabSucceeded)
            {
                Bitmap bmp = ConvertGrabResultToBitmap(grabResult1);
                SaveImage(bmp);
            }

            _camera2.StreamGrabber.Start();
            IGrabResult grabResult2 = _camera1.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
            if (grabResult2.GrabSucceeded)
            {
                Bitmap bmp = ConvertGrabResultToBitmap(grabResult2);
                SaveImage(bmp);
            }
            return true;
        }
        private Bitmap ConvertGrabResultToBitmap(IGrabResult grabResult)
        {
            Bitmap bmp = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppArgb);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptrBmp = bmpData.Scan0;
            _converter.OutputPixelFormat = PixelType.BGRA8packed;
            _converter.Convert(ptrBmp, bmpData.Stride * bmp.Height, grabResult);
            bmp.UnlockBits(bmpData);
            return bmp;
        }
        public bool SaveImage(Bitmap bmp)
        {
            string filePath = $"{DateTime.Now.ToString("yyMMdd_hhmmssfff")}_img.png";
            bmp.Save(filePath, ImageFormat.Png);
            return true;
        }
        public bool StopCamera()
        {
            _camera1.StreamGrabber.Stop();
            _camera2.StreamGrabber.Stop();
            return true;
        }
        public bool DisConnectCamera()
        {
            _camera1.Close();
            _camera2.Close();
            return true;
        }
    }
}
