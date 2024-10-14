using Basler.Pylon;
using CoPick.Setting;
using loadingBox2dGui.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.PylonCameraCommunicator
{
    public class PylonCameraCommunicator : CameraCommunicatorForLoadingBox, IDisposable
    {
        private Camera _camera1;
        private Camera _camera2;
        private PixelDataConverter _converter;
        private string _cameraIp1;
        private string _cameraIp2;

        public PylonCameraCommunicator(Dictionary<Camera2DAttribute, string> config)
        {
            _converter = new PixelDataConverter();
        }
        public override bool Connect()
        {
            try
            {

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //ICameraInfo cameraInfo1 = CameraFinder.Enumerate().Find(info => info[CameraInfoKey.DeviceIpAddress] == _cameraIp1);
            //ICameraInfo cameraInfo2 = CameraFinder.Enumerate().Find(info => info[CameraInfoKey.DeviceIpAddress] == _cameraIp2);

            _camera1 = new Camera();
            _camera1.Open();
            //_camera2.Open();
            return true;
        }

        public bool SetCameraSettings(Camera camera)
        {
            return true;
        }
        public override Task<(Bitmap, Bitmap)> StartCamera()
        {
            Bitmap bmp1 = null;
            Bitmap bmp2 = null;
            return Task.Run(() =>
            {
                _camera1.StreamGrabber.Start(1);
                IGrabResult grabResult1 = _camera1.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
                if (grabResult1.GrabSucceeded)
                {
                    bmp1 = ConvertGrabResultToBitmap(grabResult1);
                    SaveImage(bmp1);
                }
                _camera1.StreamGrabber.Stop();
                return (bmp1, bmp1);
            });
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
        public override bool SaveImage(Bitmap bmp)
        {
            string filePath = $"{DateTime.Now.ToString("yyMMdd_hhmmssfff")}.png";
            bmp.Save(filePath, ImageFormat.Png);
            return true;
        }
        public override bool StopCamera()
        {
            _camera1.StreamGrabber.Stop();
            //_camera2.StreamGrabber.Stop();
            return true;
        }
        public override bool DisConnect()
        {
            _camera1.Close();
            _camera2.Close();
            return true;
        }
    }
}
