using System.Collections.Generic;
using System.Drawing;

namespace DB2地图编辑器
{
    class LostMap
    {
        public LostMap() { }

        private int[][] Id =
        {
            new int[]{120},
            new int[]{120,168,190,193,200},
            new int[]{120,168,200},
            new int[]{120,168},
            new int[]{120,168,183,184,186,187,188,189,190},
            new int[]{120,168},
            new int[]{120,168,189,190},
            new int[]{120,168},
            new int[]{120,168,177,178,179,180,181,182,183,
                184,187,188,189,243,244,245,246,247,248,249,250,251,
                252,253,254,255},
        };

        public int ThemeTotalNum = 9;

        public const int TheId1P = 0;
        public const int TheId2P = 13;
        public const int TheLongId1P = 24;
        public const int TheLongId2P = 72;

        private bool IntArrayContains(int[] items,int find)
        {
            foreach(int num in items)
            {
                if (num == find)
                    return true;
            }
            return false;
        }

        public List<int> ReturnLostMapPictureId(MapPanelEditor mapEditor)
        {
            List<int> NowLost = new List<int>();
            int lenth = mapEditor.PictureSize;
            for (int i = 0; i < MapPanelEditor.PictureTotal; ++i)
            {
                int judge = mapEditor.MapImage2Int(mapEditor.MapIMG_Block[i]);
                if (IntArrayContains(Id[mapEditor.ThemeNum],judge))
                {
                    int Left = mapEditor.MapLeft + i % (MapPanelEditor.RowNum) * lenth;
                    int Top = mapEditor.MapTop + i / (MapPanelEditor.LineNum) * lenth;
                    NowLost.Add(i);
                }
            }

            return NowLost;
        }
        public List<int> JudgeMapLostIdAndDraw(Graphics g,MapPanelEditor mapEditor)
        {
            List<int> NowLost = new List<int>();
            int lenth = mapEditor.PictureSize;
            for (int i = 0; i < MapPanelEditor.PictureTotal; ++i)
            {
                int judge = mapEditor.MapImage2Int(mapEditor.MapIMG_Block[i]);
                if (IntArrayContains(Id[mapEditor.ThemeNum], judge))
                {
                    int Left = mapEditor.MapLeft + i % (MapPanelEditor.RowNum) * lenth;
                    int Top = mapEditor.MapTop + i / (MapPanelEditor.LineNum) * lenth;
                    NowLost.Add(judge);
                    if (g != null)
                    {
                        Pen p = new Pen(Color.Red, 2);
                        g.DrawLine(p, Left, Top, Left + lenth, Top + lenth);
                        g.DrawLine(p, Left + lenth, Top, Left, Top + lenth);
                    }

                }
            }

            return NowLost;
        }

    }
}
