using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    public partial class Form_MapIdHexShow : CCWin.CCSkinMain
    {

        MapPanelEditor MapEditor;

        public Form_MapIdHexShow(MapPanelEditor mapedi)
        {
            InitializeComponent();

            MapEditor = mapedi;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;
            this.DoubleBuffered = true;
            //this.ControlBox = false;
            //this.ShowIcon = false;
            //this.ShowInTaskbar = false;
            //this.ShowDrawIcon = false;
            this.KeyPreview = true;
            //this.TopMost = true;

        }

        public void Init()
        {
            string str = "";
            int rowNum = MapPanelEditor.RowNum;
            int total = MapPanelEditor.PictureTotal;
            for(int i =0; i < total; ++i)
            {
                if ((i + 1) % rowNum == 0)
                    str += MapEditor.Bitmapt2HexStr(MapEditor.MapIMG_Block[i]) + " " + "\r\n";
                else
                    str += MapEditor.Bitmapt2HexStr(MapEditor.MapIMG_Block[i]) + " ";
            }
            labelMapId.Text = str;
        }

    }
}
