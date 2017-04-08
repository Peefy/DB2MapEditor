using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CCWin;
using System.Threading;

namespace DB2地图编辑器
{
    public partial class Form_Draft : CCSkinMain
    {
        #region 变量
        int GridTotalLenth = MapPanelEditor.GridLenth * MapPanelEditor.RowNum;
        Point OPoint = new Point(10, 0);
        bool LinesEN = true;
        bool LeftClickMoveEN = false;
        bool RightClickMoveEN = false;
        Color SelectedColor = Color.Black;

        BrushBlockHelper PaintHelper;
        MapPanelEditor MapEditor;

        public List<PointBrush> DesBrushRanc = new List<PointBrush>(); 

        #region 禁止Piant事件 相关

        const int WM_GETTEXT = 0x000B;
        const int FALSE = 0x0000;
        const int TRUE = 0x0001;
        private const int WM_SETREDRAW = 0xB;
        [DllImport("USER32.DLL ", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SendMessage(
        IntPtr hWnd, // handle to destination window  
        int Msg, // message  
        int wParam, // first message parameter  
        int lParam
        );
        #endregion

        #endregion
        public Form_Draft(MapPanelEditor mapedi)
        {
            InitializeComponent();
            SendMessage((IntPtr)this.Handle, WM_SETREDRAW, FALSE, 0);
            MapEditor = mapedi;
            this.Refresh();
        }

        private void Form_Draft_Load(object sender, EventArgs e)
        {
            保存草稿Dialog.Filter = "地图保存文件（*.DraftSave）|*.DraftSave";
            保存草稿Dialog.FilterIndex = 1;
            保存草稿Dialog.RestoreDirectory = true;

            载入草稿Dialog.Filter = "地图保存文件（*.DraftSave）|*.DraftSave";
            载入草稿Dialog.FilterIndex = 1;
            载入草稿Dialog.RestoreDirectory = true;
        }

        private void 显示网格_CheckedChanged(object sender, EventArgs e)
        {
            LinesEN = 显示网格.Checked;
            this.Refresh();
        }

        private void 保存草稿_Click(object sender, EventArgs e)
        {
            if (保存草稿Dialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = 保存草稿Dialog.FileName.ToString(); //获得文件路径 
                System.IO.FileStream fst = (System.IO.FileStream)保存草稿Dialog.OpenFile();//输出文件
                fst.Close();
                try
                {
                    FileStream fs = new FileStream(localFilePath, FileMode.Create);
                    BinaryWriter w = new BinaryWriter(fs);

                    int CountTemp = DesBrushRanc.Count;

                    w.Write(CountTemp);

                    //DesBrushRanc.Clear();
                    for (int i = 0; i <= DesBrushRanc.Count - 1; i++)
                    {
                        w.Write(DesBrushRanc[i].point.X);
                        w.Write(DesBrushRanc[i].point.Y);
                        string str_temp = ColorTranslator.ToHtml(DesBrushRanc[i].color);
                        w.Write(str_temp);
                    }
                    w.Flush();
                    w.Close();
                    fs.Close();
                    MessageBox.Show("保存草稿成功！");
                    this.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 载入草稿_Click(object sender, EventArgs e)
        {
            if (载入草稿Dialog.ShowDialog() == DialogResult.OK)
            {
                string resultFile = 载入草稿Dialog.FileName;
                if (File.Exists(resultFile))
                {
                    try
                    {
                        FileStream fs = new FileStream(resultFile, FileMode.Open);
                        BinaryReader r = new BinaryReader(fs);

                        DesBrushRanc.Clear();

                        int CountTemp = r.ReadInt32();

                        for (int i = 0; i <= CountTemp - 1; i++)
                        {
                            int x_temp, y_temp;
                            Color color_temp;
                            x_temp = r.ReadInt32();
                            y_temp = r.ReadInt32();
                            color_temp = ColorTranslator.FromHtml(r.ReadString());
                            Point point_temp = new Point(x_temp,y_temp);
                            PointBrush pointbrush_temp = new PointBrush(point_temp,color_temp,i);
                            DesBrushRanc.Add(pointbrush_temp);
                        }

                        r.Close();
                        fs.Close();
                        this.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void 全部清空_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否全部清除", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DesBrushRanc.Clear();
                this.Refresh();
            }
        }

        private void TopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = TopMostEN.Checked;
        }

        private void Form_Draft_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出草稿编辑", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_Grid2Draft_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            this.Cursor = Cursors.WaitCursor;
            PaintHelper = new BrushBlockHelper();
            DesBrushRanc.Clear();
            for (int i = 0; i < MapPanelEditor.PictureTotal; ++i)
            {
                PointBrush pb = new PointBrush();
                pb.clickindex = i;
                int mapid = MapEditor.MapImage2Int(MapEditor.MapIMG_Block[i]);
                pb.color = PaintHelper.BrushBlock[MapEditor.ThemeNum][mapid].Color;
                pb.point =
                    new Point(OPoint.X + i % MapPanelEditor.RowNum * MapPanelEditor.GridLenth,
                        OPoint.Y + i / 40 * MapPanelEditor.GridLenth);
                DesBrushRanc.Add(pb);

            }
            this.Refresh();
            this.Cursor = Cursors.Default;
            this.UseWaitCursor = false;
        }

        private void skinColorSelectPanel1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = skinColorSelectPanel1.SelectedColor;
            SelectedColor = skinColorSelectPanel1.SelectedColor;
        }

        private void myPanel1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black);

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

        private void myPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.X - OPoint.X >= GridTotalLenth || e.Y - OPoint.Y >= GridTotalLenth)
                return;
            if (e.X - OPoint.X < 0 || e.Y - OPoint.Y < 0)
                return;
            if (e.Button == MouseButtons.Left)
            {
                int xnum = e.X - (e.X - OPoint.X) % MapPanelEditor.GridLenth;
                int ynum = e.Y - (e.Y - OPoint.Y) % MapPanelEditor.GridLenth;
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth + (ynum - OPoint.Y) / MapPanelEditor.GridLenth * MapPanelEditor.RowNum;
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
                LeftClickMoveEN = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                int xnum = e.X - (e.X - OPoint.X) % MapPanelEditor.GridLenth;
                int ynum = e.Y - (e.Y - OPoint.Y) % MapPanelEditor.GridLenth;
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth + (ynum - OPoint.Y) / MapPanelEditor.GridLenth * 40;
                Point Point_Temp = new Point(xnum, ynum);
                PointBrush PointB_Temp = new PointBrush(Point_Temp, Color.Black, index);
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
            myPanel1.Refresh();
        }

        private void myPanel1_MouseMove(object sender, MouseEventArgs e)
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
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth + (ynum - OPoint.Y) / MapPanelEditor.GridLenth * 40;
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
                int index = (xnum - OPoint.X) / MapPanelEditor.GridLenth + (ynum - OPoint.Y) / MapPanelEditor.GridLenth * 40;
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
            myPanel1.Refresh();
        }

        private void myPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            LeftClickMoveEN = false;
            RightClickMoveEN = false;
        }
    }
}
