using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    class MapEditor
    {
        public MapEditor() { }

        public const int PictureTotal = 1600;
        public static int PictureSize = 40;
        public const int MapImgSuitSize = 14;
        public const int RowNum = 40;
        public const int LineNum = 40;
        public const int GridLenth = 8;
        public const int MapPanelSizeX = 774;
        public const int MapPanelSizeY = 605;

        public static Point MapPanelLocation = new Point(16, 52);

        public static Point NowMouseDownLocation = new Point();
        public static Point NowMouseMoveLocation = new Point();

        public const int AutoAjgStep = 80;
        public static int MapThemeNum = 0;
        public static int PreMapThemeNum = 0;
        public static int SelectedIndex = -1;
        public const string GtCodeMapName = "\\MapEditorCheat.cht";

        public static bool ALLClrUndoFlag = false;

        public static bool MapDragEN = false;
        public static bool Magnify = false;
        public static bool Imaginary = false;
        public static bool ImagBlockCus = false;
        public static bool IsHoverShow = false;

        public struct ImLine
        {
            public static int ImLineXOld, ImLineYOld, ImLineXNow, ImLineYNow;
            public static void DataInit()
            {
                ImLineXNow = 0;
                ImLineYNow = 0;
                ImLineXOld = 0;
                ImLineYOld = 0;
                ImagBlockCus = false;
            }

        }

        public static int MapLeft = 0;
        public static int MapTop = 0;
        public static int MapClickXnum = 0;
        public static int MapClickYnum = 0;
        public static Color MapCusorColor = Color.Turquoise;
        public static int MapCusorWidth = 2;
        public static Color MapImColor = Color.Turquoise;
        public static int IsRegister = 1;
        public const string RegisterLicense = "DB2MAPEDITOR";
        public static int IsFixedPath = 1;

        public static int MapTotalSizeX = MapEditor.PictureSize * MapEditor.RowNum + MapEditor.MapLeft;
        public static int MapTotalSizeY = MapEditor.PictureSize * MapEditor.RowNum + MapEditor.MapTop;

        public static PictureBox[] MapPicBlock = new PictureBox[MapEditor.PictureTotal];
        public static List<Image> MapIMG_Block = new List<Image>();
        public static Image[] MapSmartE = new Image[MapEditor.PictureTotal];

        public static List<Image> YiJiMaplist = new List<Image>();
        public static List<Image> Coast_Maplist = new List<Image>();
        public static List<Image> Hilly_Maplist = new List<Image>();
        public static List<Image> Tower_Maplist = new List<Image>();
        public static List<Image> City_Maplist = new List<Image>();
        public static List<Image> Future_Maplist = new List<Image>();
        public static List<Image> Aether_Maplist = new List<Image>();
        public static List<Image> EDS_Maplist = new List<Image>();
        public static List<Image> Boss_Maplist = new List<Image>();

        public static List<List<Image>> ThemeBar = new List<List<Image>>();

        public static Stack<Image> MapImgStack = new Stack<Image>();
        public static Stack<int> MapSleStack = new Stack<int>();
        public static List<Image> MapAllClrImgList = new List<Image>();
        public static List<int> MapAllClrSleList = new List<int>();

        public static Image MapCathe = null;
        public static Image MapNull = null;

        #region 方法

        public static int Bitmap2Int(PictureBox pic)
        {
            return MapEditor.ThemeBar[MapEditor.MapThemeNum].IndexOf(pic.Image);
        }

        public static Image Int2MapImage(int read)
        {
            return MapEditor.ThemeBar[MapEditor.MapThemeNum][read];
        }

        public static int MapImage2Int(Image img)
        {
            return MapEditor.ThemeBar[MapEditor.MapThemeNum].IndexOf(img);
        }

        public static string Bitmapt2HexStr(Image pic)
        {
            int ing = MapEditor.ThemeBar[MapEditor.MapThemeNum].IndexOf(pic);
            if (ing == (int)MapEditor.MapIdDefine.我方基地) ing = (int)MapEditor.MapIdDefine.空地;
            if (ing == (int)MapEditor.MapIdDefine.敌方基地) ing = (int)MapEditor.MapIdDefine.空地;
            if (ing == (int)MapEditor.MapIdDefine.我方单位) ing = (int)MapEditor.MapIdDefine.草地Start + 2;
            if (ing == (int)MapEditor.MapIdDefine.敌方单位) ing = (int)MapEditor.MapIdDefine.草地Start + 2;
            return ing > 9 ? (ing.ToString("X2")) : ("0" + ing.ToString());
        }

        public static int ImagBlockCusx1, ImagBlockCusy1, ImagBlockCusx2, ImagBlockCusy2;
        //public static AroundMap NowMap = AroundMap.MapNone;

        public static Point[] GetRectanglePointsFromDiagonalPoints(Point old, Point now)
        {
            int ImagOldTop = MapTop;
            int ImagOldLeft = MapLeft;
            if ((now.Y - old.Y) > 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapDownRight;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) < 0)
            {
               // NowMap = AroundMap.MapUpLeft;

                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else if ((now.Y - old.Y) > 0 && (now.X - old.X) < 0)
            {
               // NowMap = AroundMap.MapDownLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) > 0)
            {
               // NowMap = AroundMap.MapUpRight;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else
            {

            }
            ImagBlockCusx1 = old.X;
            ImagBlockCusy1 = old.Y;
            ImagBlockCusx2 = now.X;
            ImagBlockCusy2 = now.Y;

            return new Point[]
            {
                new Point(ImagBlockCusx1,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy1),
            };
        }

        public static Point[] GetExpandRectanglePointsFromDiagonalPoints(Point old, Point now)
        {

            int ImagOldTop = MapTop;
            int ImagOldLeft = MapLeft;
            if ((now.Y - old.Y) > 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapDownRight;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapUpLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else if ((now.Y - old.Y) > 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapDownLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapUpRight;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else
            {

            }
            ImagBlockCusx1 = old.X - (old.X - ImagOldLeft) % PictureSize + MapEditor.PictureSize - MapEditor.PictureSize;
            ImagBlockCusy1 = old.Y - (old.Y - ImagOldTop) % MapEditor.PictureSize + MapEditor.PictureSize - MapEditor.PictureSize;
            ImagBlockCusx2 = now.X - (now.X - ImagOldLeft) % MapEditor.PictureSize + MapEditor.PictureSize;
            ImagBlockCusy2 = now.Y - (now.Y - ImagOldTop) % MapEditor.PictureSize + MapEditor.PictureSize;

            return new Point[]
            {
                new Point(ImagBlockCusx1,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy1),
            };
        }

        public static Rectangle GetExpandRectanglePointsFromSinglePoint(Point now)
        {
            int lenth = MapEditor.PictureSize;

            int MapTotalSizeX = MapEditor.PictureSize * MapEditor.RowNum + MapEditor.MapLeft;
            int MapTotalSizeY = MapEditor.PictureSize * MapEditor.RowNum + MapEditor.MapTop;

            int mapClickXnum = now.X - (now.X - MapEditor.MapLeft) % MapEditor.PictureSize;
            int mapClickYnum = now.Y - (now.Y - MapEditor.MapTop) % MapEditor.PictureSize;

            int selectedIndex = (mapClickXnum - MapEditor.MapLeft) / MapEditor.PictureSize +
                (mapClickYnum - MapEditor.MapTop) / MapEditor.PictureSize * MapEditor.RowNum;

            int Left = MapEditor.MapLeft + selectedIndex % (MapEditor.RowNum) * lenth;
            int Top = MapTop + selectedIndex / (MapEditor.LineNum) * lenth - PictureSize;

            return new Rectangle(Left, Top, lenth, lenth);

        }

        public static Rectangle GetExpandRectangleFromDiagonalPoints(Point old, Point now)
        {

            int ImagOldTop = MapTop;
            int ImagOldLeft = MapLeft;
            if ((now.Y - old.Y) > 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapDownRight;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapUpLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else if ((now.Y - old.Y) > 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapDownLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapUpRight;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else
            {

            }
            ImagBlockCusx1 = old.X - (old.X - ImagOldLeft) % MapEditor.PictureSize + MapEditor.PictureSize - MapEditor.PictureSize;
            ImagBlockCusy1 = old.Y - (old.Y - ImagOldTop) % MapEditor.PictureSize + MapEditor.PictureSize - MapEditor.PictureSize;
            ImagBlockCusx2 = now.X - (now.X - ImagOldLeft) % MapEditor.PictureSize + MapEditor.PictureSize;
            ImagBlockCusy2 = now.Y - (now.Y - ImagOldTop) % MapEditor.PictureSize + MapEditor.PictureSize;

            int Width = Math.Abs(ImagBlockCusx2 - ImagBlockCusx1);
            int Height = Math.Abs(ImagBlockCusy2 - ImagBlockCusy1);

            return new Rectangle(ImagBlockCusx1, ImagBlockCusy1, Width, Height);
        }

        public static bool RectangleContainsPoint(Rectangle rec, Point p)
        {
            if (rec.Left < p.X && p.X < rec.Left + rec.Width && rec.Top < p.Y && p.Y < rec.Top + rec.Height)
                return true;
            else
                return false;
        }

        public enum MapIdDefine : int
        {
            我方基地 = 0,
            藤蔓Start = 1,
            草地Start = 5,
            空地 = 9,
            湿地Start = 10,
            空地墙 = 13,
            轻旱地 = 14,
            重旱地 = 19,
            花地Start = 15,
            水面Start = 25,
            水面End = 71,
            岩浆Start = 73,
            岩浆End = 119,
            山地顶Start = 121,
            山地顶End = 167,
            山地底Start = 169,
            山地底End = 190,
            沙地Start = 191,
            雪地Start = 192,
            冰面Start = 209,
            冰面End = 255,
            敌方基地 = 13,
            我方单位 = 24,
            敌方单位 = 72,
            水面Count = 水面End - 水面Start + 1,
            岩浆Count = 岩浆End - 岩浆Start + 1,

        }
        #endregion

    }

    enum MapThemeIdEnum : int
    {
        遗迹主题 = 0,
        海岸主题 = 1,
        山地主题 = 2,
        城堡主题 = 3,
        城市主题 = 4,
        未来城主题 = 5,
        太空主题 = 6,
        异次元主题 = 7,
        博士基地主题 = 8,

    }

}
