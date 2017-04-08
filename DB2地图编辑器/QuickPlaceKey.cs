using System.Windows.Forms;

namespace DB2地图编辑器
{
    class QuickPlaceKey
    {
        MapPanelEditor mapEditor;
        public QuickPlaceKey(MapPanelEditor mapedi) { mapEditor = mapedi; }
        public int KeyDownPlaceId { get; set; } 
        public void KeyNumQuickPlace(Keys key)
        {
            if (mapEditor.SelectedIndex == -1)
                return;
            int KeyVal = 0;
            if (key == Keys.D0) KeyVal = 10 - 1;
            else KeyVal = (int)(key - Keys.D0) - 1;
            if (mapEditor.ImagBlockCus == false)
            {
                OnceOperation.RedoOneMap(mapEditor.SelectedIndex,mapEditor);
                mapEditor.MapIMG_Block[mapEditor.SelectedIndex] =
                    mapEditor.ThemeBar[mapEditor.ThemeNum][KeyValueToMapId[KeyVal]];
                OnceOperation.ClearResume();
            }
            else
            {
                //if (mapEditor.NowMap == AroundMap.MapNone)
                 //   return;
                int ImagOldLeft = mapEditor.MapLeft;
                int ImagOldTop = mapEditor.MapTop;
                int ImagBlockCusx1 = mapEditor.ImagBlockCusx1;
                int ImagBlockCusy1 = mapEditor.ImagBlockCusy1;
                int ImagBlockCusx2 = mapEditor.ImagBlockCusx2;
                int ImagBlockCusy2 = mapEditor.ImagBlockCusy2;

                int Index_Temp = (ImagBlockCusx1 - ImagOldLeft) / mapEditor.PictureSize +
                    (ImagBlockCusy1 - ImagOldTop) / mapEditor.PictureSize * 40;
                int xtemp = (ImagBlockCusx2 - ImagBlockCusx1) / mapEditor.PictureSize;
                int ytemp = (ImagBlockCusy2 - ImagBlockCusy1) / mapEditor.PictureSize;

                PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.RectanglePastePlace,mapEditor);

                for (int j = 0; j < ytemp; ++j)
                {
                    int index = 0;
                    for (int i = 0; i < xtemp; ++i)
                    {
                        index = i + Index_Temp + j * 40;
                        OperationTemp.Items.Add(index);
                        mapEditor.MapIMG_Block[index] = mapEditor.ThemeBar[mapEditor.ThemeNum][KeyValueToMapId[KeyVal]];

                    }
                }
                OnceOperation.Redo(OperationTemp);
                OnceOperation.ClearResume();
                mapEditor.DataInit();
            }
        }

        public static int[] KeyValueToMapId = { 1, 2, 3, 4, 5, 6, 7, 8, 9, (int)MapIdDefine.轻旱地 };
    }

    enum QuickPlaceKeyKind
    {
        KeyNum1 = 0,
        KeyNum2 = 1,
        KeyNum3 = 2,
        KeyNum4 = 3,
        KeyNum5 = 4,
        KeyNum6 = 5,
        KeyNum7 = 6,
        KeyNum8 = 7,
        KeyNum9 = 8,
        KeyNum0 = 9,
    }

}
