using Basler.Pylon;
using CoPick.Logging;
using CoPick.Setting;
using loadingBox2dGui.models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace loadingBox2dGui.PylonCameraCommunicator
{
    public class PylonCameraCommunicator : CameraCommunicatorForLoadingBox, IDisposable
    {
        private readonly static LogHelper Logger = LogHelper.Logger;
        private PixelDataConverter _converter;
        private readonly Dictionary<InspectionLocation, Camera> _cameraOnLocation;
        private readonly Dictionary<string, InspectionLocation> _ipToLocationDict;
        private readonly Dictionary<InspectionLocation, Bitmap> _bitmapsOnLocation;
        private readonly ConcurrentDictionary<InspectionLocation, CameraState> _cameraStateOnLocation;
        private bool _isConnected = false;
        private static readonly int reconnectTimeoutMs = 60000;
        public bool IsConnected => _isConnected;

        public PylonCameraCommunicator()
        {
            _cameraOnLocation = new Dictionary<InspectionLocation, Camera>();
            _ipToLocationDict = new Dictionary<string, InspectionLocation>();
            _cameraStateOnLocation = new ConcurrentDictionary<InspectionLocation, CameraState>();
            _bitmapsOnLocation = new Dictionary<InspectionLocation, Bitmap>();
            _converter = new PixelDataConverter();
        }

        public override bool Connect(ConcurrentDictionary<InspectionLocation, CameraParameter> locationToConfigDict)
        {
            if (locationToConfigDict == null || locationToConfigDict.Count == 0)
            {
                throw new ArgumentNullException();
            }

            if (_isConnected)
            {
                Logger.Info(GetCameraStatus());
                Logger.Info($"\nDisconnecting previously registered cameras..."); 
                Disconnect();
                Reset();
                _isConnected = false;
            }

            locationToConfigDict.Keys.ToList().ForEach( key => 
            {
                string camIp = locationToConfigDict[key].IpAddress;
                _cameraStateOnLocation[key] = CameraState.Undefined;

                ICameraInfo cameraInfo = CameraFinder.Enumerate().Find(info => info[CameraInfoKey.DeviceIpAddress] == camIp);
                if (cameraInfo != null)
                {
                    Camera camera = null;
                    try
                    {
                        if (_ipToLocationDict.ContainsKey(camIp))
                        {
                            Logger.Error($"Overlapping Cam IP {camIp}. Camera IP Address must be Unique for each Inspection Location");
                            return;
                        }
                        _bitmapsOnLocation[key] = null;
                        _ipToLocationDict[camIp] = key;

                        camera = new Camera(cameraInfo);
                        camera.ConnectionLost += async (sender, e) => 
                        await OnConnectionLostAsync(camera, key, cameraInfo[CameraInfoKey.DeviceIpAddress]);
                        bool openRet = OpenCamera(camera, key, cameraInfo[CameraInfoKey.DeviceIpAddress]);
                        if (openRet)
                        {
                            _cameraOnLocation[key] = camera;
                            _cameraStateOnLocation[key] = CameraState.Connected;
                        }
                        else
                        {
                            _cameraStateOnLocation[key] = CameraState.Undefined;
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.Error($"Failed while connecting to camera on IP : {cameraInfo[CameraInfoKey.DeviceIpAddress]}, Error: {ex}");
                    }
                }
                else
                {
                    Logger.Info($"Cam Not Found on IP {camIp}, Location : {key}");
                }
            });
            _isConnected = true;
            return true;
        }

        private static bool OpenCamera(Camera camera, InspectionLocation location, string ipAddress)
        {
            // Conditional Open?
            camera.Open();
            if (!camera.IsOpen)
            {
                Logger.Info($"Cam {location}, IP: {ipAddress} Failed To Open");
                return false;
            }
            camera.Parameters[PLTransportLayer.HeartbeatTimeout].SetValue(1000);
            #region Cam Param Set 
            Console.WriteLine("Camera Parameter Limits:");
            Console.WriteLine("========================");

            // Retrieve min, max, and increment for ROI X
            Console.WriteLine("ROI X:");
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.OffsetX].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.OffsetX].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.OffsetX].GetIncrement());

            // Retrieve min, max, and increment for ROI Y
            Console.WriteLine("ROI Y:");
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.OffsetY].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.OffsetY].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.OffsetY].GetIncrement());

            // Retrieve min, max, and increment for Width
            Console.WriteLine("Width:");
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.Width].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.Width].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.Width].GetIncrement());

            // Retrieve min, max, and increment for Height
            Console.WriteLine("Height:");
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.Height].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.Height].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.Height].GetIncrement());

            // Retrieve min, max, and increment for Gain
            Console.WriteLine("Gain:");
            if (camera.Parameters[PLCamera.GainRaw].IsReadable)
            {
                Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.GainRaw].GetMinimum());
                Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.GainRaw].GetMaximum());
                Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.GainRaw].GetIncrement());
            }
            else
            {
                Console.WriteLine("  Gain parameter is not available.");
            }

            // Retrieve min, max, and increment for Exposure
            Console.WriteLine("Exposure:");
            if (camera.Parameters[PLCamera.ExposureTimeAbs].IsReadable)
            {
                Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.ExposureTimeAbs].GetMinimum());
                Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.ExposureTimeAbs].GetMaximum());
                Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.ExposureTimeAbs].GetIncrement());
            }
            else
            {
                Console.WriteLine("  Exposure parameter is not available.");
            }
            #endregion
            return true;
        }

        public override bool SetCameraSettings(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict)
        {
            foreach (var kvp in camParamDict)
            {
                if (_cameraOnLocation.TryGetValue(kvp.Key, out Camera cam))
                {
                    var camParams = kvp.Value;
                    SetCameraSetting(camParams, cam, _cameraStateOnLocation[kvp.Key]);
                }
                else
                {
                    _cameraStateOnLocation[kvp.Key] = CameraState.Undefined;
                }
            }
            return true;
        }

        private bool SetCameraSetting(CameraParameter camParameter, Camera camera, CameraState state)
        {
            if (camera == null || state != CameraState.Connected)
            {
                return false;
            }
        
            // Offset X
            if (camera.Parameters[PLCamera.OffsetX].IsWritable)
            {
                camera.Parameters[PLCamera.OffsetX].SetValue(camParameter.RoiX);
                Logger.Info($"Offset X set to: {camParameter.RoiX}, {camera.Parameters[PLCamera.OffsetX].GetValue()}");
            }
            else
            {
                Logger.Info("Offset X parameter is not writable.");
            }
        
            // Offset Y
            if (camera.Parameters[PLCamera.OffsetY].IsWritable)
            {
                camera.Parameters[PLCamera.OffsetY].SetValue(camParameter.RoiY);
                Logger.Info($"Offset Y set to: {camParameter.RoiY}, {camera.Parameters[PLCamera.OffsetY].GetValue()}");
            }
            else
            {
                Logger.Info("Offset Y parameter is not writable.");
            }
        
            // Width
            if (camera.Parameters[PLCamera.Width].IsWritable)
            {
                camera.Parameters[PLCamera.Width].SetValue(camParameter.RoiWidth);
                Logger.Info($"Width set to: {camParameter.RoiWidth}, {camera.Parameters[PLCamera.Width].GetValue()}");
            }
            else
            {
                Logger.Info("Width parameter is not writable.");
            }
        
            // Height
            if (camera.Parameters[PLCamera.Height].IsWritable)
            {
                camera.Parameters[PLCamera.Height].SetValue(camParameter.RoiHeight);
                Logger.Info($"Height set to: {camParameter.RoiHeight}, {camera.Parameters[PLCamera.Height].GetValue()}");
            }
            else
            {
                Logger.Info("Height parameter is not writable.");
            }
        
            // Gain
            if (camera.Parameters[PLCamera.GainRaw].IsWritable)
            {
                camera.Parameters[PLCamera.GainRaw].SetValue(camParameter.Gain);
                Logger.Info($"Gain set to: {camParameter.Gain}, {camera.Parameters[PLCamera.GainRaw].GetValue()}");
                Logger.Info($"Increment: {camera.Parameters[PLCamera.GainRaw].GetIncrement()}");
            }
            else
            {
                Logger.Info("Gain parameter is not writable.");
            }
        
            // Exposure
            if (camera.Parameters[PLCamera.ExposureTimeAbs].IsWritable)
            {
                camera.Parameters[PLCamera.ExposureTimeAbs].SetValue(camParameter.ExposureTimeMicroSeconds);
                Logger.Info($"Exposure set to: {camParameter.ExposureTimeMicroSeconds}, {camera.Parameters[PLCamera.ExposureTimeAbs].GetValue()}");
            }
            else
            {
                Logger.Info("Exposure parameter is not writable.");
            }
        
            return true;
        }

        public override Task StartCamera(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict)
        {
            return Task.Run(() =>
            {
                SetCameraSettings(camParamDict);
                _cameraOnLocation.Keys.ToList().ForEach(location =>
                {
                    try
                    {
                        if (_cameraStateOnLocation[location] != CameraState.Grabbing)
                        {
                            _cameraOnLocation[location].StreamGrabber.Start(1);
                        }
                        else
                        {
                            Logger.Info($"Camera on {location} already grabbing images");
                            return;
                        }

                        _cameraStateOnLocation[location] = CameraState.Grabbing;
                        IGrabResult grabResult = _cameraOnLocation[location]?.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
                        if (grabResult.GrabSucceeded)
                        {
                            Bitmap bmp = ConvertGrabResultToBitmap(grabResult);
                            _bitmapsOnLocation[location] = bmp;
                            SaveImage(bmp);
                        }
                        _cameraOnLocation[location].StreamGrabber.Stop();
                        _cameraStateOnLocation[location] = CameraState.Connected;
                    }
                    catch (Exception ex)
                    {
                        foreach (var kvp in _cameraStateOnLocation)
                        {
                            if (kvp.Value != CameraState.Connected)
                            {
                                _cameraStateOnLocation[kvp.Key] = CameraState.Undefined;
                            }
                        }
                    }
                    
                });
            });
        }

        public override Bitmap GetImage(string cameraName)
        {
            if (_ipToLocationDict.TryGetValue(cameraName, out var location))
            {
                return GetImage(location);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override Bitmap GetImage(InspectionLocation location)
        {
            if (_bitmapsOnLocation.TryGetValue(location, out var bitmap))
            {
                return bitmap;
            }
            else
            {
                return null;
            }
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
            string parentDirectory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(parentDirectory))
            {
                Directory.CreateDirectory(parentDirectory);
            }
            bmp.Save(filePath, ImageFormat.Tiff);
            return true;
        }

        public override bool StopCamera()
        {
            _cameraOnLocation.Keys.ToList().ForEach(location =>
            {
                if (_cameraOnLocation.TryGetValue(location, out Camera camera))
                {
                    if (camera.StreamGrabber.IsGrabbing) 
                    {
                        camera.StreamGrabber.Stop();
                    }
                    _cameraStateOnLocation[location] = CameraState.Connected;
                }
                else
                {
                    _cameraStateOnLocation[location] = CameraState.Undefined;
                }
            });
            return true;
        }

        public override bool Disconnect()
        {
            _cameraOnLocation.ToList().ForEach(kvp =>
            {
                ResetDevice(kvp.Value, kvp.Key);
            });
            return true;
        }

        #region Utils
        private void ResetDevice(Camera camera, InspectionLocation location)
        {
            _cameraStateOnLocation[location] = CameraState.Undefined;
            if (camera == null)
            {
                return;
            }
            if (camera.IsOpen)
            {
                camera.Close();
            }
            camera?.Dispose();
        }
        private void Reset()
        {
            _ipToLocationDict.Clear();
            _cameraOnLocation.Clear();
            _cameraStateOnLocation.Clear();
            _bitmapsOnLocation.Clear();
            _isConnected = false;
        }
        private string GetCameraStatus()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Device Previously Connected");
            foreach (var kvp in _cameraStateOnLocation)
            {
                builder.Append($" Camera on {kvp.Key}, State: {kvp.Value}.");
            }
            return builder.ToString();
        }
        #endregion
        private async Task OnConnectionLostAsync(Camera camera, InspectionLocation inspectionLocation, string ipAddress)
        {
            Console.WriteLine($"Connection to Camera {inspectionLocation}, IP : {ipAddress} lost. Attempting to reconnect...");
            _cameraStateOnLocation[inspectionLocation] = CameraState.Disconnected;
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (stopwatch.ElapsedMilliseconds < reconnectTimeoutMs)
            {
                try
                {
                    _cameraStateOnLocation[inspectionLocation] = CameraState.Reconnecting;
                    if (camera.IsOpen)
                    {
                        camera.Close();
                    }

                    bool openRet = OpenCamera(camera, inspectionLocation, ipAddress);
                    if (openRet)
                    {
                        _cameraStateOnLocation[inspectionLocation] = CameraState.Connected;
                        Logger.Info($"Camera {inspectionLocation}, IP : {ipAddress} reconnected successfully.");
                        return;
                    }
                    await Task.Delay(1000); // Wait before retrying
                }
                catch (Exception ex)
                {
                    _cameraStateOnLocation[inspectionLocation] = CameraState.Reconnecting;
                    Logger.Info($"Reconnection attempt failed for Camera {inspectionLocation}, IP : {ipAddress}: {ex.Message}");
                }
            }
            _cameraStateOnLocation[inspectionLocation] = CameraState.Disconnected;
            Logger.Error($"Failed to reconnect to Camera {inspectionLocation}, IP : {ipAddress} within the timeout period.");
        }
    }
}
