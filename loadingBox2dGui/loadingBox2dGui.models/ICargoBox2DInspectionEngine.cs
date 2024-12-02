using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static loadingBox2dGui.models.CargoBox2DInspectionEngine;
namespace loadingBox2dGui.models
{
    public interface ICargoBox2DInspectionEngine
    {
        IntPtr GetEnginePointer();
        void SetCallbackWriteLog(WriteLogCallback callBack);
        bool DeleteEnginePointer(IntPtr enginePointer);
        string GetEngineApiVersion();
        bool SetEngineVerbosity(int logLevel, int imgLevel);
        bool SetEngineType(TaskType taskType);
        bool LoadImageSetTest(ImageStruct[] images, int imageCount);
        bool LoadImageSetTestCheckerboard(ImageStruct[] images, int imageCount);
        bool LoadCharucoBoardConfig(MasterPathStruct[] masterPaths, int configCount);
        bool LoadMasterImage(MasterPathStruct[] masterPaths, int configCount);
        bool InitializeMaster();
        bool ShowCharuco();
        bool PoseAdjustment2D(ImageStruct[] images, int imageCount);
        bool PoseAdjustmentCargoBox2D(ImageStruct[] images, int imageCount);
        bool LoadTransformationMatrix(TCP masterScanPose, TCP masterInstallPose, TCP leftCameraTcp, TCP rightCameraTcp);
    }
}