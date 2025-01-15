using CoPick;
using CoPick.Plc;
using CoPick.Logging;
using loadingBox2dGui.models;
using loadingBox2dGui.views;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace loadingBox2dGui.OMM
{
    public partial class OfflineMainForm : MaterialForm, IOfflineCargoBox2DView
    {
        private static readonly LogHelper Logger = LogHelper.Logger;
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;
        public OfflineMainForm()
        {
            InitializeComponent();
            _materialSkinManager.AddFormToManage(this);
            Logger.RtbLog = rtbLog;
            Logger.MaxLine = 1000;
            this.ApplyFont();
        }

        public int CarType
        {
            get => cmbCarType_.InvokeIfNeeded(() => (int)cmbCarType_.SelectedValue);
            set => cmbCarType_.InvokeIfNeeded(() => cmbCarType_.SelectedValue = value);
        }
        public string ConfigPath
        {
            set
            {
                tbConfigFilePath_.InvokeIfNeeded(() => tbConfigFilePath_.Text = value);
            }
        }

        public int EngineVerbosityLogLvl
        {
            get => tbVerbosityLogLvl_.InvokeIfNeeded(() => int.Parse(tbVerbosityLogLvl_.Text));
            set => tbVerbosityLogLvl_.InvokeIfNeeded(() => tbVerbosityLogLvl_.Text = value.ToString());
        }

        public int EngineVerbosityImgLvl
        {
            get => tbVerbosityImgLvl_.InvokeIfNeeded(() => int.Parse(tbVerbosityImgLvl_.Text));
            set => tbVerbosityImgLvl_.InvokeIfNeeded(() => tbVerbosityImgLvl_.Text = value.ToString());
        }

        public event EventHandler OfflineFormReady;
        public event EventHandler ShowSettingManagerRequested;
        public event EventHandler<FormClosingEventArgs> OfflineFormCloseRequested;
        public event EventHandler<DataPathChangeEventArgs> CheckModelImageRequested;
        public event EventHandler CarTypeChangeRequested;
        public event EventHandler SetEngineVerbosity;
        public event EventHandler<DataPathChangeEventArgs> LoadModelFromPathRequested;
        public event EventHandler<DataPathChangeEventArgs> LoadConfigFromPathRequested;
        public event EventHandler<DataPathChangeEventArgs> ModelFilesFromPathRequested;
        public event EventHandler<DataPathChangeEventArgs> ModelSourceImageFromPathRequested;
        public event EventHandler<DataPathChangeEventArgs> InspectionRecordFromPathRequested;
        public event EventHandler<string[]> OfflineImageAlignmentRequested;

        public void SetCarTypeList(BindingList<CarTypeAndName> carTypeList, int selectedCarType = -1)
        {
            cmbCarType_.InvokeIfNeeded(() =>
            {
                cmbCarType_.DisplayMember = "CarName";
                cmbCarType_.ValueMember = "CarType";
                cmbCarType_.DataSource = carTypeList;
                if (selectedCarType != -1 && carTypeList.Any(c => c.CarType == selectedCarType))
                {
                    cmbCarType_.SelectedValue = selectedCarType;
                }
            });
        }
        public void DisplayVisionResult(VisionStatus visionStatus)
        {
            this.BeginInvokeIfNeeded(() =>
            {
                switch (visionStatus)
                {
                    case VisionStatus.OK:
                        pbResult.Image = Properties.Resources.visionOKOn;
                        break;

                    case VisionStatus.NG:
                        pbResult.Image = Properties.Resources.visionNGOn;
                        break;

                    case VisionStatus.NONE:
                        pbResult.Image = null;
                        break;
                }
            });
        }
        public void SetInspectionImage(InspectionLocation location, Image image)
        {
            if (location == InspectionLocation.LH)
            {
                pbLh.InvokeIfNeeded(() =>
                {
                    if (pbLh.Image != null)
                    {
                        pbLh.Image?.Dispose();
                        pbLh.Image = null;
                    }
                    pbLh.Image = image;
                });
            }
            else if (location == InspectionLocation.RH)
            {
                pbRh.InvokeIfNeeded(() =>
                {
                    if (pbRh.Image != null)
                    {
                        pbRh.Image?.Dispose();
                        pbRh.Image = null;
                    }
                    pbRh.Image = image;
                });
            }
            else { }
        }
        public void SetModelInferredImage(Image image)
        {
            pbModel.InvokeIfNeeded(() =>
            {
                if (pbModel.Image != null)
                {
                    pbModel.Image?.Dispose();
                    pbModel.Image = null;
                }
                pbModel.Image = image;
            });
        }
        public void SetModelPerformance(float confidenceScore, int detectedRefHoleCount)
        {
            this.InvokeIfNeeded(() =>
            {
                tbDetectedRefHoleCount_.Text = detectedRefHoleCount.ToString();
                tbConfidenceScore_.Text = confidenceScore.ToString();
            });
        }
        public void SetCalculatedShiftValue(double Tx, double Ty, double Rz)
        {
            this.InvokeIfNeeded(() =>
            {
                tbShiftTx.Text = Tx.ToString("F3");
                tbShiftTy.Text = Ty.ToString("F3");
                tbShiftRz.Text = Rz.ToString("F3");
            });
        }
        public void SetAlignmentModelPerformance(float confidenceScore, float absRefSizeDiff, int detectedRefHoleCount)
        {
            this.InvokeIfNeeded(() =>
            {
                tbAlignerMinConfidenceScore_.Text = confidenceScore.ToString();
                tbAlignerMaxAbsRefSizeDiff_.Text = absRefSizeDiff.ToString();
                tbAlignerMaxDetectedRefHoleCount_.Text = detectedRefHoleCount.ToString();
            });
        }
        public void SetModelSourceImagesList(List<RetrievedFile> sourceImageFilePaths)
        {
            lvOfflineSourceImages_.InvokeIfNeeded(() =>
            {
                lvOfflineSourceImages_.Items.Clear();
                foreach (var path in sourceImageFilePaths)
                {
                    var item = new ListViewItem(path.FileName)
                    {
                        Tag = path.FileFullPath
                    };
                    lvOfflineSourceImages_.Items.Add(item);
                }
            });
        }
        public void SetModelList(BindingList<RetrievedFile> modelList, string selectedModel = "")
        {
            cmbModelSelection_.InvokeIfNeeded(() =>
            {
                cmbModelSelection_.DisplayMember = "FileName";
                cmbModelSelection_.ValueMember = "FileFullPath";
                cmbModelSelection_.DataSource = modelList;
                if (!string.IsNullOrEmpty(selectedModel) && modelList.Any(m => m.FileFullPath == selectedModel))
                {
                    cmbModelSelection_.SelectedValue = selectedModel;
                }
                else
                {
                    cmbModelSelection_.SelectedIndex = -1;
                }
            });
        }

        private void btnSetConfigPath__Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.FileName = Path.GetFullPath(tbConfigFilePath_.Text);
            }
            catch { }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbConfigFilePath_.Text = openFileDialog.FileName;
                LoadConfigFromPathRequested?.Invoke(this, new DataPathChangeEventArgs(openFileDialog.FileName));
            }
        }

        private void cmbCarType__SelectedIndexChanged(object sender, EventArgs e)
        {
            CarTypeChangeRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnSetOfflineImageRootPath_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.SelectedPath = Path.GetFullPath("C:\\Data");
            }
            catch { }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                InspectionRecordFromPathRequested?.Invoke(this, new DataPathChangeEventArgs(folderBrowserDialog.SelectedPath));
            }
        }

        private void dgvOfflineInspectionRecordPaths_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvOfflineInspectionRecordPaths_.ColumnCount == 0)
            {
                return;
            }

            dgvOfflineInspectionRecordPaths_.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOfflineInspectionRecordPaths_.Columns["DirectoryName"].Visible = true;
            dgvOfflineInspectionRecordPaths_.Columns["LhImagePath"].Visible = false;
            dgvOfflineInspectionRecordPaths_.Columns["RhImagePath"].Visible = false;
            dgvOfflineInspectionRecordPaths_.Columns["HasLhImagePath"].Visible = true;
            dgvOfflineInspectionRecordPaths_.Columns["HasRhImagePath"].Visible = true;

            dgvOfflineInspectionRecordPaths_.Columns["DirectoryName"].HeaderText = "Directory Name";
            dgvOfflineInspectionRecordPaths_.Columns["HasLhImagePath"].HeaderText = "LH Image";
            dgvOfflineInspectionRecordPaths_.Columns["HasRhImagePath"].HeaderText = "RH Image";

            dgvOfflineInspectionRecordPaths_.Columns["DirectoryName"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOfflineInspectionRecordPaths_.Columns["DirectoryName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOfflineInspectionRecordPaths_.Columns["HasLhImagePath"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOfflineInspectionRecordPaths_.Columns["HasLhImagePath"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOfflineInspectionRecordPaths_.Columns["HasRhImagePath"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOfflineInspectionRecordPaths_.Columns["HasRhImagePath"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow row in dgvOfflineInspectionRecordPaths_.Rows)
            {
                bool hasLhImage = Convert.ToBoolean(row.Cells["HasLhImagePath"].Value);
                bool hasRhImage = Convert.ToBoolean(row.Cells["HasRhImagePath"].Value);

                row.Cells["HasLhImagePath"].Style.BackColor = hasLhImage ? Color.Green : Color.Red;
                row.Cells["HasRhImagePath"].Style.BackColor = hasRhImage ? Color.Green : Color.Red;
            }
        }

        private void dgvOfflineInspectionRecordPaths_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RequestOfflineAlignmentCalculation();
        }

        private void dgvOfflineInspectionRecordPaths_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RequestOfflineAlignmentCalculation();
            }
        }

        private void RequestOfflineAlignmentCalculation()
        {
            if (dgvOfflineInspectionRecordPaths_.ColumnCount == 0)
            {
                return;
            }

            var lhImagePath = dgvOfflineInspectionRecordPaths_.SelectedRows[0].Cells["LhImagePath"].Value?.ToString();
            var rhImagePath = dgvOfflineInspectionRecordPaths_.SelectedRows[0].Cells["RhImagePath"].Value?.ToString();
            OfflineImageAlignmentRequested?.Invoke(this, new string[] {lhImagePath, rhImagePath});
        }

        public void SetOfflineImagesOnDataGrid(BindingSource bindingSource)
        {
            dgvOfflineInspectionRecordPaths_.InvokeIfNeeded(() =>
            {
                dgvOfflineInspectionRecordPaths_.DataSource = bindingSource;
            });
        }

        private void OfflineMainForm_Load(object sender, EventArgs e)
        {
            OfflineFormReady?.Invoke(this, EventArgs.Empty);
        }

        private void OfflineMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OfflineFormCloseRequested?.Invoke(this, e);
        }

        private void cmbModelSelection__SelectedIndexChanged(object sender, EventArgs e)
        {
            string modelFilePath = cmbModelSelection_.SelectedValue?.ToString();
            LoadModelFromPathRequested?.Invoke(this, new DataPathChangeEventArgs(modelFilePath));
        }

        private void btnSetEngineVerbosity__Click(object sender, EventArgs e)
        {
            SetEngineVerbosity?.Invoke(this, EventArgs.Empty);
        }

        private void lvOfflineSourceImages__SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOfflineSourceImages_.SelectedItems.Count == 0)
            {
                return;
            }
            string sourceImagePath = lvOfflineSourceImages_.SelectedItems[0].Tag.ToString();
            CheckModelImageRequested?.Invoke(this, new DataPathChangeEventArgs(sourceImagePath));
        }

        private void btnSettingManage__Click(object sender, EventArgs e)
        {
            ShowSettingManagerRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnSetModelPath__Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.SelectedPath = Path.GetFullPath("C:\\Data\\ShiftModel");
            }
            catch { }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ModelFilesFromPathRequested?.Invoke(this, new DataPathChangeEventArgs(folderBrowserDialog.SelectedPath));
            }
        }

        private void btnSetOfflineRootPath__Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog.SelectedPath = Path.GetFullPath("C:\\Data");
            }
            catch { }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbOfflineSourceImageRootPath_.Text = folderBrowserDialog.SelectedPath;
                ModelSourceImageFromPathRequested?.Invoke(this, new DataPathChangeEventArgs(folderBrowserDialog.SelectedPath));
            }
        }

        private void dgvOfflineInspectionRecordPaths__CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RequestOfflineAlignmentCalculation();
        }
    }
}