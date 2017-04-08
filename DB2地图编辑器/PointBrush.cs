using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DB2地图编辑器
{
    public class PointBrush
    {
        public Point point = new Point();
        public Color color;
        public int clickindex;
        public PointBrush() { }
        public PointBrush(Point p, Color c, int i)
        {
            point = p;
            color = c;
            clickindex = i;
        }
    }
}
