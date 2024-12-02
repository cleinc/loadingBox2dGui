using CoPick.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public class CargoBox2DInspectionEngine: ICargoBox2DInspectionEngine
    { 
        private static readonly LogHelper Logger = LogHelper.Logger;
        private bool disposedValue;
        private IntPtr _engineHandler;

        public CargoBox2DInspectionEngine(Config config)
        {
            SetEngineType(config.TaskType);
            _engineHandler = GetEnginePointer();
        }

        public delegate void WriteLogCallback([MarshalAs(UnmanagedType.LPWStr)]string msg, LogLevel logLvl, string caller);
        private static WriteLogCallback _scb;

        public void SetCallbackWriteLog(WriteLogCallback callBack)
        {
            Logger.Debug("[GUI] Called SetCallbackWriteLog API");
            _scb = callBack;
            CargoBox2DInspectionEngineApi.SetLogCallback(_scb);
        }

        //public delegate void GetLogSyntaxCallback(ref LogData logData, string key);
        //private static GetLogSyntaxCallback _sgl;
        //public static GetLogSyntaxCallback CallbackGetLogSyntax
        //{
        //    set
        //    {
        //        _sgl = value;
        //        BottomTouchUpInspectionEngineApi.SetGetLogSyntaxCallback(_sgl);
        //    }
        //}

        public IntPtr GetEnginePointer()
        {
            Logger.Debug("[GUI] Called GetEnginePointer API");
            return CargoBox2DInspectionEngineApi.GetEnginePointer();
        }
        
        public bool DeleteEnginePointer(IntPtr enginePointer)
        {
            Logger.Debug("[GUI] Called DeleteEnginePointer API");
            return CargoBox2DInspectionEngineApi.DeleteEnginePointer(enginePointer);
        }
        
        public string GetEngineApiVersion()
        {
            Logger.Debug("[GUI] Called GetEngineApiVersion API");
            return CargoBox2DInspectionEngineApi.GetEngineAPIVersion();
        }
        
        public bool SetEngineType(TaskType taskType)
        {
            Logger.Debug($"[GUI] Called SetEngineType API, Setting TaskType to {taskType}, int: {(int)taskType}");
            return CargoBox2DInspectionEngineApi.SetEngineType((int)taskType);
        }
        
        public bool SetEngineVerbosity(int logLevel, int imgLevel)
        {
            logLevel = Math.Min(logLevel, 5);
            imgLevel = Math.Min(imgLevel, 5);
            Logger.Debug("[GUI] Called SetVerbose API");
            return CargoBox2DInspectionEngineApi.setVerbose(_engineHandler, logLevel, imgLevel);
        }
        public bool LoadImageSetTest(ImageStruct[] images, int imageCount)
        {
            Logger.Debug("[GUI] Called LoadImageSetTest API");
            return CargoBox2DInspectionEngineApi.loadImageSetTest(_engineHandler, images, imageCount);
        }
        
        public bool LoadImageSetTestCheckerboard(ImageStruct[] images, int imageCount)
        {
            Logger.Debug("[GUI] Called LoadImageSetTestCheckerboard API");
            return CargoBox2DInspectionEngineApi.loadImageSetTestCheckerboard(_engineHandler, images, imageCount);
        }
        
        public bool LoadCharucoBoardConfig(MasterPathStruct[] masterPaths, int configCount)
        {
            Logger.Debug($"[GUI] Called LoadCharucoBoardConfig API, Count: {configCount}");
            return CargoBox2DInspectionEngineApi.loadCharucoBoadConfig(_engineHandler, masterPaths, configCount);
        }
        
        public bool LoadMasterImage(MasterPathStruct[] masterPaths, int configCount)
        {
            Logger.Debug($"[GUI] Called LoadMasterImage API, Count: {configCount}");
            return CargoBox2DInspectionEngineApi.loadMasterImage(_engineHandler, masterPaths, configCount);
        }
        
        public bool InitializeMaster()
        {
            Logger.Debug("[GUI] Called InitializeMaster API");
            return CargoBox2DInspectionEngineApi.initializeMaster(_engineHandler);
        }

        public bool ShowCharuco()
        {
            Logger.Debug("[GUI] Called ShowCharuco API");
            return CargoBox2DInspectionEngineApi.showCharuco(_engineHandler);
        }
        
        public bool PoseAdjustment2D(ImageStruct[] images, int imageCount)
        {
            Logger.Debug("[GUI] Called PoseAdjustment2D API");
            return CargoBox2DInspectionEngineApi.poseAdjustment2D(_engineHandler, images, imageCount);
        }

        public bool LoadTransformationMatrix(TCP scanPoseTcp, TCP installPoseTcp, TCP leftCamTcp, TCP rightCamTcp)
        {
            Logger.Debug("[GUI] Called LoadTransformationMatrix API");
            return CargoBox2DInspectionEngineApi.loadTransMat(_engineHandler, ref scanPoseTcp, ref installPoseTcp, ref leftCamTcp, ref rightCamTcp);
        }

        public bool PoseAdjustmentCargoBox2D(ImageStruct[] images, int imageCount)
        {
            Logger.Debug("[GUI] Called PoseAdjustmentCargoBox2D API");
            return CargoBox2DInspectionEngineApi.poseAdjustment2D(_engineHandler, images, imageCount);
        }

        public class CargoBox2DInspectionEngineApi
        {
            private const string _dllName = "CargoBoxTouchUpEngine.dll";

            [DllImport(_dllName)]
            public static extern IntPtr GetEnginePointer();

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool DeleteEnginePointer(IntPtr enginePointer);

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool SetEngineType(int taskType);

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.LPStr)]
            public static extern string GetEngineAPIVersion();

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool SetLogCallback(WriteLogCallback callback);

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool setVerbose(IntPtr enginePointer, int logVerbose, int imgVerbose);
            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool loadImageSetTest(
                IntPtr enginePointer,
                [In, Out, MarshalAs(UnmanagedType.LPArray)] ImageStruct[] images,
                int imageCount);

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool loadImageSetTestCheckerboard(
                IntPtr enginePointer,
                [In, Out, MarshalAs(UnmanagedType.LPArray)] ImageStruct[] images,
                int imageCount);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool loadCharucoBoadConfig(
                IntPtr enginePointer,
                [In, Out, MarshalAs(UnmanagedType.LPArray)] MasterPathStruct[] masterPaths,
                int configCount);

            [DllImport(_dllName, CallingConvention = CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool loadMasterImage(
                IntPtr enginePointer,
                [In, Out, MarshalAs(UnmanagedType.LPArray)] MasterPathStruct[] masterPaths,
                int configCount);

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool initializeMaster(IntPtr enginePointer);

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool checkModelPath(IntPtr enginePointer, [MarshalAs(UnmanagedType.LPStr)] string modelPath);
            
            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool showCharuco(IntPtr enginePointer);

            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool poseAdjustment2D(IntPtr enginePointer, [In, Out, MarshalAs(UnmanagedType.LPArray)] ImageStruct[] images, int imageCount);
            
            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool poseAdjustment2DCargo(IntPtr enginePointer, [In, Out, MarshalAs(UnmanagedType.LPArray)] ImageStruct[] images, int imageCount);
            
            [DllImport(_dllName)]
            [return: MarshalAs(UnmanagedType.I1)]
            public static extern bool loadTransMat(
                IntPtr enginePointer,
                ref TCP scanPose,
                ref TCP installPose,
                ref TCP leftCamTCP,
                ref TCP rightCamTCP
            );
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 관리형 상태(관리형 개체)를 삭제합니다.
                }

                // TODO: 비관리형 리소스(비관리형 개체)를 해제하고 종료자를 재정의합니다.
                // TODO: 큰 필드를 null로 설정합니다.
                DeleteEnginePointer(_engineHandler);
                _engineHandler = IntPtr.Zero;
                disposedValue = true;
            }
        }

        // // TODO: 비관리형 리소스를 해제하는 코드가 'Dispose(bool disposing)'에 포함된 경우에만 종료자를 재정의합니다.
        ~CargoBox2DInspectionEngine()
        {
            // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // 이 코드를 변경하지 마세요. 'Dispose(bool disposing)' 메서드에 정리 코드를 입력합니다.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
