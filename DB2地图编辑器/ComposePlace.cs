using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace DB2地图编辑器
{
    class ComposePlace
    {
        MapPanelEditor mapEditor;
        public ComposePlace(MapPanelEditor MapEditor)
        {
            mapEditor = MapEditor;

            this.Items = new MapBlockContent(MapEditor);

            int ImagOldLeft = MapEditor.MapLeft;
            int ImagOldTop = MapEditor.MapTop;
            int ImagBlockCusx1 = MapEditor.ImagBlockCusx1;
            int ImagBlockCusy1 = MapEditor.ImagBlockCusy1;
            int ImagBlockCusx2 = MapEditor.ImagBlockCusx2;
            int ImagBlockCusy2 = MapEditor.ImagBlockCusy2;

            int Index_Temp = (ImagBlockCusx1 - ImagOldLeft) / MapEditor.PictureSize +
                (ImagBlockCusy1 - ImagOldTop) / MapEditor.PictureSize * 40;
            int xtemp = (ImagBlockCusx2 - ImagBlockCusx1) / MapEditor.PictureSize;
            int ytemp = (ImagBlockCusy2 - ImagBlockCusy1) / MapEditor.PictureSize;

            int picSize = 10;

            Image AddNewImg = new Bitmap(picSize * xtemp, picSize * ytemp);
            Graphics g = Graphics.FromImage(AddNewImg);

            for (int j = 0; j < ytemp; ++j)
            {
                int index = 0;
                for (int i = 0; i < xtemp; ++i)
                {
                    index = i + Index_Temp + j * 40;
                    this.Items.Add(index);
                    Rectangle r = new Rectangle(i * picSize, j * picSize,
                        picSize, picSize);
                    g.DrawImage(MapEditor.MapIMG_Block[index], r);
                }
            }
            this.ShowImg = AddNewImg;
            this.Size = new Size(xtemp, ytemp);
        }

        public ComposePlace(bool _bool,MapPanelEditor mapedi)
        {
            this.Items = new MapBlockContent(mapedi);
            this.mapEditor = mapedi;
        }

        public MapBlockContent Items;
        public Image ShowImg;
        public Size Size;

        public int MinIndex
        {
            get
            {
                if (Items.Index.Count == 0) return -1;
                else
                {
                    int min = MapPanelEditor.PictureTotal;
                    foreach (int data in Items.Index)
                    {
                        if (data <= min)
                            min = data;
                    }
                    return min;
                }
            }
        }

        public static List<ComposePlace> List = new List<ComposePlace>();

        static string path = AppInfo.GetConfigPath() + "\\ComPlace";

        public void WriteToFile(BinaryWriter w)
        {
            w.Write(this.Size.Width);
            w.Write(this.Size.Height);
            w.Write(this.Items.Index.Count);
            foreach (int i in this.Items.Index)
            {
                w.Write(i);
            }
            foreach (int i in this.Items.ImageInThemeBarIndex)
            {
                w.Write(i);
            }
            string indexTemp = List.IndexOf(this).ToString();
            //this.ShowImg.Save(path + "\\ComPlace" + indexTemp + "ShowImg.jpg");
        }

        public void ReadFromFile(BinaryReader r, string indexStr)
        {
            this.Size.Width = r.ReadInt32();
            this.Size.Height = r.ReadInt32();
            int count = r.ReadInt32();
            for (int i = 0; i < count; ++i)
                this.Items.Add(r.ReadInt32(), false);
            for (int i = 0; i < count; ++i)
                this.Items.ImageInThemeBarIndex.Add(r.ReadInt32());
            int picSize = 10;
            int xtemp = this.Size.Width;
            int ytemp = this.Size.Height;
            Image AddNewImg = new Bitmap(picSize * xtemp, picSize * ytemp);
            Graphics g = Graphics.FromImage(AddNewImg);

            int index = 0;
            for (int j = 0; j < ytemp; ++j)
            {
                for (int i = 0; i < xtemp; ++i)
                {
                    var rec = new Rectangle(i * picSize, j * picSize,
                        picSize, picSize);
                    g.DrawImage(mapEditor.Int2MapImage(Items.ImageInThemeBarIndex[index++]), rec);
                }
            }
            this.ShowImg = AddNewImg;
        }

        public void RenewShowImgAndItemImage()
        {
            int picSize = 10;
            int xtemp = this.Size.Width;
            int ytemp = this.Size.Height;
            Image AddNewImg = new Bitmap(picSize * xtemp, picSize * ytemp);
            Graphics g = Graphics.FromImage(AddNewImg);

            int index = 0;
            for (int j = 0; j < ytemp; ++j)
            {
                for (int i = 0; i < xtemp; ++i)
                {
                    Rectangle rec = new Rectangle(i * picSize, j * picSize,
                        picSize, picSize);
                    g.DrawImage(mapEditor.Int2MapImage(this.Items.ImageInThemeBarIndex[index++]), rec);
                }
            }
            this.ShowImg = AddNewImg;

            for (int i = 0; i < this.Items.Index.Count; ++i)
            {
                this.Items.Image[i] = mapEditor.Int2MapImage(this.Items.ImageInThemeBarIndex[i]);
            }

        }

    }
}

