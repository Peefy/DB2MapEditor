using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    class SmartEditor
    {
        MapPanelEditor MapEditor;
        private int AroundMapNumTotal = 0;

        public static List<PictureBox> ColorBlock = new List<PictureBox>();

        public SmartEditor(MapPanelEditor mapedi)
        {
            MapEditor = mapedi;

        }
        public void Start(MapStructureKind kind, List<PointBrush> DesBrushRanc, int index)
        {
            int IndexTemp = DesBrushRanc[index].clickindex;
            for (int jugdei = 0; jugdei < 8; jugdei++)
            {
                int JugdeIndex = AroundNowMapOfIndex(IndexTemp, (AroundMap)jugdei);
                if (JugdeIndex >= 0)
                {
                    int ii = 0;
                    for (; ii < DesBrushRanc.Count; ii++)
                    {
                        if (JugdeIndex == DesBrushRanc[ii].clickindex)
                        {
                            if (DesBrushRanc[ii].color == StructureMap2Color(kind))
                            {
                                AroundMapNumTotal |= 1 << jugdei;
                                break;
                            }

                        }
                    }
                    if (ii >= DesBrushRanc.Count)
                        AroundMapNumTotal &= ~(1 << jugdei);
                }
                else
                    AroundMapNumTotal |= 1 << jugdei;
            }

            MapEditor.MapIMG_Block[IndexTemp] = SmartEditorDefineMap(IndexTemp, kind);

        }

        private int AroundNowMapOfIndex(int nowIndex, AroundMap map)
        {
            if (nowIndex < 0)
                return -1;
            int xtemp = (nowIndex) % 40 + 1;
            int ytemp = (nowIndex) / 40 + 1;
            switch (map)
            {
                case AroundMap.MapUpLeft:
                    xtemp = xtemp - 1;
                    ytemp = ytemp - 1;
                    break;
                case AroundMap.MapUp:
                    ytemp = ytemp - 1;
                    break;
                case AroundMap.MapUpRight:
                    xtemp = xtemp + 1;
                    ytemp = ytemp - 1;
                    break;
                case AroundMap.MapLeft:
                    xtemp = xtemp - 1;
                    break;
                case AroundMap.MapRight:
                    xtemp = xtemp + 1;
                    break;
                case AroundMap.MapDownLeft:
                    xtemp = xtemp - 1;
                    ytemp = ytemp + 1;
                    break;
                case AroundMap.MapDown:
                    ytemp = ytemp + 1;
                    break;
                case AroundMap.MapDownRight:
                    xtemp = xtemp + 1;
                    ytemp = ytemp + 1;
                    break;
            }
            return JugdePointIsExistAndReturnIndex(xtemp, ytemp);
        }

        private int JugdePointIsExistAndReturnIndex(int x, int y)
        {
            if (x <= 0 || x >= MapPanelEditor.RowNum + 1)
            {
                return -1;
            }
            if (y <= 0 || y >= MapPanelEditor.RowNum + 1)
            {
                return -1;
            }
            return (y - 1) * MapPanelEditor.RowNum + (x - 1);
        }

        private Color StructureMap2Color(MapStructureKind kind)
        {
            switch (kind)
            {
                case MapStructureKind.Water:
                    return ColorBlock[0].BackColor;
                case MapStructureKind.Magma:
                    return ColorBlock[1].BackColor;
                case MapStructureKind.Universe:
                    return ColorBlock[3].BackColor;
                case MapStructureKind.MountainTop:
                    return ColorBlock[4].BackColor;
                case MapStructureKind.Ice:
                    return ColorBlock[2].BackColor;
                default:
                    return Color.Black;
            }
        }

        #region 智能编辑算法核心

        private Image SmartEditorDefineMap(int IndexTemp, MapStructureKind map)
        {
            int MapStructureKindNum = (int)map;
            switch (AroundMapNumTotal)
            {
                case 0:
                    return
                        MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //break;
                case 1:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //break;
                case 2:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //break;
                case 3:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //break;
                case 4:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //break;
                case 5:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //break;
                case 6:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //break;
                case 7:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                // break;
                case 8:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                   MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                // break;
                case 9:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //break;
                case 10:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                // break;
                case 11:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                //break;
                case 12:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //break;
                case 13:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //break;
                case 14:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                //break;
                case 15:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                //break;
                case 16:
                    //MapEditor.MapIMG_Block[IndexTemp] =
                    return
                   MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                // break;
                case 17:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                // break;
                case 18:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                // break;
                case 19:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                // break;
                case 20:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                // break;
                case 21:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 22:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 23:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 24:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 25:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                // break;
                case 26:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][58 + MapStructureKindNum];
                //  break;
                case 27:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][47 + MapStructureKindNum];
                //  break;
                case 28:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 29:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 30:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][43 + MapStructureKindNum];
                // break;
                case 31:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][32 + MapStructureKindNum];
                // break;
                case 32:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                // break;
                case 33:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 34:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                // break;
                case 35:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 36:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                // break;
                case 37:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                // break;
                case 38:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 39:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                // break;
                case 40:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                // break;
                case 41:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 42:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                // break;
                case 43:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                //   break;
                case 44:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 45:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //   break;
                case 46:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                //  break;
                case 47:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                // break;
                case 48:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                // break;
                case 49:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 50:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                // break;
                case 51:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                //  break;
                case 52:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 53:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                // break;
                case 54:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 55:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 56:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 57:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 58:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][58 + MapStructureKindNum];
                //  break;
                case 59:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][47 + MapStructureKindNum];
                //  break;
                case 60:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 61:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 62:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][43 + MapStructureKindNum];
                //  break;
                case 63:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][32 + MapStructureKindNum];
                //  break;
                case 64:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
              MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 65:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                // break;
                case 66:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 67:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 68:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 69:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //   break;
                case 70:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 71:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 72:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                //   break;
                case 73:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                //  break;
                case 74:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][60 + MapStructureKindNum];
                //  break;
                case 75:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][50 + MapStructureKindNum];
                //  break;
                case 76:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                // break;
                case 77:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                //  break;
                case 78:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][60 + MapStructureKindNum];
                //  break;
                case 79:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][50 + MapStructureKindNum];
                // break;
                case 80:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                // break;
                case 81:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                // break;
                case 82:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][59 + MapStructureKindNum];
                //  break;
                case 83:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][59 + MapStructureKindNum];
                //  break;
                case 84:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                //  break;
                case 85:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                // break;
                case 86:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][54 + MapStructureKindNum];
                // break;
                case 87:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][54 + MapStructureKindNum];
                // break;
                case 88:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][57 + MapStructureKindNum];
                // break;
                case 89:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][57 + MapStructureKindNum];
                // break;
                case 90:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                 MapEditor.ThemeBar[MapEditor.ThemeNum][71 + MapStructureKindNum];
                // break;
                case 91:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][66 + MapStructureKindNum];
                //  break;
                case 92:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][57 + MapStructureKindNum];
                //  break;
                case 93:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][57 + MapStructureKindNum];
                //  break;
                case 94:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][66 + MapStructureKindNum];
                //  break;
                case 95:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][65 + MapStructureKindNum];
                //  break;
                case 96:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 97:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 98:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 99:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 100:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //   break;
                case 101:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //   break;
                case 102:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 103:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 104:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //  break;
                case 105:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //  break;
                case 106:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][42 + MapStructureKindNum];
                //  break;
                case 107:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][30 + MapStructureKindNum];
                //  break;
                case 108:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //  break;
                case 109:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //  break;
                case 110:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][42 + MapStructureKindNum];
                // break;
                case 111:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][30 + MapStructureKindNum];
                // break;
                case 112:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                //  break;
                case 113:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                //  break;
                case 114:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][59 + MapStructureKindNum];
                //  break;
                case 115:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][59 + MapStructureKindNum];
                //  break;
                case 116:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                //  break;
                case 117:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][56 + MapStructureKindNum];
                //  break;
                case 118:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][54 + MapStructureKindNum];
                //  break;
                case 119:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][54 + MapStructureKindNum];
                //  break;
                case 120:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
                    MapEditor.ThemeBar[MapEditor.ThemeNum][55 + MapStructureKindNum];
                //  break;
                case 121:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][55 + MapStructureKindNum];
                //  break;
                case 122:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][62 + MapStructureKindNum];
                //  break;
                case 123:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][63 + MapStructureKindNum];
                //   break;
                case 124:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][55 + MapStructureKindNum];
                //  break;
                case 125:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][55 + MapStructureKindNum];
                //   break;
                case 126:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][69 + MapStructureKindNum];
                //   break;
                case 127:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][53 + MapStructureKindNum];
                //   break;
                case 128:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 129:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 130:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 131:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //   break;
                case 132:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 133:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //   break;
                case 134:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 135:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 136:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 137:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                // break;
                case 138:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                //   break;
                case 139:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                //  break;
                case 140:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                // break;
                case 141:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 142:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                //  break;
                case 143:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                //  break;
                case 144:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 145:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 146:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                //  break;
                case 147:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                //  break;
                case 148:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 149:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //   break;
                case 150:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 151:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 152:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 153:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 154:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][58 + MapStructureKindNum];
                //  break;
                case 155:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][47 + MapStructureKindNum];
                //  break;
                case 156:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 157:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 158:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][43 + MapStructureKindNum];
                //  break;
                case 159:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][32 + MapStructureKindNum];
                //  break;
                case 160:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 161:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 162:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 163:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 164:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 165:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][40 + MapStructureKindNum];
                //  break;
                case 166:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 167:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][39 + MapStructureKindNum];
                //  break;
                case 168:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 169:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 170:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                //  break;
                case 171:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                //  break;
                case 172:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 173:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][36 + MapStructureKindNum];
                //  break;
                case 174:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][44 + MapStructureKindNum];
                //  break;
                case 175:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][33 + MapStructureKindNum];
                //  break;
                case 176:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 177:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 178:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                //   break;
                case 179:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][48 + MapStructureKindNum];
                //   break;
                case 180:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //   break;
                case 181:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][34 + MapStructureKindNum];
                //  break;
                case 182:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 183:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][31 + MapStructureKindNum];
                //  break;
                case 184:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 185:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 186:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][58 + MapStructureKindNum];
                //  break;
                case 187:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][47 + MapStructureKindNum];
                // break;
                case 188:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //   break;
                case 189:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][35 + MapStructureKindNum];
                //  break;
                case 190:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][43 + MapStructureKindNum];
                //  break;
                case 191:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][32 + MapStructureKindNum];
                //  break;
                case 192:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                // break;
                case 193:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 194:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                // break;
                case 195:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //   break;
                case 196:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 197:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 198:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //   break;
                case 199:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //  break;
                case 200:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                //  break;
                case 201:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                //  break;
                case 202:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][60 + MapStructureKindNum];
                //  break;
                case 203:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][50 + MapStructureKindNum];
                //  break;
                case 204:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                //  break;
                case 205:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][52 + MapStructureKindNum];
                //  break;
                case 206:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][60 + MapStructureKindNum];
                //  break;
                case 207:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][50 + MapStructureKindNum];
                //  break;
                case 208:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //  break;
                case 209:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //  break;
                case 210:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][46 + MapStructureKindNum];
                //  break;
                case 211:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][46 + MapStructureKindNum];
                //  break;
                case 212:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //  break;
                case 213:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //  break;
                case 214:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][29 + MapStructureKindNum];
                // break;
                case 215:
                    // MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][29 + MapStructureKindNum];
                //  break;
                case 216:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][51 + MapStructureKindNum];
                //  break;
                case 217:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][51 + MapStructureKindNum];
                //  break;
                case 218:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][68 + MapStructureKindNum];
                //  break;
                case 219:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
               MapEditor.ThemeBar[MapEditor.ThemeNum][70 + MapStructureKindNum];
                //  break;
                case 220:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][51 + MapStructureKindNum];
                //  break;
                case 221:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][51 + MapStructureKindNum];
                //  break;
                case 222:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][67 + MapStructureKindNum];
                //  break;
                case 223:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][49 + MapStructureKindNum];
                //  break;
                case 224:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 225:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 226:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //   break;
                case 227:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //   break;
                case 228:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //  break;
                case 229:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][37 + MapStructureKindNum];
                //   break;
                case 230:
                    //    MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //   break;
                case 231:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][38 + MapStructureKindNum];
                //   break;
                case 232:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //   break;
                case 233:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //   break;
                case 234:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][42 + MapStructureKindNum];
                //   break;
                case 235:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][30 + MapStructureKindNum];
                //   break;
                case 236:
                    //    MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //   break;
                case 237:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][28 + MapStructureKindNum];
                //   break;
                case 238:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][42 + MapStructureKindNum];
                //   break;
                case 239:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][30 + MapStructureKindNum];
                //   break;
                case 240:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //   break;
                case 241:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //  break;
                case 242:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][46 + MapStructureKindNum];
                //   break;
                case 243:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][46 + MapStructureKindNum];
                //  break;
                case 244:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //   break;
                case 245:
                    //  MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][26 + MapStructureKindNum];
                //  break;
                case 246:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][29 + MapStructureKindNum];
                //   break;
                case 247:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][29 + MapStructureKindNum];
                //   break;
                case 248:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][27 + MapStructureKindNum];
                //   break;
                case 249:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][27 + MapStructureKindNum];
                //   break;
                case 250:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][61 + MapStructureKindNum];
                //   break;
                case 251:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][45 + MapStructureKindNum];
                //   break;
                case 252:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][27 + MapStructureKindNum];
                //   break;
                case 253:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][27 + MapStructureKindNum];
                //   break;
                case 254:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
      MapEditor.ThemeBar[MapEditor.ThemeNum][41 + MapStructureKindNum];
                //   break;
                case 255:
                    //   MapEditor.MapIMG_Block[IndexTemp] =
                    return
                MapEditor.ThemeBar[MapEditor.ThemeNum][25 + MapStructureKindNum];
                //   break;
                default:
                    return MapEditor.ThemeBar[MapEditor.ThemeNum][(int)MapIdDefine.空地];
            }
            //return MapEditor.ThemeBar[MapEditor.ThemeNum][25];
        }

        #endregion
    }

    enum AroundMap
    {
        MapNone = -1,
        MapUpLeft = 0,
        MapUp = 1,
        MapUpRight = 2,
        MapLeft = 3,
        MapRight = 4,
        MapDownLeft = 5,
        MapDown = 6,
        MapDownRight = 7
    }
    public enum MapStructureKind
    {
        Water = 0,
        Magma = 48,
        MountainTop = (int)(MapIdDefine.山地顶Start - MapIdDefine.水面Start),
        Universe = 88,
        Ice = (int)(MapIdDefine.冰面Start -MapIdDefine.水面Start),
    }
}

