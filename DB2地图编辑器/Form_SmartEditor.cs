using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;

using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace DB2地图编辑器
{
    public partial class Form_SmartEditor : CCWin.CCSkinMain
    {
        #region 变量
        int GridTotalLenth = MapPanelEditor.GridLenth * MapPanelEditor.RowNum;
        Point OPoint = new Point(5, 5);
        bool LinesEN = true;
        bool LeftClickMoveEN = false;
        bool RightClickMoveEN = false;
        Color SelectedColor = Color.Black;
        int SelectedColorIndex = 0;

        #region 禁止Piant事件 相关

        const int WM_GETTEXT = 0x000B;
        const int FALSE = 0x0000;
        const int TRUE = 0x0001;
        private const int WM_SETREDRAW = 0xB;

        public List<PointBrush> DesBrushRanc = new List<PointBrush>(); 

        [DllImport( "USER32.DLL ",CharSet=CharSet.Auto, SetLastError=true)] 
        public static extern bool SendMessage(  
        IntPtr hWnd, // handle to destination window  
        int Msg, // message  
        int wParam, // first message parameter  
        int lParam
        );
        #endregion

        #endregion

        MapPanelEditor MapEditor;
        BrushBlockHelper PaintHelper;

        public Form_SmartEditor(MapPanelEditor mapedi)
        {
            InitializeComponent();
            SendMessage((IntPtr)this.Handle, WM_SETREDRAW, FALSE, 0);
            this.StartPosition = FormStartPosition.CenterScreen;
            MapEditor = mapedi;
            myPanel1.Paint += Form_SmartEditor_Paint;
            myPanel1.MouseMove += Form_SmartEditor_MouseMove;
            myPanel1.MouseDown += Form_SmartEditor_MouseDown;
            myPanel1.MouseUp += Form_SmartEditor_MouseUp;

        }

        public void Init()
        {
            
            #region 数据初始化

            SmartEditor.ColorBlock.Clear();
            SmartEditor.ColorBlock.Add(草地Color);
            SmartEditor.ColorBlock.Add(死地Color);
            SmartEditor.ColorBlock.Add(水面Color);
            SmartEditor.ColorBlock.Add(岩浆Color);
            SmartEditor.ColorBlock.Add(山顶Color);

            草地Color.BackColor = SmartEditor.ColorBlock[0].BackColor;
            死地Color.BackColor = SmartEditor.ColorBlock[1].BackColor;
            水面Color.BackColor = SmartEditor.ColorBlock[2].BackColor;
            岩浆Color.BackColor = SmartEditor.ColorBlock[3].BackColor;
            山顶Color.BackColor = SmartEditor.ColorBlock[4].BackColor;

            #endregion
            PaintHelper = new BrushBlockHelper();
            MapEditor.MapSmartE = MapEditor.MapIMG_Block.ToArray();

        }

        private void Form_SmartEditor_Paint(object sender, PaintEventArgs e)
        {
            #region 画笔画刷定义
            Pen p = new Pen(Color.Black);
            #endregion
            #region 原始地图缩略图
            for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)   //方块
            {
                int Temp = MapEditor.MapImage2Int(MapEditor.MapSmartE[i]);
                e.Graphics.FillRectangle(PaintHelper.BrushBlock[MapEditor.ThemeNum][Temp], new Rectangle(OPoint.X + i % (MapPanelEditor.RowNum) * MapPanelEditor.GridLenth,
                    OPoint.Y + i / (MapPanelEditor.RowNum) * MapPanelEditor.GridLenth,
                    MapPanelEditor.GridLenth, MapPanelEditor.GridLenth));
            }
            
            #endregion
            #region 用户自定义Map
            int Count_Temp = DesBrushRanc.Count;
            for (int i = 0; i <= Count_Temp - 1; ++i)
            {
                SolidBrush SBrush_Temp = new SolidBrush(DesBrushRanc[i].color);
                e.Graphics.FillRectangle(SBrush_Temp, new Rectangle(DesBrushRanc[i].point.X,
                    DesBrushRanc[i].point.Y,
                    MapPanelEditor.GridLenth, MapPanelEditor.GridLenth));
            }
            #endregion
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
        }

        private void Form_SmartEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X - OPoint.X >= GridTotalLenth || e.Y - OPoint.Y >= GridTotalLenth)
                return;
            if (e.X - OPoint.X < 0 || e.Y - OPoint.Y < 0)
                return;
            int xnum = e.X - (e.X - OPoint.X) % MapPanelEditor.GridLenth;
            int ynum = e.Y - (e.Y - OPoint.Y) % MapPanelEditor.GridLenth;
            int xindex = (xnum - OPoint.X) / MapPanelEditor.GridLenth + 1;
            int yindex = (ynum - OPoint.Y) / MapPanelEditor.GridLenth + 1;
            X坐标.Text = "X坐标: " + xindex.ToString();
            Y坐标.Text = "Y坐标: " + yindex.ToString();
            if (LeftClickMoveEN == false && RightClickMoveEN == false)
                return;
            if (LeftClickMoveEN == true)
            {
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth  + (ynum - OPoint.Y) / MapPanelEditor.GridLenth * 40;
                Point Point_Temp = new Point(xnum, ynum);
                PointBrush PointB_Temp = new PointBrush(Point_Temp, SelectedColor, index);
                int CountTemp = DesBrushRanc.Count;
                for (int i = 0; i <= DesBrushRanc.Count - 1; i++)
                {
                    if (DesBrushRanc[i].point == PointB_Temp.point)
                    {
                        DesBrushRanc.RemoveAt(i);
                        break;
                    }
                }
                DesBrushRanc.Add(PointB_Temp);
            }
            if (RightClickMoveEN == true)
            {
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth + (ynum - OPoint.Y) / MapPanelEditor.GridLenth  * 40;
                Point Point_Temp = new Point(xnum, ynum);
                PointBrush PointB_Temp = new PointBrush(Point_Temp, SelectedColor, index);
                int CountTemp = DesBrushRanc.Count;
                for (int i = 0; i <= DesBrushRanc.Count - 1; i++)
                {
                    if (DesBrushRanc[i].point == PointB_Temp.point)
                    {
                        DesBrushRanc.RemoveAt(i);
                        break;
                    }
                }
            }
            this.Refresh();
        }

        private void Form_SmartEditor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X - OPoint.X >= GridTotalLenth || e.Y - OPoint.Y >= GridTotalLenth)
                return;
            if (e.X - OPoint.X < 0 || e.Y - OPoint.Y < 0)
                return;
            if (e.Button == MouseButtons.Left)
            {
                int xnum = e.X - (e.X - OPoint.X) % MapPanelEditor.GridLenth;
                int ynum = e.Y - (e.Y - OPoint.Y) % MapPanelEditor.GridLenth;
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth  + (ynum - OPoint.Y) / MapPanelEditor.GridLenth  * 40;
                Point Point_Temp = new Point(xnum, ynum);
                PointBrush PointB_Temp = new PointBrush(Point_Temp, SelectedColor,index);
                int CountTemp = DesBrushRanc.Count;
                for (int i = 0; i <= DesBrushRanc.Count - 1; i++)
                {
                    if (DesBrushRanc[i].point == PointB_Temp.point)
                    {
                        DesBrushRanc.RemoveAt(i);
                        break;
                    }
                }
                DesBrushRanc.Add(PointB_Temp);
                LeftClickMoveEN = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                int xnum = e.X - (e.X - OPoint.X) % MapPanelEditor.GridLenth;
                int ynum = e.Y - (e.Y - OPoint.Y) % MapPanelEditor.GridLenth;
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth  + (ynum - OPoint.Y) / MapPanelEditor.GridLenth * 40;
                Point Point_Temp = new Point(xnum, ynum);
                PointBrush PointB_Temp = new PointBrush(Point_Temp, Color.Black,index);
                int CountTemp = DesBrushRanc.Count;
                for (int i = 0; i <= DesBrushRanc.Count - 1; i++)
                {
                    if (DesBrushRanc[i].point == PointB_Temp.point)
                    {
                        DesBrushRanc.RemoveAt(i);
                        break;
                    }
                }
                RightClickMoveEN = true;
            }
            this.Refresh();
            
        }

        private void Form_SmartEditor_MouseUp(object sender, MouseEventArgs e)
        {
            LeftClickMoveEN = false;
            RightClickMoveEN = false;
        }

        private void 显示网格_CheckedChanged(object sender, EventArgs e)
        {
            LinesEN = 显示网格.Checked;
            this.Refresh();
        }

        private void 生成编辑_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void 全部清空_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否全部清除", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DesBrushRanc.Clear();
                this.Refresh();
            }
        }
       
        private void ColorSel_Click(object sender, EventArgs e)
        {   
            if (选择颜色.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("确定更换颜色？更换后将使之前编辑清除", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    PictureBox Pic_Temp = (PictureBox)sender;
                    Pic_Temp.BackColor = 选择颜色.Color;
                    DesBrushRanc.Clear();
                    this.Refresh();
                    if (SelectedColorIndex == Convert.ToInt32(Pic_Temp.Tag))
                    {
                        SelectedColor = 选择颜色.Color;
                    }
                    SmartEditor.ColorBlock[Convert.ToInt32(Pic_Temp.Tag)].BackColor = 选择颜色.Color;
                }
            }

        }

        private void SelColorChange(object sender, EventArgs e)
        {
            RadioButton Rb_Temp = (RadioButton)sender;
            int IndexTemp = Convert.ToInt32(Rb_Temp.Tag) - 1;
            SelectedColorIndex = IndexTemp;
            SelectedColor = SmartEditor.ColorBlock[IndexTemp].BackColor;
        }

        private void Form_SmartEditor_Load(object sender, EventArgs e)
        {

        }
    }       

}
