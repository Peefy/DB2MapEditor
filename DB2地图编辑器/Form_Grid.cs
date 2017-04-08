using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    public partial class Form_Grid : CCWin.CCSkinMain
    {

        #region 变量

        public event EventHandler UpdateDataMapView = null;
        public event EventHandler SpaceKeyDown = null;

        int GridTotalLenth = MapPanelEditor.GridLenth * MapPanelEditor.RowNum;
        int WhiteLineLenthX = 11 * MapPanelEditor.GridLenth;
        int WhiteLineLenthY = 11 * MapPanelEditor.GridLenth;

        bool LinesEN = true;
        bool isGameGrid = true;
        bool isShowKuang = true;

        Point OPoint = new Point(25, 35);
        BrushBlockHelper PaintHelper;
        MapPanelEditor MapEditor;

        #endregion

        public Form_Grid()
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
            this.TopMost = true;

        }

        private void Form_Grid_Load(object sender, EventArgs e)
        {
            PaintTimer.Start();
        }

        public void Init(MapPanelEditor mapedi)
        {
            MapEditor = mapedi;
            PaintHelper = new BrushBlockHelper();
        }

        private void PaintTimer_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void Form_Grid_Paint(object sender, PaintEventArgs e)
        {
            #region 画笔画刷定义
            //Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Black);
            Pen Wp = new Pen((LinesEN == true) ? Color.White : Color.Black, 3);
            Pen Sp = new Pen(MapEditor.MapCusorColor, 2);

            #endregion
            #region 地图信息
            if(isGameGrid == false)
            {
                for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)   //方块
                {
                    int Temp = MapEditor.MapImage2Int(MapEditor.MapIMG_Block[i]);
                    e.Graphics.FillRectangle(PaintHelper.BrushBlock[MapEditor.ThemeNum][Temp], new Rectangle(OPoint.X + i % (MapPanelEditor.RowNum) * MapPanelEditor.GridLenth,
                        OPoint.Y + i / (MapPanelEditor.RowNum) * MapPanelEditor.GridLenth,
                        MapPanelEditor.GridLenth, MapPanelEditor.GridLenth));
                }
            }
            else
            {
                for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                {
                    int Temp = MapEditor.MapImage2Int(MapEditor.MapIMG_Block[i]);
                    e.Graphics.DrawImage(PaintHelper.GameGridImageList[MapEditor.ThemeNum][Temp]
       , OPoint.X + i % (MapPanelEditor.RowNum) * 9, OPoint.Y + i / (MapPanelEditor.RowNum) * 9);

                }
            }
            #region 网格线
            if (LinesEN == true)
            {
                for (int i = 0; i <= MapPanelEditor.RowNum; ++i)   //横线
                {
                    e.Graphics.DrawLine(p, OPoint.X, OPoint.Y + i * MapPanelEditor.GridLenth,
                        OPoint.X + GridTotalLenth, OPoint.Y + i * MapPanelEditor.GridLenth);
                }
                for (int i = 0; i <= MapPanelEditor.RowNum; ++i)   //竖线
                {
                    e.Graphics.DrawLine(p, OPoint.X + i * MapPanelEditor.GridLenth, OPoint.Y,
                        OPoint.X + i * MapPanelEditor.GridLenth, OPoint.Y + GridTotalLenth);
                }
            }

            #endregion
            #endregion
            #region 框框
            if(isShowKuang == true)
            {
                WhiteLineLenthX = MapEditor.Size.Width / MapEditor.PictureSize * MapPanelEditor.GridLenth;
                WhiteLineLenthY = MapEditor.Size.Height / MapEditor.PictureSize * MapPanelEditor.GridLenth;
                int Num_X = -MapEditor.MapLeft / MapEditor.PictureSize;
                int Num_Y = -MapEditor.MapTop / MapEditor.PictureSize;
                Point[] POINT = new Point[4];
                POINT[0] = new Point(Num_X * MapPanelEditor.GridLenth + OPoint.X,
                    Num_Y * MapPanelEditor.GridLenth + OPoint.Y);
                POINT[1] = new Point(Num_X * MapPanelEditor.GridLenth + OPoint.X + WhiteLineLenthX,
                    Num_Y * MapPanelEditor.GridLenth + OPoint.Y);
                POINT[2] = new Point(Num_X * MapPanelEditor.GridLenth + OPoint.X,
                    Num_Y * MapPanelEditor.GridLenth + OPoint.Y + WhiteLineLenthY);
                POINT[3] = new Point(Num_X * MapPanelEditor.GridLenth + OPoint.X + WhiteLineLenthX,
                    Num_Y * MapPanelEditor.GridLenth + OPoint.Y + WhiteLineLenthY);
                e.Graphics.DrawLine(Wp, POINT[0], POINT[1]);
                e.Graphics.DrawLine(Wp, POINT[0], POINT[2]);
                e.Graphics.DrawLine(Wp, POINT[1], POINT[3]);
                e.Graphics.DrawLine(Wp, POINT[2], POINT[3]);
            }

            #endregion
            #region 显示选中光标
            if (MapEditor.SelectedIndex != -1)
            {
                int xtemp = (MapEditor.SelectedIndex) % 40;
                int ytemp = (MapEditor.SelectedIndex) / 40;
                Point[] POINT_ = new Point[4];
                POINT_[0] = new Point(xtemp * MapPanelEditor.GridLenth + OPoint.X,
                    ytemp * MapPanelEditor.GridLenth + OPoint.Y);
                POINT_[1] = new Point(xtemp * MapPanelEditor.GridLenth + OPoint.X + MapPanelEditor.GridLenth,
                    ytemp * MapPanelEditor.GridLenth + OPoint.Y);
                POINT_[2] = new Point(xtemp * MapPanelEditor.GridLenth + OPoint.X,
                         ytemp * MapPanelEditor.GridLenth + OPoint.Y + MapPanelEditor.GridLenth);
                POINT_[3] = new Point(xtemp * MapPanelEditor.GridLenth + OPoint.X + MapPanelEditor.GridLenth,
                        ytemp * MapPanelEditor.GridLenth + OPoint.Y + MapPanelEditor.GridLenth);
                e.Graphics.DrawLine(Sp, POINT_[0], POINT_[1]);
                e.Graphics.DrawLine(Sp, POINT_[0], POINT_[2]);
                e.Graphics.DrawLine(Sp, POINT_[1], POINT_[3]);
                e.Graphics.DrawLine(Sp, POINT_[2], POINT_[3]);
            }
            #endregion
        }

        private void checkboxIsGameGrid_CheckedChanged(object sender, EventArgs e)
        {
            isGameGrid = !isGameGrid;
            this.Refresh();
        }

        private void checkboxIsLines_CheckedChanged(object sender, EventArgs e)
        {
            LinesEN = !LinesEN;
            this.Refresh();
        }

        private void checkboxShowKuang_CheckedChanged(object sender, EventArgs e)
        {
            isShowKuang = checkboxShowKuang.Checked;
            this.Refresh();
        }

        private void Form_Grid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                SpaceKeyDown?.Invoke(this, EventArgs.Empty);
                this.Refresh();
            }
            else
            {
                if (e.KeyCode == Keys.A)
                {
                    MapEditor.SelectedIndex--;
                }
                else if (e.KeyCode == Keys.D)
                {
                    MapEditor.SelectedIndex++;
                }
                else if (e.KeyCode == Keys.W)
                {
                    MapEditor.SelectedIndex = MapEditor.SelectedIndex -= 40;
                    if (MapEditor.SelectedIndex < 0)
                        MapEditor.SelectedIndex = MapEditor.SelectedIndex += 40;

                }
                else if (e.KeyCode == Keys.S)
                {
                    MapEditor.SelectedIndex = MapEditor.SelectedIndex += 40;
                    if (MapEditor.SelectedIndex >= MapPanelEditor.PictureTotal)
                        MapEditor.SelectedIndex = MapEditor.SelectedIndex -= 40;
                }
                if (MapEditor.SelectedIndex < 0)
                    MapEditor.SelectedIndex = 0;
                else if (MapEditor.SelectedIndex >= MapPanelEditor.PictureTotal)
                    MapEditor.SelectedIndex = MapPanelEditor.PictureTotal - 1;
                UpdateDataMapView?.Invoke(this, EventArgs.Empty);
            }
        }

        private void Form_Grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Refresh();
            }
            if (e.Button == MouseButtons.Left)
            {
                if (e.X - OPoint.X >= GridTotalLenth || e.Y - OPoint.Y >= GridTotalLenth)
                    return;
                if (e.X - OPoint.X < 0 || e.Y - OPoint.Y < 0)
                    return;
                int xnum = e.X - (e.X - OPoint.X) % MapPanelEditor.GridLenth;
                int ynum = e.Y - (e.Y - OPoint.Y) % MapPanelEditor.GridLenth;
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth + (ynum - OPoint.Y) / MapPanelEditor.GridLenth * 40;
                Point Point_Temp = new Point(xnum, ynum);
                MapEditor.SelectedIndex = index;
                this.Refresh();
                UpdateDataMapView?.Invoke(this, EventArgs.Empty);
                this.Refresh();
            }
        }

        private void Form_Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X - OPoint.X >= GridTotalLenth || e.Y - OPoint.Y >= GridTotalLenth)
                return;
            if (e.X - OPoint.X < 0 || e.Y - OPoint.Y < 0)
                return;
            int xnum = e.X - (e.X - OPoint.X) % MapPanelEditor.GridLenth;
            int ynum = e.Y - (e.Y - OPoint.Y) % MapPanelEditor.GridLenth;
            int xindex = (xnum - OPoint.X) / MapPanelEditor.GridLenth + 1;
            int yindex = (ynum - OPoint.Y) / MapPanelEditor.GridLenth + 1;
            labelXpoint.Text = "X坐标: " + xindex.ToString();
            labelYpoint.Text = "Y坐标: " + yindex.ToString();
        }
    }
}
