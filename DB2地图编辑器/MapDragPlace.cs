using System.Drawing;

namespace DB2地图编辑器
{
    class MapDragPlace
    {
        public MapDragPlace() { }

        public static bool IsEnter = false;
        public static bool IsOver = false;

        private static Point nowPoint = new Point();

        public static Point NowPoint
        {
            get
            {
                return nowPoint;
            }
            set
            {
                nowPoint = value;
            }
        }
    }
}
