using CoPick.Plc;
using loadingBox2dGui.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace loadingBox2dGui.views
{
    public interface IOfflineCargoBox2DView
    {
        int CarType { get; set; }
        string ConfigPath { set; }
        int EngineVerbosityLogLvl { get; set; }
        int EngineVerbosityImgLvl { get; set; }
        void SetCarTypeList(BindingList<CarTypeAndName> carTypeList, int selectedCarType = -1);
        void SetInspectionImage(InspectionLocation location, Image image);
        void SetModelInferredImage(Image image);
        void DisplayVisionResult(VisionStatus visionStatus);
        void SetModelList(BindingList<RetrievedFile> modelList, string selectedModel = "");
        void SetModelSourceImagesList(List<RetrievedFile> sourceImageFilePaths);
        void SetModelPerformance(float confidenceScore, int detectedRefHoleCount);
        void SetCalculatedShiftValue(double Tx, double Ty, double Rz);
        void SetAlignmentModelPerformance(float confidenceScore, float absRefSizeDiff, int detectedRefHoleCount);
        void SetOfflineImagesOnDataGrid(BindingSource bindingSource);

        event EventHandler OfflineFormReady;
        event EventHandler ShowSettingManagerRequested;
        event EventHandler<FormClosingEventArgs> OfflineFormCloseRequested;
        event EventHandler<DataPathChangeEventArgs> CheckModelImageRequested;
        event EventHandler SetEngineVerbosity;
        event EventHandler CarTypeChangeRequested;
        event EventHandler<DataPathChangeEventArgs> LoadModelFromPathRequested;
        event EventHandler<DataPathChangeEventArgs> LoadConfigFromPathRequested;
        event EventHandler<DataPathChangeEventArgs> ModelFilesFromPathRequested;
        event EventHandler<DataPathChangeEventArgs> InspectionRecordFromPathRequested;
        event EventHandler<DataPathChangeEventArgs> ModelSourceImageFromPathRequested;
        event EventHandler<string[]> OfflineImageAlignmentRequested;
    }

    public class OfflineInspectionRecordPath
    {
        public string DirectoryName { get; set; }
        public bool HasLhImagePath { get; set; }
        public bool HasRhImagePath { get; set; }
        public string LhImagePath { get; set; }
        public string RhImagePath { get; set; }
    }

    public class RetrievedFile
    {
        public string FileName { get; set; }
        public string FileFullPath { get; set; }
    }
}