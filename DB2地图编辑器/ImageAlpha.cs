using System.Drawing.Imaging;

namespace DB2地图编辑器
{
    class ImageAlpha
    {
        public ImageAlpha() { }

        public ImageAlpha(ImageAlphaLevel level)
        {
            TransparentLevel = level;
        }

        public ImageAttributes GetImageTransparentSet()
        {
            float[][] ptsArray =
                    {
                   new float[]{1,0,0,0,0},
                   new float[]{0,1,0,0,0},
                   new float[]{0,0,1,0,0},
                   new float[]{0,0,0,(int)(TransparentLevel)/100.0f,0},
                   new float[]{0,0,0,0,1},
                    };
            ColorMatrix clrMatrix = new ColorMatrix(ptsArray);
            ImageAttributes imgAttributes = new ImageAttributes();
            imgAttributes.SetColorMatrix(clrMatrix, ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            return imgAttributes;
        }

        public ImageAlphaLevel TransparentLevel = ImageAlphaLevel.HalfTransparent;
    }
    enum ImageAlphaLevel
    {
        Transparent = 0,
        InTransparent = 100,
        HalfTransparent = 50,
    }
}
