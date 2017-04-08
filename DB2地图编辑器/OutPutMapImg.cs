using System.Drawing;
using System.Drawing.Imaging;

namespace DB2地图编辑器
{
    class OutPutMapImg
    {
        MapPanelEditor MapEditor;
        public OutPutMapImg(MapPanelEditor mapedi)
        {
            MapEditor = mapedi;
        }

        int _cellPicSize = 15;

        string _name = "out";

        public int CellPicSize
        {
            set { _cellPicSize = value; }
        }

        public string ImgName
        {
            set { _name = value; }
        }

        public void GenerateImg(string path, string name, ImageFormat format)
        {
            int xtemp = MapPanelEditor.RowNum;
            int ytemp = MapPanelEditor.LineNum;
            Image AddNewImg = new Bitmap(_cellPicSize * xtemp, _cellPicSize * ytemp);
            Graphics g = Graphics.FromImage(AddNewImg);

            int index = 0;
            for (int j = 0; j < ytemp; ++j)
            {
                for (int i = 0; i < xtemp; ++i)
                {
                    Rectangle rec = new Rectangle(i * _cellPicSize, j * _cellPicSize,
                        _cellPicSize, _cellPicSize);
                    g.DrawImage(MapEditor.MapIMG_Block[index++], rec);
                }
            }
            AddNewImg.Save(path + "\\" + name + ".jpg", format);

        }

        public void GenerateImg(string path, ImageFormat format)
        {
            int xtemp = MapPanelEditor.RowNum;
            int ytemp = MapPanelEditor.LineNum;
            Image AddNewImg = new Bitmap(_cellPicSize * xtemp, _cellPicSize * ytemp);
            Graphics g = Graphics.FromImage(AddNewImg);

            int index = 0;
            for (int j = 0; j < ytemp; ++j)
            {
                for (int i = 0; i < xtemp; ++i)
                {
                    Rectangle rec = new Rectangle(i * _cellPicSize, j * _cellPicSize,
                        _cellPicSize, _cellPicSize);
                    g.DrawImage(MapEditor.MapIMG_Block[index++], rec);
                }
            }
            AddNewImg.Save(path + "\\" + _name + ".jpg", format);

        }

    }
}

