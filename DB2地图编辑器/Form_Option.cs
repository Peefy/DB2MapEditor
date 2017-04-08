using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    public partial class Form_Option : CCWin.CCSkinMain
    {

        private MapPanelEditor mapEditor;

        public delegate void VoidDelegate();

        public VoidDelegate BtnOkClickHandler;

        public VoidDelegate MainWindowRefresh;

        public int SetPictureSize => (int)nmudSetPictrueSize.Value;

        public int CursorWidth => (int)umudSetCusorWidth.Value;

        public Form_Option(MapPanelEditor mapEdi)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowDrawIcon = false;

            mapEditor = mapEdi;
            this.nmudSetPictrueSize.Value = mapEditor.PictureSize;
            this.umudSetCusorWidth.Value = mapEditor.MapCusorWidth;

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            BtnOkClickHandler?.Invoke();
            this.Close();
        }

        private void nmudSetPictrueSize_ValueChanged(object sender, EventArgs e)
        {
            mapEditor.PictureSize = (int)nmudSetPictrueSize.Value;
            MainWindowRefresh?.Invoke();
        }

        private void umudSetCusorWidth_ValueChanged(object sender, EventArgs e)
        {
            mapEditor.MapCusorWidth = (int)umudSetCusorWidth.Value;
            MainWindowRefresh?.Invoke();
        }
    }
}
