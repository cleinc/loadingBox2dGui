using CoPick.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace loadingBox2dGui.models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LogData
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string Syntax;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CamSettings
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string CamName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)] public string IpAdr;
        public int CameraRoiX;
        public int CameraRoiY;
        public int CameraRoiWidth;
        public int CameraRoiHeight;
        public int MaxFPS;
        public int CamIndex;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string CamNameSmartRay;
        public int PortNum;
        public uint NumberOfExpectedProfiles;
        public uint PacketSize;
        public uint PacketTimeOut;
        public uint Width;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string ParamSetPath;
        public int ExposureTimeMicroS;
        public int Gain;
        public int Exposure;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string ImageFolderPath;
        public int Fps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ModelSettings
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string ModelPath;
        public int ModelInputWidth;
        public int ModelInputHeight;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)] public string DictionaryPath;
        public int DictionarySize;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct ImageStruct
    {
        public uint Version;
        public IntPtr ImageData; // Pointer to the image data (void* in C++)
        public ulong ImageDataLength; // Corresponds to size_t in C++
        
        public SensorType SensorType; // IDS RO PYLON 
        public int CarType;
        public InspectionLocation CameraLocation; // int section

        public int Width; // Image width
        public int Height; // Image height
        public int Stride; // Image stride
        public Pose6D Shift6D;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public double[] ScanPose4x4Matrix;
        public uint CheckSum;
        public static ImageStruct GetPylonImageStruct(IntPtr imageData, ulong imageDataLength, int width, int height, int stride)
        {
            return new ImageStruct()
            {
                Version = 1, ImageData = imageData, ImageDataLength = imageDataLength,
                SensorType = SensorType.PYLON, Width = width, Height = height, Stride = stride, 
                Shift6D = new Pose6D(), ScanPose4x4Matrix = new double[16], CheckSum = 123456789
            };
        }

        public static ImageStruct GetDefaultImageStruct(IntPtr imageData, ulong imageDataLength, int width, int height, int stride,
            int carType, InspectionLocation location)
        {
            ImageStruct newImgStruct = ImageStruct.GetPylonImageStruct(imageData, imageDataLength, width, height, stride);
            newImgStruct.CameraLocation = location;
            newImgStruct.CarType = carType;
            return newImgStruct;
        }

        public static ImageStruct GetOfflineImageStruct(IntPtr imageData, ulong imageDataLength, int width, int height, int stride, 
            int carType, InspectionLocation location)
        {
            return new ImageStruct()
            {
                Version = 1, ImageData = imageData, ImageDataLength = imageDataLength,
                SensorType = SensorType.OFFLINE, CarType = carType, CameraLocation = location, 
                Width = width, Height = height, Stride = stride, 
                Shift6D = new Pose6D(), ScanPose4x4Matrix = new double[16], CheckSum = 123456789
            };
        }

        public RobotPose GetRobotPose()
        {
            return new YaskawaRobotPose()
            {
                Tx = Shift6D.Tx,
                Ty = Shift6D.Ty,
                Tz = Shift6D.Tz,
                Rx = Shift6D.Rx,
                Ry = Shift6D.Ry,
                Rz = Shift6D.Rz
            };
        }
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MasterPathStruct
    {
        public uint Version;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 300)]
        public string ImagePath; // Image Path
    
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 300)]
        public string SegModelPath; // Segmentation Model Path
    
        public DataType ImageType; // MasterImage or CheckerBoard
    
        public int CarType; // CarType ~ CarName
    
        public SensorType SensorType; // IDS or PYLON
    
        public InspectionLocation CameraLocation; 
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public double[] CameraMatrix; // 3x3 Camera Matrix
    
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public double[] DistCoeffs; // Distortion Coefficients

        public Pose6D Shift6D;
        public uint Checksum;
        public static MasterPathStruct MasterImageStruct(int carType, string masterImagePath, string shiftModelPath, 
            InspectionLocation location, CalibrationData calibrationData, float zDegree)
        {
            return new MasterPathStruct()
            {
                Version = 1,
                SensorType = SensorType.PYLON,
                ImageType = DataType.MasterImage,
                CameraMatrix = calibrationData?.CameraMatrix.Data.ToArray() ?? new double[9] { 0,0,0, 
                                                                                               0,0,0,
                                                                                               0,0,0 }, 
                DistCoeffs = calibrationData?.DistCoeffs.Data.ToArray() ?? new double[5] { 0,0,0,0,0 },

                CarType = carType,
                CameraLocation = location,
                SegModelPath = shiftModelPath, 
                ImagePath = masterImagePath,
                Shift6D = new Pose6D()
                {
                    Rz = zDegree,
                }, 
                Checksum = 123459789, 
            };
        }

        public static MasterPathStruct CharucoImageStruct(int cartype, string masterImagePath, string shiftModelPath, 
            InspectionLocation location, CalibrationData calibrationData, float zDegree)
        {
            return new MasterPathStruct()
            {
                Version = 1,
                SensorType = SensorType.PYLON,
                ImageType = DataType.CheckerBoard,
                CameraMatrix = calibrationData?.CameraMatrix.Data.ToArray() ?? new double[9] { 0,0,0, 
                                                                                               0,0,0,
                                                                                               0,0,0 }, 
                DistCoeffs = calibrationData?.DistCoeffs.Data.ToArray() ?? new double[5] { 0,0,0,0,0 },

                CarType = cartype, 
                CameraLocation = location,
                SegModelPath = shiftModelPath,
                ImagePath = masterImagePath,
                Shift6D = new Pose6D()
                {
                    Rz = zDegree,
                },
                Checksum = 123456789,
            };
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Pose6D
    {
        public float Tx;
        public float Ty;
        public float Tz;
        public float Rx;
        public float Ry;
        public float Rz;

        public override string ToString()
        {
            return string.Format(
            "Position: [Tx: {0:F2}, Ty: {1:F2}, Tz: {2:F2}], " +
            "Rotation: [Rx: {3:F2}, Ry: {4:F2}, Rz: {5:F2}]",
            Tx, Ty, Tz, Rx, Ry, Rz
            );
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TCP
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public double[] TcpMatrix;
        public static TCP GetTCPFromRobotPose(RobotPose pose)
            {
            // Compute cosines and sines for the rotation matrix
            double cosX = Math.Cos(pose.Rx);
            double sinX = Math.Sin(pose.Rx);
            double cosY = Math.Cos(pose.Ry);
            double sinY = Math.Sin(pose.Ry);
            double cosZ = Math.Cos(pose.Rz);
            double sinZ = Math.Sin(pose.Rz);

            // Compute the rotation matrix using ZYX Euler angles
            double m11 = cosY * cosZ;
            double m12 = cosY * sinZ;
            double m13 = -sinY;

            double m21 = sinX * sinY * cosZ - cosX * sinZ;
            double m22 = sinX * sinY * sinZ + cosX * cosZ;
            double m23 = sinX * cosY;

            double m31 = cosX * sinY * cosZ + sinX * sinZ;
            double m32 = cosX * sinY * sinZ - sinX * cosZ;
            double m33 = cosX * cosY;

            // Translation components
            double tx = pose.Tx;
            double ty = pose.Ty;
            double tz = pose.Tz;

            // Flattened 4x4 matrix
            return new TCP
            {
                TcpMatrix = new double[]
                {
                    m11, m12, m13, 0,  // First row
                    m21, m22, m23, 0,  // Second row
                    m31, m32, m33, 0,  // Third row
                    tx,  ty,  tz,  1   // Fourth row (translation + homogeneous coord)
                }
            };
        }
        public static double[] GetFlattenMatrix4x4FromRobotPose(RobotPose pose)
        {
            // Convert degrees to radians
            double rx = pose.Rx * Math.PI / 180.0;
            double ry = pose.Ry * Math.PI / 180.0;
            double rz = pose.Rz * Math.PI / 180.0;

            // Compute cosines and sines for the rotation matrix
            double cosX = Math.Cos(rx);
            double sinX = Math.Sin(rx);
            double cosY = Math.Cos(ry);
            double sinY = Math.Sin(ry);
            double cosZ = Math.Cos(rz);
            double sinZ = Math.Sin(rz);

            // Compute the rotation matrix using ZYX Euler angles
            double m11 = cosY * cosZ;
            double m12 = cosY * sinZ;
            double m13 = -sinY;

            double m21 = sinX * sinY * cosZ - cosX * sinZ;
            double m22 = sinX * sinY * sinZ + cosX * cosZ;
            double m23 = sinX * cosY;

            double m31 = cosX * sinY * cosZ + sinX * sinZ;
            double m32 = cosX * sinY * sinZ - sinX * cosZ;
            double m33 = cosX * cosY;

            // Translation components
            double tx = pose.Tx;
            double ty = pose.Ty;
            double tz = pose.Tz;

            // Flattened 4x4 matrix
            return new double[]
            {
                m11, m12, m13, 0,  // First row
                m21, m22, m23, 0,  // Second row
                m31, m32, m33, 0,  // Third row
                tx,  ty,  tz,  1   // Fourth row (translation + homogeneous coord)
            };
        }
        public static TCP GetDefault()
        {
            return new TCP() { TcpMatrix = new double[16] };
        }
        public static TCP IdentityMatrix()
        {
            return new TCP()
            {
                TcpMatrix = new double[16]
                {
                    1, 0, 0, 0,
                    0, 1, 0, 0,
                    0, 0, 1, 0,
                    0, 0, 0, 1 
                }
            };
        }
        public override string ToString()
        {
            if (TcpMatrix == null || TcpMatrix.Length != 16)
            {
                return "Invalid TCP Matrix";
            }

            return string.Format(
                "{0,10:F12} {1,10:F12} {2,10:F12} {3,10:F12}\n" +
                "{4,10:F12} {5,10:F12} {6,10:F12} {7,10:F12}\n" +
                "{8,10:F12} {9,10:F12} {10,10:F12} {11,10:F12}\n" +
                "{12,10:F12} {13,10:F12} {14,10:F12} {15,10:F12}\n",
                TcpMatrix[0], TcpMatrix[1], TcpMatrix[2], TcpMatrix[3],
                TcpMatrix[4], TcpMatrix[5], TcpMatrix[6], TcpMatrix[7],
                TcpMatrix[8], TcpMatrix[9], TcpMatrix[10], TcpMatrix[11],
                TcpMatrix[12], TcpMatrix[13], TcpMatrix[14], TcpMatrix[15]
            );
        }
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct ExposureImage
    {
        public uint version;
        public IntPtr ImageData;
        public ulong ImageDataLength;
        public int width;
        public int height;
        public int stride;
        public int currentExposure;
        public int setExposure;
        public int score;
    }
    public enum DataType
    {
        MasterImage, 
        CheckerBoard
    }

    public enum SensorType
    {
        OFFLINE,
        IDS, 
        PYLON
    }

    public enum TaskType
    {
        Cargo, 
        TouchUp
    }

    public class CalibrationData
    {
        public double ReprojectionError { get; set; }
        public Matrix CameraMatrix { get; set; }
        public Matrix DistCoeffs { get; set; }
    }

    public class Matrix
    {
        public int Rows { get; set; }
        public int Cols { get; set; }
        public string Dt { get; set; } // Data type (e.g., "d")
        public List<double> Data { get; set; }
    }   

    public class HandEyeCalibrationData
    {
        public Matrix Lh { get; set; }
        public Matrix Rh { get; set; }
    }
}