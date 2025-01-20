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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace loadingBox2dGui.PylonCameraCommunicator
{
    public class PylonCameraCommunicator : CameraCommunicatorForLoadingBox, IDisposable, IImageProvider<InspectionLocation>
    {
        private readonly static LogHelper Logger = LogHelper.Logger;
        private PixelDataConverter _converter;
        private Timer _updateDeviceTimer;
        private SemaphoreSlim _sem = new SemaphoreSlim(1, 1);
        private Dictionary<string, InspectionLocation> _ipToLoc;
        private Dictionary<InspectionLocation, Bitmap> _locToBmp;
        private Dictionary<Bitmap, BitmapData> _bmpToBmpData;
        private ConcurrentDictionary<InspectionLocation, Camera> _locToCamera;
        private bool _isConnected = false;
        private static readonly int reconnectTimeoutMs = 15000;
        public override bool IsConnected => _isConnected;

        public PylonCameraCommunicator()
        {
            _converter = new PixelDataConverter();
            _updateDeviceTimer = new Timer(UpdateDevices);
        }

        public override bool Connect(ConcurrentDictionary<InspectionLocation, CameraParameter> locationToCamParameter)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(PylonCameraCommunicator));
            }

            if (_isConnected)
            {
                Logger.Info($"PylonCommunicator Already Connected");
                return true;
            }

            _sem.Wait();
            Logger.Info($"Connecting PylonCommunicator");
            try
            {
                _ipToLoc = new Dictionary<string, InspectionLocation>();
                _locToBmp = new Dictionary<InspectionLocation, Bitmap>();
                _bmpToBmpData = new Dictionary<Bitmap, BitmapData>();
                locationToCamParameter.Keys.ToList().ForEach( key => 
                {
                    string camIp = locationToCamParameter[key].IpAddress;
                    _locToCamera = new ConcurrentDictionary<InspectionLocation, Camera>();
                    if (_ipToLoc.ContainsKey(camIp))
                    {
                        Logger.Error($"Overlapping Cam IP {camIp}. Camera IP Address must be Unique for each Inspection Location");
                        return;
                    }
                    else
                    {
                        _ipToLoc.Add(camIp, key);
                    }
                });
                Logger.Info($"Starting Device Updater at interval {1000}");
                _updateDeviceTimer.Change(0, 1000);
                _isConnected = true;
            }
            finally
            {
                _sem.Release();
            }
            return true;
        }

        private void UpdateDevices(object state)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(PylonCameraCommunicator));
            }

            if (!_isConnected || _ipToLoc is null || _locToCamera is null)
            {
                return;
            }
            
            if (!_sem.Wait(100))
            {
                return;
            }

            try
            {
                if(_ipToLoc.Count == _locToCamera.Count)
                {
                    return;
                }
                List<ICameraInfo> camDevices = CameraFinder.Enumerate();
                foreach (var camDevice in camDevices)
                {
                    string ipAddress = camDevice[CameraInfoKey.DeviceIpAddress];
                    if (!_ipToLoc.TryGetValue(ipAddress, out InspectionLocation location))
                    {
                        return;
                    }
                    
                    if(_locToCamera.TryGetValue(location, out var _))
                    {
                        return;
                    }

                    Camera camera = new Camera(camDevice);
                    camera.ConnectionLost += (sender, e) => OnConnectionLostAsync(camera, location, ipAddress);
                    bool ret = OpenCamera(camera, location, ipAddress, 5000);
                    if (ret)
                    {
                        Logger.Info($"Camera on {location}, IP : {ipAddress} Added");
                        _locToCamera[location] = camera;
                    }
                    else
                    {
                        camera.ConnectionLost -= (sender, e) => OnConnectionLostAsync(camera, location, ipAddress);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Debug($"Error while Updating Devices, Error : {ex}");
            }
            finally
            {
                _sem.Release();
            }
        }

        private static bool OpenCamera(Camera camera, InspectionLocation location, string ipAddress, int timeOut = 750)
        {
            try
            {
                bool ret = camera.Open(timeOut, TimeoutHandling.ThrowException);
                if (!ret)
                {
                    Logger.Info($"Opening Cam Failed: Location: {location}, IP: {ipAddress}");
                    return false;
                }
                camera.Parameters[PLTransportLayer.HeartbeatTimeout].SetValue(1000);
            }
            catch (Exception ex)
            {
                Logger.Info($"Opening Cam Failed with Exception: Location {location}, IP: {ipAddress} Error: {ex}");
            }
            // Conditional Open?
            #region Read Current Camera Parameters
            Console.WriteLine("Camera Parameter Limits:");
            Console.WriteLine("========================");
            if (camera.Parameters[PLStream.EnableResend].IsWritable)
            {
                camera.Parameters[PLStream.EnableResend].SetValue(true);
            }
            else
            {
                Console.WriteLine($"Enable Resend is not writable");
            }
            // Retrieve min, max, and increment for ROI X
            Console.WriteLine("ROI X:");
            Console.WriteLine("  Value       : {0}", camera.Parameters[PLCamera.OffsetX].GetValue());
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.OffsetX].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.OffsetX].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.OffsetX].GetIncrement());

            // Retrieve min, max, and increment for ROI Y
            Console.WriteLine("ROI Y:");
            Console.WriteLine("  Value       : {0}", camera.Parameters[PLCamera.OffsetY].GetValue());
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.OffsetY].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.OffsetY].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.OffsetY].GetIncrement());

            // Retrieve min, max, and increment for Width
            Console.WriteLine("Width:");
            Console.WriteLine("  Value       : {0}", camera.Parameters[PLCamera.Width].GetValue());
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.Width].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.Width].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.Width].GetIncrement());

            // Retrieve min, max, and increment for Height
            Console.WriteLine("Height:");
            Console.WriteLine("  Value       : {0}", camera.Parameters[PLCamera.Height].GetValue());
            Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.Height].GetMinimum());
            Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.Height].GetMaximum());
            Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.Height].GetIncrement());

            // Retrieve min, max, and increment for Gain
            Console.WriteLine("Gain:");
            if (camera.Parameters[PLCamera.GainRaw].IsReadable)
            {
                Console.WriteLine("  Value       : {0}", camera.Parameters[PLCamera.GainRaw].GetValue());
                Console.WriteLine("  Min       : {0}", camera.Parameters[PLCamera.GainRaw].GetMinimum());
                Console.WriteLine("  Max       : {0}", camera.Parameters[PLCamera.GainRaw].GetMaximum());
                Console.WriteLine("  Increment : {0}", camera.Parameters[PLCamera.GainRaw].GetIncrement());
            }
            else
            {
                Console.WriteLine("  Gain parameter is not available.");
            }
            #endregion
            return true;
        }

        public override bool ApplyCameraSettings(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict)
        {
            foreach (var kvp in camParamDict)
            {
                if (_locToCamera.TryGetValue(kvp.Key, out Camera cam))
                {
                    var camParams = kvp.Value;
                    SetCameraSetting(camParams, cam);
                }
            }
            return true;
        }

        public override ImageStruct[] GetImageStructArray(int carType)
        {
            if (!_isConnected)
            {
                Logger.Error($"Communicator Disposed {_disposed}, Camera Communicator Connected : {_isConnected}");
                return null;
            }

            List<ImageStruct> imgStructsList = new List<ImageStruct>();
            foreach (var kvp in _locToCamera)
            {
                ImageStruct? imgStruct = GetImageStructImpl(carType, kvp.Key);
                if (imgStruct != null)
                {
                    imgStructsList.Add(imgStruct.Value);
                }
            }

            return imgStructsList.ToArray(); 
        }

        private ImageStruct? GetImageStructImpl(int carType, InspectionLocation location)
        {
            if (_locToBmp.Count == 0)
            {
                Logger.Error($"Check if ConvertBitmapFromPath has been Called"); 
                return null;
            }
            if (_locToBmp.TryGetValue(location, out Bitmap bitmap))
            {
                try
                {
                    BitmapData bmpData = bitmap.LockBits(
                    new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadOnly,
                    bitmap.PixelFormat);
                    int width = bitmap.Width;
                    int height = bitmap.Height;
                    int stride = bmpData.Stride;
                    int totalBytes = checked(stride * height);
                    _bmpToBmpData[bitmap] = bmpData; // Saved to Free After finishing sending data to unmanaged side
                    return ImageStruct.GetDefaultImageStruct(bmpData.Scan0, (ulong)totalBytes, 
                        width, height, stride, carType, location);
                }
                catch(Exception ex)
                {
                    Logger.Error($"Getting Image Ptr Failed from Location {location}: {ex}");
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private bool SetCameraSetting(CameraParameter camParameter, Camera camera)
        {
            if (camera == null)
            {
                return false;
            }

            if (camera.Parameters[PLStream.AutoPacketSize].IsWritable)
            {
                camera.Parameters[PLStream.AutoPacketSize].SetValue(true);
            }
            else
            {
                Logger.Error($"AutoPacketSize is not writable");
            }

            if (camera.Parameters[PLStream.EnableResend].IsWritable)
            {
                camera.Parameters[PLStream.EnableResend].SetValue(true);
            }
            else
            {
                Logger.Error($"Enable Resend is not writable");
            }

            if (camera.Parameters[PLStream.MaximumNumberResendRequests].IsWritable)
            {
                camera.Parameters[PLStream.MaximumNumberResendRequests].SetValue(25);
            }
            else
            {
                Logger.Error($"Maximumnumberresendrequest is not writable");
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
            if (camera.Parameters[PLCamera.ExposureAuto].IsWritable)
            {
                camera.Parameters[PLCamera.ExposureAuto].SetValue(PLCamera.ExposureAuto.Off);
            }
            else
            {
                Console.WriteLine("Exposure parameter is not writable.");
            }

            if (camera.Parameters[PLCamera.ExposureTimeAbs].IsWritable)
            {
                camera.Parameters[PLCamera.ExposureTimeAbs].SetValue(camParameter.ExposureTimeMicroSeconds);
                Logger.Info($"Setting Initial exposure value: {camParameter.ExposureTimeMicroSeconds}");
            }
            else
            {
                Logger.Info($"ExposureTime not writable");
            }

            if (camera.Parameters[PLCamera.ExposureAuto].IsWritable)
            {
                camera.Parameters[PLCamera.ExposureAuto].SetValue(PLCamera.ExposureAuto.Continuous);
                Console.WriteLine($"Exposure set to: {camera.Parameters[PLCamera.ExposureTimeAbs].GetValue()}");
                camera.Parameters[PLCamera.AutoExposureTimeAbsLowerLimit].SetValue(50000);
                camera.Parameters[PLCamera.AutoExposureTimeAbsUpperLimit].SetValue(250000);
                Console.WriteLine($"Exposure Auto Lower Limit: {camera.Parameters[PLCamera.AutoExposureTimeAbsLowerLimit].GetValue()}");
                Console.WriteLine($"Exposure Auto Upper Limit: {camera.Parameters[PLCamera.AutoExposureTimeAbsUpperLimit].GetValue()}");
            }
            else
            {
                Console.WriteLine("Exposure parameter is not writable.");
            }

            if (camera.Parameters[PLCamera.GrayValueAdjustmentDampingAbs].IsWritable)
            {
                camera.Parameters[PLCamera.GrayValueAdjustmentDampingAbs].SetValue(0.78125);
                Console.WriteLine($"GrayValueAdjustmentDamping Abs set to 0.78125");
            }
            else
            {
                Console.WriteLine($"GrayValueAdjustment Damping Abs not writable");
            }
            // Exposure
            //if (camera.Parameters[PLCamera.ExposureTimeAbs].IsWritable)
            //{
            //    camera.Parameters[PLCamera.ExposureTimeAbs].SetValue(camParameter.ExposureTimeMicroSeconds);
            //    Logger.Info($"Exposure set to: {camParameter.ExposureTimeMicroSeconds}, {camera.Parameters[PLCamera.ExposureTimeAbs].GetValue()}");
            //}
            //else
            //{
            //    Logger.Info("Exposure parameter is not writable.");
            //}            
            //if (camera.Parameters[PLCamera.ExposureAuto].IsWritable)
            //{
            //    camera.Parameters[PLCamera.ExposureAuto].SetValue(PLCamera.ExposureAuto.Once);
            //    Logger.Info($"Exposure set to: {camera.Parameters[PLCamera.ExposureTimeAbs].GetValue()}");
            //}
            //else
            //{
            //    Logger.Info("Exposure parameter is not writable.");
            //}

            return true;
        }

        private double GetExposure(Camera camera)
        {
            if (camera.Parameters[PLCamera.ExposureTimeAbs].IsReadable)
            {
                double exposureValue = camera.Parameters[PLCamera.ExposureTimeAbs].GetValue();
                Logger.Info($"Current Exposure Value:{exposureValue}");
                return exposureValue;
            }
            else
            {
                Logger.Info("Exposure parameter is not Readable.");
                return -1;
            }
        }

        public override async Task StartCamera(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict, int shotAttempt)
        {
            if (_disposed || !_isConnected)
            {
                Logger.Warning($"Communicator Disposed {_disposed}, Camera Communicator Connected : {_isConnected}");
                return;
            }

            await _sem.WaitAsync();
            try
            {
                ApplyCameraSettings(camParamDict);
                List<Task> tasks = new List<Task>();
                Stopwatch captureWatch = Stopwatch.StartNew();
                var capturedTime = $"{DateTime.Now:HHmmss}";

                foreach (var locToCam in _locToCamera)
                {
                    tasks.Add(Task.Run(() => BurstTakeImages(capturedTime, locToCam.Key, locToCam.Value, 5)));
                }
                await Task.WhenAll(tasks); tasks.Clear();
                Logger.Info($"Burst Takes took {captureWatch.Elapsed}"); captureWatch.Restart();
                foreach (var locToCam in _locToCamera)
                {
                    tasks.Add(Task.Run(() => GrabImage(locToCam.Key)));
                }
                await Task.WhenAll(tasks);
                Logger.Info($"Grab took {captureWatch.Elapsed}");
            }
            catch (Exception ex)
            {
                Logger.Error($"Error While Capturing Async, {ex}");
            }
            finally
            {
                _sem.Release();
            }
        }

        private void GrabImage(InspectionLocation location)
        {
            try
            {
                Logger.Info($"Starting Capturing Image on Camera {location}");
                var camera = _locToCamera[location];
                for (int i = 0; i < 3; i++)
                {
                    IGrabResult grabResult = camera.StreamGrabber.GrabOne(15000, TimeoutHandling.ThrowException);
                    camera.StreamGrabber.Stop();
                    if (grabResult.GrabSucceeded)
                    {
                        Bitmap bmp = ConvertGrabResultToBitmap(grabResult);
                        grabResult.Dispose();
                        Console.WriteLine($"bmp result is Null {bmp is null}");
                        _locToBmp[location] = bmp;
                        break;
                    }
                    else
                    {
                        Logger.Error($"Grab on Location: {location} Trial: {i}, Error indication {grabResult.ErrorCode}, {grabResult.ErrorDescription}");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Camera {location} Grab Image Failed, Error: {ex}");
            }
        }

        public bool BurstTakeImages(string capturedTime, InspectionLocation location, Camera camera, int takes = 8)
        {
            if (camera == null)
            {
                return false;
            }
            int capturedOnMinMaxCount = 0;
            for (int i = 1; i <= takes; i++)
            {
                double exposureValue = GetExposure(camera);
                if (exposureValue >= 250000 || exposureValue <= 50000)
                {
                    capturedOnMinMaxCount++;
                }

                if (capturedOnMinMaxCount > 1)
                    break;

                try
                {
                    IGrabResult grabResult = camera.StreamGrabber.GrabOne(15000, TimeoutHandling.ThrowException);
                    if (grabResult.GrabSucceeded)
                    {
                        //var convertedBmp = ConvertGrabResultToBitmap(grabResult);
                        //SaveExposureImages(location, capturedTime, convertedBmp, i, exposureValue);
                        grabResult.Dispose();
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error($"Grab Failed: Error: {ex}");
                }
                finally
                {
                    if (camera.StreamGrabber.IsGrabbing)
                    {
                        camera.StreamGrabber.Stop();
                    }
                }
            }
            return true;
        }

        public override Bitmap GetImage(string ipAddress)
        {
            if (_ipToLoc.TryGetValue(ipAddress, out var location))
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
            if (_locToBmp.TryGetValue(location, out var bitmap))
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

        public override bool SaveImage(InspectionLocation location, Bitmap bmp)
        {
            string filePath = $"./images/{DateTime.Now.ToString("yyMMdd_hhmmssfff")}.png";
            string parentDirectory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(parentDirectory))
            {
                Directory.CreateDirectory(parentDirectory);
            }
            bmp.Save(filePath, ImageFormat.Png);
            return true;
        }

        private bool SaveExposureImages(InspectionLocation location, string capturedTime, Bitmap bmp, int attempt, double exposure)
        {
            string filePath = $"D:/log/Captures/{DateTime.Now:yyMMdd}/temp/{capturedTime}/try_{attempt}_exposure_{(int)exposure}/{location}/{location}_{(int)exposure}.png";
            string parentDirectory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(parentDirectory))
            {
                Directory.CreateDirectory(parentDirectory);
            }
            bmp.Save(filePath, ImageFormat.Png);
            return true;
        }

        public override bool StopCamera()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(PylonCameraCommunicator));
            }

            if (!_isConnected)
            {
                return false;
            }

            _sem.Wait(); 

            try
            {
                _updateDeviceTimer.Change(-1, -1);
                Disconnect();
                _locToBmp = null; 
                _locToCamera = null; 
                _ipToLoc = null;
            }
            catch(Exception ex)
            {
                Logger.Error($"Error while stopping PylonCommunicator, Error: {ex}");
                return false;
            }
            finally
            {
                _sem.Release();
            }
            
            Logger.Info($"Camera Stopped");
            return true;
        }

        public override bool Disconnect()
        {
            _locToCamera.ToList().ForEach(kvp =>
            {
                ResetDevice(kvp.Key);
            });

            _isConnected = false;
            return true;
        }

        #region Utils
        private void ResetDevice(InspectionLocation location)
        {
            if (!_locToCamera.TryGetValue(location, out var cam))
            {
                return;
            }
            if (cam.IsOpen)
            {
                cam.Close();
            }
            cam?.Dispose();
            _locToCamera[location] = null;
            if (_locToBmp.TryGetValue(location, out var bmp))
            {
                if (_bmpToBmpData.TryGetValue(bmp, out var bmpData))
                {
                    bmp.UnlockBits(bmpData);
                    bmp.Dispose();
                    _bmpToBmpData.Remove(bmp);
                }
                else
                {
                    bmp.Dispose();
                }
                _locToBmp[location] = null;
            }
            if(_locToCamera.TryRemove(location, out _))
            {
                Logger.Info($"Remove Camera Success at Location: {location}");
            }
            else
            {
                Logger.Info($"Remove Camera Fail at Location: {location}");
            }
        }

        public override bool ClearBmpData()
        {
            if (_bmpToBmpData == null || _bmpToBmpData.Count == 0)
            {
                return false;
            }

            foreach (var kvp in _bmpToBmpData)
            {
                kvp.Key.UnlockBits(kvp.Value);
                kvp.Key.Dispose();
            }
            _bmpToBmpData.Clear();
            Logger.Info($"BitmapData Cleared");
            return true;
        }

        #endregion
        private async void OnConnectionLostAsync(Camera camera, InspectionLocation inspectionLocation, string ipAddress, int trials = 15)
        {
            Logger.Error($"Connection to Camera {inspectionLocation}, IP : {ipAddress} lost.");
            await _sem.WaitAsync();
            try
            {
                ResetDevice(inspectionLocation);
            }
            catch (Exception ex)
            {
                Logger.Info($"Closing attempt failed for Camera {inspectionLocation}, IP : {ipAddress}, Error: {ex}");
            }
            finally
            {
                _sem.Release();
            }
        }

        private void DestroyCamera(InspectionLocation location)
        {
            if (!_locToCamera.TryGetValue(location, out var cam))
            {
                throw new ArgumentException();
            }

            if (cam.IsOpen)
            {
                cam.Close();
            }
            cam?.Dispose();
            _locToCamera[location] = null;
        }

        public override Bitmap GetBitmapImage(InspectionLocation camLoc)
        {
            return GetImage(camLoc);
        }

        public override (InspectionLocation, Bitmap)[] GetAllBitmaps()
        {
            return _locToBmp.Select(x => (x.Key, x.Value)).ToArray();
        }
    }
}