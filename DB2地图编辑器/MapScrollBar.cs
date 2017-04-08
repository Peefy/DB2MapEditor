using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace DB2地图编辑器
{
    class MapScrollBar
    {
        private VScrollBar Map_VScrollBar;
        private HScrollBar Map_HScrollBar;
        private MapPanelEditor MyMapEditor;

        public MapScrollBar(VScrollBar vSB,HScrollBar hSB,MapPanelEditor mPE)
        {
            Map_VScrollBar = vSB;
            Map_HScrollBar = hSB;
            MyMapEditor = mPE;
        }

        public MapScrollBar ChangeInfo()
        {
            Map_VScrollBar.Maximum = MyMapEditor.PictureSize * MapPanelEditor.RowNum - MyMapEditor.Size.Height + 10;// Convert.ToInt32(MyMapEditor.PictureSize * 0.6);
            Map_HScrollBar.Maximum = MyMapEditor.PictureSize * MapPanelEditor.RowNum - MyMapEditor.Size.Width + 10;// Convert.ToInt32(MyMapEditor.PictureSize * 0.6);
            Map_HScrollBar.Minimum = 0;
            Map_VScrollBar.Minimum = 0;
            return this;
        }

        public MapScrollBar AutoDudge()
        {
            int H, V;
            H = MyMapEditor.SelectedIndex % (MapPanelEditor.RowNum) * MyMapEditor.PictureSize - MyMapEditor.Size.Width / 2;
            V = MyMapEditor.SelectedIndex / (MapPanelEditor.LineNum) * MyMapEditor.PictureSize - MyMapEditor.Size.Height / 2;
            Map_HScrollBar.Value =
                        MyPublicFuntion.MathFunctionDefine.Range(H, Map_HScrollBar.Minimum, Map_HScrollBar.Maximum);

            Map_VScrollBar.Value =
                           MyPublicFuntion.MathFunctionDefine.Range(V, Map_VScrollBar.Minimum, Map_VScrollBar.Maximum);

            MyMapEditor.MapLeft = -Map_HScrollBar.Value;
            MyMapEditor.MapTop = -Map_VScrollBar.Value;
            return this;
        }

    }
}
