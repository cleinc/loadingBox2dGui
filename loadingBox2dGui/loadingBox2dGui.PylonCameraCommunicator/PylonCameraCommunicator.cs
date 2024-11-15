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
    public class PylonCameraCommunicator : CameraCommunicatorForLoadingBox, IDisposable
    {
        private readonly static LogHelper Logger = LogHelper.Logger;
        private PixelDataConverter _converter;
        private Timer _updateDeviceTimer;
        private SemaphoreSlim _sem = new SemaphoreSlim(1, 1);
        private Dictionary<string, InspectionLocation> _ipToLocationDict;
        private Dictionary<InspectionLocation, Bitmap> _bitmapsOnLocation;
        private ConcurrentDictionary<InspectionLocation, Camera> _cameraOnLocation;
        private ConcurrentDictionary<InspectionLocation, CameraState> _cameraStateOnLocation;
        private bool _isConnected = false;
        private static readonly int reconnectTimeoutMs = 15000;
        public bool IsConnected => _isConnected;

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
                Logger.Info(GetCameraStatus());
                Logger.Info($"PylonCommunicator Already Connected");
                return true;
            }

            _sem.Wait();
            Logger.Info($"Connecting PylonCommunicator");
            try
            {
                _ipToLocationDict = new Dictionary<string, InspectionLocation>();
                _cameraStateOnLocation = new ConcurrentDictionary<InspectionLocation, CameraState>();
                _bitmapsOnLocation = new Dictionary<InspectionLocation, Bitmap>();
                locationToCamParameter.Keys.ToList().ForEach( key => 
                {
                    string camIp = locationToCamParameter[key].IpAddress;
                    _cameraStateOnLocation[key] = CameraState.Disconnected;
                    _cameraOnLocation = new ConcurrentDictionary<InspectionLocation, Camera>();
                    if (_ipToLocationDict.ContainsKey(camIp))
                    {
                        Logger.Error($"Overlapping Cam IP {camIp}. Camera IP Address must be Unique for each Inspection Location");
                        return;
                    }
                    else
                    {
                        _ipToLocationDict.Add(camIp, key);
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

            if (!_isConnected || _ipToLocationDict is null || _cameraOnLocation is null || _cameraStateOnLocation is null)
            {
                return;
            }
            
            if (!_sem.Wait(100))
            {
                return;
            }

            try
            {
                var camDevices = CameraFinder.Enumerate();
                foreach (var camDevice in camDevices)
                {
                    string ipAddress = camDevice[CameraInfoKey.DeviceIpAddress];
                    if (!_ipToLocationDict.TryGetValue(ipAddress, out InspectionLocation location))
                    {
                        return;
                    }
                    
                    if(_cameraOnLocation.TryGetValue(location, out Camera newCamera))
                    {
                        if (_cameraStateOnLocation[location] == CameraState.Disconnected)
                        {
                            DestroyCamera(location);
                        }
                        else
                        {
                            return;
                        }
                    }

                    Camera camera = new Camera(ipAddress);
                    newCamera.ConnectionLost += (sender, e) => OnConnectionLostAsync(newCamera, location, ipAddress);
                    bool ret = OpenCamera(newCamera, location, ipAddress, 1000);
                    if (ret)
                    {
                        Logger.Info($"Camera on {location}, IP : {ipAddress} Added");
                        _cameraOnLocation[location] = newCamera;
                    }
                    else
                    {
                        newCamera.ConnectionLost -= (sender, e) => OnConnectionLostAsync(newCamera, location, ipAddress);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Error while Updating Devices, Error : {ex}");
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

            // Retrieve min, max, and increment for Exposure
            Console.WriteLine("Exposure:");
            if (camera.Parameters[PLCamera.ExposureTimeAbs].IsReadable)
            {
                Console.WriteLine("  Value       : {0}", camera.Parameters[PLCamera.ExposureTimeAbs].GetValue());
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

        public override bool ApplyCameraSettings(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict)
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

        private bool CheckConnection(InspectionLocation location)
        {
            return false;
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

        public override async Task StartCamera(ConcurrentDictionary<InspectionLocation, CameraParameter> camParamDict)
        {
            if (_disposed || !_isConnected)
            {
                Logger.Error($"Communicator Disposed {_disposed}, Communicator Connected : {_isConnected}");
                return;
            }

            await _sem.WaitAsync();
            Logger.Info(GetCameraStatus());
            try
            {
                ApplyCameraSettings(camParamDict);
                List<Task> tasks = new List<Task>();
                _cameraOnLocation.Keys.ToList().ForEach(location =>
                {
                    tasks.Add(Task.Run(() => GrabImage(location)));
                });
                await Task.WhenAll(tasks);
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
                var currentCamState = _cameraStateOnLocation[location];
                Logger.Error($"Camera {location} Grab Image Failed, State: {currentCamState}, Error: {ex.Message}");
            }
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
                _bitmapsOnLocation = null; 
                _cameraOnLocation = null; 
                _cameraStateOnLocation = null; 
                _ipToLocationDict = null;
                return true;
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
        }

        public override bool Disconnect()
        {
            _cameraOnLocation.ToList().ForEach(kvp =>
            {
                ResetDevice(kvp.Key);
            });

            _isConnected = false;
            return true;
        }

        #region Utils
        private void ResetDevice(InspectionLocation location)
        {
            if (!_cameraOnLocation.TryGetValue(location, out var cam))
            {
                _cameraStateOnLocation[location] = CameraState.Undefined;
                return;
            }
            if (cam.IsOpen)
            {
                cam.Close();
            }
            cam?.Dispose();
            _cameraOnLocation[location] = null;
            _cameraStateOnLocation[location] = CameraState.Disconnected;
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
        private void OnConnectionLostAsync(Camera camera, InspectionLocation inspectionLocation, string ipAddress, int trials = 15)
        {
            if (_cameraStateOnLocation[inspectionLocation] == CameraState.Disconnected)
            {
                return;
            }
            Logger.Error($"Connection to Camera {inspectionLocation}, IP : {ipAddress} lost.");
            
            try
            {
                if (camera == null || _cameraStateOnLocation[inspectionLocation] == CameraState.Disconnected)
                {
                    return;
                }

                if (camera.IsOpen)
                {
                    camera.Close();
                }
                _cameraStateOnLocation[inspectionLocation] = CameraState.Disconnected;
            }
            catch (Exception ex)
            {
                Logger.Info($"Closing attempt failed for Camera {inspectionLocation}, IP : {ipAddress}, Error: {ex}");
                Console.WriteLine($"Reconnection : Error: {ex}");
                _cameraStateOnLocation[inspectionLocation] = CameraState.Error;
            }
        }

        private void DestroyCamera(InspectionLocation location)
        {
            if (!_cameraOnLocation.TryGetValue(location, out var cam))
            {
                throw new ArgumentException();
            }

            if (cam.IsOpen)
            {
                cam.Close();
            }
            cam?.Dispose();
            _cameraOnLocation[location] = null;
        }
           
    }
}