using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    public partial class Form_Property : CCWin.CCSkinMain
    {
        public PictureProperty pictureProperty;

        public Form_Property()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowDrawIcon = false;

        }

        public Form_Property(PictureProperty pictureProperty)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowDrawIcon = false;

            this.pictureProperty = pictureProperty;

            picBoxImg.SizeMode = pictureProperty.Id < 256 ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.AutoSize;
            picBoxImg.Image = pictureProperty.Image;
            label_id.Text = pictureProperty.IdShowStr;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
