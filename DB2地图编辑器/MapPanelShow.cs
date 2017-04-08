using System.Drawing;
using System.Drawing.Imaging;

namespace DB2地图编辑器
{
    class MapPanelShow
    {

        MapPanelEditor mapEditor;

        public MapPanelShow(MapPanelEditor mapeditor)
        {
            mapEditor = mapeditor;
            lenth = mapEditor.PictureSize;
        }

        int lenth = 20;

        public int MapTotalSizeX
        {
            get { return mapEditor.PictureSize * MapPanelEditor.RowNum + mapEditor.MapLeft; }
        }

        public int MapTotalSizeY
        {
            get { return mapEditor.PictureSize * MapPanelEditor.RowNum + mapEditor.MapTop; }
        }

        public MapPanelShow DrawMapPicture(Graphics g)
        {
            for (int i = 0; i <=MapPanelEditor.PictureTotal - 1; ++i)
            {
                int Left = mapEditor.MapLeft + i % (MapPanelEditor.RowNum) * lenth;
                int Top = mapEditor.MapTop + i / (MapPanelEditor.LineNum) * lenth;
                Rectangle r = new Rectangle(Left, Top, lenth, lenth);
                g.DrawImage(mapEditor.MapIMG_Block[i], r);
            }
            new LostMap().JudgeMapLostIdAndDraw(g,mapEditor);
            return this;
        }

        public MapPanelShow DrawSelectedIndex(Graphics g)
        {
            if (mapEditor.SelectedIndex != -1)
            {
                Pen p = new Pen(mapEditor.MapCusorColor,mapEditor.MapCusorWidth);
                int Left = mapEditor.MapLeft + mapEditor.SelectedIndex % (MapPanelEditor.RowNum) * lenth;
                int Top = mapEditor.MapTop + mapEditor.SelectedIndex / (MapPanelEditor.LineNum) * lenth;
                g.DrawRectangle(p, new Rectangle(Left, Top, lenth, lenth));
            }
            return this;
        }

        public MapPanelShow DrawImagenaryAndBlock(Graphics g)
        {
            if (mapEditor.Imaginary == true)
            {
                Pen pen1 = new Pen(mapEditor.MapImColor);
                pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                int OldX = mapEditor.ImLineXOld;
                int OldY = mapEditor.ImLineYOld;
                int NowX = mapEditor.ImLineXNow;
                int NowY = mapEditor.ImLineYNow;

                g.DrawLines(pen1, mapEditor.GetRectanglePointsFromDiagonalPoints(
                 new Point(OldX, OldY), new Point(NowX, NowY)));

                SolidBrush sb = new SolidBrush(Color.FromArgb(100, Color.Blue));
                g.FillRectangle(sb, mapEditor.GetExpandRectangleFromDiagonalPoints(
                    new Point(OldX, OldY), new Point(NowX, NowY)));
            }
            if (mapEditor.ImagBlockCus == true)
            {
                Pen pen1 = new Pen(mapEditor.MapImColor);
                int OldX = mapEditor.ImLineXOld;
                int OldY = mapEditor.ImLineYOld;
                int NowX = mapEditor.ImLineXNow;
                int NowY = mapEditor.ImLineYNow;
                g.DrawLines(pen1, mapEditor.GetExpandRectanglePointsFromDiagonalPoints(
                    new Point(OldX, OldY), new Point(NowX, NowY)));

                SolidBrush sb = new SolidBrush(Color.FromArgb(100, Color.Blue));
                g.FillRectangle(sb, mapEditor.GetExpandRectangleFromDiagonalPoints(
                    new Point(OldX, OldY), new Point(NowX, NowY)));

            }
            return this;
        }

        public MapPanelShow DrawOver(Graphics g)
        {
            if (MapDragPlace.IsOver == true)
            {
                SolidBrush sb = new SolidBrush(Color.FromArgb(90, Color.Black));
                g.FillRectangle(sb, mapEditor.GetExpandRectanglePointsFromSinglePoint(
                    MapDragPlace.NowPoint));
            }
            return this;
        }

        public bool DrawPasteHover(Graphics g)
        {
            if (mapEditor.IsHoverShow == true)
            {
                if (SmartPaste.State == null)
                { mapEditor.IsHoverShow = false; return false; }
                int minIndex = SmartPaste.State.MinIndex;
                if (minIndex == -1) return false;
                int iterator = 0;

                ImageAlpha imgAlpha = new ImageAlpha(ImageAlphaLevel.HalfTransparent);
                ImageAttributes imgSet = imgAlpha.GetImageTransparentSet();

                foreach (int IndexTemp in SmartPaste.State.Items.Index)
                {
                    int Index = mapEditor.SelectedIndex + IndexTemp - minIndex;
                    int left = mapEditor.MapLeft + Index % (MapPanelEditor.RowNum) * lenth;
                    int top = mapEditor.MapTop + Index / (MapPanelEditor.LineNum) * lenth;
                    Rectangle rec = new Rectangle(left, top, lenth, lenth);
                    SolidBrush sb = new SolidBrush(Color.Gray);
                    if (SmartPaste.State != null)
                    {
                        g.FillRectangle(sb, rec);
                        Image img = mapEditor.ImgAutoImg(SmartPaste.State.Items.Image[iterator++], SmartPaste.State.CopyMapThemeNum);
                        int width = img.Width;
                        int height = img.Height;
                        g.DrawImage(img, new Rectangle(left, top, lenth, lenth), 0, 0, width, height,
                            GraphicsUnit.Pixel, imgSet);
                    }

                }
            }
            return true;
        }
    }
}
