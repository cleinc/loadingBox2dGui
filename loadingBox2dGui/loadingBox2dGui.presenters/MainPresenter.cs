using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.presenters
{
    public class MainPresenter
    {
        public MainPresenter()
        {

        }

        #region Auto Events
        #endregion

        #region Manual Events
        #endregion

        #region Methods
        private bool LoadConfig()
        {
            return true;
        }
        private bool InitializeCameraSettings()
        {
            return true;
        }
        private bool InitializeModelSettings()
        {
            return true;
        }
        private bool InitializePlc()
        {
            return true;
        }
        private bool ConnectPlc(bool isOn)
        {
            return true;
        }
        private bool ReadyCamera()
        {
            return true;
        }
        private bool ReadyModel()
        {
            return true;
        }
        private bool StartCamera()
        {
            return true;
        }
        private bool StartInspection()
        {
            return true;
        }
        private bool StopCamera()
        {
            return true;
        }
        private bool StopInspection()
        {
            return true;
        }
        private bool WriteOnPlc()
        {
            return true;
        }
        private bool SaveProductionRecord()
        {
            return true;
        }
        private bool UpdateControls(ProgramState programState)
        {
            return true;
        }
        private bool ChangeMode()
        {
            return true;
        }
        #endregion
        #region Enums
        enum ProgramState
        {

        }
        #endregion
    }
}
