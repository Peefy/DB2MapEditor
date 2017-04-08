using System.Collections.Generic;
using System.Drawing;

namespace DB2地图编辑器
{
    class ToolStripOperation
    {
        public const int minenum = 3;
        public static int MouseDownItemId = -1;
        public static int MouseDownItemIndex = -1;
        public const int AssistantConstant = 111;
        public static int TsCount = 10;

        public const int TsId = minenum * AssistantConstant;

        public static string GetKeepOutDeleteStr() { return "不允许删除的系统操作!"; }

        public static List<int> IndexList = new List<int>();

        public enum KindEnum
        {
            Save = minenum * 111,
            Open = 444,
            Export = 555,
            Undo = 666,
            Resume = 777,
            Copy = 888,
            Cut = 999,
            Paste = 1110,
            Grid = (11 * 111),
            SmartEdi = (12 * 111),
        }

        public static Image[] ImgList = {
            new Bitmap(Properties.Resources.op_save),
            new Bitmap(Properties.Resources.op_open),
            new Bitmap(Properties.Resources.op_export),
            new Bitmap(Properties.Resources.op_undo),
            new Bitmap(Properties.Resources.op_resume),
            new Bitmap(Properties.Resources.op_copy),
            new Bitmap(Properties.Resources.op_cut),
            new Bitmap(Properties.Resources.op_paste),
            new Bitmap(Properties.Resources.op_grid),
            new Bitmap(Properties.Resources.op_smartedi),
        };

        public static string[] StrList = {
            "保存地图方案",
            "载入地图方案",
            "生成地图代码",
            "撤销",
            "重做",
            "复制",
            "剪切",
            "粘贴",
            "编辑缩略图",
            "智能编辑",
        };


    }
}

