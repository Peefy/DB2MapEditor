using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace DB2地图编辑器
{
    public partial class Form_Instructions : CCSkinMain
    {

        private string InstrutionText { get; set; } = "DB2地图编辑器说明：\r\n" +
            "\r\n" +
            "欢迎使用DB2地图编辑器!\r\n" +
            "#0 海岸主题 \r\n" +
            "#1 山地主题\r\n" +
            "#2 遗迹主题\r\n" +
            "#3 城堡主题\r\n" +
            "#4 城市主题\r\n" +
            "#5 未来城主题\r\n" +
            "#6 太空（升）主题\r\n" +
            "#7 太空（静）主题\r\n" +
            "#8 太空（降）主题\r\n" +
            "#9 异次元主题\r\n" +
            "#A 博士基地主题\r\n" +
            "\r\n" +
            "0002B5\r\n" +
            "0002C1\r\n" +
            "0002C5\r\n" +
            "0002BB\r\n" +
            "0002D7\r\n" +
            "0002B2\r\n" +
            "0002B3\r\n" +
            "000298\r\n" +
            "000299\r\n" +
            "00029A\r\n" +
            "00029B\r\n" +
            "00029C\r\n" +
            "00029D\r\n" +
            "00029C\r\n" +
            "\r\n";

        public Form_Instructions()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;
            this.DoubleBuffered = true;
            //this.ControlBox = false;
            this.ShowIcon = false;
            //this.ShowInTaskbar = false;
            //this.ShowDrawIcon = false;
            this.KeyPreview = true;
            //this.TopMost = true;

            this.TextBoxInstrution.Text = InstrutionText;

        }
    }
}
