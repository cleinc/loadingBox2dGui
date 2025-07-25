using CoPick.Logging;
using loadingBox2dGui.models;
using loadingBox2dGui.models.ProductionRecord;
using loadingBox2dGui.views;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace loadingBox2dGui.presenters
{
    public static class FileHelper
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        private static readonly HashSet<char> _invalidFileNameCharsSet = new HashSet<char>(Path.GetInvalidFileNameChars());
        private static readonly HashSet<char> _invalidFilePathCharsSet = new HashSet<char>(Path.GetInvalidPathChars());

        private const string _defaultRefDataPath = "C:\\Data";
        private const string _defaultOfflineConfigPath = "C:\\Data\\OfflineConfig\\OfflineConfig.yml";
        public static string GenerateMasterDataPath(DataType dataType, string rootPath = _defaultRefDataPath)
        {
            return Path.Combine(rootPath, dataType.ToString(), DateTime.Now.ToString("yyMMdd"));
        }

        public static string GenerateMasterDataPath(DataType dataType, int carType, string rootPath = _defaultRefDataPath)
        {
            return Path.Combine(rootPath, dataType.ToString(), carType.ToString(), DateTime.Now.ToString("yyMMdd"));
        }

        public static void GetScreenCaptureFullPath(string rootPath, InspectionResult result, 
            string sequenceNumber, string bodyNumber, DateTime? dateTime, 
            out string captureDirectoryPath, out string captureFileName)
        {
            string capturedDate = (dateTime ?? DateTime.Now).ToString("yyMMdd");
            string capturedTime = (dateTime ?? DateTime.Now).ToString("HHmmss");
            string directoryPath = $"{rootPath}\\Total_{result}\\{capturedDate}";
            string fileName = $"{capturedDate}_{capturedTime}";
            if (!string.IsNullOrEmpty(sequenceNumber))
            {
                fileName += $"_{sequenceNumber}";
            }
            if (!string.IsNullOrEmpty(bodyNumber))
            {
                fileName += $"_{bodyNumber}";
            }
            fileName += ".png";

            captureDirectoryPath = directoryPath;
            captureFileName = fileName;
        }

        public static void GetResultSavePath(string rootPath, InspectionResult result, 
            DateTime? dateTime, string carName, string sequenceNumber, string bodyNumber, ImageFormat imageFormat,
            out string saveDirectoryPath, out string saveFileName)
        {
            string capturedDate = (dateTime ?? DateTime.Now).ToString("yyMMdd");
            string capturedTime = (dateTime ?? DateTime.Now).ToString("HHmmss");
            string directoryPath = $"{rootPath}\\{result}\\{capturedDate}\\{carName}\\{sequenceNumber}_{bodyNumber}";
            if (!CheckFilePathValidity(directoryPath))
            {
                directoryPath = $"{rootPath}\\{result}\\{capturedDate}\\{carName}\\TEMP_{DateTime.Now:yyMMdd_HHmmss}";
            }

            string fileName = $"{capturedDate}_{capturedTime}_{result}.{imageFormat}";
            saveDirectoryPath = directoryPath;
            saveFileName = fileName;
        }

        private static bool CheckFileNamePathValidity(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                Logger.Error("File name is empty");
                return false;
            }

            if (_invalidFileNameCharsSet.Overlaps(fileName))
            {
                Logger.Error($"Invalid file name : {fileName}");
                return false;
            }

            return true;
        }   

        private static bool CheckFilePathValidity(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                Logger.Error("File path is empty");
                return false;
            }

            if (_invalidFilePathCharsSet.Overlaps(filePath))
            {
                Logger.Error($"Invalid file path : {filePath}");
                return false;
            }

            return true;
        }

        public static string GetOfflineConfigFilePath()
        {
            string path = "./configfilepath_offline.txt";
            string configFilePath;
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                if (ValidateConfigFilePath(text))
                {
                    configFilePath = Path.GetFullPath(text);
                    return configFilePath;
                }
            }

            configFilePath = Path.GetFullPath("./config_offline.yml");
            return configFilePath;
        }

        private static bool ValidateConfigFilePath(string configFilePathCandidate)
        {
            if (!string.IsNullOrWhiteSpace(Path.GetFileName(configFilePathCandidate)))
            {
                return Directory.Exists(Path.GetDirectoryName(Path.GetFullPath(configFilePathCandidate)));
            }

            return false;
        }

        public static List<OfflineInspectionRecordPath> FindInspectionImages(string sourceDirectory)
        {
            var results = new List<OfflineInspectionRecordPath>();

            var directories = Directory.GetDirectories(sourceDirectory, "*", SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                var pngFiles = Directory.GetFiles(directory, "*.png");

                if (pngFiles.Any())
                {
                    string lhImage = pngFiles.FirstOrDefault(file => Path.GetFileName(file).StartsWith("LH_"));
                    string rhImage = pngFiles.FirstOrDefault(file => Path.GetFileName(file).StartsWith("RH_"));

                    if (lhImage == null || rhImage == null)
                    {
                        Logger.Error($"Missing LH or RH image in {directory}");
                        continue;
                    }

                    results.Add(new OfflineInspectionRecordPath
                    {
                        DirectoryName = Path.GetFileName(directory),
                        HasLhImagePath = lhImage != null,
                        HasRhImagePath = rhImage != null,
                        LhImagePath = lhImage,
                        RhImagePath = rhImage
                    });
                }
            }

            return results;
        }

        public static List<RetrievedFile> RecursivelyRetrieveFiles(string sourceDirectory, string searchPattern = null)
        {
            var retrievedFiles = Directory.GetFiles(sourceDirectory, searchPattern ?? "*", SearchOption.AllDirectories);
            if (retrievedFiles.Length == 0)
            {
                Logger.Error($"No files found in {sourceDirectory}");
                return null;
            }

            var retrievedList = new List<RetrievedFile>();
            foreach (var retrievedFile in retrievedFiles)
            {
                retrievedList.Add(
                    new RetrievedFile
                    {
                        FileName = Path.GetFileName(retrievedFile),
                        FileFullPath = retrievedFile
                    });
            }
            return retrievedList;
        }
    }
}