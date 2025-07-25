using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CoPick.Logging;

namespace loadingBox2dGui.models
{
    public class LogManagerScheduler
    {
        private Regex _logManagerScheduleRegex = new Regex(@"[ ](?=(?:[^""]*""[^""]*"")*[^""]*$)", RegexOptions.Compiled);

        public string LogPath { get; set; }
        public int LogPreservePeriod { get; set; }
        public int ImgPreservePeriod { get; set; }
        public int CsvPreservePeriod { get; set; }
        public DateTime StartDateTime { get; set; }
        public bool IsUsing { get; set; } = false;

        public async Task LoadScheduleInfoFromSystemAsync()
        {
            string logManagerArgs = await TaskSchedulerManager.CheckAlreadyRegisteredAsync();

            if (string.IsNullOrEmpty(logManagerArgs))
            {
                IsUsing = false;
                return;
            }

            string[] parsedArgs = _logManagerScheduleRegex.Split(logManagerArgs);
            LogPath = parsedArgs[1];
            LogPreservePeriod = Convert.ToInt32(parsedArgs[3]);
            ImgPreservePeriod = Convert.ToInt32(parsedArgs[5]);
            CsvPreservePeriod = Convert.ToInt32(parsedArgs[7]);
            StartDateTime = DateTime.ParseExact(parsedArgs[8], "HH:mm", Thread.CurrentThread.CurrentCulture);
            IsUsing = true;
        }

        public void DeleteSchedule()
        {
            IsUsing = false;
            TaskSchedulerManager.DeleteTaskSchedule();
        }

        public Task RegisterScheduleAsync()
        {
            IsUsing = true;
            return TaskSchedulerManager.AddDailyTaskScheduleAsync("no_zip", Path.GetFullPath(@".\LogManager.exe"), LogPath,
                                                                  0, LogPreservePeriod, 0, ImgPreservePeriod, 0, CsvPreservePeriod,
                                                                  StartDateTime);
        }
    }
}
