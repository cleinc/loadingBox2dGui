using CoPick;
using CoPick.Logging;
using CoPick.Plc.Setting;
using CoPick.Setting;
using CoPick.Robot.Setting;
using loadingBox2dGui.views;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using loadingBox2dGui.models;
using System.Linq;

namespace loadingBox2dGui
{
    public partial class CargoBox2DSettingManagerForm_ : MaterialForm, ISettingManagerView
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;

        private System.Windows.Forms.Timer _factorySettingTimer;
        private bool _needCheckLogPath;
        private int _beforeSettingManagerTabIndex = 0;
        private bool _isInvalidValue;
        private OperationMode _mode;

        public bool IsFactoryResetPossible
        {
            set => btnFactoryReset_.InvokeIfNeeded(() => btnFactoryReset_.Enabled = value);
        }

        public LogLevel FileLogLevel
        {
            set => cmbFileLogLev.InvokeIfNeeded(() => cmbFileLogLev.SelectedItem = value);
            get => cmbFileLogLev.InvokeIfNeeded(() => (LogLevel)cmbFileLogLev.SelectedItem);
        }

        public LogLevel UiLogLevel
        {
            set => cmbUiLogLev.InvokeIfNeeded(() => cmbUiLogLev.SelectedItem = value);
            get => cmbUiLogLev.InvokeIfNeeded(() => (LogLevel)cmbUiLogLev.SelectedItem);
        }

        public object TaskPropertyGridDataSource
        {
            set
            {
                taskGrid.BeginInvokeIfNeeded(() =>
                {
                    taskGrid.SelectedObject = value;
                });
            }
        }

        public DialogResult SettingManagerResult
        {
            get => DialogResult;
            set => DialogResult = value;
        }

        public string ScheduleValues { get; set; }

        public string Robot
        {
            get => cmbRobot_.InvokeIfNeeded(() =>
            {
                return cmbRobot_.SelectedItem.ToString();
            });
            set => cmbRobot_.InvokeIfNeeded(() => cmbRobot_.SelectedItem = value);
        }
        public void ShowSettingManager(bool isBlocking)
        {
            this.BeginInvokeIfNeeded(() =>
            {
                if (isBlocking)
                {
                    _mode = OperationMode.Manual;
                    ShowDialog();
                }
                else
                {
                    _mode = OperationMode.Auto;
                    WindowState = FormWindowState.Normal;
                    Show();
                    Activate();
                }
            });
        }

        public CargoBox2DSettingManagerForm_(IRobotSettingManagerView robotSettingManagerView, 
                                                    IPlcSettingManagerView plcSettingManagerView, 
                                                    ILightSettingManagerView lightSettingManagerView, 
                                                    ICamera2DSettingManagerView camera2DSettingManageView)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this, true);

            SettingManagerTabControl.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            RobotConfig_.Controls.Add((Control)robotSettingManagerView);
            PlcConfigs_.Controls.Add((Control)plcSettingManagerView);
            LightConfigs_.Controls.Add((Control)lightSettingManagerView);
            Cam2DConfigs_.Controls.Add((Control)camera2DSettingManageView);
            this.ApplyFont();
        }
        
        #region - VerticalTab Design
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color.White);
            Brush _textBrush;
            Brush _selectBrush;
            int count = SettingManagerTabControl.TabCount;

            // Get the item from the collection.
            TabPage _tabPage = SettingManagerTabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = SettingManagerTabControl.GetTabRect(e.Index);
            if (e.State == DrawItemState.Selected)
            {
                _selectBrush = new SolidBrush(Color.FromArgb(255, 208, 65));

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(_selectBrush, e.Bounds);
            }
            else
            {
                _selectBrush = new SolidBrush(Color.FromArgb(243, 243, 243));
                _textBrush = new SolidBrush(Color.FromArgb(90, 90, 90));
                e.Graphics.FillRectangle(_selectBrush, e.Bounds);
            }

            // Use our own font.
            var _tabFont = new Font(FontManager.CustomFont ?? new FontFamily("Consolas"), 13.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));

            g.FillRectangle(b, new Rectangle(SettingManagerTabControl.ItemSize.Height + 2, 0, Size.Width, Size.Height));
            g.FillRectangle(b, new Rectangle(0, 0, SettingManagerTabControl.ItemSize.Height + 1, 2));
            g.FillRectangle(b, new Rectangle(0, SettingManagerTabControl.ItemSize.Width * count + 2, SettingManagerTabControl.ItemSize.Height + 2, Size.Height - SettingManagerTabControl.ItemSize.Width * count));
        }
        #endregion
        #region - Event Handlers
        public event EventHandler CarTypeAddRequested;
        public event EventHandler CarTypeRemoveRequested;
        public event EventHandler CarTypeCopyRequested;
        public event EventHandler PlcChanged;
        public event EventHandler CameraChanged;
        public event EventHandler LightChanged;
        public event EventHandler LanguageChanged;
        public event EventHandler ConfiguringCarTypeChanged;
        public event EventHandler<SettingChangedEventArgs> SettingChanged;
        public event EventHandler FileLogLevelChanged;
        public event EventHandler UiLogLevelChanged;

        public event EventHandler FactoryResetAsked;
        public event EventHandler LogPathChanged;
        public event EventHandler FactorySettingSaveAsked;
        public event EventHandler EndRequested;
        public event EventHandler SearchModelPathRequested;
        public event EventHandler SearchRoiPathRequested;
        public event EventHandler SearchImageFolderPathRequested;
        public event EventHandler SelectOtherTabPageRequested;
        public event EventHandler SaveSourceImageRequested;

        public event EventHandler SaveResultImageRequested;
        public event EventHandler ConfiguringCarTypeInSectionTabChanged;

        public event EventHandler FlipCameraHorizontalRequested;
        public event EventHandler FlipCameraVerticalRequested;

        public event EventHandler PassAllSectionRequested;
        public event EventHandler ChangePasswordRequested;
        public event EventHandler SettingTabExitRequested;
        public event EventHandler SettingTabEnterRequested;
        public event EventHandler PassValueChangeRequested;
        public event EventHandler PaintSectionRequested;
        public event EventHandler DailyProdResetTimeChangeRequested;
        public event EventHandler<ModelSettingPathChangeEventArgs> ModelSettingPathChangeRequested;
        public event EventHandler RobotChanged;
        public event EventHandler CameraMaxScanTimeChanged;
        public event EventHandler LogManagerArgsRegisterAsked;
        public event EventHandler LogManagerArgsDeleteAsked;
        public event EventHandler UpdateMasterDataRequested;
        public event EventHandler<SettingTabChangeEventArgs> SettingTabChangeRequested;
        #endregion

        private void CargoBox2DSettingManagerForm_Load(object sender, EventArgs e)
        {
            taskGrid.InvokeIfNeeded(() => taskGrid.MoveSplitter(240));
        }

        private bool ValidateDoubleValue(string value)
        {
            return Regex.IsMatch(value, "^[+-]?\\d*(?:\\.\\d*)?$");
        }

        private bool ValidateIntValue(string value)
        {
            return Regex.IsMatch(value, "^[+-]?\\d*$");
        }

        private bool ValidateByteValue(string value)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return Regex.IsMatch(value, pattern);
        }

        public void SetUiForAutoMode()
        {
            this.InvokeIfNeeded(() => 
            { 
                cmbPlc.Enabled = false;
                cmbLight.Enabled = false;
                cmbCamera.Enabled = false;
                cmbRobot_.Enabled = false;
                taskGrid.Enabled = false;
            });
            _factorySettingTimer = null;
        }
        public void SetUiForManualMode()
        {
            this.InvokeIfNeeded(() => 
            { 
                cmbPlc.Enabled = true;
                cmbCamera.Enabled = true;
                cmbRobot_.Enabled = true;
                cmbLight.Enabled = true;
                taskGrid.Enabled = true;
            });
            _factorySettingTimer = null;
        }

        public void SetUiForSetMode()
        {
            this.InvokeIfNeeded(() => 
            { 
                cmbPlc.Enabled = true;
                cmbCamera.Enabled = true;
                cmbRobot_.Enabled = true;
                cmbLight.Enabled = true;
                taskGrid.Enabled = true;
            });
            SetFactorySettingsTimer();
        }

        private void SetFactorySettingsTimer()
        {
            _factorySettingTimer = new System.Windows.Forms.Timer();
            _factorySettingTimer.Interval = 3000;
            _factorySettingTimer.Tick += (s, e) =>
            {
                _factorySettingTimer.Stop();
                FactorySettingSaveAsked?.Invoke(this, EventArgs.Empty);
            };
        }

        private void CargoBox2DSettingManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isInvalidValue)
            {
                if (_mode != OperationMode.Auto)
                {
                    MessageBox.Show("INVLID INPUT! please check data type.");
                }
                e.Cancel = true;
                return;
            }

            if (_needCheckLogPath)
            {
                _needCheckLogPath = false;
                LogPathChanged?.Invoke(this, EventArgs.Empty);
            }

            EndRequested?.Invoke(this, EventArgs.Empty);
        }

        public void SetRobotList(List<string> robotList, string selectedRobot = null)
        {
            cmbRobot_.InvokeIfNeeded(() =>
            {
                cmbRobot_.DataSource = robotList;
                if (selectedRobot == null)
                {
                    cmbRobot_.SelectedItem = -1;
                }
                else if (robotList.Contains(selectedRobot))
                {
                    cmbRobot_.SelectedItem = selectedRobot;
                }
            });
        }
        public DialogResult ShowMessageBox(string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return this.InvokeIfNeeded(() => MessageBox.Show(message, title, buttons, icon));
        }

        private async void Logging__Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //try
            //{
            //    ScheduleValues = await TaskSchedulerManager.CheckAlreadyRegisteredAsync();
            //    SetScheduleValues();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        private void SetScheduleValues()
        {
            Invoke(new MethodInvoker(() =>
            {
                if (!string.IsNullOrEmpty(ScheduleValues))
                {
                    btnDeleteSchedule_.Enabled = true;
                    string[] values = new Regex(@"[ ](?=(?:[^""]*""[^""]*"")*[^""]*$)").Split(ScheduleValues);
                    numericLogPeriodCount.Text = values[3];
                    numericImgPeriodCount.Text = values[5];
                    numericCsvPeriodCount.Text = values[7];
                    dtpScheduleStartTime.Value = DateTime.ParseExact(values[8], "HH:mm", Thread.CurrentThread.CurrentCulture);
                }
                else
                {
                    btnDeleteSchedule_.Enabled = false;
                    numericLogPeriodCount.Text = "0";
                    numericImgPeriodCount.Text = "0";
                    numericCsvPeriodCount.Text = "0";
                    dtpScheduleStartTime.Value = DateTime.Today;
                }
            }));
        }

        private async void btnRegisterSchedule__Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    btnDeleteSchedule_.Enabled = false;
            //    btnRegisterSchedule_.Enabled = false;

            //    string editedLogPath = tbLogPath.Text.Contains(" ") ? $"\"{tbLogPath.Text}\"" : tbLogPath.Text;
            //    ScheduleValues = $"no_zip {Path.GetFullPath(editedLogPath)} " +
            //        $"0 {numericLogPeriodCount.Value} " +
            //        $"0 {numericImgPeriodCount.Value} " +
            //        $"0 {numericCsvPeriodCount.Value} " +
            //        $"{dtpScheduleStartTime.Value:HH:mm}";
            //    await TaskSchedulerManager.AddDailyTaskScheduleAsync("no_zip", Path.GetFullPath(Path.Combine(Application.StartupPath, "LogManager.exe")), Path.GetFullPath(editedLogPath),
            //        0, Convert.ToInt32(numericLogPeriodCount.Value),
            //        0, Convert.ToInt32(numericImgPeriodCount.Value),
            //        0, Convert.ToInt32(numericCsvPeriodCount.Value),
            //        dtpScheduleStartTime.Value);
            //}
            //catch (Exception ex)
            //{
            //   Logger.Debug(ex.ToString());
            //}
            //finally
            //{
            //    btnDeleteSchedule_.Enabled = true;
            //    btnRegisterSchedule_.Enabled = true;
            //}
        }

        private void btnDeleteSchedule__Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //ScheduleValues = "";
            //TaskSchedulerManager.DeleteTaskSchedule();
            //SetScheduleValues();
        }

        public int ConfiguringCarType
        {
            get => cmbCarType.InvokeIfNeeded(() =>
            {
                if (cmbCarType.SelectedValue == null)
                {
                    return -1;
                }
                else
                {
                    return (int)cmbCarType.SelectedValue;
                }
            }
            );
            set => cmbCarType.InvokeIfNeeded(() => cmbCarType.SelectedValue = value);
        }

        public string Plc
        {
            get
            {
                return cmbPlc.InvokeIfNeeded(() =>
                {
                    return cmbPlc.SelectedItem.ToString();
                });
            }

            set => cmbPlc.InvokeIfNeeded(() => cmbPlc.SelectedItem = value);
        }


        public string Camera
        {
            get => cmbCamera.InvokeIfNeeded(() =>
            {
                return cmbCamera.SelectedItem.ToString();
            });
            set => cmbCamera.InvokeIfNeeded(() => cmbCamera.SelectedItem = value);
        }

        public string Light
        {
            get => cmbLight.InvokeIfNeeded(() =>
            {
                return cmbLight.SelectedItem.ToString();
            });
            set => cmbLight.InvokeIfNeeded(() => cmbLight.SelectedItem = value);
        }

        public string SelectedLanguage
        {
            get => cmbLanguage.InvokeIfNeeded(() => cmbLanguage.SelectedItem.ToString());
            set => cmbLanguage.InvokeIfNeeded(() => cmbLanguage.SelectedItem = value);
        }

        public string LogPath
        {
            get => tbLogPath.InvokeIfNeeded(() => tbLogPath.Text);
            set => tbLogPath.InvokeIfNeeded(() => tbLogPath.Text = value);
        }

        public bool IsControlDisposed
        {
            get => IsDisposed;
        }

        public string ShiftModelPath
        {
            get => tbModelPath.InvokeIfNeeded(() => tbModelPath.Text);
            set => tbModelPath.InvokeIfNeeded(() => tbModelPath.Text = value);
        }
        public string CheckerBoardImageRootFolderPath
        {
            get => tbCheckerBoardRootPath.InvokeIfNeeded(() => tbCheckerBoardRootPath.Text);
            set => tbCheckerBoardRootPath.InvokeIfNeeded(() => tbCheckerBoardRootPath.Text = value);
        }
        public string MasterImageRootFolderPath
        {
            get => tbMasterImageRootPath.InvokeIfNeeded(() => tbMasterImageRootPath.Text);
            set => tbMasterImageRootPath.InvokeIfNeeded(() => tbMasterImageRootPath.Text = value);
        }

        public string CalibrationDataRootFolderPath
        {
            get => tbCalibrationRootFolderPath.InvokeIfNeeded(() => tbCalibrationRootFolderPath.Text);
            set => tbCalibrationRootFolderPath.InvokeIfNeeded(() => tbCalibrationRootFolderPath.Text = value);
        }
        public string CameraTcpDataRootFolderPath
        {
            get => tbCameraTcpRootFolderPath.InvokeIfNeeded(() => tbCameraTcpRootFolderPath.Text);
            set => tbCameraTcpRootFolderPath.InvokeIfNeeded(() => tbCameraTcpRootFolderPath.Text = value);
        }
        public long CameraMaxScanTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CanLogManagerScheduleBeDeleted { set => throw new NotImplementedException(); }

        public DateTime LogManagerScheduleStartTime => throw new NotImplementedException();

        public int LogPeriodCount => throw new NotImplementedException();

        public int ImgPeriodCount => throw new NotImplementedException();

        public int CsvPeriodCount => throw new NotImplementedException();

        public void ResetInvalidValue(PropertyDescriptor propertyDescriptor, object component, object value, string msg)
        {
            this.InvokeIfNeeded(() =>
            {
                MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                propertyDescriptor.SetValue(component ?? taskGrid.SelectedObject, value);
                SendKeys.Send("{TAB}");
            });
        }

        private void taskGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            SettingChanged?.Invoke(this, new SettingChangedEventArgs(e.ChangedItem.PropertyDescriptor,
                                                                      e.OldValue, e.ChangedItem.Value,
                                                                      e.ChangedItem.Parent.Value,
                                                                      e.ChangedItem.Label,
                                                                      e.ChangedItem.Parent.Label));
        }
        public void RefreshTaskGrid()
        {
            taskGrid.InvokeIfNeeded(() => taskGrid.Refresh());
        }

        public void Localize()
        {
            //throw new NotImplementedException();
            //this.BeginInvokeIfNeeded(() => this.Translate(Lang.Primer.ResourceManager));
        }

        public void SetCarTypeList(BindingList<int> carTypeList, int selectedCarType = -1)
        {
            cmbCarType.InvokeIfNeeded(() =>
            {
                cmbCarType.DataSource = carTypeList;
                if (selectedCarType != -1 && carTypeList.Contains(selectedCarType))
                {
                    cmbCarType.SelectedItem = selectedCarType;
                }
            });
        }


        public void SetPlcList(List<string> plcList, string selectedPlc)
        {
            cmbPlc.InvokeIfNeeded(() =>
            {
                cmbPlc.DataSource = plcList;
                if (plcList.Contains(selectedPlc))
                {
                    cmbPlc.SelectedItem = selectedPlc;
                }
            });
        }

        public void SetCameraList(List<string> cameraList, string selectedCamera)
        {
            cmbCamera.InvokeIfNeeded(() =>
            {
                cmbCamera.DataSource = cameraList;
                if (cameraList.Contains(selectedCamera))
                {
                    cmbCamera.SelectedItem = selectedCamera;
                }
            });
        }

        public void SetLightList(List<string> lightList, string selectedLight)
        {
            cmbLight.InvokeIfNeeded(() =>
            {
                cmbLight.DataSource = lightList;
                if (lightList.Contains(selectedLight))
                {
                    cmbLight.SelectedItem = selectedLight;
                }
            });
        }

        public void SetFileLogLevelList(Array LogLevels, LogLevel selectedLevel)
        {
            cmbFileLogLev.InvokeIfNeeded(() =>
            {
                cmbFileLogLev.DataSource = LogLevels;
                cmbFileLogLev.SelectedItem = selectedLevel;
            });
        }

        public void SetUiLogLevelList(Array LogLevels, LogLevel selectedLevel)
        {
            cmbUiLogLev.InvokeIfNeeded(() =>
            {
                cmbUiLogLev.DataSource = LogLevels;
                cmbUiLogLev.SelectedItem = selectedLevel;
            });
        }

        public void SetSupportedLanguageList(List<string> languageList, string selectedLanguage = null)
        {
            cmbLanguage.InvokeIfNeeded(() =>
            {
                cmbLanguage.DataSource = languageList;
                if (selectedLanguage != null && languageList.Contains(selectedLanguage))
                {
                    cmbLanguage.SelectedItem = selectedLanguage;
                }
            });
        }

        private void cmbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCarType.Text = cmbCarType.SelectedValue.ToString();
            ConfiguringCarTypeChanged?.Invoke(this, EventArgs.Empty);
        }

        private void cmbFileLogLev_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileLogLevelChanged?.Invoke(this, EventArgs.Empty);
        }

        private void cmbUiLogLev_SelectedIndexChanged(object sender, EventArgs e)
        {
            UiLogLevelChanged?.Invoke(this, EventArgs.Empty);
        }

        private void cmbPlc_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlcChanged?.Invoke(this, EventArgs.Empty);
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnAddCarType__Click(object sender, EventArgs e)
        {
            CarTypeAddRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnRemoveCarType__Click(object sender, EventArgs e)
        {
            CarTypeRemoveRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnCopyCarType__Click(object sender, EventArgs e)
        {
            CarTypeCopyRequested?.Invoke(this, EventArgs.Empty);
        }

        private void tbLogPath_Enter(object sender, EventArgs e)
        {
            _needCheckLogPath = true;
        }

        private void tbLogPath_Leave(object sender, EventArgs e)
        {
            _needCheckLogPath = false;
            LogPathChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogPath_Click(object sender, EventArgs e)
        {
            this.InvokeIfNeeded(() =>
            {
                try
                {
                    folderBrowserDialog.SelectedPath = Path.GetFullPath(tbLogPath.Text);
                }
                catch
                {
                }

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    tbLogPath.Text = folderBrowserDialog.SelectedPath;
                    LogPathChanged.Invoke(this, EventArgs.Empty);
                }
            });
        }

        private void btnFactoryReset__Click(object sender, EventArgs e)
        {
            FactoryResetAsked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSaveFactorySettings_MouseDown(object sender, MouseEventArgs e)
        {
            _factorySettingTimer?.Start();
        }

        private void btnSaveFactorySettings_MouseUp(object sender, MouseEventArgs e)
        {
            _factorySettingTimer?.Stop();
        }

        private void btnModelPath__Click(object sender, EventArgs e)
        {
            try
            {
                fileBrowserDialog.FileName = Path.GetFullPath(tbModelPath.Text);
            }
            catch(Exception) { }

            if (fileBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (tbModelPath.Text != fileBrowserDialog.FileName)
                {
                    ModelSettingPathChangeRequested?.Invoke(sender, new ModelSettingPathChangeEventArgs(ModelPathType.ShiftModelFilePath, fileBrowserDialog.FileName.Replace('\\', '/')));
                }
            }
        }

        private void btnImageFolderPath__Click(object sender, EventArgs e)
        {
            SearchImageFolderPathRequested?.Invoke(this, EventArgs.Empty);
        }

        private void cmbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraChanged?.Invoke(this, EventArgs.Empty);
        }

        private void cmbLight_SelectedIndexChanged(object sender, EventArgs e)
        {
            LightChanged?.Invoke(this, EventArgs.Empty);
        }

        private void SettingManagerTabControl_Selected(object sender, TabControlEventArgs e)
        {
            SelectOtherTabPageRequested?.Invoke(this, EventArgs.Empty);
        }

        private void cbSaveSourceImage__CheckedChanged(object sender, EventArgs e)
        {
            SaveSourceImageRequested?.Invoke(this, EventArgs.Empty);
        }

        private void cbSaveResultFlag__CheckedChanged(object sender, EventArgs e)
        {
            SaveResultImageRequested?.Invoke(this, EventArgs.Empty);
        }
        public void SetFont()
        {
            this.InvokeIfNeeded(() => this.ApplyFont());
        }

        private void checkboxFlipHorizontal__CheckedChanged(object sender, EventArgs e)
        {
            FlipCameraHorizontalRequested?.Invoke(sender, e);
        }

        private void checkBoxFlipVertical__CheckedChanged(object sender, EventArgs e)
        {
            FlipCameraVerticalRequested?.Invoke(sender, e);
        }

        private void btnChangePassword__Click(object sender, EventArgs e)
        {
            ChangePasswordRequested?.Invoke(sender, e);
        }

        private void checkBoxAllSectionPassed__CheckedChanged(object sender, EventArgs e)
        {
            PassAllSectionRequested?.Invoke(sender, e);
        }

        private void dataGridViewSection_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            _isInvalidValue = true;
            MessageBox.Show("INVALID INPUT! Please check data type.");
        }

        private void PasteDataFromClipboard(DataGridView dgv)
        {
            try
            {
                string clipboardText = Clipboard.GetText();
                string[] rows = clipboardText.Split(new char[] { '\r', '\n' },
                                                    StringSplitOptions.RemoveEmptyEntries);

                int rowIndex = dgv.CurrentCell.RowIndex;
                int columnIndex = dgv.CurrentCell.ColumnIndex;

                foreach (string row in rows)
                {
                    string[] values = row.Split('\t');
                    for (int i = 0; i < values.Length; ++i)
                    {
                        if (dgv.Columns.Count <= columnIndex + i)
                        {
                            break;
                        }

                        dgv.Rows[rowIndex].Cells[columnIndex + i].Value = values[i];
                    }

                    rowIndex++;
                }
            }
            catch { }
        }

        private void SettingManagerTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = SettingManagerTabControl.SelectedIndex;
            if (_beforeSettingManagerTabIndex == 1 && SettingManagerTabControl.SelectedIndex != 1)
            {
                SettingTabExitRequested?.Invoke(sender, e);
            }
            if (SettingManagerTabControl.SelectedIndex == 0)
            {
                SettingTabChangeRequested?.Invoke(sender, new SettingTabChangeEventArgs((SettingTab)selectedIndex));
                this.InvokeIfNeeded(() => taskGrid.Refresh());
            }
            else if (SettingManagerTabControl.SelectedIndex == 1)
            {
                SettingTabEnterRequested?.Invoke(sender, e);
            }
            _beforeSettingManagerTabIndex = SettingManagerTabControl.SelectedIndex;
        }

        private void SettingManagerTabControl_Enter(object sender, EventArgs e)
        {
            _beforeSettingManagerTabIndex = 0;

        }

        private void dgvSectionSetting_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                PassValueChangeRequested?.Invoke(sender, e);
                PaintSectionRequested?.Invoke(this, EventArgs.Empty);
            }
        }

        private void SetRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
            dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

        public void LockLogPathButton(bool isLock)
        {
            btnLogPath.InvokeIfNeeded(() => btnLogPath.Enabled = !isLock);
        }

        private void dtpDailyProdResetTime_ValueChanged(object sender, EventArgs e)
        {
            DailyProdResetTimeChangeRequested?.Invoke(this, EventArgs.Empty);
        }

        private void dgvSectionSetting_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _isInvalidValue = false;
        }

        private void btnRoiPath_Click(object sender, EventArgs e)
        {
            SearchRoiPathRequested?.Invoke(this, EventArgs.Empty);
        }

        public void SetCarTypeList(BindingList<CarTypeAndName> carTypeList, int selectedCarType = -1)
        {
            cmbCarType.InvokeIfNeeded(() =>
            {
                cmbCarType.DisplayMember = "CarName";
                cmbCarType.ValueMember = "CarType";
                cmbCarType.DataSource = carTypeList;
                if (selectedCarType != -1 && carTypeList.Any(c => c.CarType == selectedCarType))
                {
                    cmbCarType.SelectedItem = selectedCarType;
                }
            });
        }

        public void ShowMessage(string msg, string title)
        {
            this.InvokeIfNeeded(() => MessageBox.Show(msg, title));
        }

        public bool ConfirmUserChoice(string msg, string title)
        {
            return this.InvokeIfNeeded(() =>
            {
                return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel) == DialogResult.OK;
            });
        }

        public void UpdateLogManagerScheduleToUi(int logPeriod, int imgPeriod, int csvPeriod, DateTime startDateTime)
        {
            // TODO: Implement LogManagerScheduler, consider how to manage accumulating log files and other images
        }

        private void btnUpdateMasterData__Click(object sender, EventArgs e)
        {
            UpdateMasterDataRequested?.Invoke(sender, e);
        }

        private void btnCharucoFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.SelectedPath = Path.GetFullPath(tbCheckerBoardRootPath.Text ?? "C:\\");
            }
            catch(Exception) { }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != tbCheckerBoardRootPath.Text)
                {
                    ModelSettingPathChangeRequested?.Invoke(sender, new ModelSettingPathChangeEventArgs(ModelPathType.CheckerBoardRootFolderPath, folderBrowserDialog.SelectedPath.Replace('\\', '/')));
                }
            }
        }

        private void btnMasterImageFilePath_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.SelectedPath = Path.GetFullPath(tbMasterImageRootPath.Text ?? "C:\\");
            }
            catch(Exception) { }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != tbMasterImageRootPath.Text)
                {
                    ModelSettingPathChangeRequested?.Invoke(sender, new ModelSettingPathChangeEventArgs(ModelPathType.MasterImageRootFolderPath, folderBrowserDialog.SelectedPath.Replace('\\', '/')));
                }
            }
        }

        private void btnCalibrationRootFolderPath__Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.SelectedPath = Path.GetFullPath(tbCalibrationRootFolderPath.Text ?? "C:\\");
            }
            catch(Exception) { }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != tbCalibrationRootFolderPath.Text)
                {
                    ModelSettingPathChangeRequested?.Invoke(sender, new ModelSettingPathChangeEventArgs(ModelPathType.CalibrationDataRootFolderPath, folderBrowserDialog.SelectedPath.Replace('\\', '/')));
                }
            }
        }

        private void btnCameraTcpRootFolderPath_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.SelectedPath = Path.GetFullPath(tbCameraTcpRootFolderPath.Text ?? "C:\\");
            }
            catch(Exception) { }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath != tbCameraTcpRootFolderPath.Text)
                {
                    ModelSettingPathChangeRequested?.Invoke(sender, new ModelSettingPathChangeEventArgs(ModelPathType.CameraTcpDataRootFolderPath, folderBrowserDialog.SelectedPath.Replace('\\', '/')));
                }
            }
        }

        private void cmbRobot__SelectedIndexChanged(object sender, EventArgs e)
        {
            RobotChanged?.Invoke(sender, EventArgs.Empty);
        }
    }
}
