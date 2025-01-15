using CoPick.Logging;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public class OfflineImageHandler : IImageProvider<InspectionLocation>
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        private int _currentCar = 0;
        private Dictionary<int, Dictionary<InspectionLocation, Bitmap>> _cartypeToBmpDict;
        private Dictionary<InspectionLocation, Bitmap> _inspectionLocToBmp;
        private Dictionary<string, Bitmap> _filePathToBmp;
        private Dictionary<Bitmap, BitmapData> _bmpToBitmapData;
        private Dictionary<InspectionLocation, byte[]> _locToBuffer;
        public OfflineImageHandler()
        {
            _cartypeToBmpDict = new Dictionary<int, Dictionary<InspectionLocation, Bitmap>>();
            _inspectionLocToBmp = new Dictionary<InspectionLocation, Bitmap>();
            _filePathToBmp = new Dictionary<string, Bitmap>();
            _bmpToBitmapData = new Dictionary<Bitmap, BitmapData>();
            _locToBuffer = new Dictionary<InspectionLocation, byte[]>();
        }

        public bool SetCarType(int carType)
        {
            _currentCar = carType;
            return true;
        }

        public bool CheckCarType(int carType)
        {
            if (!_cartypeToBmpDict.ContainsKey(carType))
            {
                return false;
            }
            return true;
        }

        public void RegisterCarType(int carType)
        {
            _cartypeToBmpDict[carType] = new Dictionary<InspectionLocation, Bitmap>();
            _bmpToBitmapData = new Dictionary<Bitmap, BitmapData>();
            _locToBuffer = new Dictionary<InspectionLocation, byte[]>();
        }

        public bool LoadBitMapFromPath(InspectionLocation location, string path)
        {
            //if (!CheckCarType(carType))
            //{
            //    RegisterCarType(carType);
            //}

            using (Bitmap bitmap = new Bitmap(path))
            {
                Bitmap bgraBitmap = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);

                using (Graphics g = Graphics.FromImage(bgraBitmap))
                {
                    g.DrawImage(bitmap, new Rectangle(0, 0, bgraBitmap.Width, bgraBitmap.Height));
                }

                _inspectionLocToBmp[location] = bgraBitmap;
            }
            return true;
        }

        public bool LoadBitMapFromPath(string path)
        {
            //if (!CheckCarType(carType))
            //{
            //    RegisterCarType(carType);
            //}

            using (Bitmap bitmap = new Bitmap(path))
            {
                Bitmap bgraBitmap = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);

                using (Graphics g = Graphics.FromImage(bgraBitmap))
                {
                    g.DrawImage(bitmap, new Rectangle(0, 0, bgraBitmap.Width, bgraBitmap.Height));
                }

                _filePathToBmp[path] = bgraBitmap;
            }
            return true;
        }


        public Bitmap ConvertPngEncodedFromIntPtr(IntPtr imagePtr, int length, InspectionLocation inspectionLocation)
        {
            if (!_locToBuffer.TryGetValue(inspectionLocation, out byte[] buffer))
            {
                Logger.Debug($"Creating new Buffer for {inspectionLocation}, Length = {length}");
                _locToBuffer[inspectionLocation] = new byte[length];
            }

            if (_locToBuffer[inspectionLocation].Length != length)
            {
                _locToBuffer[inspectionLocation] = new byte[length];
            }
            byte[] imageData = _locToBuffer[inspectionLocation]; 

            Marshal.Copy(imagePtr, imageData, 0, length);
            using (var ms = new MemoryStream(imageData))
            {
                return new Bitmap(ms);
            }
        }

        public IntPtr ConvertBitmapToIntPtr(Bitmap bitmap, out int length)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] imageData = ms.ToArray();
                length = imageData.Length;

                // Allocate unmanaged memory to store the byte array
                IntPtr unmanagedPointer = Marshal.AllocHGlobal(length);
                
                // Copy the byte array to the unmanaged memory
                Marshal.Copy(imageData, 0, unmanagedPointer, length);
                
                return unmanagedPointer;
            }
        }

        public ImageStruct[] GetImageStructsArray(params InspectionLocation[] locations)
        {
            List<ImageStruct> imgStructs = new List<ImageStruct>(); 
            foreach (var loc in locations)
            {
                ImageStruct? imgStruct = ConvertBitMapToImgStruct(loc);
                if (imgStruct != null)
                {
                    imgStructs.Add(imgStruct.Value);
                }
            }
            return imgStructs.ToArray();
        }

        public ImageStruct? ConvertBitMapToImgStruct(InspectionLocation location)
        {
            //var locToBmp = _cartypeToBmpDict[_currentCar];
            if (_inspectionLocToBmp.Count == 0)
            {
                Logger.Error($"Check if ConvertBitmapFromPath has been Called"); 
                return null;
            }
            if (_inspectionLocToBmp.TryGetValue(location, out Bitmap bitmap))
            {
                try
                {
                    Logger.Info($"Fetching image");
                    BitmapData bmpData = bitmap.LockBits(
                    new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadWrite,
                    bitmap.PixelFormat);
                    int width = bitmap.Width;
                    int height = bitmap.Height;
                    int stride = bmpData.Stride;
                    int totalBytes = checked(stride * height);
                    _bmpToBitmapData[bitmap] = bmpData;
                    return ImageStruct.GetOfflineImageStruct(bmpData.Scan0, (ulong)totalBytes, 
                        width, height, stride, _currentCar, location);
                }
                catch(Exception ex)
                {
                    Logger.Error($"Getting Image Ptr Failed from Location {location}: {ex}");
                    return null;
                }
            }
            else
            {
                Logger.Error($"no image found! on location {location}");
                return null;
            }
        }

        public ImageStruct? ConvertBitMapToImgStruct(string filePath)
        {
            //var locToBmp = _cartypeToBmpDict[_currentCar];
            if (_filePathToBmp.Count == 0)
            {
                Logger.Error($"Check if ConvertBitmapFromPath has been Called"); 
                return null;
            }
            if (_filePathToBmp.TryGetValue(filePath, out Bitmap bitmap))
            {
                try
                {
                    BitmapData bmpData = bitmap.LockBits(
                    new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadWrite,
                    bitmap.PixelFormat);
                    int width = bitmap.Width;
                    int height = bitmap.Height;
                    int stride = bmpData.Stride;
                    int totalBytes = checked(stride * height);
                    _bmpToBitmapData[bitmap] = bmpData;
                    return ImageStruct.GetOfflineImageStruct(bmpData.Scan0, (ulong)totalBytes, 
                        width, height, stride, _currentCar, InspectionLocation.LH);
                }
                catch(Exception ex)
                {
                    Logger.Error($"Getting Image Ptr Failed from FilePath {filePath}: {ex}");
                    return null;
                }
            }
            else
            {
                Logger.Error($"no image found! on filePath {filePath}");
                return null;
            }
        }

        public Bitmap ConvertLockedBitmapDataToBitmap(string filePath)
        {
            if (_filePathToBmp.TryGetValue(filePath, out Bitmap bitmap))
            {
                if (_bmpToBitmapData.TryGetValue(bitmap, out BitmapData bmpData))
                {
                    bitmap.UnlockBits(bmpData);
                    _bmpToBitmapData.Remove(bitmap);
                    Console.WriteLine($"Unlocked Bitmap Data for {bitmap} on path {filePath}");
                    return bitmap;
                }
                else
                {
                    Logger.Error($"Bitmap Data not found for {filePath}");
                    return null;
                }
            }
            else
            {
                Logger.Error($"Bitmap not found for {filePath}");
                return null;
            }
        }

        public bool ClearBmpData()
        {
            if (_bmpToBitmapData.Count == 0 && _inspectionLocToBmp.Count == 0 && _filePathToBmp.Count == 0)
            {
                Logger.Error($"Check if ImgStruct Function or ConvertBitmapFrom Path has not been Called");
                return false;
            }

            foreach (var bmp in _inspectionLocToBmp.Values)
            {
                if (_bmpToBitmapData.TryGetValue(bmp, out var bmpData))
                {
                    
                    bmp.UnlockBits(bmpData);
                    _bmpToBitmapData.Remove(bmp);
                }
                bmp?.Dispose();
            }

            foreach (var bmp in _filePathToBmp.Values)
            {
                if (_bmpToBitmapData.TryGetValue(bmp, out var bmpData))
                {
                    bmp.UnlockBits(bmpData);
                    _bmpToBitmapData.Remove(bmp);
                }
                bmp?.Dispose();
            }

            _inspectionLocToBmp.Clear();
            _filePathToBmp.Clear();
            _bmpToBitmapData.Clear();
            return true;
        }

        public Bitmap GetBitmapImage(InspectionLocation camLoc)
        {
            var locToBmp = _cartypeToBmpDict[_currentCar];
            if (locToBmp.TryGetValue(camLoc, out var bmp))
            {
                return bmp;
            }
            else
            {
                return null;
            }
        }

        public Bitmap GetBitmapImage(string filePath)
        {
            if (_filePathToBmp.TryGetValue(filePath, out var bmp))
            {
                return bmp;
            }
            else
            {
                return null;
            }
        }

        public (InspectionLocation, Bitmap)[] GetAllBitmaps()
        {
            //return _cartypeToBmpDict[_currentCar].Select(x => (x.Key, x.Value)).ToArray();
            return _inspectionLocToBmp.Select(x => (x.Key, x.Value)).ToArray();
        }
    }
    public interface IImageProvider<T> where T: Enum
    {
        Bitmap GetBitmapImage(T camLoc);
        (InspectionLocation, Bitmap)[] GetAllBitmaps();
    }
}