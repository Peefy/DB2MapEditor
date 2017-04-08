using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    class MapPanelMouse
    {
        public MapPanelMouse() { }

        public static long CurrentTimeMillis
        {
            get
            {
                return (System.DateTime.UtcNow.Ticks - new DateTime(1970, 1, 1, 0, 0, 0).Ticks) / 10000;
            }
        }

        public static long NowUpTime = 0;
        public static long NowDownTime = 0;

        private static long MouseHoldMillis = 300;

        const int MinPicSize = 10;
        const int MaxPicSize = 90;

        public static bool IsMouseHold()
        {
            return ((NowUpTime - NowDownTime) >= MouseHoldMillis);
        }

        public static int WheelChangePicSize(MouseEventArgs e,MapPanelEditor mapEditor)
        {
            int PicSize_Temp = mapEditor.PictureSize;
            PicSize_Temp += (int)(e.Delta * 0.1);
            return MyPublicFuntion.MathFunctionDefine.Range(PicSize_Temp, MinPicSize, MaxPicSize);
        }

        public static int DownSelectIndex(MouseEventArgs e,MapPanelEditor mapEditor)
        {
            mapEditor.MapClickXnum = e.X - (e.X - mapEditor.MapLeft) % mapEditor.PictureSize;
            mapEditor.MapClickYnum = e.Y - (e.Y - mapEditor.MapTop) % mapEditor.PictureSize;
            return (mapEditor.MapClickXnum - mapEditor.MapLeft) / mapEditor.PictureSize +
            (mapEditor.MapClickYnum - mapEditor.MapTop) / mapEditor.PictureSize * 40;
        }

        public static void ImLineFisrtDown(MouseEventArgs e,MapPanelEditor mapEditor)
        {
            mapEditor.ImLineXOld = e.X;
            mapEditor.ImLineYOld = e.Y;
            mapEditor.ImLineXNow = e.X;
            mapEditor.ImLineYNow = e.Y;
        }

        public static void RecordDownPoint(MouseEventArgs e,MapPanelEditor mapEditor)
        {
            mapEditor.NowMouseDownLocation.X = e.X;
            mapEditor.NowMouseDownLocation.Y = e.Y;
        }

        private static bool IsFileEnter;
        public static void DragEnterEvent(DragEventArgs e,MapPanelEditor mapEditor,MyPanel.MyPanel MapPanel)
        {
            MapPanel.Focus();
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            if (MyPublicFuntion.StringOperation.GetFileexc(path) ==
                MyPublicFuntion.StringOperation.GetFileexc(new FileMap.FileOperator().MapLoadFilter))
            {
                e.Effect = DragDropEffects.All;
                IsFileEnter = true;
            }
            else
            {
                IsFileEnter = false;
                e.Effect = DragDropEffects.None;
            }

            MapPanel.Refresh();
        }

        public static void DragDropEvent(DragEventArgs e, MapPanelEditor mapEditor, MyPanel.MyPanel MapPanel)
        {
            if (IsFileEnter == false) return;
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            FileMap.LoadMapInfo(path,mapEditor);
            MapPanel.Refresh();
        }

        public static void DragLeaveEvent(EventArgs e, MapPanelEditor mapEditor, MyPanel.MyPanel MapPanel)
        {
            MapDragPlace.IsEnter = false;
            MapPanel.Refresh();
        }

        public static void ClickEvent(MouseEventArgs e,MapPanelEditor mapEditor,MyPanel.MyPanel control)
        {
            MapPanelMouse.NowUpTime = MapPanelMouse.CurrentTimeMillis;
            if (e.Button == MouseButtons.Right && MapPanelMouse.IsMouseHold() == false)
            {
                Point nowClick = new Point(e.X, e.Y);
                if (mapEditor.ImagBlockCus == true)
                {
                    Point old = new Point(mapEditor.ImLineXOld, mapEditor.ImLineYOld);
                    Point now = new Point(mapEditor.ImLineXNow, mapEditor.ImLineYNow);
                    Rectangle rec = mapEditor.GetExpandRectangleFromDiagonalPoints(old, now);

                    if (mapEditor.RectangleContainsPoint(rec, nowClick) == true)
                        control.MouseRightDownMenu.Show(control, nowClick);
                    else
                        mapEditor.DataInit();
                }
                else
                {
                    control.MouseRightDownMenu.Show(control, nowClick);
                }
            }
        }

        public static void DoubleClickEvent(MouseEventArgs e, MapPanelEditor mapEditor, MyPanel.MyPanel control)
        {

        }

        public static int MoveXOld, MoveYOld;
        public static void DownEvent(MouseEventArgs e,MapPanelEditor mapEditor,MyPanel.MyPanel MapPanel)
        {
            
            MapPanelMouse.NowDownTime = MapPanelMouse.CurrentTimeMillis;
            MapPanel.Focus();
            MapPanelMouse.RecordDownPoint(e,mapEditor);
            MapPanelShow showTemp = new MapPanelShow(mapEditor);
            int MapTotalSizeX = showTemp.MapTotalSizeX;
            int MapTotalSizeY = showTemp.MapTotalSizeY;
            if (e.X >= MapTotalSizeX || e.Y >= MapTotalSizeY)
                return;
            if (e.X < 0 || e.Y < 0)
                return;
            if (e.Button == MouseButtons.Right)
            {
                MapDragPlace.IsEnter = false;
                MapDragPlace.IsOver = false;
                MoveXOld = e.X;
                MoveYOld = e.Y;
                mapEditor.MapDragEN = true;

                mapEditor.SelectedIndex = MapPanelMouse.DownSelectIndex(e,mapEditor);

            }
            else if (e.Button == MouseButtons.Left)
            {
                SmartPaste.HoverPasteInit();
                mapEditor.SelectedIndex = MapPanelMouse.DownSelectIndex(e,mapEditor);

                MapPanelMouse.ImLineFisrtDown(e,mapEditor);

                mapEditor.Imaginary = true;
                mapEditor.ImagBlockCus = false;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                mapEditor.ImagBlockCus = false;
                MoveXOld = e.X;
                MoveYOld = e.Y;
                mapEditor.Magnify = true;

                mapEditor.SelectedIndex = MapPanelMouse.DownSelectIndex(e,mapEditor);

                MapPanel.Refresh();
            
            }

        }

        public static void UpEvent(MouseEventArgs e, MapPanelEditor mapEditor, MyPanel.MyPanel MapPanel)
        {
            MapPanelMouse.NowUpTime = MapPanelMouse.CurrentTimeMillis;
            mapEditor.MapDragEN = false;
            mapEditor.Magnify = false;
            mapEditor.Imaginary = false;

            SmartPaste.HoverPasteInit();
            if (e.Button == MouseButtons.Left)
            {
                int MapTotalSizeX = mapEditor.PictureSize * MapPanelEditor.RowNum + mapEditor.MapLeft;
                int MapTotalSizeY = mapEditor.PictureSize * MapPanelEditor.RowNum + mapEditor.MapTop;
                if (MapPanelMouse.IsMouseHold() == true)
                    mapEditor.ImagBlockCus = true;
            }
        }
     
        private static bool FirstFlag = false;
        private const float DragSpeed = 1.0f;
        public static void MoveEvent(MouseEventArgs e, MapPanelEditor mapEditor, MyPanel.MyPanel MapPanel,
            VScrollBar Map_VScrollBar, HScrollBar Map_HScrollBar)
        {
            mapEditor.NowMouseMoveLocation = new Point(e.X, e.Y);
            if (mapEditor.MapDragEN == false && mapEditor.Magnify == false &&
                mapEditor.Imaginary == false)
                return;

            if (FirstFlag == false)
            {
                FirstFlag = true;
                return;
            }
            if (mapEditor.MapDragEN == true)
            {
                if (mapEditor.PictureSize < 17)
                    return;
                //this.Cursor = Cursors.Hand;
                mapEditor.ImagBlockCus = false;
                try
                {
                    int i = Map_HScrollBar.Value;
                    i = Convert.ToInt32(i - DragSpeed * (e.X - MoveXOld));
                    if (Math.Abs(e.X - MoveXOld) >= 2) MapPanelMouse.NowDownTime = 0;
                    if (i >= Map_HScrollBar.Maximum)
                        Map_HScrollBar.Value = Map_HScrollBar.Maximum;
                    else if (i <= Map_HScrollBar.Minimum)
                        Map_HScrollBar.Value = Map_HScrollBar.Minimum;
                    else
                        Map_HScrollBar.Value = i;

                }
                catch
                {

                }
                try
                {
                    int j = Map_VScrollBar.Value;
                    j = Convert.ToInt32(j - DragSpeed * (e.Y - MoveYOld));
                    if (Math.Abs(e.Y - MoveYOld) >= 2) MapPanelMouse.NowDownTime = 0;
                    if (j >= Map_VScrollBar.Maximum)
                        Map_VScrollBar.Value = Map_VScrollBar.Maximum;
                    else if (j <= Map_VScrollBar.Minimum)
                        Map_VScrollBar.Value = Map_VScrollBar.Minimum;
                    else
                        Map_VScrollBar.Value = j;
                }
                catch
                {

                }
                mapEditor.MapTop = -Map_VScrollBar.Value;
                mapEditor.MapLeft = -Map_HScrollBar.Value;
                MapPanel.Refresh();
            }
            if (mapEditor.Magnify == true)
            {
                //this.Cursor = Cursors.Cross;
                int PicSize_Temp = mapEditor.PictureSize;
                mapEditor.PictureSize = Convert.ToInt32(PicSize_Temp - 0.1 * (e.Y - MoveYOld));
                if (mapEditor.PictureSize >= 90)
                    mapEditor.PictureSize = 90;
                if (mapEditor.PictureSize <= 10)
                    mapEditor.PictureSize = 10;


            }
            MoveXOld = e.X;
            MoveYOld = e.Y;
            if (mapEditor.Imaginary == true)
            {
                int MapTotalSizeX = mapEditor.PictureSize * MapPanelEditor.RowNum + mapEditor.MapLeft;
                int MapTotalSizeY = mapEditor.PictureSize * MapPanelEditor.RowNum + mapEditor.MapTop;
                if (e.X >= MapTotalSizeX || e.Y >= MapTotalSizeY)
                    return;
                if (e.X < 0 || e.Y < 0)
                    return;
                mapEditor.ImLineXNow = e.X;
                mapEditor.ImLineYNow = e.Y;

                MapPanel.Refresh();
            }

        }



    }
}