using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using System.Windows.Forms;

namespace DB2地图编辑器
{
    class MapMorePictures
    {

        MapPanelEditor mapEditor;

        public MapMorePictures(MapPanelEditor mapedi)
        {

            mapEditor = mapedi;
            ImagOldLeft = mapEditor.MapLeft;
            ImagOldTop = mapEditor.MapTop;
            ImagBlockCusx1 = mapEditor.ImagBlockCusx1;
            ImagBlockCusy1 = mapEditor.ImagBlockCusy1;
            ImagBlockCusx2 = mapEditor.ImagBlockCusx2;
            ImagBlockCusy2 = mapEditor.ImagBlockCusy2;

            Index_Temp = (ImagBlockCusx1 - ImagOldLeft) / mapEditor.PictureSize +
                (ImagBlockCusy1 - ImagOldTop) / mapEditor.PictureSize * 40;

            xtemp = (ImagBlockCusx2 - ImagBlockCusx1) / mapEditor.PictureSize;
            ytemp = (ImagBlockCusy2 - ImagBlockCusy1) / mapEditor.PictureSize;

        }

        private int ImagOldLeft;
        private int ImagOldTop;
        private int ImagBlockCusx1;
        private int ImagBlockCusy1;
        private int ImagBlockCusx2;
        private int ImagBlockCusy2;

        private int Index_Temp;
        private int xtemp;
        readonly int ytemp;

        public bool Place()
        {
            PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.RectanglePastePlace,mapEditor);
            for (int j = 0; j < ytemp; ++j)
            {
                int index = 0;
                for (int i = 0; i < xtemp; ++i)
                {
                    index = i + Index_Temp + j * 40;
                    OperationTemp.Items.Add(index);
                    mapEditor.MapIMG_Block[index] = mapEditor.MapCathe;
                }
            }
            OnceOperation.Redo(OperationTemp);
            OnceOperation.ClearResume();

            mapEditor.DataInit();

            return true;

        }

        public bool MoveOperation(AroundMap map)
        {
            Image[] ImageCache = new Image[xtemp * ytemp];
            PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.LeftMove,mapEditor);

            switch (map)
            {
                case AroundMap.MapLeft:
                    for (int j = 0; j < ytemp; ++j)
                    {
                        ImageCache[j] = mapEditor.MapIMG_Block[0 + Index_Temp + j * 40 - 1];
                        for (int i = 0; i < xtemp; ++i)
                        {
                            int index = i + Index_Temp + j * 40 - 1;
                            OperationTemp.Items.Add(index);
                            mapEditor.MapIMG_Block[i + Index_Temp + j * 40 - 1] = mapEditor.MapIMG_Block[i + Index_Temp + j * 40];
                        }
                        OperationTemp.Items.Add(xtemp - 1 + Index_Temp + j * 40);
                        mapEditor.MapIMG_Block[xtemp - 1 + Index_Temp + j * 40] = ImageCache[j];
                    }
                    break;
                case AroundMap.MapRight:
                    for (int j = 0; j < ytemp; ++j)
                    {
                        ImageCache[j] = mapEditor.MapIMG_Block[xtemp - 1 + Index_Temp + j * 40 + 1];
                        for (int i = xtemp - 1; i >= 0; --i)
                        {
                            OperationTemp.Items.Add(i + Index_Temp + j * 40 + 1);
                            mapEditor.MapIMG_Block[i + Index_Temp + j * 40 + 1] = mapEditor.MapIMG_Block[i + Index_Temp + j * 40];
                        }
                        OperationTemp.Items.Add(0 + Index_Temp + j * 40);
                        mapEditor.MapIMG_Block[0 + Index_Temp + j * 40] = ImageCache[j];
                    }
                    break;
                case AroundMap.MapUp:
                    for (int i = 0; i < xtemp; ++i)
                    {
                        ImageCache[i] = mapEditor.MapIMG_Block[i + Index_Temp - 1 * 40];
                        for (int j = 0; j < ytemp; ++j)
                        {
                            OperationTemp.Items.Add(i + Index_Temp + j * 40 - 40);
                            mapEditor.MapIMG_Block[i + Index_Temp + j * 40 - 40] = mapEditor.MapIMG_Block[i + Index_Temp + j * 40];
                        }
                        OperationTemp.Items.Add(i + Index_Temp + (ytemp - 1) * 40);
                        mapEditor.MapIMG_Block[i + Index_Temp + (ytemp - 1) * 40] = ImageCache[i];
                    }
                    break;
                case AroundMap.MapDown:
                    for (int i = 0; i < xtemp; ++i)
                    {
                        ImageCache[i] = mapEditor.MapIMG_Block[i + Index_Temp + (ytemp) * 40];
                        for (int j = ytemp - 1; j >= 0; --j)
                        {
                            OperationTemp.Items.Add(i + Index_Temp + j * 40 + 40);
                            mapEditor.MapIMG_Block[i + Index_Temp + j * 40 + 40] = mapEditor.MapIMG_Block[i + Index_Temp + j * 40];
                        }
                        OperationTemp.Items.Add(i + Index_Temp + 0 * 40);
                        mapEditor.MapIMG_Block[i + Index_Temp + 0 * 40] = ImageCache[i];
                    }
                    break;
                default:
                    return false;
            }

            OnceOperation.Redo(OperationTemp);
            OnceOperation.ClearResume();

            mapEditor.DataInit();

            return true;

        }

    }
}
