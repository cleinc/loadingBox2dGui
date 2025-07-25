using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoPick;
using MaterialSkin.Controls;

namespace loadingBox2dGui.views
{
    public partial class NgListItemImageForm_ : MaterialForm
    {
        public NgListItemImageForm_(string filePath)
        {
            InitializeComponent();
            this.Text = filePath;
            pboxNgListItemImage.ImageLocation = filePath;
        }

        public void UpdateNgListItemImagePath(string filePath)
        {
            this.InvokeIfNeeded(() =>
            {
                pboxNgListItemImage.ImageLocation = filePath;
                Text = filePath;
                Activate();
            });
        }

        private void NgListItemImageForm__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
