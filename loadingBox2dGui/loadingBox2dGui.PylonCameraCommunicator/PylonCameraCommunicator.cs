using Basler.Pylon;
using CoPick.Logging;
using CoPick.Setting;
using loadingBox2dGui.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.PylonCameraCommunicator
{
    public class PylonCameraCommunicator : CameraCommunicatorForLoadingBox, IDisposable
    {
        private static readonly LogHelper Logger = LogHelper.Logger;

        private PixelDataConverter _converter;
        Dictionary<string, Dictionary<Camera2DAttribute, string>> _camConfigs;
        Dictionary<string, Camera> _cameras;
        Dictionary<string, Bitmap> _results;
        private bool _isConnected = false;
        public bool IsConnected
        {
            get => _isConnected;
        }

        public PylonCameraCommunicator(Dictionary<string, Dictionary<Camera2DAttribute, string>> configs)
        {
            _camConfigs = configs;
            _cameras = new Dictionary<string, Camera>();
            _results = new Dictionary<string, Bitmap>();
            _converter = new PixelDataConverter();
        }

        public override bool SetCameraSettings()
        {
            return true;
        }

        public override bool Connect()
        {
            _cameras.Clear();

            try
            {
                if (_camConfigs != null && _camConfigs.Count != 0)
                {
                    _camConfigs.Keys.ToList().ForEach(key =>
                    {
                        ICameraInfo cameraInfo = CameraFinder.Enumerate().Find(info => info[CameraInfoKey.DeviceIpAddress] == _camConfigs[key][Camera2DAttribute.IPAdr]);
                        _cameras[key] = new Camera(cameraInfo);
                        _cameras[key].Open();
                    });
                    Logger.Info("Succeed Setting Camera Information.");
                }
                else
                {
                    Logger.Info("Fail Setting Camera Information..");
                }

                _isConnected = _cameras.Keys.ToList().All(key => _cameras[key].IsConnected);
                return _isConnected;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.ToString());
                return false;
            }
        }


        public override Task StartCamera()
        {
            return Task.Run(() =>
            {
                _camConfigs.Keys.ToList().ForEach(camera =>
                {
                    _cameras[camera].StreamGrabber.Start(1);
                    IGrabResult grabResult1 = _cameras[camera].StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
                    if (grabResult1.GrabSucceeded)
                    {
                        Bitmap bmp = ConvertGrabResultToBitmap(grabResult1);
                        _results[camera] = bmp;
                        SaveImage(bmp);
                    }
                    _cameras[camera].StreamGrabber.Stop();
                });
            });
        }

        public override Bitmap GetImage(string cameraName)
        {
            return _results[cameraName];
        }

        private Bitmap ConvertGrabResultToBitmap(IGrabResult grabResult)
        {
            Bitmap bmp = new Bitmap(grabResult.Width, grabResult.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);
            IntPtr ptrBmp = bmpData.Scan0;
            _converter.OutputPixelFormat = PixelType.BGRA8packed;
            _converter.Convert(ptrBmp, bmpData.Stride * bmp.Height, grabResult);
            bmp.UnlockBits(bmpData);
            return bmp;
        }
        public override bool SaveImage(Bitmap bmp)
        {
            string filePath = $"./images/{DateTime.Now.ToString("yyMMdd_hhmmssfff")}.png";
            bmp.Save(filePath, ImageFormat.Png);
            return true;
        }
        public override bool StopCamera()
        {
            _cameras.Keys.ToList().ForEach(camera =>
            {
                _cameras[camera].StreamGrabber.Stop();
            });
            return true;
        }
        public override bool DisConnect()
        {
            _cameras.Keys.ToList().ForEach(camera =>
            {
                _cameras[camera].Close();
            });
            return true;
        }
    }
}
