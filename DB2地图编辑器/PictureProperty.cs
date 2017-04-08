using System.Drawing;

namespace DB2地图编辑器
{
    public class PictureProperty
    {
        private PictureProperty() { }

        public PictureProperty(int id,MapPanelEditor MapEditor)
        {
            IdShowStr = id < 256 ? ("Bin:" + id.ToString()) : ("组合放置" + (id - 256).ToString());
            Image = id < 256 ? MapEditor.ThemeBar[MapEditor.ThemeNum][id] : ComposePlace.List[id - 256].ShowImg;
        }

        public int Id { get; set; }
        public string IdShowStr { get; set; }
        public Image Image { get; set; }
    }
}
