using System.Collections.Generic;
using System.Drawing;

namespace DB2地图编辑器
{
    class PlaceOperation
    {

        MapPanelEditor MapEditor;
        private PlaceOperation(MapPanelEditor mapEditor)
        {
            MapEditor = mapEditor;
        }

        public PlaceOperation(Kind kind,MapPanelEditor mapEditor)
        {
            MapEditor = mapEditor;
            OpKind = kind;
            Items = new MapBlockContent(mapEditor);
        }

        public Kind OpKind;
        public MapBlockContent Items;

        public enum Kind
        {
            SinglePlace,
            RectanglePastePlace,
            AllMap,
            PastePlace,
            UpMove,
            LeftMove,
            RightMove,
            DownMove,
        }
    }

    class MapBlockContent
    {

        MapPanelEditor MapEditor;

        public MapBlockContent(MapPanelEditor mapedi)
        {
            MapEditor = mapedi;
            Index = new Queue<int>();
            Image = new List<Image>();
            ImageInThemeBarIndex = new List<int>();
        }
        public Queue<int> Index;
        public List<Image> Image;
        public List<int> ImageInThemeBarIndex;
        public void Add(int index)
        {
            this.Index.Enqueue(index);
            this.Image.Add(MapEditor.MapIMG_Block[index]);
            this.ImageInThemeBarIndex.Add(MapEditor.MapImage2Int(MapEditor.MapIMG_Block[index]));
        }
        public void Add(int index, bool _bool)
        {
            this.Index.Enqueue(index);
            this.Image.Add(MapEditor.MapIMG_Block[index]);
            //this.ImageInThemeBarIndex.Add(MapEditor.MapImage2Int(MapEditor.MapIMG_Block[index]));
        }
    }

    class OnceOperation
    {
        private static Stack<PlaceOperation> Stack = new Stack<PlaceOperation>();
        private static Stack<PlaceOperation> ResumeStack = new Stack<PlaceOperation>();

        public static void Redo(PlaceOperation po)
        {
            Stack.Push(po);
        }
        public static void RedoOneMap(int index,MapPanelEditor MapEditor)
        {
            if (index == -1) return;
            PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.SinglePlace,MapEditor);
            OperationTemp.Items.Add(index);
            Redo(OperationTemp);
        }
        public static void RedoAllMap(MapPanelEditor MapEditor)
        {
            PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.AllMap,MapEditor);

            for (int index = 0; index <= MapPanelEditor.PictureTotal - 1; ++index)
            {
                OperationTemp.Items.Add(index);
            }
            OnceOperation.Redo(OperationTemp);
        }
        public static bool Undo(MapPanelEditor MapEditor)
        {
            if (OnceOperation.StackIsNull() == true)
                return false;
            PlaceOperation OperationTemp = Stack.Pop();

            PlaceOperation ResumeOpTemp = new PlaceOperation(PlaceOperation.Kind.SinglePlace,MapEditor);

            ResumeStack.Push(ResumeOpTemp);
            //ResumeStack.Push(ResumeOpTemp);
            //ResumeStack.Pop();
            switch (OperationTemp.OpKind)
            {
                case PlaceOperation.Kind.SinglePlace:
                case PlaceOperation.Kind.RectanglePastePlace:
                case PlaceOperation.Kind.AllMap:
                case PlaceOperation.Kind.LeftMove:
                case PlaceOperation.Kind.RightMove:
                case PlaceOperation.Kind.UpMove:
                case PlaceOperation.Kind.DownMove:
                case PlaceOperation.Kind.PastePlace:
                    int iterator = 0;
                    foreach (int IndexTemp in OperationTemp.Items.Index)
                    {
                        MapEditor.SelectedIndex = IndexTemp;
                        ResumeOpTemp.Items.Add(MapEditor.SelectedIndex);
                        MapEditor.MapIMG_Block[MapEditor.SelectedIndex] =
                            MapEditor.Int2MapImage(OperationTemp.Items.ImageInThemeBarIndex[iterator++]);
                        if (OperationTemp.Items.Image.Count == iterator) return true;
                    }
                    break;
            }
            ResumeStack.Push(ResumeOpTemp);
            //ResumeStack.Push(ResumeOpTemp);
            return true;
        }

        public static bool Resume(MapPanelEditor MapEditor)
        {
            if (ResumeStack.Count == 0) return false;
            PlaceOperation OperationTemp = ResumeStack.Pop();

            PlaceOperation CtrlzOpTemp = new PlaceOperation(PlaceOperation.Kind.SinglePlace,MapEditor);

            Stack.Push(CtrlzOpTemp);
            //Stack.Push(CtrlzOpTemp);

            switch (OperationTemp.OpKind)
            {
                case PlaceOperation.Kind.SinglePlace:
                case PlaceOperation.Kind.RectanglePastePlace:
                case PlaceOperation.Kind.AllMap:
                case PlaceOperation.Kind.LeftMove:
                case PlaceOperation.Kind.RightMove:
                case PlaceOperation.Kind.UpMove:
                case PlaceOperation.Kind.DownMove:
                case PlaceOperation.Kind.PastePlace:
                    int iterator = 0;
                    foreach (int IndexTemp in OperationTemp.Items.Index)
                    {
                        MapEditor.SelectedIndex = IndexTemp;
                        CtrlzOpTemp.Items.Add(MapEditor.SelectedIndex);
                        MapEditor.MapIMG_Block[MapEditor.SelectedIndex] =
                            MapEditor.Int2MapImage(OperationTemp.Items.ImageInThemeBarIndex[iterator++]);
                        if (OperationTemp.Items.Image.Count == iterator) return true;
                    }
                    break;
            }
            Stack.Push(CtrlzOpTemp);
            return true;
        }

        public static bool StackIsNull()
        {
            return Stack.Count == 0;
        }

        public static bool ResumeStackIsNull()
        {
            return ResumeStack.Count == 0;
        }

        public static void ClearResume() { ResumeStack.Clear(); }

    }

}
