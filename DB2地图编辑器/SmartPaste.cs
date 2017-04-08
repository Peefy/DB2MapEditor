using System.Drawing;

namespace DB2地图编辑器
{
    class SmartPaste
    {
        static MapPanelEditor MapEditor;
        public SmartPaste(MapPanelEditor mapedi)
        {
            MapEditor = mapedi;
            this.Items = new MapBlockContent(MapEditor);
            CopyMapThemeNum = MapEditor.ThemeNum;
            Size = new Size();
            CopyKind = SmartPasteCopyKind.NoneCopy;
        }

        public SmartPaste(SmartPasteCopyKind kind,MapPanelEditor mapedi)
        {
            MapEditor = mapedi;
            this.Items = new MapBlockContent(MapEditor);
            CopyMapThemeNum = MapEditor.ThemeNum;
            Size = new Size();
            CopyKind = kind;

            int ImagOldLeft = MapEditor.MapLeft;
            int ImagOldTop = MapEditor.MapTop;
            int ImagBlockCusx1 = MapEditor.ImagBlockCusx1;
            int ImagBlockCusy1 = MapEditor.ImagBlockCusy1;
            int ImagBlockCusx2 = MapEditor.ImagBlockCusx2;
            int ImagBlockCusy2 = MapEditor.ImagBlockCusy2;

            int Index_Temp = (ImagBlockCusx1 - ImagOldLeft) / MapEditor.PictureSize +
                (ImagBlockCusy1 - ImagOldTop) / MapEditor.PictureSize * 40;
            int xtemp = (ImagBlockCusx2 - ImagBlockCusx1) / MapEditor.PictureSize;
            int ytemp = (ImagBlockCusy2 - ImagBlockCusy1) / MapEditor.PictureSize;

            this.Size = new Size(xtemp, ytemp);

            for (int j = 0; j < ytemp; ++j)
            {
                int index = 0;
                for (int i = 0; i < xtemp; ++i)
                {
                    index = i + Index_Temp + j * 40;
                    this.Items.Add(index);
                    SmartPaste.State = this;
                }
            }
            SmartPaste.IsPasteIng = true;

        }

        public MapBlockContent Items;

        public SmartPasteCopyKind CopyKind;

        public Size Size;

        public int CopyMapThemeNum;

        public int MinIndex
        {
            get
            {
                if (Items.Index.Count == 0) return -1;
                else
                {
                    int min = MapPanelEditor.PictureTotal;
                    foreach(int data in Items.Index)
                    {
                        if (data <= min)
                            min = data;
                    }
                    return min;
                } 
            }
        }

        //静态属性

        public static Image PasteImage
        {
            get
            {
                if (SmartPaste.State != null)
                {
                    int xtemp = SmartPaste.State.Size.Width;
                    int ytemp = SmartPaste.State.Size.Height;
                    int picSize = 10;
                    int index = 0;
                    Image AddNewImg = new Bitmap(picSize * xtemp, picSize * ytemp);
                    Graphics g = Graphics.FromImage(AddNewImg);   //生成Graphics对象 
                    for (int j = 0; j < ytemp; ++j)
                    {

                        for (int i = 0; i < xtemp; ++i)
                        {
                            Rectangle r = new Rectangle(i * picSize, j * picSize,
                                picSize, picSize);
                            g.DrawImage(MapEditor.Int2MapImage(SmartPaste.State.Items.ImageInThemeBarIndex[index++]), r);
                        }
                    }
                    return AddNewImg;
                }
                else
                    return null;
            }
        }

        public static string TextShowStr
        {
            get
            {
                return "智能粘贴:" + "有" + SmartPaste.State.Items.Index.Count + "个图片元素 " +
                    SmartPaste.State.Size.Width + "×" + SmartPaste.State.Size.Height + SmartPaste.State.ToString();
            }
        }

        public static SmartPaste State = null;

        public static bool IsPasteIng = false;

        public static void Copy()
        {

        }

        public static bool Paste(MapPanelEditor mapEditor)
        {
            MapEditor = mapEditor;
            bool IsSuccessPaste = true;
            if (MapEditor.SelectedIndex == -1)
                return false;
            PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.PastePlace,MapEditor);
            try
            {
                if (SmartPaste.State == null)
                    return true;
                int num = MapPanelEditor.RowNum;
                int width = SmartPaste.State.Size.Width;
                int height = SmartPaste.State.Size.Height;
                if (SmartPaste.IsPasteIng == true)
                {
                    int minIndex = SmartPaste.State.MinIndex;
                    if (minIndex == -1) return false;
                    int iterator = 0;
                    foreach (int IndexTemp in SmartPaste.State.Items.Index)
                    {
                        if (SmartPaste.State.CopyKind == SmartPasteCopyKind.CtrlX)
                        {
                            OperationTemp.Items.Add(IndexTemp);
                            MapEditor.MapIMG_Block[IndexTemp] = MapEditor.ThemeBar[MapEditor.ThemeNum][(int)MapIdDefine.空地];
                        }
                        int Index = MapEditor.SelectedIndex + IndexTemp - minIndex;
                        int x = Index % num; int y = Index / num;
                        //if ((x + width) > num || (y + height) > num)
                        //    continue;
                        OperationTemp.Items.Add(Index);
                        MapEditor.MapIMG_Block[Index] = MapEditor.ImgAutoImg(SmartPaste.State.Items.Image[iterator++],SmartPaste.State.CopyMapThemeNum);
                    }
                }

            }
            catch
            {
                IsSuccessPaste = false;
            }
            finally
            {
                OnceOperation.Redo(OperationTemp);
            }
            if (SmartPaste.State.CopyKind == SmartPasteCopyKind.CtrlX)
                SmartPaste.State = null;
            return (IsSuccessPaste == false) ? false : true;
        }

        private static int _count = 0;
        private const int minSecond = 10;

        public static void HoverPasteInit()
        {
            _count = 0;
        }

        public static void ShowHoverPaste()
        {
            if (JudgeMouseIsInSelectedBlock() == true)
            {
                if (_count++ >= 33)
                    _count = 0;
            }
            else
            {
                _count = 0;
            }
            if (_count >= minSecond)
            {
                MapEditor.IsHoverShow = true;
            }
            else
            {
                MapEditor.IsHoverShow = false;
            }
        }

        static bool JudgeMouseIsInSelectedBlock()
        {
            if (MapEditor.SelectedIndex == -1) return false;
            int lenth = MapEditor.PictureSize;
            int selecteedLeft = MapEditor.MapLeft + MapEditor.SelectedIndex % (MapPanelEditor.RowNum) * lenth;
            int selectedTop = MapEditor.MapTop + MapEditor.SelectedIndex / (MapPanelEditor.LineNum) * lenth;
            Rectangle rec = new Rectangle(selecteedLeft, selectedTop, lenth, lenth);
            if (MapEditor.RectangleContainsPoint(rec, MapEditor.NowMouseMoveLocation) == true
                && State != null)
                return true;
            else
                return false;

        }

        public override string ToString()
        {
            switch (CopyKind)
            {
                case SmartPasteCopyKind.CtrlC:
                    return " 复制";
                case SmartPasteCopyKind.CtrlX:
                    return " 剪切";
                case SmartPasteCopyKind.NoneCopy:
                    return " null";
                default:
                    return " null";
            }
        }

    }

    enum SmartPasteCopyKind
    {
        NoneCopy,
        CtrlC,
        CtrlX,
    }

}

