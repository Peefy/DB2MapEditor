using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DB2地图编辑器
{
    class BrushBlockHelper
    {

        #region 颜色定义

        Color ColorTengWan = Color.Green;
        Color ColorCaoDi = Color.GreenYellow;
        Color ColorKongDi = Color.FromKnownColor(KnownColor.Control);
        Color ColorShiDi = Color.LightSeaGreen;
        Color ColorKeng = Color.Black;
        Color ColorHanDi = Color.Gray;
        Color ColorHuaDi = Color.GreenYellow;
        Color ColorSiDi = Color.RosyBrown;
        Color ColorShu = Color.Green;
        Color ColorShiTou = Color.Brown;
        Color ColorHuoYan = Color.Red;
        Color ColorShuiMian = Color.LightBlue;
        Color ColorYanJiang = Color.IndianRed;
        Color ColorShanDi = Color.SandyBrown;
        Color ColorShaDi = Color.Khaki;
        Color ColorXueDi = Color.LightCyan;
        Color ColorBingMian = Color.LightSkyBlue;

        #endregion

        public List<SolidBrush[]> BrushBlock = new List<SolidBrush[]>();
        public List<List<Bitmap>> GameGridImageList = new List<List<Bitmap>>();

        public BrushBlockHelper()
        {

                #region 遗迹主题

                SolidBrush[] brush_YiJi = new SolidBrush[256];
                brush_YiJi[0] = new SolidBrush(Color.Yellow);
                brush_YiJi[1] = new SolidBrush(Color.Green);
                brush_YiJi[2] = new SolidBrush(Color.Green);
                brush_YiJi[3] = new SolidBrush(Color.Green);
                brush_YiJi[4] = new SolidBrush(Color.Green);
                brush_YiJi[5] = new SolidBrush(Color.GreenYellow);
                brush_YiJi[6] = new SolidBrush(Color.GreenYellow);
                brush_YiJi[7] = new SolidBrush(Color.GreenYellow);
                brush_YiJi[8] = new SolidBrush(Color.GreenYellow);
                brush_YiJi[9] = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
                brush_YiJi[10] = new SolidBrush(Color.LightSeaGreen);
                brush_YiJi[11] = new SolidBrush(Color.LightSeaGreen);
                brush_YiJi[12] = new SolidBrush(Color.Black);
                brush_YiJi[13] = new SolidBrush(Color.DarkRed);
                brush_YiJi[14] = new SolidBrush(Color.Gray);
                brush_YiJi[15] = new SolidBrush(Color.GreenYellow);
                brush_YiJi[16] = new SolidBrush(Color.GreenYellow);
                brush_YiJi[17] = new SolidBrush(Color.GreenYellow);
                brush_YiJi[18] = new SolidBrush(Color.RosyBrown);
                brush_YiJi[19] = new SolidBrush(Color.Gray);
                brush_YiJi[20] = new SolidBrush(Color.Red);
                brush_YiJi[21] = new SolidBrush(Color.Brown);
                brush_YiJi[22] = new SolidBrush(Color.Brown);
                brush_YiJi[23] = new SolidBrush(Color.Green);
                brush_YiJi[24] = new SolidBrush(Color.LightGreen);
                brush_YiJi[25] = new SolidBrush(Color.LightBlue);
                brush_YiJi[26] = new SolidBrush(Color.LightBlue);
                brush_YiJi[27] = new SolidBrush(Color.LightBlue);
                brush_YiJi[28] = new SolidBrush(Color.LightBlue);
                brush_YiJi[29] = new SolidBrush(Color.LightBlue);
                brush_YiJi[30] = new SolidBrush(Color.LightBlue);
                brush_YiJi[31] = new SolidBrush(Color.LightBlue);
                brush_YiJi[32] = new SolidBrush(Color.LightBlue);
                brush_YiJi[33] = new SolidBrush(Color.LightBlue);
                brush_YiJi[34] = new SolidBrush(Color.LightBlue);
                brush_YiJi[35] = new SolidBrush(Color.LightBlue);
                brush_YiJi[36] = new SolidBrush(Color.LightBlue);
                brush_YiJi[37] = new SolidBrush(Color.LightBlue);
                brush_YiJi[38] = new SolidBrush(Color.LightBlue);
                brush_YiJi[39] = new SolidBrush(Color.LightBlue);
                brush_YiJi[40] = new SolidBrush(Color.LightBlue);
                brush_YiJi[41] = new SolidBrush(Color.LightBlue);
                brush_YiJi[42] = new SolidBrush(Color.LightBlue);
                brush_YiJi[43] = new SolidBrush(Color.LightBlue);
                brush_YiJi[44] = new SolidBrush(Color.LightBlue);
                brush_YiJi[45] = new SolidBrush(Color.LightBlue);
                brush_YiJi[46] = new SolidBrush(Color.LightBlue);
                brush_YiJi[47] = new SolidBrush(Color.LightBlue);
                brush_YiJi[48] = new SolidBrush(Color.LightBlue);
                brush_YiJi[49] = new SolidBrush(Color.LightBlue);
                brush_YiJi[50] = new SolidBrush(Color.LightBlue);
                brush_YiJi[51] = new SolidBrush(Color.LightBlue);
                brush_YiJi[52] = new SolidBrush(Color.LightBlue);
                brush_YiJi[53] = new SolidBrush(Color.LightBlue);
                brush_YiJi[54] = new SolidBrush(Color.LightBlue);
                brush_YiJi[55] = new SolidBrush(Color.LightBlue);
                brush_YiJi[56] = new SolidBrush(Color.LightBlue);
                brush_YiJi[57] = new SolidBrush(Color.LightBlue);
                brush_YiJi[58] = new SolidBrush(Color.LightBlue);
                brush_YiJi[59] = new SolidBrush(Color.LightBlue);
                brush_YiJi[60] = new SolidBrush(Color.LightBlue);
                brush_YiJi[61] = new SolidBrush(Color.LightBlue);
                brush_YiJi[62] = new SolidBrush(Color.LightBlue);
                brush_YiJi[63] = new SolidBrush(Color.LightBlue);
                brush_YiJi[64] = new SolidBrush(Color.LightBlue);
                brush_YiJi[65] = new SolidBrush(Color.LightBlue);
                brush_YiJi[66] = new SolidBrush(Color.LightBlue);
                brush_YiJi[67] = new SolidBrush(Color.LightBlue);
                brush_YiJi[68] = new SolidBrush(Color.LightBlue);
                brush_YiJi[69] = new SolidBrush(Color.LightBlue);
                brush_YiJi[70] = new SolidBrush(Color.LightBlue);
                brush_YiJi[71] = new SolidBrush(Color.LightBlue);
                brush_YiJi[72] = new SolidBrush(Color.OrangeRed);
                brush_YiJi[73] = new SolidBrush(Color.IndianRed);
                brush_YiJi[74] = new SolidBrush(Color.IndianRed);
                brush_YiJi[75] = new SolidBrush(Color.IndianRed);
                brush_YiJi[76] = new SolidBrush(Color.IndianRed);
                brush_YiJi[77] = new SolidBrush(Color.IndianRed);
                brush_YiJi[78] = new SolidBrush(Color.IndianRed);
                brush_YiJi[79] = new SolidBrush(Color.IndianRed);
                brush_YiJi[80] = new SolidBrush(Color.IndianRed);
                brush_YiJi[81] = new SolidBrush(Color.IndianRed);
                brush_YiJi[82] = new SolidBrush(Color.IndianRed);
                brush_YiJi[83] = new SolidBrush(Color.IndianRed);
                brush_YiJi[84] = new SolidBrush(Color.IndianRed);
                brush_YiJi[85] = new SolidBrush(Color.IndianRed);
                brush_YiJi[86] = new SolidBrush(Color.IndianRed);
                brush_YiJi[87] = new SolidBrush(Color.IndianRed);
                brush_YiJi[88] = new SolidBrush(Color.IndianRed);
                brush_YiJi[89] = new SolidBrush(Color.IndianRed);
                brush_YiJi[90] = new SolidBrush(Color.IndianRed);
                brush_YiJi[91] = new SolidBrush(Color.IndianRed);
                brush_YiJi[92] = new SolidBrush(Color.IndianRed);
                brush_YiJi[93] = new SolidBrush(Color.IndianRed);
                brush_YiJi[94] = new SolidBrush(Color.IndianRed);
                brush_YiJi[95] = new SolidBrush(Color.IndianRed);
                brush_YiJi[96] = new SolidBrush(Color.IndianRed);
                brush_YiJi[97] = new SolidBrush(Color.IndianRed);
                brush_YiJi[98] = new SolidBrush(Color.IndianRed);
                brush_YiJi[99] = new SolidBrush(Color.IndianRed);
                brush_YiJi[100] = new SolidBrush(Color.IndianRed);
                brush_YiJi[101] = new SolidBrush(Color.IndianRed);
                brush_YiJi[102] = new SolidBrush(Color.IndianRed);
                brush_YiJi[103] = new SolidBrush(Color.IndianRed);
                brush_YiJi[104] = new SolidBrush(Color.IndianRed);
                brush_YiJi[105] = new SolidBrush(Color.IndianRed);
                brush_YiJi[106] = new SolidBrush(Color.IndianRed);
                brush_YiJi[107] = new SolidBrush(Color.IndianRed);
                brush_YiJi[108] = new SolidBrush(Color.IndianRed);
                brush_YiJi[109] = new SolidBrush(Color.IndianRed);
                brush_YiJi[110] = new SolidBrush(Color.IndianRed);
                brush_YiJi[111] = new SolidBrush(Color.IndianRed);
                brush_YiJi[112] = new SolidBrush(Color.IndianRed);
                brush_YiJi[113] = new SolidBrush(Color.IndianRed);
                brush_YiJi[114] = new SolidBrush(Color.IndianRed);
                brush_YiJi[115] = new SolidBrush(Color.IndianRed);
                brush_YiJi[116] = new SolidBrush(Color.IndianRed);
                brush_YiJi[117] = new SolidBrush(Color.IndianRed);
                brush_YiJi[118] = new SolidBrush(Color.IndianRed);
                brush_YiJi[119] = new SolidBrush(Color.IndianRed);
                brush_YiJi[120] = new SolidBrush(Color.Black);
                brush_YiJi[121] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[122] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[123] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[124] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[125] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[126] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[127] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[128] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[129] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[130] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[131] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[132] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[133] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[134] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[135] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[136] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[137] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[138] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[139] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[140] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[141] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[141] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[142] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[143] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[144] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[145] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[146] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[147] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[148] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[149] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[150] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[151] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[152] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[153] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[154] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[155] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[156] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[157] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[158] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[159] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[160] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[161] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[162] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[163] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[164] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[165] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[166] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[167] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[168] = new SolidBrush(Color.Black);
                brush_YiJi[169] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[170] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[171] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[172] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[173] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[174] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[175] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[176] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[177] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[178] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[179] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[180] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[181] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[182] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[183] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[184] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[185] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[186] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[187] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[188] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[190] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[191] = new SolidBrush(Color.Khaki);
                brush_YiJi[192] = new SolidBrush(Color.LightCyan);
                brush_YiJi[193] = new SolidBrush(Color.Brown);
                brush_YiJi[194] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[195] = new SolidBrush(Color.Green);
                brush_YiJi[196] = new SolidBrush(Color.Green);
                brush_YiJi[197] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[198] = new SolidBrush(Color.Brown);
                brush_YiJi[199] = new SolidBrush(Color.Brown);
                brush_YiJi[200] = new SolidBrush(Color.Brown);
                brush_YiJi[201] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[202] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[203] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[204] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[205] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[206] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[207] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[208] = new SolidBrush(Color.SandyBrown);
                brush_YiJi[209] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[210] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[211] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[212] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[213] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[214] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[215] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[216] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[217] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[218] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[219] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[220] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[221] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[222] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[223] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[224] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[225] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[226] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[227] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[228] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[229] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[230] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[231] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[232] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[233] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[234] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[235] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[236] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[237] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[238] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[239] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[240] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[241] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[242] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[243] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[244] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[245] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[246] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[247] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[248] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[249] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[250] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[251] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[252] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[253] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[254] = new SolidBrush(Color.LightSkyBlue);
                brush_YiJi[255] = new SolidBrush(Color.LightSkyBlue);

                #endregion
                #region 海岸主题

                SolidBrush[] brush_Coast = new SolidBrush[256];

                brush_Coast[0] = new SolidBrush(Color.Yellow);
                brush_Coast[1] = new SolidBrush(Color.Green);
                brush_Coast[2] = new SolidBrush(Color.Green);
                brush_Coast[3] = new SolidBrush(Color.Green);
                brush_Coast[4] = new SolidBrush(Color.Green);
                brush_Coast[5] = new SolidBrush(Color.GreenYellow);
                brush_Coast[6] = new SolidBrush(Color.GreenYellow);
                brush_Coast[7] = new SolidBrush(Color.GreenYellow);
                brush_Coast[8] = new SolidBrush(Color.GreenYellow);
                brush_Coast[9] = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
                brush_Coast[10] = new SolidBrush(ColorShiDi);
                brush_Coast[11] = new SolidBrush(ColorShiDi);
                brush_Coast[12] = new SolidBrush(ColorKeng);
                brush_Coast[13] = new SolidBrush(Color.DarkRed);
                brush_Coast[14] = new SolidBrush(ColorHanDi);
                brush_Coast[15] = new SolidBrush(ColorHuaDi);
                brush_Coast[16] = new SolidBrush(ColorHuaDi);
                brush_Coast[17] = new SolidBrush(ColorHuaDi);
                brush_Coast[18] = new SolidBrush(ColorSiDi);
                brush_Coast[19] = new SolidBrush(ColorHanDi);
                brush_Coast[20] = new SolidBrush(ColorHuoYan);
                brush_Coast[21] = new SolidBrush(ColorShiTou);
                brush_Coast[22] = new SolidBrush(ColorShiTou);
                brush_Coast[23] = new SolidBrush(ColorShu);
                brush_Coast[24] = new SolidBrush(Color.LightGreen);
                brush_Coast[25] = new SolidBrush(ColorShuiMian);
                brush_Coast[26] = new SolidBrush(ColorShuiMian);
                brush_Coast[27] = new SolidBrush(ColorShuiMian);
                brush_Coast[28] = new SolidBrush(ColorShuiMian);
                brush_Coast[29] = new SolidBrush(ColorShuiMian);
                brush_Coast[30] = new SolidBrush(ColorShuiMian);
                brush_Coast[31] = new SolidBrush(ColorShuiMian);
                brush_Coast[32] = new SolidBrush(ColorShuiMian);
                brush_Coast[33] = new SolidBrush(ColorShuiMian);
                brush_Coast[34] = new SolidBrush(ColorShuiMian);
                brush_Coast[35] = new SolidBrush(ColorShuiMian);
                brush_Coast[36] = new SolidBrush(ColorShuiMian);
                brush_Coast[37] = new SolidBrush(ColorShuiMian);
                brush_Coast[38] = new SolidBrush(ColorShuiMian);
                brush_Coast[39] = new SolidBrush(ColorShuiMian);
                brush_Coast[40] = new SolidBrush(ColorShuiMian);
                brush_Coast[41] = new SolidBrush(ColorShuiMian);
                brush_Coast[42] = new SolidBrush(ColorShuiMian);
                brush_Coast[43] = new SolidBrush(ColorShuiMian);
                brush_Coast[44] = new SolidBrush(ColorShuiMian);
                brush_Coast[45] = new SolidBrush(ColorShuiMian);
                brush_Coast[46] = new SolidBrush(ColorShuiMian);
                brush_Coast[47] = new SolidBrush(ColorShuiMian);
                brush_Coast[48] = new SolidBrush(ColorShuiMian);
                brush_Coast[49] = new SolidBrush(ColorShuiMian);
                brush_Coast[50] = new SolidBrush(ColorShuiMian);
                brush_Coast[51] = new SolidBrush(ColorShuiMian);
                brush_Coast[52] = new SolidBrush(ColorShuiMian);
                brush_Coast[53] = new SolidBrush(ColorShuiMian);
                brush_Coast[54] = new SolidBrush(ColorShuiMian);
                brush_Coast[55] = new SolidBrush(ColorShuiMian);
                brush_Coast[56] = new SolidBrush(ColorShuiMian);
                brush_Coast[57] = new SolidBrush(ColorShuiMian);
                brush_Coast[58] = new SolidBrush(ColorShuiMian);
                brush_Coast[59] = new SolidBrush(ColorShuiMian);
                brush_Coast[60] = new SolidBrush(ColorShuiMian);
                brush_Coast[61] = new SolidBrush(ColorShuiMian);
                brush_Coast[62] = new SolidBrush(ColorShuiMian);
                brush_Coast[63] = new SolidBrush(ColorShuiMian);
                brush_Coast[64] = new SolidBrush(ColorShuiMian);
                brush_Coast[65] = new SolidBrush(ColorShuiMian);
                brush_Coast[66] = new SolidBrush(ColorShuiMian);
                brush_Coast[67] = new SolidBrush(ColorShuiMian);
                brush_Coast[68] = new SolidBrush(ColorShuiMian);
                brush_Coast[69] = new SolidBrush(ColorShuiMian);
                brush_Coast[70] = new SolidBrush(ColorShuiMian);
                brush_Coast[71] = new SolidBrush(ColorShuiMian);
                brush_Coast[72] = new SolidBrush(Color.OrangeRed);
                brush_Coast[73] = new SolidBrush(ColorYanJiang);
                brush_Coast[74] = new SolidBrush(ColorYanJiang);
                brush_Coast[75] = new SolidBrush(ColorYanJiang);
                brush_Coast[76] = new SolidBrush(ColorYanJiang);
                brush_Coast[77] = new SolidBrush(ColorYanJiang);
                brush_Coast[78] = new SolidBrush(ColorYanJiang);
                brush_Coast[79] = new SolidBrush(ColorYanJiang);
                brush_Coast[80] = new SolidBrush(ColorYanJiang);
                brush_Coast[81] = new SolidBrush(ColorYanJiang);
                brush_Coast[82] = new SolidBrush(ColorYanJiang);
                brush_Coast[83] = new SolidBrush(ColorYanJiang);
                brush_Coast[84] = new SolidBrush(ColorYanJiang);
                brush_Coast[85] = new SolidBrush(ColorYanJiang);
                brush_Coast[86] = new SolidBrush(ColorYanJiang);
                brush_Coast[87] = new SolidBrush(ColorYanJiang);
                brush_Coast[88] = new SolidBrush(ColorYanJiang);
                brush_Coast[89] = new SolidBrush(ColorYanJiang);
                brush_Coast[90] = new SolidBrush(ColorYanJiang);
                brush_Coast[91] = new SolidBrush(ColorYanJiang);
                brush_Coast[92] = new SolidBrush(ColorYanJiang);
                brush_Coast[93] = new SolidBrush(ColorYanJiang);
                brush_Coast[94] = new SolidBrush(ColorYanJiang);
                brush_Coast[95] = new SolidBrush(ColorYanJiang);
                brush_Coast[96] = new SolidBrush(ColorYanJiang);
                brush_Coast[97] = new SolidBrush(ColorYanJiang);
                brush_Coast[98] = new SolidBrush(ColorYanJiang);
                brush_Coast[99] = new SolidBrush(ColorYanJiang);
                brush_Coast[100] = new SolidBrush(ColorYanJiang);
                brush_Coast[101] = new SolidBrush(ColorYanJiang);
                brush_Coast[102] = new SolidBrush(ColorYanJiang);
                brush_Coast[103] = new SolidBrush(ColorYanJiang);
                brush_Coast[104] = new SolidBrush(ColorYanJiang);
                brush_Coast[105] = new SolidBrush(ColorYanJiang);
                brush_Coast[106] = new SolidBrush(ColorYanJiang);
                brush_Coast[107] = new SolidBrush(ColorYanJiang);
                brush_Coast[108] = new SolidBrush(ColorYanJiang);
                brush_Coast[109] = new SolidBrush(ColorYanJiang);
                brush_Coast[110] = new SolidBrush(ColorYanJiang);
                brush_Coast[111] = new SolidBrush(ColorYanJiang);
                brush_Coast[112] = new SolidBrush(ColorYanJiang);
                brush_Coast[113] = new SolidBrush(ColorYanJiang);
                brush_Coast[114] = new SolidBrush(ColorYanJiang);
                brush_Coast[115] = new SolidBrush(ColorYanJiang);
                brush_Coast[116] = new SolidBrush(ColorYanJiang);
                brush_Coast[117] = new SolidBrush(ColorYanJiang);
                brush_Coast[118] = new SolidBrush(ColorYanJiang);
                brush_Coast[119] = new SolidBrush(ColorYanJiang);
                brush_Coast[120] = new SolidBrush(ColorYanJiang);
                brush_Coast[121] = new SolidBrush(ColorShanDi);
                brush_Coast[122] = new SolidBrush(ColorShanDi);
                brush_Coast[123] = new SolidBrush(ColorShanDi);
                brush_Coast[124] = new SolidBrush(ColorShanDi);
                brush_Coast[125] = new SolidBrush(ColorShanDi);
                brush_Coast[126] = new SolidBrush(ColorShanDi);
                brush_Coast[127] = new SolidBrush(ColorShanDi);
                brush_Coast[128] = new SolidBrush(ColorShanDi);
                brush_Coast[129] = new SolidBrush(ColorShanDi);
                brush_Coast[130] = new SolidBrush(ColorShanDi);
                brush_Coast[131] = new SolidBrush(ColorShanDi);
                brush_Coast[132] = new SolidBrush(ColorShanDi);
                brush_Coast[133] = new SolidBrush(ColorShanDi);
                brush_Coast[134] = new SolidBrush(ColorShanDi);
                brush_Coast[135] = new SolidBrush(ColorShanDi);
                brush_Coast[136] = new SolidBrush(ColorShanDi);
                brush_Coast[137] = new SolidBrush(ColorShanDi);
                brush_Coast[138] = new SolidBrush(ColorShanDi);
                brush_Coast[139] = new SolidBrush(ColorShanDi);
                brush_Coast[140] = new SolidBrush(ColorShanDi);
                brush_Coast[141] = new SolidBrush(ColorShanDi);
                brush_Coast[142] = new SolidBrush(ColorShanDi);
                brush_Coast[143] = new SolidBrush(ColorShanDi);
                brush_Coast[144] = new SolidBrush(ColorShanDi);
                brush_Coast[145] = new SolidBrush(ColorShanDi);
                brush_Coast[146] = new SolidBrush(ColorShanDi);
                brush_Coast[147] = new SolidBrush(ColorShanDi);
                brush_Coast[148] = new SolidBrush(ColorShanDi);
                brush_Coast[149] = new SolidBrush(ColorShanDi);
                brush_Coast[150] = new SolidBrush(ColorShanDi);
                brush_Coast[151] = new SolidBrush(ColorShanDi);
                brush_Coast[152] = new SolidBrush(ColorShanDi);
                brush_Coast[153] = new SolidBrush(ColorShanDi);
                brush_Coast[154] = new SolidBrush(ColorShanDi);
                brush_Coast[155] = new SolidBrush(ColorShanDi);
                brush_Coast[156] = new SolidBrush(ColorShanDi);
                brush_Coast[157] = new SolidBrush(ColorShanDi);
                brush_Coast[158] = new SolidBrush(ColorShanDi);
                brush_Coast[159] = new SolidBrush(ColorShanDi);
                brush_Coast[160] = new SolidBrush(ColorShanDi);
                brush_Coast[161] = new SolidBrush(ColorShanDi);
                brush_Coast[162] = new SolidBrush(ColorShanDi);
                brush_Coast[163] = new SolidBrush(ColorShanDi);
                brush_Coast[164] = new SolidBrush(ColorShanDi);
                brush_Coast[165] = new SolidBrush(ColorShanDi);
                brush_Coast[166] = new SolidBrush(ColorShanDi);
                brush_Coast[167] = new SolidBrush(ColorShanDi);
                brush_Coast[168] = new SolidBrush(ColorShanDi);
                brush_Coast[169] = new SolidBrush(ColorShanDi);
                brush_Coast[170] = new SolidBrush(ColorShanDi);
                brush_Coast[171] = new SolidBrush(ColorShanDi);
                brush_Coast[172] = new SolidBrush(ColorShanDi);
                brush_Coast[173] = new SolidBrush(ColorShanDi);
                brush_Coast[174] = new SolidBrush(ColorShanDi);
                brush_Coast[175] = new SolidBrush(ColorShanDi);
                brush_Coast[176] = new SolidBrush(ColorShanDi);
                brush_Coast[177] = new SolidBrush(ColorShanDi);
                brush_Coast[178] = new SolidBrush(ColorShanDi);
                brush_Coast[179] = new SolidBrush(ColorShanDi);
                brush_Coast[180] = new SolidBrush(ColorShanDi);
                brush_Coast[181] = new SolidBrush(ColorShanDi);
                brush_Coast[182] = new SolidBrush(ColorShanDi);
                brush_Coast[183] = new SolidBrush(ColorShanDi);
                brush_Coast[184] = new SolidBrush(ColorShanDi);
                brush_Coast[185] = new SolidBrush(ColorShanDi);
                brush_Coast[186] = new SolidBrush(ColorShanDi);
                brush_Coast[187] = new SolidBrush(ColorShanDi);
                brush_Coast[188] = new SolidBrush(ColorShanDi);
                brush_Coast[189] = new SolidBrush(ColorShanDi);
                brush_Coast[190] = new SolidBrush(Color.Black);

                brush_Coast[191] = new SolidBrush(ColorShaDi);
                brush_Coast[192] = new SolidBrush(ColorXueDi);
                brush_Coast[193] = new SolidBrush(Color.Black);
                brush_Coast[194] = new SolidBrush(ColorShu);
                brush_Coast[195] = new SolidBrush(ColorShu);
                brush_Coast[196] = new SolidBrush(ColorShu);
                brush_Coast[197] = new SolidBrush(ColorShu);
                brush_Coast[198] = new SolidBrush(ColorShiTou);
                brush_Coast[199] = new SolidBrush(ColorShiTou);
                brush_Coast[200] = new SolidBrush(Color.Black);
                brush_Coast[201] = new SolidBrush(ColorShanDi);
                brush_Coast[202] = new SolidBrush(ColorShanDi);
                brush_Coast[203] = new SolidBrush(ColorShanDi);
                brush_Coast[204] = new SolidBrush(ColorShanDi);
                brush_Coast[205] = new SolidBrush(ColorShanDi);
                brush_Coast[206] = new SolidBrush(ColorShanDi);
                brush_Coast[207] = new SolidBrush(ColorShanDi);
                brush_Coast[208] = new SolidBrush(ColorShanDi);
                brush_Coast[208] = new SolidBrush(ColorBingMian);
                brush_Coast[209] = new SolidBrush(ColorBingMian);
                brush_Coast[210] = new SolidBrush(ColorBingMian);
                brush_Coast[211] = new SolidBrush(ColorBingMian);
                brush_Coast[212] = new SolidBrush(ColorBingMian);
                brush_Coast[213] = new SolidBrush(ColorBingMian);
                brush_Coast[214] = new SolidBrush(ColorBingMian);
                brush_Coast[215] = new SolidBrush(ColorBingMian);
                brush_Coast[216] = new SolidBrush(ColorBingMian);
                brush_Coast[217] = new SolidBrush(ColorBingMian);
                brush_Coast[218] = new SolidBrush(ColorBingMian);
                brush_Coast[219] = new SolidBrush(ColorBingMian);
                brush_Coast[220] = new SolidBrush(ColorBingMian);
                brush_Coast[221] = new SolidBrush(ColorBingMian);
                brush_Coast[222] = new SolidBrush(ColorBingMian);
                brush_Coast[223] = new SolidBrush(ColorBingMian);
                brush_Coast[224] = new SolidBrush(ColorBingMian);
                brush_Coast[225] = new SolidBrush(ColorBingMian);
                brush_Coast[226] = new SolidBrush(ColorBingMian);
                brush_Coast[227] = new SolidBrush(ColorBingMian);
                brush_Coast[228] = new SolidBrush(ColorBingMian);
                brush_Coast[229] = new SolidBrush(ColorBingMian);
                brush_Coast[230] = new SolidBrush(ColorBingMian);
                brush_Coast[231] = new SolidBrush(ColorBingMian);
                brush_Coast[232] = new SolidBrush(ColorBingMian);
                brush_Coast[233] = new SolidBrush(ColorBingMian);
                brush_Coast[234] = new SolidBrush(ColorBingMian);
                brush_Coast[235] = new SolidBrush(ColorBingMian);
                brush_Coast[236] = new SolidBrush(ColorBingMian);
                brush_Coast[237] = new SolidBrush(ColorBingMian);
                brush_Coast[238] = new SolidBrush(ColorBingMian);
                brush_Coast[239] = new SolidBrush(ColorBingMian);
                brush_Coast[240] = new SolidBrush(ColorBingMian);
                brush_Coast[241] = new SolidBrush(ColorBingMian);
                brush_Coast[242] = new SolidBrush(ColorBingMian);
                brush_Coast[243] = new SolidBrush(ColorBingMian);
                brush_Coast[244] = new SolidBrush(ColorBingMian);
                brush_Coast[245] = new SolidBrush(ColorBingMian);
                brush_Coast[246] = new SolidBrush(ColorBingMian);
                brush_Coast[247] = new SolidBrush(ColorBingMian);
                brush_Coast[248] = new SolidBrush(ColorBingMian);
                brush_Coast[249] = new SolidBrush(ColorBingMian);
                brush_Coast[250] = new SolidBrush(ColorBingMian);
                brush_Coast[251] = new SolidBrush(ColorBingMian);
                brush_Coast[252] = new SolidBrush(ColorBingMian);
                brush_Coast[253] = new SolidBrush(ColorBingMian);
                brush_Coast[254] = new SolidBrush(ColorBingMian);
                brush_Coast[255] = new SolidBrush(ColorBingMian);


                #endregion
                #region 山地主题

                SolidBrush[] brush_Hilly = new SolidBrush[256];

                brush_Hilly[0] = new SolidBrush(Color.Yellow);
                brush_Hilly[1] = new SolidBrush(Color.Green);
                brush_Hilly[2] = new SolidBrush(Color.Green);
                brush_Hilly[3] = new SolidBrush(Color.Green);
                brush_Hilly[4] = new SolidBrush(Color.Green);
                brush_Hilly[5] = new SolidBrush(ColorCaoDi);
                brush_Hilly[6] = new SolidBrush(ColorCaoDi);
                brush_Hilly[7] = new SolidBrush(ColorCaoDi);
                brush_Hilly[8] = new SolidBrush(ColorCaoDi);
                brush_Hilly[9] = new SolidBrush(ColorKongDi);
                brush_Hilly[10] = new SolidBrush(ColorShiDi);
                brush_Hilly[11] = new SolidBrush(ColorShiDi);
                brush_Hilly[12] = new SolidBrush(ColorKeng);
                brush_Hilly[13] = new SolidBrush(Color.DarkRed);
                brush_Hilly[14] = new SolidBrush(ColorHanDi);
                brush_Hilly[15] = new SolidBrush(ColorHuaDi);
                brush_Hilly[16] = new SolidBrush(ColorHuaDi);
                brush_Hilly[17] = new SolidBrush(ColorHuaDi);
                brush_Hilly[18] = new SolidBrush(ColorSiDi);
                brush_Hilly[19] = new SolidBrush(ColorHanDi);
                brush_Hilly[20] = new SolidBrush(ColorHuoYan);
                brush_Hilly[21] = new SolidBrush(ColorShiTou);
                brush_Hilly[22] = new SolidBrush(ColorShiTou);
                brush_Hilly[23] = new SolidBrush(ColorShu);
                brush_Hilly[24] = new SolidBrush(Color.LightGreen);
                brush_Hilly[25] = new SolidBrush(ColorShuiMian);
                brush_Hilly[26] = new SolidBrush(ColorShuiMian);
                brush_Hilly[27] = new SolidBrush(ColorShuiMian);
                brush_Hilly[28] = new SolidBrush(ColorShuiMian);
                brush_Hilly[29] = new SolidBrush(ColorShuiMian);
                brush_Hilly[30] = new SolidBrush(ColorShuiMian);
                brush_Hilly[31] = new SolidBrush(ColorShuiMian);
                brush_Hilly[32] = new SolidBrush(ColorShuiMian);
                brush_Hilly[33] = new SolidBrush(ColorShuiMian);
                brush_Hilly[34] = new SolidBrush(ColorShuiMian);
                brush_Hilly[35] = new SolidBrush(ColorShuiMian);
                brush_Hilly[36] = new SolidBrush(ColorShuiMian);
                brush_Hilly[37] = new SolidBrush(ColorShuiMian);
                brush_Hilly[38] = new SolidBrush(ColorShuiMian);
                brush_Hilly[39] = new SolidBrush(ColorShuiMian);
                brush_Hilly[40] = new SolidBrush(ColorShuiMian);
                brush_Hilly[41] = new SolidBrush(ColorShuiMian);
                brush_Hilly[42] = new SolidBrush(ColorShuiMian);
                brush_Hilly[43] = new SolidBrush(ColorShuiMian);
                brush_Hilly[44] = new SolidBrush(ColorShuiMian);
                brush_Hilly[45] = new SolidBrush(ColorShuiMian);
                brush_Hilly[46] = new SolidBrush(ColorShuiMian);
                brush_Hilly[47] = new SolidBrush(ColorShuiMian);
                brush_Hilly[48] = new SolidBrush(ColorShuiMian);
                brush_Hilly[49] = new SolidBrush(ColorShuiMian);
                brush_Hilly[50] = new SolidBrush(ColorShuiMian);
                brush_Hilly[51] = new SolidBrush(ColorShuiMian);
                brush_Hilly[52] = new SolidBrush(ColorShuiMian);
                brush_Hilly[53] = new SolidBrush(ColorShuiMian);
                brush_Hilly[54] = new SolidBrush(ColorShuiMian);
                brush_Hilly[55] = new SolidBrush(ColorShuiMian);
                brush_Hilly[56] = new SolidBrush(ColorShuiMian);
                brush_Hilly[57] = new SolidBrush(ColorShuiMian);
                brush_Hilly[58] = new SolidBrush(ColorShuiMian);
                brush_Hilly[59] = new SolidBrush(ColorShuiMian);
                brush_Hilly[60] = new SolidBrush(ColorShuiMian);
                brush_Hilly[61] = new SolidBrush(ColorShuiMian);
                brush_Hilly[62] = new SolidBrush(ColorShuiMian);
                brush_Hilly[63] = new SolidBrush(ColorShuiMian);
                brush_Hilly[64] = new SolidBrush(ColorShuiMian);
                brush_Hilly[65] = new SolidBrush(ColorShuiMian);
                brush_Hilly[66] = new SolidBrush(ColorShuiMian);
                brush_Hilly[67] = new SolidBrush(ColorShuiMian);
                brush_Hilly[68] = new SolidBrush(ColorShuiMian);
                brush_Hilly[69] = new SolidBrush(ColorShuiMian);
                brush_Hilly[70] = new SolidBrush(ColorShuiMian);
                brush_Hilly[71] = new SolidBrush(ColorShuiMian);
                brush_Hilly[72] = new SolidBrush(Color.OrangeRed);
                brush_Hilly[73] = new SolidBrush(ColorYanJiang);
                brush_Hilly[74] = new SolidBrush(ColorYanJiang);
                brush_Hilly[75] = new SolidBrush(ColorYanJiang);
                brush_Hilly[76] = new SolidBrush(ColorYanJiang);
                brush_Hilly[77] = new SolidBrush(ColorYanJiang);
                brush_Hilly[78] = new SolidBrush(ColorYanJiang);
                brush_Hilly[79] = new SolidBrush(ColorYanJiang);
                brush_Hilly[80] = new SolidBrush(ColorYanJiang);
                brush_Hilly[81] = new SolidBrush(ColorYanJiang);
                brush_Hilly[82] = new SolidBrush(ColorYanJiang);
                brush_Hilly[83] = new SolidBrush(ColorYanJiang);
                brush_Hilly[84] = new SolidBrush(ColorYanJiang);
                brush_Hilly[85] = new SolidBrush(ColorYanJiang);
                brush_Hilly[86] = new SolidBrush(ColorYanJiang);
                brush_Hilly[87] = new SolidBrush(ColorYanJiang);
                brush_Hilly[88] = new SolidBrush(ColorYanJiang);
                brush_Hilly[89] = new SolidBrush(ColorYanJiang);
                brush_Hilly[90] = new SolidBrush(ColorYanJiang);
                brush_Hilly[91] = new SolidBrush(ColorYanJiang);
                brush_Hilly[92] = new SolidBrush(ColorYanJiang);
                brush_Hilly[93] = new SolidBrush(ColorYanJiang);
                brush_Hilly[94] = new SolidBrush(ColorYanJiang);
                brush_Hilly[95] = new SolidBrush(ColorYanJiang);
                brush_Hilly[96] = new SolidBrush(ColorYanJiang);
                brush_Hilly[97] = new SolidBrush(ColorYanJiang);
                brush_Hilly[98] = new SolidBrush(ColorYanJiang);
                brush_Hilly[99] = new SolidBrush(ColorYanJiang);
                brush_Hilly[100] = new SolidBrush(ColorYanJiang);
                brush_Hilly[101] = new SolidBrush(ColorYanJiang);
                brush_Hilly[102] = new SolidBrush(ColorYanJiang);
                brush_Hilly[103] = new SolidBrush(ColorYanJiang);
                brush_Hilly[104] = new SolidBrush(ColorYanJiang);
                brush_Hilly[105] = new SolidBrush(ColorYanJiang);
                brush_Hilly[106] = new SolidBrush(ColorYanJiang);
                brush_Hilly[107] = new SolidBrush(ColorYanJiang);
                brush_Hilly[108] = new SolidBrush(ColorYanJiang);
                brush_Hilly[109] = new SolidBrush(ColorYanJiang);
                brush_Hilly[110] = new SolidBrush(ColorYanJiang);
                brush_Hilly[111] = new SolidBrush(ColorYanJiang);
                brush_Hilly[112] = new SolidBrush(ColorYanJiang);
                brush_Hilly[113] = new SolidBrush(ColorYanJiang);
                brush_Hilly[114] = new SolidBrush(ColorYanJiang);
                brush_Hilly[115] = new SolidBrush(ColorYanJiang);
                brush_Hilly[116] = new SolidBrush(ColorYanJiang);
                brush_Hilly[117] = new SolidBrush(ColorYanJiang);
                brush_Hilly[118] = new SolidBrush(ColorYanJiang);
                brush_Hilly[119] = new SolidBrush(ColorYanJiang);
                brush_Hilly[120] = new SolidBrush(ColorYanJiang);
                brush_Hilly[121] = new SolidBrush(ColorShanDi);
                brush_Hilly[122] = new SolidBrush(ColorShanDi);
                brush_Hilly[123] = new SolidBrush(ColorShanDi);
                brush_Hilly[124] = new SolidBrush(ColorShanDi);
                brush_Hilly[125] = new SolidBrush(ColorShanDi);
                brush_Hilly[126] = new SolidBrush(ColorShanDi);
                brush_Hilly[127] = new SolidBrush(ColorShanDi);
                brush_Hilly[128] = new SolidBrush(ColorShanDi);
                brush_Hilly[129] = new SolidBrush(ColorShanDi);
                brush_Hilly[130] = new SolidBrush(ColorShanDi);
                brush_Hilly[131] = new SolidBrush(ColorShanDi);
                brush_Hilly[132] = new SolidBrush(ColorShanDi);
                brush_Hilly[133] = new SolidBrush(ColorShanDi);
                brush_Hilly[134] = new SolidBrush(ColorShanDi);
                brush_Hilly[135] = new SolidBrush(ColorShanDi);
                brush_Hilly[136] = new SolidBrush(ColorShanDi);
                brush_Hilly[137] = new SolidBrush(ColorShanDi);
                brush_Hilly[138] = new SolidBrush(ColorShanDi);
                brush_Hilly[139] = new SolidBrush(ColorShanDi);
                brush_Hilly[140] = new SolidBrush(ColorShanDi);
                brush_Hilly[141] = new SolidBrush(ColorShanDi);
                brush_Hilly[142] = new SolidBrush(ColorShanDi);
                brush_Hilly[143] = new SolidBrush(ColorShanDi);
                brush_Hilly[144] = new SolidBrush(ColorShanDi);
                brush_Hilly[145] = new SolidBrush(ColorShanDi);
                brush_Hilly[146] = new SolidBrush(ColorShanDi);
                brush_Hilly[147] = new SolidBrush(ColorShanDi);
                brush_Hilly[148] = new SolidBrush(ColorShanDi);
                brush_Hilly[149] = new SolidBrush(ColorShanDi);
                brush_Hilly[150] = new SolidBrush(ColorShanDi);
                brush_Hilly[151] = new SolidBrush(ColorShanDi);
                brush_Hilly[152] = new SolidBrush(ColorShanDi);
                brush_Hilly[153] = new SolidBrush(ColorShanDi);
                brush_Hilly[154] = new SolidBrush(ColorShanDi);
                brush_Hilly[155] = new SolidBrush(ColorShanDi);
                brush_Hilly[156] = new SolidBrush(ColorShanDi);
                brush_Hilly[157] = new SolidBrush(ColorShanDi);
                brush_Hilly[158] = new SolidBrush(ColorShanDi);
                brush_Hilly[159] = new SolidBrush(ColorShanDi);
                brush_Hilly[160] = new SolidBrush(ColorShanDi);
                brush_Hilly[161] = new SolidBrush(ColorShanDi);
                brush_Hilly[162] = new SolidBrush(ColorShanDi);
                brush_Hilly[163] = new SolidBrush(ColorShanDi);
                brush_Hilly[164] = new SolidBrush(ColorShanDi);
                brush_Hilly[165] = new SolidBrush(ColorShanDi);
                brush_Hilly[166] = new SolidBrush(ColorShanDi);
                brush_Hilly[167] = new SolidBrush(ColorShanDi);
                brush_Hilly[168] = new SolidBrush(ColorShanDi);
                brush_Hilly[169] = new SolidBrush(ColorShanDi);
                brush_Hilly[170] = new SolidBrush(ColorShanDi);
                brush_Hilly[171] = new SolidBrush(ColorShanDi);
                brush_Hilly[172] = new SolidBrush(ColorShanDi);
                brush_Hilly[173] = new SolidBrush(ColorShanDi);
                brush_Hilly[174] = new SolidBrush(ColorShanDi);
                brush_Hilly[175] = new SolidBrush(ColorShanDi);
                brush_Hilly[176] = new SolidBrush(ColorShanDi);
                brush_Hilly[177] = new SolidBrush(ColorShanDi);
                brush_Hilly[178] = new SolidBrush(ColorShanDi);
                brush_Hilly[179] = new SolidBrush(ColorShanDi);
                brush_Hilly[180] = new SolidBrush(ColorShanDi);
                brush_Hilly[181] = new SolidBrush(ColorShanDi);
                brush_Hilly[182] = new SolidBrush(ColorShanDi);
                brush_Hilly[183] = new SolidBrush(ColorShanDi);
                brush_Hilly[184] = new SolidBrush(ColorShanDi);
                brush_Hilly[185] = new SolidBrush(ColorShanDi);
                brush_Hilly[186] = new SolidBrush(ColorShanDi);
                brush_Hilly[187] = new SolidBrush(ColorSiDi);
                brush_Hilly[188] = new SolidBrush(ColorSiDi);
                brush_Hilly[189] = new SolidBrush(ColorShanDi);
                brush_Hilly[190] = new SolidBrush(ColorHuoYan);
                brush_Hilly[191] = new SolidBrush(ColorShaDi);
                brush_Hilly[192] = new SolidBrush(ColorXueDi);
                brush_Hilly[193] = new SolidBrush(ColorShanDi);
                brush_Hilly[194] = new SolidBrush(ColorShu);
                brush_Hilly[195] = new SolidBrush(ColorShanDi);
                brush_Hilly[196] = new SolidBrush(ColorShu);
                brush_Hilly[197] = new SolidBrush(ColorShu);
                brush_Hilly[198] = new SolidBrush(ColorShiTou);
                brush_Hilly[199] = new SolidBrush(ColorShiTou);
                brush_Hilly[200] = new SolidBrush(ColorShiTou);
                brush_Hilly[201] = new SolidBrush(ColorShu);
                brush_Hilly[202] = new SolidBrush(ColorShu);
                brush_Hilly[203] = new SolidBrush(ColorShanDi);
                brush_Hilly[204] = new SolidBrush(ColorShanDi);
                brush_Hilly[205] = new SolidBrush(ColorShanDi);
                brush_Hilly[206] = new SolidBrush(ColorShanDi);
                brush_Hilly[207] = new SolidBrush(ColorShanDi);
                brush_Hilly[208] = new SolidBrush(ColorShanDi);
                brush_Hilly[209] = new SolidBrush(ColorShanDi);
                brush_Hilly[210] = new SolidBrush(ColorShanDi);
                brush_Hilly[211] = new SolidBrush(ColorShanDi);
                brush_Hilly[212] = new SolidBrush(ColorShanDi);
                brush_Hilly[213] = new SolidBrush(ColorShanDi);
                brush_Hilly[214] = new SolidBrush(ColorShanDi);
                brush_Hilly[215] = new SolidBrush(ColorShanDi);
                brush_Hilly[216] = new SolidBrush(ColorShanDi);
                brush_Hilly[217] = new SolidBrush(ColorShanDi);
                brush_Hilly[218] = new SolidBrush(ColorShanDi);
                brush_Hilly[219] = new SolidBrush(ColorShanDi);
                brush_Hilly[220] = new SolidBrush(ColorShanDi);
                brush_Hilly[221] = new SolidBrush(ColorShanDi);
                brush_Hilly[222] = new SolidBrush(ColorShanDi);
                brush_Hilly[223] = new SolidBrush(ColorShanDi);
                brush_Hilly[224] = new SolidBrush(ColorShanDi);
                brush_Hilly[225] = new SolidBrush(ColorShanDi);
                brush_Hilly[226] = new SolidBrush(ColorShanDi);
                brush_Hilly[227] = new SolidBrush(ColorShanDi);
                brush_Hilly[228] = new SolidBrush(ColorShanDi);
                brush_Hilly[229] = new SolidBrush(ColorShanDi);
                brush_Hilly[230] = new SolidBrush(ColorShanDi);
                brush_Hilly[231] = new SolidBrush(ColorShanDi);
                brush_Hilly[232] = new SolidBrush(ColorShanDi);
                brush_Hilly[233] = new SolidBrush(ColorShanDi);
                brush_Hilly[234] = new SolidBrush(ColorShanDi);
                brush_Hilly[235] = new SolidBrush(ColorShanDi);
                brush_Hilly[236] = new SolidBrush(ColorShanDi);
                brush_Hilly[237] = new SolidBrush(ColorShanDi);
                brush_Hilly[238] = new SolidBrush(ColorShanDi);
                brush_Hilly[239] = new SolidBrush(ColorShanDi);
                brush_Hilly[240] = new SolidBrush(ColorShanDi);
                brush_Hilly[241] = new SolidBrush(ColorShanDi);
                brush_Hilly[242] = new SolidBrush(ColorShanDi);
                brush_Hilly[243] = new SolidBrush(ColorShanDi);
                brush_Hilly[244] = new SolidBrush(ColorShanDi);
                brush_Hilly[245] = new SolidBrush(ColorShanDi);
                brush_Hilly[246] = new SolidBrush(ColorShanDi);
                brush_Hilly[247] = new SolidBrush(ColorShanDi);
                brush_Hilly[248] = new SolidBrush(ColorShanDi);
                brush_Hilly[249] = new SolidBrush(ColorShanDi);
                brush_Hilly[250] = new SolidBrush(ColorShanDi);
                brush_Hilly[251] = new SolidBrush(ColorShanDi);
                brush_Hilly[252] = new SolidBrush(ColorShanDi);
                brush_Hilly[253] = new SolidBrush(ColorShanDi);
                brush_Hilly[254] = new SolidBrush(ColorShanDi);
                brush_Hilly[255] = new SolidBrush(ColorShanDi);


                #endregion
                #region 城堡主题

                SolidBrush[] brush_Tower = new SolidBrush[256];

                brush_Tower[0] = new SolidBrush(Color.Yellow);
                brush_Tower[1] = new SolidBrush(Color.Green);
                brush_Tower[2] = new SolidBrush(Color.Green);
                brush_Tower[3] = new SolidBrush(Color.Green);
                brush_Tower[4] = new SolidBrush(Color.Green);
                brush_Tower[5] = new SolidBrush(ColorCaoDi);
                brush_Tower[6] = new SolidBrush(ColorCaoDi);
                brush_Tower[7] = new SolidBrush(ColorCaoDi);
                brush_Tower[8] = new SolidBrush(ColorCaoDi);
                brush_Tower[9] = new SolidBrush(ColorKongDi);
                brush_Tower[10] = new SolidBrush(ColorShiDi);
                brush_Tower[11] = new SolidBrush(ColorShiDi);
                brush_Tower[12] = new SolidBrush(ColorKeng);
                brush_Tower[13] = new SolidBrush(Color.DarkRed);
                brush_Tower[14] = new SolidBrush(ColorHanDi);
                brush_Tower[15] = new SolidBrush(ColorHuaDi);
                brush_Tower[16] = new SolidBrush(ColorHuaDi);
                brush_Tower[17] = new SolidBrush(ColorHuaDi);
                brush_Tower[18] = new SolidBrush(ColorSiDi);
                brush_Tower[19] = new SolidBrush(ColorHanDi);
                brush_Tower[20] = new SolidBrush(ColorHuoYan);
                brush_Tower[21] = new SolidBrush(ColorShiTou);
                brush_Tower[22] = new SolidBrush(ColorShiTou);
                brush_Tower[23] = new SolidBrush(ColorShu);
                brush_Tower[24] = new SolidBrush(Color.LightGreen);
                brush_Tower[25] = new SolidBrush(ColorShuiMian);
                brush_Tower[26] = new SolidBrush(ColorShuiMian);
                brush_Tower[27] = new SolidBrush(ColorShuiMian);
                brush_Tower[28] = new SolidBrush(ColorShuiMian);
                brush_Tower[29] = new SolidBrush(ColorShuiMian);
                brush_Tower[30] = new SolidBrush(ColorShuiMian);
                brush_Tower[31] = new SolidBrush(ColorShuiMian);
                brush_Tower[32] = new SolidBrush(ColorShuiMian);
                brush_Tower[33] = new SolidBrush(ColorShuiMian);
                brush_Tower[34] = new SolidBrush(ColorShuiMian);
                brush_Tower[35] = new SolidBrush(ColorShuiMian);
                brush_Tower[36] = new SolidBrush(ColorShuiMian);
                brush_Tower[37] = new SolidBrush(ColorShuiMian);
                brush_Tower[38] = new SolidBrush(ColorShuiMian);
                brush_Tower[39] = new SolidBrush(ColorShuiMian);
                brush_Tower[40] = new SolidBrush(ColorShuiMian);
                brush_Tower[41] = new SolidBrush(ColorShuiMian);
                brush_Tower[42] = new SolidBrush(ColorShuiMian);
                brush_Tower[43] = new SolidBrush(ColorShuiMian);
                brush_Tower[44] = new SolidBrush(ColorShuiMian);
                brush_Tower[45] = new SolidBrush(ColorShuiMian);
                brush_Tower[46] = new SolidBrush(ColorShuiMian);
                brush_Tower[47] = new SolidBrush(ColorShuiMian);
                brush_Tower[48] = new SolidBrush(ColorShuiMian);
                brush_Tower[49] = new SolidBrush(ColorShuiMian);
                brush_Tower[50] = new SolidBrush(ColorShuiMian);
                brush_Tower[51] = new SolidBrush(ColorShuiMian);
                brush_Tower[52] = new SolidBrush(ColorShuiMian);
                brush_Tower[53] = new SolidBrush(ColorShuiMian);
                brush_Tower[54] = new SolidBrush(ColorShuiMian);
                brush_Tower[55] = new SolidBrush(ColorShuiMian);
                brush_Tower[56] = new SolidBrush(ColorShuiMian);
                brush_Tower[57] = new SolidBrush(ColorShuiMian);
                brush_Tower[58] = new SolidBrush(ColorShuiMian);
                brush_Tower[59] = new SolidBrush(ColorShuiMian);
                brush_Tower[60] = new SolidBrush(ColorShuiMian);
                brush_Tower[61] = new SolidBrush(ColorShuiMian);
                brush_Tower[62] = new SolidBrush(ColorShuiMian);
                brush_Tower[63] = new SolidBrush(ColorShuiMian);
                brush_Tower[64] = new SolidBrush(ColorShuiMian);
                brush_Tower[65] = new SolidBrush(ColorShuiMian);
                brush_Tower[66] = new SolidBrush(ColorShuiMian);
                brush_Tower[67] = new SolidBrush(ColorShuiMian);
                brush_Tower[68] = new SolidBrush(ColorShuiMian);
                brush_Tower[69] = new SolidBrush(ColorShuiMian);
                brush_Tower[70] = new SolidBrush(ColorShuiMian);
                brush_Tower[71] = new SolidBrush(ColorShuiMian);
                brush_Tower[72] = new SolidBrush(Color.OrangeRed);
                brush_Tower[73] = new SolidBrush(ColorYanJiang);
                brush_Tower[74] = new SolidBrush(ColorYanJiang);
                brush_Tower[75] = new SolidBrush(ColorYanJiang);
                brush_Tower[76] = new SolidBrush(ColorYanJiang);
                brush_Tower[77] = new SolidBrush(ColorYanJiang);
                brush_Tower[78] = new SolidBrush(ColorYanJiang);
                brush_Tower[79] = new SolidBrush(ColorYanJiang);
                brush_Tower[80] = new SolidBrush(ColorYanJiang);
                brush_Tower[81] = new SolidBrush(ColorYanJiang);
                brush_Tower[82] = new SolidBrush(ColorYanJiang);
                brush_Tower[83] = new SolidBrush(ColorYanJiang);
                brush_Tower[84] = new SolidBrush(ColorYanJiang);
                brush_Tower[85] = new SolidBrush(ColorYanJiang);
                brush_Tower[86] = new SolidBrush(ColorYanJiang);
                brush_Tower[87] = new SolidBrush(ColorYanJiang);
                brush_Tower[88] = new SolidBrush(ColorYanJiang);
                brush_Tower[89] = new SolidBrush(ColorYanJiang);
                brush_Tower[90] = new SolidBrush(ColorYanJiang);
                brush_Tower[91] = new SolidBrush(ColorYanJiang);
                brush_Tower[92] = new SolidBrush(ColorYanJiang);
                brush_Tower[93] = new SolidBrush(ColorYanJiang);
                brush_Tower[94] = new SolidBrush(ColorYanJiang);
                brush_Tower[95] = new SolidBrush(ColorYanJiang);
                brush_Tower[96] = new SolidBrush(ColorYanJiang);
                brush_Tower[97] = new SolidBrush(ColorYanJiang);
                brush_Tower[98] = new SolidBrush(ColorYanJiang);
                brush_Tower[99] = new SolidBrush(ColorYanJiang);
                brush_Tower[100] = new SolidBrush(ColorYanJiang);
                brush_Tower[101] = new SolidBrush(ColorYanJiang);
                brush_Tower[102] = new SolidBrush(ColorYanJiang);
                brush_Tower[103] = new SolidBrush(ColorYanJiang);
                brush_Tower[104] = new SolidBrush(ColorYanJiang);
                brush_Tower[105] = new SolidBrush(ColorYanJiang);
                brush_Tower[106] = new SolidBrush(ColorYanJiang);
                brush_Tower[107] = new SolidBrush(ColorYanJiang);
                brush_Tower[108] = new SolidBrush(ColorYanJiang);
                brush_Tower[109] = new SolidBrush(ColorYanJiang);
                brush_Tower[110] = new SolidBrush(ColorYanJiang);
                brush_Tower[111] = new SolidBrush(ColorYanJiang);
                brush_Tower[112] = new SolidBrush(ColorYanJiang);
                brush_Tower[113] = new SolidBrush(ColorYanJiang);
                brush_Tower[114] = new SolidBrush(ColorYanJiang);
                brush_Tower[115] = new SolidBrush(ColorYanJiang);
                brush_Tower[116] = new SolidBrush(ColorYanJiang);
                brush_Tower[117] = new SolidBrush(ColorYanJiang);
                brush_Tower[118] = new SolidBrush(ColorYanJiang);
                brush_Tower[119] = new SolidBrush(ColorYanJiang);
                brush_Tower[120] = new SolidBrush(ColorYanJiang);
                brush_Tower[121] = new SolidBrush(ColorShanDi);
                brush_Tower[122] = new SolidBrush(ColorShanDi);
                brush_Tower[123] = new SolidBrush(ColorShanDi);
                brush_Tower[124] = new SolidBrush(ColorShanDi);
                brush_Tower[125] = new SolidBrush(ColorShanDi);
                brush_Tower[126] = new SolidBrush(ColorShanDi);
                brush_Tower[127] = new SolidBrush(ColorShanDi);
                brush_Tower[128] = new SolidBrush(ColorShanDi);
                brush_Tower[129] = new SolidBrush(ColorShanDi);
                brush_Tower[130] = new SolidBrush(ColorShanDi);
                brush_Tower[131] = new SolidBrush(ColorShanDi);
                brush_Tower[132] = new SolidBrush(ColorShanDi);
                brush_Tower[133] = new SolidBrush(ColorShanDi);
                brush_Tower[134] = new SolidBrush(ColorShanDi);
                brush_Tower[135] = new SolidBrush(ColorShanDi);
                brush_Tower[136] = new SolidBrush(ColorShanDi);
                brush_Tower[137] = new SolidBrush(ColorShanDi);
                brush_Tower[138] = new SolidBrush(ColorShanDi);
                brush_Tower[139] = new SolidBrush(ColorShanDi);
                brush_Tower[140] = new SolidBrush(ColorShanDi);
                brush_Tower[141] = new SolidBrush(ColorShanDi);
                brush_Tower[142] = new SolidBrush(ColorShanDi);
                brush_Tower[143] = new SolidBrush(ColorShanDi);
                brush_Tower[144] = new SolidBrush(ColorShanDi);
                brush_Tower[145] = new SolidBrush(ColorShanDi);
                brush_Tower[146] = new SolidBrush(ColorShanDi);
                brush_Tower[147] = new SolidBrush(ColorShanDi);
                brush_Tower[148] = new SolidBrush(ColorShanDi);
                brush_Tower[149] = new SolidBrush(ColorShanDi);
                brush_Tower[150] = new SolidBrush(ColorShanDi);
                brush_Tower[151] = new SolidBrush(ColorShanDi);
                brush_Tower[152] = new SolidBrush(ColorShanDi);
                brush_Tower[153] = new SolidBrush(ColorShanDi);
                brush_Tower[154] = new SolidBrush(ColorShanDi);
                brush_Tower[155] = new SolidBrush(ColorShanDi);
                brush_Tower[156] = new SolidBrush(ColorShanDi);
                brush_Tower[157] = new SolidBrush(ColorShanDi);
                brush_Tower[158] = new SolidBrush(ColorShanDi);
                brush_Tower[159] = new SolidBrush(ColorShanDi);
                brush_Tower[160] = new SolidBrush(ColorShanDi);
                brush_Tower[161] = new SolidBrush(ColorShanDi);
                brush_Tower[162] = new SolidBrush(ColorShanDi);
                brush_Tower[163] = new SolidBrush(ColorShanDi);
                brush_Tower[164] = new SolidBrush(ColorShanDi);
                brush_Tower[165] = new SolidBrush(ColorShanDi);
                brush_Tower[166] = new SolidBrush(ColorShanDi);
                brush_Tower[167] = new SolidBrush(ColorShanDi);
                brush_Tower[168] = new SolidBrush(ColorShanDi);
                brush_Tower[169] = new SolidBrush(ColorShanDi);
                brush_Tower[170] = new SolidBrush(ColorShanDi);
                brush_Tower[171] = new SolidBrush(ColorShanDi);
                brush_Tower[172] = new SolidBrush(ColorShanDi);
                brush_Tower[173] = new SolidBrush(ColorShanDi);
                brush_Tower[174] = new SolidBrush(ColorShanDi);
                brush_Tower[175] = new SolidBrush(ColorShanDi);
                brush_Tower[176] = new SolidBrush(ColorShanDi);
                brush_Tower[177] = new SolidBrush(ColorShanDi);
                brush_Tower[178] = new SolidBrush(ColorShanDi);
                brush_Tower[179] = new SolidBrush(ColorShanDi);
                brush_Tower[180] = new SolidBrush(ColorShanDi);
                brush_Tower[181] = new SolidBrush(ColorShanDi);
                brush_Tower[182] = new SolidBrush(ColorShanDi);
                brush_Tower[183] = new SolidBrush(ColorShanDi);
                brush_Tower[184] = new SolidBrush(ColorShanDi);
                brush_Tower[185] = new SolidBrush(ColorShanDi);
                brush_Tower[186] = new SolidBrush(ColorShanDi);
                brush_Tower[187] = new SolidBrush(ColorShanDi);
                brush_Tower[188] = new SolidBrush(ColorShanDi);
                brush_Tower[189] = new SolidBrush(ColorShanDi);
                brush_Tower[190] = new SolidBrush(ColorShanDi);
                brush_Tower[191] = new SolidBrush(ColorShaDi);
                brush_Tower[192] = new SolidBrush(ColorXueDi);
                brush_Tower[193] = new SolidBrush(ColorShiTou);
                brush_Tower[194] = new SolidBrush(ColorShanDi);
                brush_Tower[195] = new SolidBrush(ColorShu);
                brush_Tower[196] = new SolidBrush(ColorShu);
                brush_Tower[197] = new SolidBrush(ColorShanDi);
                brush_Tower[198] = new SolidBrush(ColorShiTou);
                brush_Tower[199] = new SolidBrush(ColorShiTou);
                brush_Tower[200] = new SolidBrush(ColorShiTou);
                brush_Tower[201] = new SolidBrush(ColorShanDi);
                brush_Tower[202] = new SolidBrush(ColorShanDi);
                brush_Tower[203] = new SolidBrush(ColorShanDi);
                brush_Tower[204] = new SolidBrush(ColorShanDi);
                brush_Tower[205] = new SolidBrush(ColorShanDi);
                brush_Tower[206] = new SolidBrush(ColorShanDi);
                brush_Tower[207] = new SolidBrush(ColorShanDi);
                brush_Tower[208] = new SolidBrush(ColorShanDi);
                brush_Tower[209] = new SolidBrush(ColorBingMian);
                brush_Tower[210] = new SolidBrush(ColorBingMian);
                brush_Tower[211] = new SolidBrush(ColorBingMian);
                brush_Tower[212] = new SolidBrush(ColorBingMian);
                brush_Tower[213] = new SolidBrush(ColorBingMian);
                brush_Tower[214] = new SolidBrush(ColorBingMian);
                brush_Tower[215] = new SolidBrush(ColorBingMian);
                brush_Tower[216] = new SolidBrush(ColorBingMian);
                brush_Tower[217] = new SolidBrush(ColorBingMian);
                brush_Tower[218] = new SolidBrush(ColorBingMian);
                brush_Tower[219] = new SolidBrush(ColorBingMian);
                brush_Tower[220] = new SolidBrush(ColorBingMian);
                brush_Tower[221] = new SolidBrush(ColorBingMian);
                brush_Tower[222] = new SolidBrush(ColorBingMian);
                brush_Tower[223] = new SolidBrush(ColorBingMian);
                brush_Tower[224] = new SolidBrush(ColorBingMian);
                brush_Tower[225] = new SolidBrush(ColorBingMian);
                brush_Tower[226] = new SolidBrush(ColorBingMian);
                brush_Tower[227] = new SolidBrush(ColorBingMian);
                brush_Tower[228] = new SolidBrush(ColorBingMian);
                brush_Tower[229] = new SolidBrush(ColorBingMian);
                brush_Tower[230] = new SolidBrush(ColorBingMian);
                brush_Tower[231] = new SolidBrush(ColorBingMian);
                brush_Tower[232] = new SolidBrush(ColorBingMian);
                brush_Tower[233] = new SolidBrush(ColorBingMian);
                brush_Tower[234] = new SolidBrush(ColorBingMian);
                brush_Tower[235] = new SolidBrush(ColorBingMian);
                brush_Tower[236] = new SolidBrush(ColorBingMian);
                brush_Tower[237] = new SolidBrush(ColorBingMian);
                brush_Tower[238] = new SolidBrush(ColorBingMian);
                brush_Tower[239] = new SolidBrush(ColorBingMian);
                brush_Tower[240] = new SolidBrush(ColorBingMian);
                brush_Tower[241] = new SolidBrush(ColorBingMian);
                brush_Tower[242] = new SolidBrush(ColorBingMian);
                brush_Tower[243] = new SolidBrush(ColorBingMian);
                brush_Tower[244] = new SolidBrush(ColorBingMian);
                brush_Tower[245] = new SolidBrush(ColorBingMian);
                brush_Tower[246] = new SolidBrush(ColorBingMian);
                brush_Tower[247] = new SolidBrush(ColorBingMian);
                brush_Tower[248] = new SolidBrush(ColorBingMian);
                brush_Tower[249] = new SolidBrush(ColorBingMian);
                brush_Tower[250] = new SolidBrush(ColorBingMian);
                brush_Tower[251] = new SolidBrush(ColorBingMian);
                brush_Tower[252] = new SolidBrush(ColorBingMian);
                brush_Tower[253] = new SolidBrush(ColorBingMian);
                brush_Tower[254] = new SolidBrush(ColorBingMian);
                brush_Tower[255] = new SolidBrush(ColorBingMian);



                #endregion
                #region 城市主题

                SolidBrush[] brush_City = new SolidBrush[256];

                brush_City[0] = new SolidBrush(Color.Yellow);
                brush_City[1] = new SolidBrush(Color.Green);
                brush_City[2] = new SolidBrush(Color.Green);
                brush_City[3] = new SolidBrush(Color.Green);
                brush_City[4] = new SolidBrush(Color.Green);
                brush_City[5] = new SolidBrush(ColorCaoDi);
                brush_City[6] = new SolidBrush(ColorCaoDi);
                brush_City[7] = new SolidBrush(ColorCaoDi);
                brush_City[8] = new SolidBrush(ColorCaoDi);
                brush_City[9] = new SolidBrush(ColorKongDi);
                brush_City[10] = new SolidBrush(ColorShiDi);
                brush_City[11] = new SolidBrush(ColorShiDi);
                brush_City[12] = new SolidBrush(ColorKeng);
                brush_City[13] = new SolidBrush(Color.DarkRed);
                brush_City[14] = new SolidBrush(ColorHanDi);
                brush_City[15] = new SolidBrush(ColorHuaDi);
                brush_City[16] = new SolidBrush(ColorHuaDi);
                brush_City[17] = new SolidBrush(ColorHuaDi);
                brush_City[18] = new SolidBrush(ColorSiDi);
                brush_City[19] = new SolidBrush(ColorHanDi);
                brush_City[20] = new SolidBrush(ColorHuoYan);
                brush_City[21] = new SolidBrush(ColorShiTou);
                brush_City[22] = new SolidBrush(ColorShiTou);
                brush_City[23] = new SolidBrush(ColorShu);
                brush_City[24] = new SolidBrush(Color.LightGreen);
                brush_City[25] = new SolidBrush(ColorShuiMian);
                brush_City[26] = new SolidBrush(ColorShuiMian);
                brush_City[27] = new SolidBrush(ColorShuiMian);
                brush_City[28] = new SolidBrush(ColorShuiMian);
                brush_City[29] = new SolidBrush(ColorShuiMian);
                brush_City[30] = new SolidBrush(ColorShuiMian);
                brush_City[31] = new SolidBrush(ColorShuiMian);
                brush_City[32] = new SolidBrush(ColorShuiMian);
                brush_City[33] = new SolidBrush(ColorShuiMian);
                brush_City[34] = new SolidBrush(ColorShuiMian);
                brush_City[35] = new SolidBrush(ColorShuiMian);
                brush_City[36] = new SolidBrush(ColorShuiMian);
                brush_City[37] = new SolidBrush(ColorShuiMian);
                brush_City[38] = new SolidBrush(ColorShuiMian);
                brush_City[39] = new SolidBrush(ColorShuiMian);
                brush_City[40] = new SolidBrush(ColorShuiMian);
                brush_City[41] = new SolidBrush(ColorShuiMian);
                brush_City[42] = new SolidBrush(ColorShuiMian);
                brush_City[43] = new SolidBrush(ColorShuiMian);
                brush_City[44] = new SolidBrush(ColorShuiMian);
                brush_City[45] = new SolidBrush(ColorShuiMian);
                brush_City[46] = new SolidBrush(ColorShuiMian);
                brush_City[47] = new SolidBrush(ColorShuiMian);
                brush_City[48] = new SolidBrush(ColorShuiMian);
                brush_City[49] = new SolidBrush(ColorShuiMian);
                brush_City[50] = new SolidBrush(ColorShuiMian);
                brush_City[51] = new SolidBrush(ColorShuiMian);
                brush_City[52] = new SolidBrush(ColorShuiMian);
                brush_City[53] = new SolidBrush(ColorShuiMian);
                brush_City[54] = new SolidBrush(ColorShuiMian);
                brush_City[55] = new SolidBrush(ColorShuiMian);
                brush_City[56] = new SolidBrush(ColorShuiMian);
                brush_City[57] = new SolidBrush(ColorShuiMian);
                brush_City[58] = new SolidBrush(ColorShuiMian);
                brush_City[59] = new SolidBrush(ColorShuiMian);
                brush_City[60] = new SolidBrush(ColorShuiMian);
                brush_City[61] = new SolidBrush(ColorShuiMian);
                brush_City[62] = new SolidBrush(ColorShuiMian);
                brush_City[63] = new SolidBrush(ColorShuiMian);
                brush_City[64] = new SolidBrush(ColorShuiMian);
                brush_City[65] = new SolidBrush(ColorShuiMian);
                brush_City[66] = new SolidBrush(ColorShuiMian);
                brush_City[67] = new SolidBrush(ColorShuiMian);
                brush_City[68] = new SolidBrush(ColorShuiMian);
                brush_City[69] = new SolidBrush(ColorShuiMian);
                brush_City[70] = new SolidBrush(ColorShuiMian);
                brush_City[71] = new SolidBrush(ColorShuiMian);
                brush_City[72] = new SolidBrush(Color.OrangeRed);
                brush_City[73] = new SolidBrush(ColorYanJiang);
                brush_City[74] = new SolidBrush(ColorYanJiang);
                brush_City[75] = new SolidBrush(ColorYanJiang);
                brush_City[76] = new SolidBrush(ColorYanJiang);
                brush_City[77] = new SolidBrush(ColorYanJiang);
                brush_City[78] = new SolidBrush(ColorYanJiang);
                brush_City[79] = new SolidBrush(ColorYanJiang);
                brush_City[80] = new SolidBrush(ColorYanJiang);
                brush_City[81] = new SolidBrush(ColorYanJiang);
                brush_City[82] = new SolidBrush(ColorYanJiang);
                brush_City[83] = new SolidBrush(ColorYanJiang);
                brush_City[84] = new SolidBrush(ColorYanJiang);
                brush_City[85] = new SolidBrush(ColorYanJiang);
                brush_City[86] = new SolidBrush(ColorYanJiang);
                brush_City[87] = new SolidBrush(ColorYanJiang);
                brush_City[88] = new SolidBrush(ColorYanJiang);
                brush_City[89] = new SolidBrush(ColorYanJiang);
                brush_City[90] = new SolidBrush(ColorYanJiang);
                brush_City[91] = new SolidBrush(ColorYanJiang);
                brush_City[92] = new SolidBrush(ColorYanJiang);
                brush_City[93] = new SolidBrush(ColorYanJiang);
                brush_City[94] = new SolidBrush(ColorYanJiang);
                brush_City[95] = new SolidBrush(ColorYanJiang);
                brush_City[96] = new SolidBrush(ColorYanJiang);
                brush_City[97] = new SolidBrush(ColorYanJiang);
                brush_City[98] = new SolidBrush(ColorYanJiang);
                brush_City[99] = new SolidBrush(ColorYanJiang);
                brush_City[100] = new SolidBrush(ColorYanJiang);
                brush_City[101] = new SolidBrush(ColorYanJiang);
                brush_City[102] = new SolidBrush(ColorYanJiang);
                brush_City[103] = new SolidBrush(ColorYanJiang);
                brush_City[104] = new SolidBrush(ColorYanJiang);
                brush_City[105] = new SolidBrush(ColorYanJiang);
                brush_City[106] = new SolidBrush(ColorYanJiang);
                brush_City[107] = new SolidBrush(ColorYanJiang);
                brush_City[108] = new SolidBrush(ColorYanJiang);
                brush_City[109] = new SolidBrush(ColorYanJiang);
                brush_City[110] = new SolidBrush(ColorYanJiang);
                brush_City[111] = new SolidBrush(ColorYanJiang);
                brush_City[112] = new SolidBrush(ColorYanJiang);
                brush_City[113] = new SolidBrush(ColorYanJiang);
                brush_City[114] = new SolidBrush(ColorYanJiang);
                brush_City[115] = new SolidBrush(ColorYanJiang);
                brush_City[116] = new SolidBrush(ColorYanJiang);
                brush_City[117] = new SolidBrush(ColorYanJiang);
                brush_City[118] = new SolidBrush(ColorYanJiang);
                brush_City[119] = new SolidBrush(ColorYanJiang);
                brush_City[120] = new SolidBrush(ColorYanJiang);
                brush_City[121] = new SolidBrush(ColorShanDi);
                brush_City[122] = new SolidBrush(ColorShanDi);
                brush_City[123] = new SolidBrush(ColorShanDi);
                brush_City[124] = new SolidBrush(ColorShanDi);
                brush_City[125] = new SolidBrush(ColorShanDi);
                brush_City[126] = new SolidBrush(ColorShanDi);
                brush_City[127] = new SolidBrush(ColorShanDi);
                brush_City[128] = new SolidBrush(ColorShanDi);
                brush_City[129] = new SolidBrush(ColorShanDi);
                brush_City[130] = new SolidBrush(ColorShanDi);
                brush_City[131] = new SolidBrush(ColorShanDi);
                brush_City[132] = new SolidBrush(ColorShanDi);
                brush_City[133] = new SolidBrush(ColorShanDi);
                brush_City[134] = new SolidBrush(ColorShanDi);
                brush_City[135] = new SolidBrush(ColorShanDi);
                brush_City[136] = new SolidBrush(ColorShanDi);
                brush_City[137] = new SolidBrush(ColorShanDi);
                brush_City[138] = new SolidBrush(ColorShanDi);
                brush_City[139] = new SolidBrush(ColorShanDi);
                brush_City[140] = new SolidBrush(ColorShanDi);
                brush_City[141] = new SolidBrush(ColorShanDi);
                brush_City[142] = new SolidBrush(ColorShanDi);
                brush_City[143] = new SolidBrush(ColorShanDi);
                brush_City[144] = new SolidBrush(ColorShanDi);
                brush_City[145] = new SolidBrush(ColorShanDi);
                brush_City[146] = new SolidBrush(ColorShanDi);
                brush_City[147] = new SolidBrush(ColorShanDi);
                brush_City[148] = new SolidBrush(ColorShanDi);
                brush_City[149] = new SolidBrush(ColorShanDi);
                brush_City[150] = new SolidBrush(ColorShanDi);
                brush_City[151] = new SolidBrush(ColorShanDi);
                brush_City[152] = new SolidBrush(ColorShanDi);
                brush_City[153] = new SolidBrush(ColorShanDi);
                brush_City[154] = new SolidBrush(ColorShanDi);
                brush_City[155] = new SolidBrush(ColorShanDi);
                brush_City[156] = new SolidBrush(ColorShanDi);
                brush_City[157] = new SolidBrush(ColorShanDi);
                brush_City[158] = new SolidBrush(ColorShanDi);
                brush_City[159] = new SolidBrush(ColorShanDi);
                brush_City[160] = new SolidBrush(ColorShanDi);
                brush_City[161] = new SolidBrush(ColorShanDi);
                brush_City[162] = new SolidBrush(ColorShanDi);
                brush_City[163] = new SolidBrush(ColorShanDi);
                brush_City[164] = new SolidBrush(ColorShanDi);
                brush_City[165] = new SolidBrush(ColorShanDi);
                brush_City[166] = new SolidBrush(ColorShanDi);
                brush_City[167] = new SolidBrush(ColorShanDi);
                brush_City[168] = new SolidBrush(ColorShanDi);
                brush_City[169] = new SolidBrush(ColorShanDi);
                brush_City[170] = new SolidBrush(ColorShanDi);
                brush_City[171] = new SolidBrush(ColorShanDi);
                brush_City[172] = new SolidBrush(ColorShanDi);
                brush_City[173] = new SolidBrush(ColorShanDi);
                brush_City[174] = new SolidBrush(ColorShanDi);
                brush_City[175] = new SolidBrush(ColorShanDi);
                brush_City[176] = new SolidBrush(ColorShanDi);
                brush_City[177] = new SolidBrush(ColorShanDi);
                brush_City[178] = new SolidBrush(ColorShanDi);
                brush_City[179] = new SolidBrush(ColorShanDi);
                brush_City[180] = new SolidBrush(ColorShanDi);
                brush_City[181] = new SolidBrush(ColorShanDi);
                brush_City[182] = new SolidBrush(ColorShanDi);
                brush_City[183] = new SolidBrush(ColorShanDi);
                brush_City[184] = new SolidBrush(ColorShanDi);
                brush_City[185] = new SolidBrush(ColorShanDi);
                brush_City[186] = new SolidBrush(ColorShanDi);
                brush_City[187] = new SolidBrush(ColorShanDi);
                brush_City[188] = new SolidBrush(ColorShanDi);
                brush_City[189] = new SolidBrush(ColorShanDi);
                brush_City[190] = new SolidBrush(ColorShanDi);
                brush_City[191] = new SolidBrush(ColorShaDi);
                brush_City[192] = new SolidBrush(ColorXueDi);
                brush_City[193] = new SolidBrush(ColorShiTou);
                brush_City[194] = new SolidBrush(ColorShu);
                brush_City[195] = new SolidBrush(ColorShu);
                brush_City[196] = new SolidBrush(ColorShu);
                brush_City[197] = new SolidBrush(ColorShu);
                brush_City[198] = new SolidBrush(ColorShiTou);
                brush_City[199] = new SolidBrush(ColorShiTou);
                brush_City[200] = new SolidBrush(ColorShiTou);
                brush_City[201] = new SolidBrush(ColorSiDi);
                brush_City[202] = new SolidBrush(ColorSiDi);
                brush_City[203] = new SolidBrush(ColorSiDi);
                brush_City[204] = new SolidBrush(ColorSiDi);
                brush_City[205] = new SolidBrush(ColorSiDi);
                brush_City[206] = new SolidBrush(ColorSiDi);
                brush_City[207] = new SolidBrush(ColorSiDi);
                brush_City[208] = new SolidBrush(ColorSiDi);
                brush_City[209] = new SolidBrush(ColorSiDi);
                brush_City[210] = new SolidBrush(ColorSiDi);
                brush_City[211] = new SolidBrush(ColorSiDi);
                brush_City[212] = new SolidBrush(ColorSiDi);
                brush_City[213] = new SolidBrush(ColorSiDi);
                brush_City[214] = new SolidBrush(ColorSiDi);
                brush_City[215] = new SolidBrush(ColorSiDi);
                brush_City[216] = new SolidBrush(ColorSiDi);
                brush_City[217] = new SolidBrush(ColorSiDi);
                brush_City[218] = new SolidBrush(ColorSiDi);
                brush_City[219] = new SolidBrush(ColorSiDi);
                brush_City[220] = new SolidBrush(ColorSiDi);
                brush_City[221] = new SolidBrush(ColorSiDi);
                brush_City[222] = new SolidBrush(ColorSiDi);
                brush_City[223] = new SolidBrush(ColorSiDi);
                brush_City[224] = new SolidBrush(ColorSiDi);
                brush_City[225] = new SolidBrush(ColorSiDi);
                brush_City[226] = new SolidBrush(ColorSiDi);
                brush_City[227] = new SolidBrush(ColorSiDi);
                brush_City[228] = new SolidBrush(ColorSiDi);
                brush_City[229] = new SolidBrush(ColorSiDi);
                brush_City[230] = new SolidBrush(ColorSiDi);
                brush_City[231] = new SolidBrush(ColorSiDi);
                brush_City[232] = new SolidBrush(ColorSiDi);
                brush_City[233] = new SolidBrush(ColorSiDi);
                brush_City[234] = new SolidBrush(ColorSiDi);
                brush_City[235] = new SolidBrush(ColorSiDi);
                brush_City[236] = new SolidBrush(ColorSiDi);

                brush_City[237] = new SolidBrush(ColorShanDi);
                brush_City[238] = new SolidBrush(ColorShanDi);
                brush_City[239] = new SolidBrush(ColorShanDi);
                brush_City[240] = new SolidBrush(ColorShanDi);
                brush_City[241] = new SolidBrush(ColorYanJiang);
                brush_City[242] = new SolidBrush(ColorYanJiang);
                brush_City[243] = new SolidBrush(ColorYanJiang);
                brush_City[244] = new SolidBrush(ColorYanJiang);
                brush_City[245] = new SolidBrush(ColorShanDi);
                brush_City[246] = new SolidBrush(ColorShanDi);
                brush_City[247] = new SolidBrush(ColorShanDi);
                brush_City[248] = new SolidBrush(ColorShanDi);
                brush_City[249] = new SolidBrush(ColorShanDi);
                brush_City[250] = new SolidBrush(ColorShanDi);
                brush_City[251] = new SolidBrush(ColorShanDi);
                brush_City[252] = new SolidBrush(ColorShanDi);
                brush_City[253] = new SolidBrush(ColorShanDi);
                brush_City[254] = new SolidBrush(ColorShanDi);
                brush_City[255] = new SolidBrush(ColorShanDi);

                #endregion
                #region 未来城

                SolidBrush[] brush_Future = new SolidBrush[256];

                brush_Future[0] = new SolidBrush(Color.Yellow);
                brush_Future[1] = new SolidBrush(Color.Green);
                brush_Future[2] = new SolidBrush(Color.Green);
                brush_Future[3] = new SolidBrush(Color.Green);
                brush_Future[4] = new SolidBrush(Color.Green);
                brush_Future[5] = new SolidBrush(ColorCaoDi);
                brush_Future[6] = new SolidBrush(ColorCaoDi);
                brush_Future[7] = new SolidBrush(ColorCaoDi);
                brush_Future[8] = new SolidBrush(ColorCaoDi);
                brush_Future[9] = new SolidBrush(ColorKongDi);
                brush_Future[10] = new SolidBrush(ColorShiDi);
                brush_Future[11] = new SolidBrush(ColorShiDi);
                brush_Future[12] = new SolidBrush(ColorKeng);
                brush_Future[13] = new SolidBrush(Color.DarkRed);
                brush_Future[14] = new SolidBrush(ColorHanDi);
                brush_Future[15] = new SolidBrush(ColorHuaDi);
                brush_Future[16] = new SolidBrush(ColorHuaDi);
                brush_Future[17] = new SolidBrush(ColorHuaDi);
                brush_Future[18] = new SolidBrush(ColorSiDi);
                brush_Future[19] = new SolidBrush(ColorHanDi);
                brush_Future[20] = new SolidBrush(ColorHuoYan);
                brush_Future[21] = new SolidBrush(ColorShiTou);
                brush_Future[22] = new SolidBrush(ColorShiTou);
                brush_Future[23] = new SolidBrush(ColorShu);
                brush_Future[24] = new SolidBrush(Color.LightGreen);
                brush_Future[25] = new SolidBrush(ColorShuiMian);
                brush_Future[26] = new SolidBrush(ColorShuiMian);
                brush_Future[27] = new SolidBrush(ColorShuiMian);
                brush_Future[28] = new SolidBrush(ColorShuiMian);
                brush_Future[29] = new SolidBrush(ColorShuiMian);
                brush_Future[30] = new SolidBrush(ColorShuiMian);
                brush_Future[31] = new SolidBrush(ColorShuiMian);
                brush_Future[32] = new SolidBrush(ColorShuiMian);
                brush_Future[33] = new SolidBrush(ColorShuiMian);
                brush_Future[34] = new SolidBrush(ColorShuiMian);
                brush_Future[35] = new SolidBrush(ColorShuiMian);
                brush_Future[36] = new SolidBrush(ColorShuiMian);
                brush_Future[37] = new SolidBrush(ColorShuiMian);
                brush_Future[38] = new SolidBrush(ColorShuiMian);
                brush_Future[39] = new SolidBrush(ColorShuiMian);
                brush_Future[40] = new SolidBrush(ColorShuiMian);
                brush_Future[41] = new SolidBrush(ColorShuiMian);
                brush_Future[42] = new SolidBrush(ColorShuiMian);
                brush_Future[43] = new SolidBrush(ColorShuiMian);
                brush_Future[44] = new SolidBrush(ColorShuiMian);
                brush_Future[45] = new SolidBrush(ColorShuiMian);
                brush_Future[46] = new SolidBrush(ColorShuiMian);
                brush_Future[47] = new SolidBrush(ColorShuiMian);
                brush_Future[48] = new SolidBrush(ColorShuiMian);
                brush_Future[49] = new SolidBrush(ColorShuiMian);
                brush_Future[50] = new SolidBrush(ColorShuiMian);
                brush_Future[51] = new SolidBrush(ColorShuiMian);
                brush_Future[52] = new SolidBrush(ColorShuiMian);
                brush_Future[53] = new SolidBrush(ColorShuiMian);
                brush_Future[54] = new SolidBrush(ColorShuiMian);
                brush_Future[55] = new SolidBrush(ColorShuiMian);
                brush_Future[56] = new SolidBrush(ColorShuiMian);
                brush_Future[57] = new SolidBrush(ColorShuiMian);
                brush_Future[58] = new SolidBrush(ColorShuiMian);
                brush_Future[59] = new SolidBrush(ColorShuiMian);
                brush_Future[60] = new SolidBrush(ColorShuiMian);
                brush_Future[61] = new SolidBrush(ColorShuiMian);
                brush_Future[62] = new SolidBrush(ColorShuiMian);
                brush_Future[63] = new SolidBrush(ColorShuiMian);
                brush_Future[64] = new SolidBrush(ColorShuiMian);
                brush_Future[65] = new SolidBrush(ColorShuiMian);
                brush_Future[66] = new SolidBrush(ColorShuiMian);
                brush_Future[67] = new SolidBrush(ColorShuiMian);
                brush_Future[68] = new SolidBrush(ColorShuiMian);
                brush_Future[69] = new SolidBrush(ColorShuiMian);
                brush_Future[70] = new SolidBrush(ColorShuiMian);
                brush_Future[71] = new SolidBrush(ColorShuiMian);
                brush_Future[72] = new SolidBrush(Color.OrangeRed);
                brush_Future[73] = new SolidBrush(ColorYanJiang);
                brush_Future[74] = new SolidBrush(ColorYanJiang);
                brush_Future[75] = new SolidBrush(ColorYanJiang);
                brush_Future[76] = new SolidBrush(ColorYanJiang);
                brush_Future[77] = new SolidBrush(ColorYanJiang);
                brush_Future[78] = new SolidBrush(ColorYanJiang);
                brush_Future[79] = new SolidBrush(ColorYanJiang);
                brush_Future[80] = new SolidBrush(ColorYanJiang);
                brush_Future[81] = new SolidBrush(ColorYanJiang);
                brush_Future[82] = new SolidBrush(ColorYanJiang);
                brush_Future[83] = new SolidBrush(ColorYanJiang);
                brush_Future[84] = new SolidBrush(ColorYanJiang);
                brush_Future[85] = new SolidBrush(ColorYanJiang);
                brush_Future[86] = new SolidBrush(ColorYanJiang);
                brush_Future[87] = new SolidBrush(ColorYanJiang);
                brush_Future[88] = new SolidBrush(ColorYanJiang);
                brush_Future[89] = new SolidBrush(ColorYanJiang);
                brush_Future[90] = new SolidBrush(ColorYanJiang);
                brush_Future[91] = new SolidBrush(ColorYanJiang);
                brush_Future[92] = new SolidBrush(ColorYanJiang);
                brush_Future[93] = new SolidBrush(ColorYanJiang);
                brush_Future[94] = new SolidBrush(ColorYanJiang);
                brush_Future[95] = new SolidBrush(ColorYanJiang);
                brush_Future[96] = new SolidBrush(ColorYanJiang);
                brush_Future[97] = new SolidBrush(ColorYanJiang);
                brush_Future[98] = new SolidBrush(ColorYanJiang);
                brush_Future[99] = new SolidBrush(ColorYanJiang);
                brush_Future[100] = new SolidBrush(ColorYanJiang);
                brush_Future[101] = new SolidBrush(ColorYanJiang);
                brush_Future[102] = new SolidBrush(ColorYanJiang);
                brush_Future[103] = new SolidBrush(ColorYanJiang);
                brush_Future[104] = new SolidBrush(ColorYanJiang);
                brush_Future[105] = new SolidBrush(ColorYanJiang);
                brush_Future[106] = new SolidBrush(ColorYanJiang);
                brush_Future[107] = new SolidBrush(ColorYanJiang);
                brush_Future[108] = new SolidBrush(ColorYanJiang);
                brush_Future[109] = new SolidBrush(ColorYanJiang);
                brush_Future[110] = new SolidBrush(ColorYanJiang);
                brush_Future[111] = new SolidBrush(ColorYanJiang);
                brush_Future[112] = new SolidBrush(ColorYanJiang);
                brush_Future[113] = new SolidBrush(ColorYanJiang);
                brush_Future[114] = new SolidBrush(ColorYanJiang);
                brush_Future[115] = new SolidBrush(ColorYanJiang);
                brush_Future[116] = new SolidBrush(ColorYanJiang);
                brush_Future[117] = new SolidBrush(ColorYanJiang);
                brush_Future[118] = new SolidBrush(ColorYanJiang);
                brush_Future[119] = new SolidBrush(ColorYanJiang);
                brush_Future[120] = new SolidBrush(ColorYanJiang);
                brush_Future[121] = new SolidBrush(ColorShanDi);
                brush_Future[122] = new SolidBrush(ColorShanDi);
                brush_Future[123] = new SolidBrush(ColorShanDi);
                brush_Future[124] = new SolidBrush(ColorShanDi);
                brush_Future[125] = new SolidBrush(ColorShanDi);
                brush_Future[126] = new SolidBrush(ColorShanDi);
                brush_Future[127] = new SolidBrush(ColorShanDi);
                brush_Future[128] = new SolidBrush(ColorShanDi);
                brush_Future[129] = new SolidBrush(ColorShanDi);
                brush_Future[130] = new SolidBrush(ColorShanDi);
                brush_Future[131] = new SolidBrush(ColorShanDi);
                brush_Future[132] = new SolidBrush(ColorShanDi);
                brush_Future[133] = new SolidBrush(ColorShanDi);
                brush_Future[134] = new SolidBrush(ColorShanDi);
                brush_Future[135] = new SolidBrush(ColorShanDi);
                brush_Future[136] = new SolidBrush(ColorShanDi);
                brush_Future[137] = new SolidBrush(ColorShanDi);
                brush_Future[138] = new SolidBrush(ColorShanDi);
                brush_Future[139] = new SolidBrush(ColorShanDi);
                brush_Future[140] = new SolidBrush(ColorShanDi);
                brush_Future[141] = new SolidBrush(ColorShanDi);
                brush_Future[142] = new SolidBrush(ColorShanDi);
                brush_Future[143] = new SolidBrush(ColorShanDi);
                brush_Future[144] = new SolidBrush(ColorShanDi);
                brush_Future[145] = new SolidBrush(ColorShanDi);
                brush_Future[146] = new SolidBrush(ColorShanDi);
                brush_Future[147] = new SolidBrush(ColorShanDi);
                brush_Future[148] = new SolidBrush(ColorShanDi);
                brush_Future[149] = new SolidBrush(ColorShanDi);
                brush_Future[150] = new SolidBrush(ColorShanDi);
                brush_Future[151] = new SolidBrush(ColorShanDi);
                brush_Future[152] = new SolidBrush(ColorShanDi);
                brush_Future[153] = new SolidBrush(ColorShanDi);
                brush_Future[154] = new SolidBrush(ColorShanDi);
                brush_Future[155] = new SolidBrush(ColorShanDi);
                brush_Future[156] = new SolidBrush(ColorShanDi);
                brush_Future[157] = new SolidBrush(ColorShanDi);
                brush_Future[158] = new SolidBrush(ColorShanDi);
                brush_Future[159] = new SolidBrush(ColorShanDi);
                brush_Future[160] = new SolidBrush(ColorShanDi);
                brush_Future[161] = new SolidBrush(ColorShanDi);
                brush_Future[162] = new SolidBrush(ColorShanDi);
                brush_Future[163] = new SolidBrush(ColorShanDi);
                brush_Future[164] = new SolidBrush(ColorShanDi);
                brush_Future[165] = new SolidBrush(ColorShanDi);
                brush_Future[166] = new SolidBrush(ColorShanDi);
                brush_Future[167] = new SolidBrush(ColorShanDi);
                brush_Future[168] = new SolidBrush(ColorShanDi);
                brush_Future[169] = new SolidBrush(ColorShanDi);
                brush_Future[170] = new SolidBrush(ColorShanDi);
                brush_Future[171] = new SolidBrush(ColorShanDi);
                brush_Future[172] = new SolidBrush(ColorShanDi);
                brush_Future[173] = new SolidBrush(ColorShanDi);
                brush_Future[174] = new SolidBrush(ColorShanDi);
                brush_Future[175] = new SolidBrush(ColorShanDi);
                brush_Future[176] = new SolidBrush(ColorShanDi);
                brush_Future[177] = new SolidBrush(ColorShanDi);
                brush_Future[178] = new SolidBrush(ColorShanDi);
                brush_Future[179] = new SolidBrush(ColorShanDi);
                brush_Future[180] = new SolidBrush(ColorShanDi);
                brush_Future[181] = new SolidBrush(ColorShanDi);
                brush_Future[182] = new SolidBrush(ColorShanDi);
                brush_Future[183] = new SolidBrush(ColorShanDi);
                brush_Future[184] = new SolidBrush(ColorShanDi);
                brush_Future[185] = new SolidBrush(ColorShanDi);
                brush_Future[186] = new SolidBrush(ColorShanDi);
                brush_Future[187] = new SolidBrush(ColorShanDi);
                brush_Future[188] = new SolidBrush(ColorShanDi);
                brush_Future[189] = new SolidBrush(ColorShanDi);
                brush_Future[190] = new SolidBrush(ColorShanDi);

                brush_Future[191] = new SolidBrush(ColorShaDi);
                brush_Future[192] = new SolidBrush(ColorXueDi);
                brush_Future[193] = new SolidBrush(ColorShiTou);
                brush_Future[194] = new SolidBrush(ColorShu);
                brush_Future[195] = new SolidBrush(ColorShu);
                brush_Future[196] = new SolidBrush(ColorShiTou);
                brush_Future[197] = new SolidBrush(ColorShiTou);
                brush_Future[198] = new SolidBrush(ColorShiTou);
                brush_Future[199] = new SolidBrush(ColorShiTou);
                brush_Future[200] = new SolidBrush(ColorShiTou);
                brush_Future[201] = new SolidBrush(ColorShanDi);
                brush_Future[202] = new SolidBrush(ColorShanDi);
                brush_Future[203] = new SolidBrush(ColorShanDi);
                brush_Future[204] = new SolidBrush(ColorShanDi);
                brush_Future[205] = new SolidBrush(ColorShanDi);
                brush_Future[206] = new SolidBrush(ColorShanDi);
                brush_Future[207] = new SolidBrush(ColorShanDi);
                brush_Future[208] = new SolidBrush(ColorShanDi);
                brush_Future[209] = new SolidBrush(ColorShanDi);
                brush_Future[210] = new SolidBrush(ColorShanDi);
                brush_Future[211] = new SolidBrush(ColorShanDi);
                brush_Future[212] = new SolidBrush(ColorShanDi);
                brush_Future[213] = new SolidBrush(ColorShanDi);
                brush_Future[214] = new SolidBrush(ColorShanDi);
                brush_Future[215] = new SolidBrush(ColorShanDi);
                brush_Future[216] = new SolidBrush(ColorShanDi);
                brush_Future[217] = new SolidBrush(ColorShanDi);
                brush_Future[218] = new SolidBrush(ColorShanDi);
                brush_Future[219] = new SolidBrush(ColorShanDi);
                brush_Future[220] = new SolidBrush(ColorShanDi);
                brush_Future[221] = new SolidBrush(ColorShanDi);
                brush_Future[222] = new SolidBrush(ColorShanDi);
                brush_Future[223] = new SolidBrush(ColorShanDi);
                brush_Future[224] = new SolidBrush(ColorShanDi);
                brush_Future[225] = new SolidBrush(ColorShanDi);
                brush_Future[226] = new SolidBrush(ColorShanDi);
                brush_Future[227] = new SolidBrush(ColorShanDi);
                brush_Future[228] = new SolidBrush(ColorShanDi);
                brush_Future[229] = new SolidBrush(ColorShanDi);
                brush_Future[230] = new SolidBrush(ColorShanDi);
                brush_Future[231] = new SolidBrush(ColorShanDi);
                brush_Future[232] = new SolidBrush(ColorShanDi);
                brush_Future[233] = new SolidBrush(ColorShanDi);
                brush_Future[234] = new SolidBrush(ColorShanDi);
                brush_Future[235] = new SolidBrush(ColorShanDi);
                brush_Future[236] = new SolidBrush(ColorShanDi);
                brush_Future[237] = new SolidBrush(ColorShanDi);
                brush_Future[238] = new SolidBrush(ColorShanDi);
                brush_Future[239] = new SolidBrush(ColorShanDi);
                brush_Future[240] = new SolidBrush(ColorShanDi);
                brush_Future[241] = new SolidBrush(ColorShanDi);
                brush_Future[242] = new SolidBrush(ColorShanDi);
                brush_Future[243] = new SolidBrush(ColorShanDi);
                brush_Future[244] = new SolidBrush(ColorShanDi);
                brush_Future[245] = new SolidBrush(ColorShanDi);
                brush_Future[246] = new SolidBrush(ColorShanDi);
                brush_Future[247] = new SolidBrush(ColorShanDi);
                brush_Future[248] = new SolidBrush(ColorShanDi);
                brush_Future[249] = new SolidBrush(ColorShanDi);
                brush_Future[250] = new SolidBrush(ColorShanDi);
                brush_Future[251] = new SolidBrush(ColorShanDi);
                brush_Future[252] = new SolidBrush(ColorShanDi);
                brush_Future[253] = new SolidBrush(ColorShanDi);
                brush_Future[254] = new SolidBrush(ColorShanDi);
                brush_Future[255] = new SolidBrush(ColorShanDi);


                #endregion
                #region 太空主题

                SolidBrush[] brush_Aether = new SolidBrush[256];

                brush_Aether[0] = new SolidBrush(Color.Yellow);
                brush_Aether[1] = new SolidBrush(Color.Green);
                brush_Aether[2] = new SolidBrush(Color.Green);
                brush_Aether[3] = new SolidBrush(Color.Green);
                brush_Aether[4] = new SolidBrush(Color.Green);
                brush_Aether[5] = new SolidBrush(ColorCaoDi);
                brush_Aether[6] = new SolidBrush(ColorCaoDi);
                brush_Aether[7] = new SolidBrush(ColorCaoDi);
                brush_Aether[8] = new SolidBrush(ColorCaoDi);
                brush_Aether[9] = new SolidBrush(ColorKongDi);
                brush_Aether[10] = new SolidBrush(ColorShiDi);
                brush_Aether[11] = new SolidBrush(ColorShiDi);
                brush_Aether[12] = new SolidBrush(ColorKeng);
                brush_Aether[13] = new SolidBrush(Color.DarkRed);
                brush_Aether[14] = new SolidBrush(ColorHanDi);
                brush_Aether[15] = new SolidBrush(ColorHuaDi);
                brush_Aether[16] = new SolidBrush(ColorHuaDi);
                brush_Aether[17] = new SolidBrush(ColorHuaDi);
                brush_Aether[18] = new SolidBrush(ColorSiDi);
                brush_Aether[19] = new SolidBrush(ColorHanDi);
                brush_Aether[20] = new SolidBrush(ColorHuoYan);
                brush_Aether[21] = new SolidBrush(ColorShiTou);
                brush_Aether[22] = new SolidBrush(ColorShiTou);
                brush_Aether[23] = new SolidBrush(ColorShu);
                brush_Aether[24] = new SolidBrush(Color.LightGreen);
                brush_Aether[25] = new SolidBrush(ColorShuiMian);
                brush_Aether[26] = new SolidBrush(ColorShuiMian);
                brush_Aether[27] = new SolidBrush(ColorShuiMian);
                brush_Aether[28] = new SolidBrush(ColorShuiMian);
                brush_Aether[29] = new SolidBrush(ColorShuiMian);
                brush_Aether[30] = new SolidBrush(ColorShuiMian);
                brush_Aether[31] = new SolidBrush(ColorShuiMian);
                brush_Aether[32] = new SolidBrush(ColorShuiMian);
                brush_Aether[33] = new SolidBrush(ColorShuiMian);
                brush_Aether[34] = new SolidBrush(ColorShuiMian);
                brush_Aether[35] = new SolidBrush(ColorShuiMian);
                brush_Aether[36] = new SolidBrush(ColorShuiMian);
                brush_Aether[37] = new SolidBrush(ColorShuiMian);
                brush_Aether[38] = new SolidBrush(ColorShuiMian);
                brush_Aether[39] = new SolidBrush(ColorShuiMian);
                brush_Aether[40] = new SolidBrush(ColorShuiMian);
                brush_Aether[41] = new SolidBrush(ColorShuiMian);
                brush_Aether[42] = new SolidBrush(ColorShuiMian);
                brush_Aether[43] = new SolidBrush(ColorShuiMian);
                brush_Aether[44] = new SolidBrush(ColorShuiMian);
                brush_Aether[45] = new SolidBrush(ColorShuiMian);
                brush_Aether[46] = new SolidBrush(ColorShuiMian);
                brush_Aether[47] = new SolidBrush(ColorShuiMian);
                brush_Aether[48] = new SolidBrush(ColorShuiMian);
                brush_Aether[49] = new SolidBrush(ColorShuiMian);
                brush_Aether[50] = new SolidBrush(ColorShuiMian);
                brush_Aether[51] = new SolidBrush(ColorShuiMian);
                brush_Aether[52] = new SolidBrush(ColorShuiMian);
                brush_Aether[53] = new SolidBrush(ColorShuiMian);
                brush_Aether[54] = new SolidBrush(ColorShuiMian);
                brush_Aether[55] = new SolidBrush(ColorShuiMian);
                brush_Aether[56] = new SolidBrush(ColorShuiMian);
                brush_Aether[57] = new SolidBrush(ColorShuiMian);
                brush_Aether[58] = new SolidBrush(ColorShuiMian);
                brush_Aether[59] = new SolidBrush(ColorShuiMian);
                brush_Aether[60] = new SolidBrush(ColorShuiMian);
                brush_Aether[61] = new SolidBrush(ColorShuiMian);
                brush_Aether[62] = new SolidBrush(ColorShuiMian);
                brush_Aether[63] = new SolidBrush(ColorShuiMian);
                brush_Aether[64] = new SolidBrush(ColorShuiMian);
                brush_Aether[65] = new SolidBrush(ColorShuiMian);
                brush_Aether[66] = new SolidBrush(ColorShuiMian);
                brush_Aether[67] = new SolidBrush(ColorShuiMian);
                brush_Aether[68] = new SolidBrush(ColorShuiMian);
                brush_Aether[69] = new SolidBrush(ColorShuiMian);
                brush_Aether[70] = new SolidBrush(ColorShuiMian);
                brush_Aether[71] = new SolidBrush(ColorShuiMian);
                brush_Aether[72] = new SolidBrush(Color.OrangeRed);

                brush_Aether[73] = new SolidBrush(ColorYanJiang);
                brush_Aether[74] = new SolidBrush(ColorYanJiang);
                brush_Aether[75] = new SolidBrush(ColorYanJiang);
                brush_Aether[76] = new SolidBrush(ColorYanJiang);
                brush_Aether[77] = new SolidBrush(ColorYanJiang);
                brush_Aether[78] = new SolidBrush(ColorYanJiang);
                brush_Aether[79] = new SolidBrush(ColorYanJiang);
                brush_Aether[80] = new SolidBrush(ColorYanJiang);
                brush_Aether[81] = new SolidBrush(ColorYanJiang);
                brush_Aether[82] = new SolidBrush(ColorYanJiang);
                brush_Aether[83] = new SolidBrush(ColorYanJiang);
                brush_Aether[84] = new SolidBrush(ColorYanJiang);
                brush_Aether[85] = new SolidBrush(ColorYanJiang);
                brush_Aether[86] = new SolidBrush(ColorYanJiang);
                brush_Aether[87] = new SolidBrush(ColorYanJiang);
                brush_Aether[88] = new SolidBrush(ColorYanJiang);
                brush_Aether[89] = new SolidBrush(ColorYanJiang);
                brush_Aether[90] = new SolidBrush(ColorYanJiang);
                brush_Aether[91] = new SolidBrush(ColorYanJiang);
                brush_Aether[92] = new SolidBrush(ColorYanJiang);
                brush_Aether[93] = new SolidBrush(ColorYanJiang);
                brush_Aether[94] = new SolidBrush(ColorYanJiang);
                brush_Aether[95] = new SolidBrush(ColorYanJiang);
                brush_Aether[96] = new SolidBrush(ColorYanJiang);
                brush_Aether[97] = new SolidBrush(ColorYanJiang);
                brush_Aether[98] = new SolidBrush(ColorYanJiang);
                brush_Aether[99] = new SolidBrush(ColorYanJiang);
                brush_Aether[100] = new SolidBrush(ColorYanJiang);
                brush_Aether[101] = new SolidBrush(ColorYanJiang);
                brush_Aether[102] = new SolidBrush(ColorYanJiang);
                brush_Aether[103] = new SolidBrush(ColorYanJiang);
                brush_Aether[104] = new SolidBrush(ColorYanJiang);
                brush_Aether[105] = new SolidBrush(ColorYanJiang);
                brush_Aether[106] = new SolidBrush(ColorYanJiang);
                brush_Aether[107] = new SolidBrush(ColorYanJiang);
                brush_Aether[108] = new SolidBrush(ColorYanJiang);
                brush_Aether[109] = new SolidBrush(ColorYanJiang);
                brush_Aether[110] = new SolidBrush(ColorYanJiang);
                brush_Aether[111] = new SolidBrush(ColorYanJiang);
                brush_Aether[112] = new SolidBrush(ColorYanJiang);
                brush_Aether[113] = new SolidBrush(ColorYanJiang);
                brush_Aether[114] = new SolidBrush(ColorYanJiang);
                brush_Aether[115] = new SolidBrush(ColorYanJiang);
                brush_Aether[116] = new SolidBrush(ColorYanJiang);
                brush_Aether[117] = new SolidBrush(ColorYanJiang);
                brush_Aether[118] = new SolidBrush(ColorYanJiang);
                brush_Aether[119] = new SolidBrush(ColorYanJiang);
                brush_Aether[120] = new SolidBrush(ColorYanJiang);
                brush_Aether[121] = new SolidBrush(ColorShanDi);
                brush_Aether[122] = new SolidBrush(ColorShanDi);
                brush_Aether[123] = new SolidBrush(ColorShanDi);
                brush_Aether[124] = new SolidBrush(ColorShanDi);
                brush_Aether[125] = new SolidBrush(ColorShanDi);
                brush_Aether[126] = new SolidBrush(ColorShanDi);
                brush_Aether[127] = new SolidBrush(ColorShanDi);
                brush_Aether[128] = new SolidBrush(ColorShanDi);
                brush_Aether[129] = new SolidBrush(ColorShanDi);
                brush_Aether[130] = new SolidBrush(ColorShanDi);
                brush_Aether[131] = new SolidBrush(ColorShanDi);
                brush_Aether[132] = new SolidBrush(ColorShanDi);
                brush_Aether[133] = new SolidBrush(ColorShanDi);
                brush_Aether[134] = new SolidBrush(ColorShanDi);
                brush_Aether[135] = new SolidBrush(ColorShanDi);
                brush_Aether[136] = new SolidBrush(ColorShanDi);
                brush_Aether[137] = new SolidBrush(ColorShanDi);
                brush_Aether[138] = new SolidBrush(ColorShanDi);
                brush_Aether[139] = new SolidBrush(ColorShanDi);
                brush_Aether[140] = new SolidBrush(ColorShanDi);
                brush_Aether[141] = new SolidBrush(ColorShanDi);
                brush_Aether[142] = new SolidBrush(ColorShanDi);
                brush_Aether[143] = new SolidBrush(ColorShanDi);
                brush_Aether[144] = new SolidBrush(ColorShanDi);
                brush_Aether[145] = new SolidBrush(ColorShanDi);
                brush_Aether[146] = new SolidBrush(ColorShanDi);
                brush_Aether[147] = new SolidBrush(ColorShanDi);
                brush_Aether[148] = new SolidBrush(ColorShanDi);
                brush_Aether[149] = new SolidBrush(ColorShanDi);
                brush_Aether[150] = new SolidBrush(ColorShanDi);
                brush_Aether[151] = new SolidBrush(ColorShanDi);
                brush_Aether[152] = new SolidBrush(ColorShanDi);
                brush_Aether[153] = new SolidBrush(ColorShanDi);
                brush_Aether[154] = new SolidBrush(ColorShanDi);
                brush_Aether[155] = new SolidBrush(ColorShanDi);
                brush_Aether[156] = new SolidBrush(ColorShanDi);
                brush_Aether[157] = new SolidBrush(ColorShanDi);
                brush_Aether[158] = new SolidBrush(ColorShanDi);
                brush_Aether[159] = new SolidBrush(ColorShanDi);
                brush_Aether[160] = new SolidBrush(ColorShanDi);
                brush_Aether[161] = new SolidBrush(ColorShanDi);
                brush_Aether[162] = new SolidBrush(ColorShanDi);
                brush_Aether[163] = new SolidBrush(ColorShanDi);
                brush_Aether[164] = new SolidBrush(ColorShanDi);
                brush_Aether[165] = new SolidBrush(ColorShanDi);
                brush_Aether[166] = new SolidBrush(ColorShanDi);
                brush_Aether[167] = new SolidBrush(ColorShanDi);
                brush_Aether[168] = new SolidBrush(ColorShanDi);
                brush_Aether[169] = new SolidBrush(ColorShanDi);
                brush_Aether[170] = new SolidBrush(ColorShanDi);
                brush_Aether[171] = new SolidBrush(ColorShanDi);
                brush_Aether[172] = new SolidBrush(ColorShanDi);
                brush_Aether[173] = new SolidBrush(ColorShanDi);
                brush_Aether[174] = new SolidBrush(ColorShanDi);
                brush_Aether[175] = new SolidBrush(ColorShanDi);
                brush_Aether[176] = new SolidBrush(ColorShanDi);
                brush_Aether[177] = new SolidBrush(ColorShanDi);
                brush_Aether[178] = new SolidBrush(ColorShanDi);
                brush_Aether[179] = new SolidBrush(ColorShanDi);
                brush_Aether[180] = new SolidBrush(ColorShanDi);
                brush_Aether[181] = new SolidBrush(ColorShanDi);
                brush_Aether[182] = new SolidBrush(ColorShanDi);
                brush_Aether[183] = new SolidBrush(ColorShanDi);
                brush_Aether[184] = new SolidBrush(ColorShanDi);
                brush_Aether[185] = new SolidBrush(ColorShanDi);
                brush_Aether[186] = new SolidBrush(ColorShanDi);
                brush_Aether[187] = new SolidBrush(ColorShanDi);
                brush_Aether[188] = new SolidBrush(ColorShanDi);

                brush_Aether[189] = new SolidBrush(Color.Black);

                brush_Aether[190] = new SolidBrush(Color.White);
                brush_Aether[191] = new SolidBrush(ColorShanDi);
                brush_Aether[192] = new SolidBrush(ColorXueDi);
                brush_Aether[193] = new SolidBrush(ColorShiTou);
                brush_Aether[194] = new SolidBrush(ColorShiTou);
                brush_Aether[195] = new SolidBrush(ColorShu);
                brush_Aether[196] = new SolidBrush(ColorShu);
                brush_Aether[197] = new SolidBrush(ColorShu);
                brush_Aether[198] = new SolidBrush(ColorShiTou);
                brush_Aether[199] = new SolidBrush(ColorShiTou);
                brush_Aether[200] = new SolidBrush(ColorShiTou);
                brush_Aether[201] = new SolidBrush(Color.Black);
                brush_Aether[202] = new SolidBrush(Color.Black);
                brush_Aether[203] = new SolidBrush(Color.Black);
                brush_Aether[204] = new SolidBrush(Color.Black);
                brush_Aether[205] = new SolidBrush(Color.Black);
                brush_Aether[206] = new SolidBrush(Color.Black);
                brush_Aether[207] = new SolidBrush(Color.Black);
                brush_Aether[208] = new SolidBrush(Color.Black);
                brush_Aether[209] = new SolidBrush(Color.Black);
                brush_Aether[210] = new SolidBrush(Color.Black);
                brush_Aether[211] = new SolidBrush(Color.Black);
                brush_Aether[212] = new SolidBrush(Color.Black);
                brush_Aether[213] = new SolidBrush(Color.Black);
                brush_Aether[214] = new SolidBrush(Color.Black);
                brush_Aether[215] = new SolidBrush(Color.Black);
                brush_Aether[216] = new SolidBrush(Color.Black);
                brush_Aether[217] = new SolidBrush(Color.Black);
                brush_Aether[218] = new SolidBrush(Color.Black);
                brush_Aether[219] = new SolidBrush(Color.Black);
                brush_Aether[220] = new SolidBrush(Color.Black);
                brush_Aether[221] = new SolidBrush(Color.Black);
                brush_Aether[222] = new SolidBrush(Color.Black);
                brush_Aether[223] = new SolidBrush(Color.Black);
                brush_Aether[224] = new SolidBrush(Color.Black);
                brush_Aether[225] = new SolidBrush(Color.Black);
                brush_Aether[226] = new SolidBrush(Color.Black);
                brush_Aether[227] = new SolidBrush(Color.Black);
                brush_Aether[228] = new SolidBrush(Color.Black);
                brush_Aether[229] = new SolidBrush(Color.Black);
                brush_Aether[230] = new SolidBrush(Color.Black);
                brush_Aether[231] = new SolidBrush(Color.Black);
                brush_Aether[232] = new SolidBrush(Color.Black);
                brush_Aether[233] = new SolidBrush(Color.Black);
                brush_Aether[234] = new SolidBrush(Color.Black);
                brush_Aether[235] = new SolidBrush(Color.Black);
                brush_Aether[236] = new SolidBrush(Color.Black);
                brush_Aether[237] = new SolidBrush(Color.Black);
                brush_Aether[238] = new SolidBrush(Color.Black);
                brush_Aether[239] = new SolidBrush(Color.Black);
                brush_Aether[240] = new SolidBrush(Color.Black);
                brush_Aether[241] = new SolidBrush(Color.Black);
                brush_Aether[242] = new SolidBrush(Color.Black);
                brush_Aether[243] = new SolidBrush(Color.Black);
                brush_Aether[244] = new SolidBrush(Color.Black);
                brush_Aether[245] = new SolidBrush(Color.Black);
                brush_Aether[246] = new SolidBrush(Color.Black);
                brush_Aether[247] = new SolidBrush(Color.Black);
                brush_Aether[248] = new SolidBrush(Color.Black);

                brush_Aether[249] = new SolidBrush(ColorShiTou);
                brush_Aether[250] = new SolidBrush(ColorShiTou);
                brush_Aether[251] = new SolidBrush(ColorShiTou);
                brush_Aether[252] = new SolidBrush(ColorShiTou);
                brush_Aether[253] = new SolidBrush(ColorShiTou);
                brush_Aether[254] = new SolidBrush(ColorShiTou);
                brush_Aether[255] = new SolidBrush(Color.Black);


                #endregion
                #region 异次元主题

                SolidBrush[] brush_EDS = new SolidBrush[256];

                brush_EDS[0] = new SolidBrush(Color.Yellow);
                brush_EDS[1] = new SolidBrush(Color.Green);
                brush_EDS[2] = new SolidBrush(Color.Green);
                brush_EDS[3] = new SolidBrush(Color.Green);
                brush_EDS[4] = new SolidBrush(Color.Green);
                brush_EDS[5] = new SolidBrush(ColorCaoDi);
                brush_EDS[6] = new SolidBrush(ColorCaoDi);
                brush_EDS[7] = new SolidBrush(ColorCaoDi);
                brush_EDS[8] = new SolidBrush(ColorCaoDi);
                brush_EDS[9] = new SolidBrush(ColorKongDi);
                brush_EDS[10] = new SolidBrush(ColorShiDi);
                brush_EDS[11] = new SolidBrush(ColorShiDi);
                brush_EDS[12] = new SolidBrush(ColorKeng);
                brush_EDS[13] = new SolidBrush(Color.DarkRed);
                brush_EDS[14] = new SolidBrush(ColorHanDi);
                brush_EDS[15] = new SolidBrush(ColorHuaDi);
                brush_EDS[16] = new SolidBrush(ColorHuaDi);
                brush_EDS[17] = new SolidBrush(ColorHuaDi);
                brush_EDS[18] = new SolidBrush(ColorSiDi);
                brush_EDS[19] = new SolidBrush(ColorHanDi);
                brush_EDS[20] = new SolidBrush(ColorHuoYan);
                brush_EDS[21] = new SolidBrush(ColorShiTou);
                brush_EDS[22] = new SolidBrush(ColorShiTou);
                brush_EDS[23] = new SolidBrush(ColorShu);
                brush_EDS[24] = new SolidBrush(Color.LightGreen);
                brush_EDS[25] = new SolidBrush(ColorShuiMian);
                brush_EDS[26] = new SolidBrush(ColorShuiMian);
                brush_EDS[27] = new SolidBrush(ColorShuiMian);
                brush_EDS[28] = new SolidBrush(ColorShuiMian);
                brush_EDS[29] = new SolidBrush(ColorShuiMian);
                brush_EDS[30] = new SolidBrush(ColorShuiMian);
                brush_EDS[31] = new SolidBrush(ColorShuiMian);
                brush_EDS[32] = new SolidBrush(ColorShuiMian);
                brush_EDS[33] = new SolidBrush(ColorShuiMian);
                brush_EDS[34] = new SolidBrush(ColorShuiMian);
                brush_EDS[35] = new SolidBrush(ColorShuiMian);
                brush_EDS[36] = new SolidBrush(ColorShuiMian);
                brush_EDS[37] = new SolidBrush(ColorShuiMian);
                brush_EDS[38] = new SolidBrush(ColorShuiMian);
                brush_EDS[39] = new SolidBrush(ColorShuiMian);
                brush_EDS[40] = new SolidBrush(ColorShuiMian);
                brush_EDS[41] = new SolidBrush(ColorShuiMian);
                brush_EDS[42] = new SolidBrush(ColorShuiMian);
                brush_EDS[43] = new SolidBrush(ColorShuiMian);
                brush_EDS[44] = new SolidBrush(ColorShuiMian);
                brush_EDS[45] = new SolidBrush(ColorShuiMian);
                brush_EDS[46] = new SolidBrush(ColorShuiMian);
                brush_EDS[47] = new SolidBrush(ColorShuiMian);
                brush_EDS[48] = new SolidBrush(ColorShuiMian);
                brush_EDS[49] = new SolidBrush(ColorShuiMian);
                brush_EDS[50] = new SolidBrush(ColorShuiMian);
                brush_EDS[51] = new SolidBrush(ColorShuiMian);
                brush_EDS[52] = new SolidBrush(ColorShuiMian);
                brush_EDS[53] = new SolidBrush(ColorShuiMian);
                brush_EDS[54] = new SolidBrush(ColorShuiMian);
                brush_EDS[55] = new SolidBrush(ColorShuiMian);
                brush_EDS[56] = new SolidBrush(ColorShuiMian);
                brush_EDS[57] = new SolidBrush(ColorShuiMian);
                brush_EDS[58] = new SolidBrush(ColorShuiMian);
                brush_EDS[59] = new SolidBrush(ColorShuiMian);
                brush_EDS[60] = new SolidBrush(ColorShuiMian);
                brush_EDS[61] = new SolidBrush(ColorShuiMian);
                brush_EDS[62] = new SolidBrush(ColorShuiMian);
                brush_EDS[63] = new SolidBrush(ColorShuiMian);
                brush_EDS[64] = new SolidBrush(ColorShuiMian);
                brush_EDS[65] = new SolidBrush(ColorShuiMian);
                brush_EDS[66] = new SolidBrush(ColorShuiMian);
                brush_EDS[67] = new SolidBrush(ColorShuiMian);
                brush_EDS[68] = new SolidBrush(ColorShuiMian);
                brush_EDS[69] = new SolidBrush(ColorShuiMian);
                brush_EDS[70] = new SolidBrush(ColorShuiMian);
                brush_EDS[71] = new SolidBrush(ColorShuiMian);
                brush_EDS[72] = new SolidBrush(Color.OrangeRed);

                brush_EDS[73] = new SolidBrush(ColorYanJiang);
                brush_EDS[74] = new SolidBrush(ColorYanJiang);
                brush_EDS[75] = new SolidBrush(ColorYanJiang);
                brush_EDS[76] = new SolidBrush(ColorYanJiang);
                brush_EDS[77] = new SolidBrush(ColorYanJiang);
                brush_EDS[78] = new SolidBrush(ColorYanJiang);
                brush_EDS[79] = new SolidBrush(ColorYanJiang);
                brush_EDS[80] = new SolidBrush(ColorYanJiang);
                brush_EDS[81] = new SolidBrush(ColorYanJiang);
                brush_EDS[82] = new SolidBrush(ColorYanJiang);
                brush_EDS[83] = new SolidBrush(ColorYanJiang);
                brush_EDS[84] = new SolidBrush(ColorYanJiang);
                brush_EDS[85] = new SolidBrush(ColorYanJiang);
                brush_EDS[86] = new SolidBrush(ColorYanJiang);
                brush_EDS[87] = new SolidBrush(ColorYanJiang);
                brush_EDS[88] = new SolidBrush(ColorYanJiang);
                brush_EDS[89] = new SolidBrush(ColorYanJiang);
                brush_EDS[90] = new SolidBrush(ColorYanJiang);
                brush_EDS[91] = new SolidBrush(ColorYanJiang);
                brush_EDS[92] = new SolidBrush(ColorYanJiang);
                brush_EDS[93] = new SolidBrush(ColorYanJiang);
                brush_EDS[94] = new SolidBrush(ColorYanJiang);
                brush_EDS[95] = new SolidBrush(ColorYanJiang);
                brush_EDS[96] = new SolidBrush(ColorYanJiang);
                brush_EDS[97] = new SolidBrush(ColorYanJiang);
                brush_EDS[98] = new SolidBrush(ColorYanJiang);
                brush_EDS[99] = new SolidBrush(ColorYanJiang);
                brush_EDS[100] = new SolidBrush(ColorYanJiang);
                brush_EDS[101] = new SolidBrush(ColorYanJiang);
                brush_EDS[102] = new SolidBrush(ColorYanJiang);
                brush_EDS[103] = new SolidBrush(ColorYanJiang);
                brush_EDS[104] = new SolidBrush(ColorYanJiang);
                brush_EDS[105] = new SolidBrush(ColorYanJiang);
                brush_EDS[106] = new SolidBrush(ColorYanJiang);
                brush_EDS[107] = new SolidBrush(ColorYanJiang);
                brush_EDS[108] = new SolidBrush(ColorYanJiang);
                brush_EDS[109] = new SolidBrush(ColorYanJiang);
                brush_EDS[110] = new SolidBrush(ColorYanJiang);
                brush_EDS[111] = new SolidBrush(ColorYanJiang);
                brush_EDS[112] = new SolidBrush(ColorYanJiang);
                brush_EDS[113] = new SolidBrush(ColorYanJiang);
                brush_EDS[114] = new SolidBrush(ColorYanJiang);
                brush_EDS[115] = new SolidBrush(ColorYanJiang);
                brush_EDS[116] = new SolidBrush(ColorYanJiang);
                brush_EDS[117] = new SolidBrush(ColorYanJiang);
                brush_EDS[118] = new SolidBrush(ColorYanJiang);
                brush_EDS[119] = new SolidBrush(ColorYanJiang);
                brush_EDS[120] = new SolidBrush(ColorYanJiang);

                brush_EDS[121] = new SolidBrush(ColorShanDi);
                brush_EDS[122] = new SolidBrush(ColorShanDi);
                brush_EDS[123] = new SolidBrush(ColorShanDi);
                brush_EDS[124] = new SolidBrush(ColorShanDi);
                brush_EDS[125] = new SolidBrush(ColorShanDi);
                brush_EDS[126] = new SolidBrush(ColorShanDi);
                brush_EDS[127] = new SolidBrush(ColorShanDi);
                brush_EDS[128] = new SolidBrush(ColorShanDi);
                brush_EDS[129] = new SolidBrush(ColorShanDi);
                brush_EDS[130] = new SolidBrush(ColorShanDi);
                brush_EDS[131] = new SolidBrush(ColorShanDi);
                brush_EDS[132] = new SolidBrush(ColorShanDi);
                brush_EDS[133] = new SolidBrush(ColorShanDi);
                brush_EDS[134] = new SolidBrush(ColorShanDi);
                brush_EDS[135] = new SolidBrush(ColorShanDi);
                brush_EDS[136] = new SolidBrush(ColorShanDi);
                brush_EDS[137] = new SolidBrush(ColorShanDi);
                brush_EDS[138] = new SolidBrush(ColorShanDi);
                brush_EDS[139] = new SolidBrush(ColorShanDi);
                brush_EDS[140] = new SolidBrush(ColorShanDi);
                brush_EDS[141] = new SolidBrush(ColorShanDi);
                brush_EDS[142] = new SolidBrush(ColorShanDi);
                brush_EDS[143] = new SolidBrush(ColorShanDi);
                brush_EDS[144] = new SolidBrush(ColorShanDi);
                brush_EDS[145] = new SolidBrush(ColorShanDi);
                brush_EDS[146] = new SolidBrush(ColorShanDi);
                brush_EDS[147] = new SolidBrush(ColorShanDi);
                brush_EDS[148] = new SolidBrush(ColorShanDi);
                brush_EDS[149] = new SolidBrush(ColorShanDi);
                brush_EDS[150] = new SolidBrush(ColorShanDi);
                brush_EDS[151] = new SolidBrush(ColorShanDi);
                brush_EDS[152] = new SolidBrush(ColorShanDi);
                brush_EDS[153] = new SolidBrush(ColorShanDi);
                brush_EDS[154] = new SolidBrush(ColorShanDi);
                brush_EDS[155] = new SolidBrush(ColorShanDi);
                brush_EDS[156] = new SolidBrush(ColorShanDi);
                brush_EDS[157] = new SolidBrush(ColorShanDi);
                brush_EDS[158] = new SolidBrush(ColorShanDi);
                brush_EDS[159] = new SolidBrush(ColorShanDi);
                brush_EDS[160] = new SolidBrush(ColorShanDi);
                brush_EDS[161] = new SolidBrush(ColorShanDi);
                brush_EDS[162] = new SolidBrush(ColorShanDi);
                brush_EDS[163] = new SolidBrush(ColorShanDi);
                brush_EDS[164] = new SolidBrush(ColorShanDi);
                brush_EDS[165] = new SolidBrush(ColorShanDi);
                brush_EDS[166] = new SolidBrush(ColorShanDi);
                brush_EDS[167] = new SolidBrush(ColorShanDi);
                brush_EDS[168] = new SolidBrush(ColorShanDi);
                brush_EDS[169] = new SolidBrush(ColorShanDi);
                brush_EDS[170] = new SolidBrush(ColorShanDi);
                brush_EDS[171] = new SolidBrush(ColorShanDi);
                brush_EDS[172] = new SolidBrush(ColorShanDi);
                brush_EDS[173] = new SolidBrush(ColorShanDi);
                brush_EDS[174] = new SolidBrush(ColorShanDi);
                brush_EDS[175] = new SolidBrush(ColorShanDi);
                brush_EDS[176] = new SolidBrush(ColorShanDi);
                brush_EDS[177] = new SolidBrush(ColorShanDi);
                brush_EDS[178] = new SolidBrush(ColorShanDi);
                brush_EDS[179] = new SolidBrush(ColorShanDi);
                brush_EDS[180] = new SolidBrush(ColorShanDi);
                brush_EDS[181] = new SolidBrush(ColorShanDi);
                brush_EDS[182] = new SolidBrush(ColorShanDi);
                brush_EDS[183] = new SolidBrush(ColorShanDi);
                brush_EDS[184] = new SolidBrush(ColorShanDi);
                brush_EDS[185] = new SolidBrush(ColorSiDi);
                brush_EDS[186] = new SolidBrush(ColorShiTou);
                brush_EDS[187] = new SolidBrush(ColorShiTou);
                brush_EDS[188] = new SolidBrush(ColorShanDi);
                brush_EDS[189] = new SolidBrush(ColorShanDi);

                brush_EDS[190] = new SolidBrush(ColorHuoYan);
                brush_EDS[191] = new SolidBrush(ColorShaDi);
                brush_EDS[192] = new SolidBrush(ColorXueDi);
                brush_EDS[193] = new SolidBrush(ColorShiTou);
                brush_EDS[194] = new SolidBrush(ColorShu);
                brush_EDS[195] = new SolidBrush(ColorShu);
                brush_EDS[196] = new SolidBrush(ColorShu);
                brush_EDS[197] = new SolidBrush(ColorShu);
                brush_EDS[198] = new SolidBrush(ColorShiTou);
                brush_EDS[199] = new SolidBrush(ColorShiTou);
                brush_EDS[200] = new SolidBrush(ColorShiTou);
                brush_EDS[201] = new SolidBrush(ColorShiTou);
                brush_EDS[202] = new SolidBrush(ColorShiTou);
                brush_EDS[203] = new SolidBrush(ColorShiTou);
                brush_EDS[204] = new SolidBrush(ColorShiTou);
                brush_EDS[205] = new SolidBrush(ColorShiTou);
                brush_EDS[206] = new SolidBrush(ColorShiTou);
                brush_EDS[207] = new SolidBrush(ColorShiTou);
                brush_EDS[208] = new SolidBrush(ColorShiTou);
                brush_EDS[209] = new SolidBrush(ColorBingMian);
                brush_EDS[210] = new SolidBrush(ColorBingMian);
                brush_EDS[211] = new SolidBrush(ColorBingMian);
                brush_EDS[212] = new SolidBrush(ColorBingMian);
                brush_EDS[213] = new SolidBrush(ColorBingMian);
                brush_EDS[214] = new SolidBrush(ColorBingMian);
                brush_EDS[215] = new SolidBrush(ColorBingMian);
                brush_EDS[216] = new SolidBrush(ColorBingMian);
                brush_EDS[217] = new SolidBrush(ColorBingMian);
                brush_EDS[218] = new SolidBrush(ColorBingMian);
                brush_EDS[219] = new SolidBrush(ColorBingMian);
                brush_EDS[220] = new SolidBrush(ColorBingMian);
                brush_EDS[221] = new SolidBrush(ColorBingMian);
                brush_EDS[222] = new SolidBrush(ColorBingMian);
                brush_EDS[223] = new SolidBrush(ColorBingMian);
                brush_EDS[224] = new SolidBrush(ColorBingMian);
                brush_EDS[225] = new SolidBrush(ColorBingMian);
                brush_EDS[226] = new SolidBrush(ColorBingMian);
                brush_EDS[227] = new SolidBrush(ColorBingMian);
                brush_EDS[228] = new SolidBrush(ColorBingMian);
                brush_EDS[229] = new SolidBrush(ColorBingMian);
                brush_EDS[230] = new SolidBrush(ColorBingMian);
                brush_EDS[231] = new SolidBrush(ColorBingMian);
                brush_EDS[232] = new SolidBrush(ColorBingMian);
                brush_EDS[233] = new SolidBrush(ColorBingMian);
                brush_EDS[234] = new SolidBrush(ColorBingMian);
                brush_EDS[235] = new SolidBrush(ColorBingMian);
                brush_EDS[236] = new SolidBrush(ColorBingMian);
                brush_EDS[237] = new SolidBrush(ColorBingMian);
                brush_EDS[238] = new SolidBrush(ColorBingMian);
                brush_EDS[239] = new SolidBrush(ColorBingMian);
                brush_EDS[240] = new SolidBrush(ColorBingMian);
                brush_EDS[241] = new SolidBrush(ColorBingMian);
                brush_EDS[242] = new SolidBrush(ColorBingMian);
                brush_EDS[243] = new SolidBrush(ColorBingMian);
                brush_EDS[244] = new SolidBrush(ColorBingMian);
                brush_EDS[245] = new SolidBrush(ColorBingMian);
                brush_EDS[246] = new SolidBrush(ColorBingMian);
                brush_EDS[247] = new SolidBrush(ColorBingMian);
                brush_EDS[248] = new SolidBrush(ColorBingMian);
                brush_EDS[249] = new SolidBrush(ColorBingMian);
                brush_EDS[250] = new SolidBrush(ColorBingMian);
                brush_EDS[251] = new SolidBrush(ColorBingMian);
                brush_EDS[252] = new SolidBrush(ColorBingMian);
                brush_EDS[253] = new SolidBrush(ColorBingMian);
                brush_EDS[254] = new SolidBrush(ColorBingMian);
                brush_EDS[255] = new SolidBrush(ColorBingMian);


                #endregion
                #region 博士基地主题

                SolidBrush[] brush_Boss = new SolidBrush[256];

                brush_Boss[0] = new SolidBrush(Color.Yellow);
                brush_Boss[1] = new SolidBrush(Color.Green);
                brush_Boss[2] = new SolidBrush(Color.Green);
                brush_Boss[3] = new SolidBrush(Color.Green);
                brush_Boss[4] = new SolidBrush(Color.Green);
                brush_Boss[5] = new SolidBrush(ColorCaoDi);
                brush_Boss[6] = new SolidBrush(ColorCaoDi);
                brush_Boss[7] = new SolidBrush(ColorCaoDi);
                brush_Boss[8] = new SolidBrush(ColorCaoDi);
                brush_Boss[9] = new SolidBrush(ColorKongDi);
                brush_Boss[10] = new SolidBrush(ColorShiDi);
                brush_Boss[11] = new SolidBrush(ColorShiDi);
                brush_Boss[12] = new SolidBrush(ColorKeng);
                brush_Boss[13] = new SolidBrush(Color.DarkRed);
                brush_Boss[14] = new SolidBrush(ColorHanDi);
                brush_Boss[15] = new SolidBrush(ColorHuaDi);
                brush_Boss[16] = new SolidBrush(ColorHuaDi);
                brush_Boss[17] = new SolidBrush(ColorHuaDi);
                brush_Boss[18] = new SolidBrush(ColorSiDi);
                brush_Boss[19] = new SolidBrush(ColorHanDi);
                brush_Boss[20] = new SolidBrush(ColorHuoYan);
                brush_Boss[21] = new SolidBrush(ColorShiTou);
                brush_Boss[22] = new SolidBrush(ColorShiTou);
                brush_Boss[23] = new SolidBrush(ColorShu);
                brush_Boss[24] = new SolidBrush(Color.LightGreen);
                brush_Boss[25] = new SolidBrush(ColorShuiMian);
                brush_Boss[26] = new SolidBrush(ColorShuiMian);
                brush_Boss[27] = new SolidBrush(ColorShuiMian);
                brush_Boss[28] = new SolidBrush(ColorShuiMian);
                brush_Boss[29] = new SolidBrush(ColorShuiMian);
                brush_Boss[30] = new SolidBrush(ColorShuiMian);
                brush_Boss[31] = new SolidBrush(ColorShuiMian);
                brush_Boss[32] = new SolidBrush(ColorShuiMian);
                brush_Boss[33] = new SolidBrush(ColorShuiMian);
                brush_Boss[34] = new SolidBrush(ColorShuiMian);
                brush_Boss[35] = new SolidBrush(ColorShuiMian);
                brush_Boss[36] = new SolidBrush(ColorShuiMian);
                brush_Boss[37] = new SolidBrush(ColorShuiMian);
                brush_Boss[38] = new SolidBrush(ColorShuiMian);
                brush_Boss[39] = new SolidBrush(ColorShuiMian);
                brush_Boss[40] = new SolidBrush(ColorShuiMian);
                brush_Boss[41] = new SolidBrush(ColorShuiMian);
                brush_Boss[42] = new SolidBrush(ColorShuiMian);
                brush_Boss[43] = new SolidBrush(ColorShuiMian);
                brush_Boss[44] = new SolidBrush(ColorShuiMian);
                brush_Boss[45] = new SolidBrush(ColorShuiMian);
                brush_Boss[46] = new SolidBrush(ColorShuiMian);
                brush_Boss[47] = new SolidBrush(ColorShuiMian);
                brush_Boss[48] = new SolidBrush(ColorShuiMian);
                brush_Boss[49] = new SolidBrush(ColorShuiMian);
                brush_Boss[50] = new SolidBrush(ColorShuiMian);
                brush_Boss[51] = new SolidBrush(ColorShuiMian);
                brush_Boss[52] = new SolidBrush(ColorShuiMian);
                brush_Boss[53] = new SolidBrush(ColorShuiMian);
                brush_Boss[54] = new SolidBrush(ColorShuiMian);
                brush_Boss[55] = new SolidBrush(ColorShuiMian);
                brush_Boss[56] = new SolidBrush(ColorShuiMian);
                brush_Boss[57] = new SolidBrush(ColorShuiMian);
                brush_Boss[58] = new SolidBrush(ColorShuiMian);
                brush_Boss[59] = new SolidBrush(ColorShuiMian);
                brush_Boss[60] = new SolidBrush(ColorShuiMian);
                brush_Boss[61] = new SolidBrush(ColorShuiMian);
                brush_Boss[62] = new SolidBrush(ColorShuiMian);
                brush_Boss[63] = new SolidBrush(ColorShuiMian);
                brush_Boss[64] = new SolidBrush(ColorShuiMian);
                brush_Boss[65] = new SolidBrush(ColorShuiMian);
                brush_Boss[66] = new SolidBrush(ColorShuiMian);
                brush_Boss[67] = new SolidBrush(ColorShuiMian);
                brush_Boss[68] = new SolidBrush(ColorShuiMian);
                brush_Boss[69] = new SolidBrush(ColorShuiMian);
                brush_Boss[70] = new SolidBrush(ColorShuiMian);
                brush_Boss[71] = new SolidBrush(ColorShuiMian);
                brush_Boss[72] = new SolidBrush(Color.OrangeRed);

                brush_Boss[73] = new SolidBrush(ColorYanJiang);
                brush_Boss[74] = new SolidBrush(ColorYanJiang);
                brush_Boss[75] = new SolidBrush(ColorYanJiang);
                brush_Boss[76] = new SolidBrush(ColorYanJiang);
                brush_Boss[77] = new SolidBrush(ColorYanJiang);
                brush_Boss[78] = new SolidBrush(ColorYanJiang);
                brush_Boss[79] = new SolidBrush(ColorYanJiang);
                brush_Boss[80] = new SolidBrush(ColorYanJiang);
                brush_Boss[81] = new SolidBrush(ColorYanJiang);
                brush_Boss[82] = new SolidBrush(ColorYanJiang);
                brush_Boss[83] = new SolidBrush(ColorYanJiang);
                brush_Boss[84] = new SolidBrush(ColorYanJiang);
                brush_Boss[85] = new SolidBrush(ColorYanJiang);
                brush_Boss[86] = new SolidBrush(ColorYanJiang);
                brush_Boss[87] = new SolidBrush(ColorYanJiang);
                brush_Boss[88] = new SolidBrush(ColorYanJiang);
                brush_Boss[89] = new SolidBrush(ColorYanJiang);
                brush_Boss[90] = new SolidBrush(ColorYanJiang);
                brush_Boss[91] = new SolidBrush(ColorYanJiang);
                brush_Boss[92] = new SolidBrush(ColorYanJiang);
                brush_Boss[93] = new SolidBrush(ColorYanJiang);
                brush_Boss[94] = new SolidBrush(ColorYanJiang);
                brush_Boss[95] = new SolidBrush(ColorYanJiang);
                brush_Boss[96] = new SolidBrush(ColorYanJiang);
                brush_Boss[97] = new SolidBrush(ColorYanJiang);
                brush_Boss[98] = new SolidBrush(ColorYanJiang);
                brush_Boss[99] = new SolidBrush(ColorYanJiang);
                brush_Boss[100] = new SolidBrush(ColorYanJiang);
                brush_Boss[101] = new SolidBrush(ColorYanJiang);
                brush_Boss[102] = new SolidBrush(ColorYanJiang);
                brush_Boss[103] = new SolidBrush(ColorYanJiang);
                brush_Boss[104] = new SolidBrush(ColorYanJiang);
                brush_Boss[105] = new SolidBrush(ColorYanJiang);
                brush_Boss[106] = new SolidBrush(ColorYanJiang);
                brush_Boss[107] = new SolidBrush(ColorYanJiang);
                brush_Boss[108] = new SolidBrush(ColorYanJiang);
                brush_Boss[109] = new SolidBrush(ColorYanJiang);
                brush_Boss[110] = new SolidBrush(ColorYanJiang);
                brush_Boss[111] = new SolidBrush(ColorYanJiang);
                brush_Boss[112] = new SolidBrush(ColorYanJiang);
                brush_Boss[113] = new SolidBrush(ColorYanJiang);
                brush_Boss[114] = new SolidBrush(ColorYanJiang);
                brush_Boss[115] = new SolidBrush(ColorYanJiang);
                brush_Boss[116] = new SolidBrush(ColorYanJiang);
                brush_Boss[117] = new SolidBrush(ColorYanJiang);
                brush_Boss[118] = new SolidBrush(ColorYanJiang);
                brush_Boss[119] = new SolidBrush(ColorYanJiang);
                brush_Boss[120] = new SolidBrush(ColorYanJiang);

                brush_Boss[121] = new SolidBrush(ColorShanDi);
                brush_Boss[121] = new SolidBrush(ColorShanDi);
                brush_Boss[122] = new SolidBrush(ColorShanDi);
                brush_Boss[123] = new SolidBrush(ColorShanDi);
                brush_Boss[124] = new SolidBrush(ColorShanDi);
                brush_Boss[125] = new SolidBrush(ColorShanDi);
                brush_Boss[126] = new SolidBrush(ColorShanDi);
                brush_Boss[127] = new SolidBrush(ColorShanDi);
                brush_Boss[128] = new SolidBrush(ColorShanDi);
                brush_Boss[129] = new SolidBrush(ColorShanDi);
                brush_Boss[130] = new SolidBrush(ColorShanDi);
                brush_Boss[131] = new SolidBrush(ColorShanDi);
                brush_Boss[132] = new SolidBrush(ColorShanDi);
                brush_Boss[133] = new SolidBrush(ColorShanDi);
                brush_Boss[134] = new SolidBrush(ColorShanDi);
                brush_Boss[135] = new SolidBrush(ColorShanDi);
                brush_Boss[136] = new SolidBrush(ColorShanDi);
                brush_Boss[137] = new SolidBrush(ColorShanDi);
                brush_Boss[138] = new SolidBrush(ColorShanDi);
                brush_Boss[139] = new SolidBrush(ColorShanDi);
                brush_Boss[140] = new SolidBrush(ColorShanDi);
                brush_Boss[141] = new SolidBrush(ColorShanDi);
                brush_Boss[142] = new SolidBrush(ColorShanDi);
                brush_Boss[143] = new SolidBrush(ColorShanDi);
                brush_Boss[144] = new SolidBrush(ColorShanDi);
                brush_Boss[145] = new SolidBrush(ColorShanDi);
                brush_Boss[146] = new SolidBrush(ColorShanDi);
                brush_Boss[147] = new SolidBrush(ColorShanDi);
                brush_Boss[148] = new SolidBrush(ColorShanDi);
                brush_Boss[149] = new SolidBrush(ColorShanDi);
                brush_Boss[150] = new SolidBrush(ColorShanDi);
                brush_Boss[151] = new SolidBrush(ColorShanDi);
                brush_Boss[152] = new SolidBrush(ColorShanDi);
                brush_Boss[153] = new SolidBrush(ColorShanDi);
                brush_Boss[154] = new SolidBrush(ColorShanDi);
                brush_Boss[155] = new SolidBrush(ColorShanDi);
                brush_Boss[156] = new SolidBrush(ColorShanDi);
                brush_Boss[157] = new SolidBrush(ColorShanDi);
                brush_Boss[158] = new SolidBrush(ColorShanDi);
                brush_Boss[159] = new SolidBrush(ColorShanDi);
                brush_Boss[160] = new SolidBrush(ColorShanDi);
                brush_Boss[161] = new SolidBrush(ColorShanDi);
                brush_Boss[162] = new SolidBrush(ColorShanDi);
                brush_Boss[163] = new SolidBrush(ColorShanDi);
                brush_Boss[164] = new SolidBrush(ColorShanDi);
                brush_Boss[165] = new SolidBrush(ColorShanDi);
                brush_Boss[166] = new SolidBrush(ColorShanDi);
                brush_Boss[167] = new SolidBrush(ColorShanDi);
                brush_Boss[168] = new SolidBrush(ColorShanDi);
                brush_Boss[169] = new SolidBrush(ColorShanDi);
                brush_Boss[170] = new SolidBrush(ColorShanDi);
                brush_Boss[171] = new SolidBrush(ColorShanDi);
                brush_Boss[172] = new SolidBrush(ColorShanDi);
                brush_Boss[173] = new SolidBrush(ColorShanDi);
                brush_Boss[174] = new SolidBrush(ColorShanDi);
                brush_Boss[175] = new SolidBrush(ColorShanDi);
                brush_Boss[176] = new SolidBrush(ColorShanDi);
                brush_Boss[177] = new SolidBrush(ColorShanDi);
                brush_Boss[178] = new SolidBrush(ColorShanDi);
                brush_Boss[179] = new SolidBrush(ColorShanDi);
                brush_Boss[180] = new SolidBrush(ColorShanDi);
                brush_Boss[181] = new SolidBrush(ColorShanDi);
                brush_Boss[182] = new SolidBrush(ColorShanDi);
                brush_Boss[183] = new SolidBrush(ColorShanDi);
                brush_Boss[184] = new SolidBrush(ColorShanDi);

                brush_Boss[185] = new SolidBrush(ColorSiDi);
                brush_Boss[186] = new SolidBrush(ColorSiDi);
                brush_Boss[187] = new SolidBrush(ColorShanDi);
                brush_Boss[188] = new SolidBrush(ColorShanDi);
                brush_Boss[189] = new SolidBrush(ColorShanDi);
                brush_Boss[190] = new SolidBrush(ColorHuoYan);
                brush_Boss[191] = new SolidBrush(ColorShaDi);
                brush_Boss[192] = new SolidBrush(ColorXueDi);
                brush_Boss[193] = new SolidBrush(ColorShiTou);
                brush_Boss[194] = new SolidBrush(ColorShiTou);
                brush_Boss[195] = new SolidBrush(ColorShu);
                brush_Boss[196] = new SolidBrush(ColorShu);
                brush_Boss[197] = new SolidBrush(ColorShiTou);
                brush_Boss[198] = new SolidBrush(ColorShiTou);
                brush_Boss[199] = new SolidBrush(ColorShiTou);
                brush_Boss[200] = new SolidBrush(ColorShiTou);
                brush_Boss[201] = new SolidBrush(ColorShanDi);
                brush_Boss[202] = new SolidBrush(ColorShanDi);
                brush_Boss[203] = new SolidBrush(ColorShanDi);
                brush_Boss[204] = new SolidBrush(ColorShanDi);
                brush_Boss[205] = new SolidBrush(ColorShanDi);
                brush_Boss[206] = new SolidBrush(ColorShanDi);
                brush_Boss[207] = new SolidBrush(ColorShanDi);
                brush_Boss[208] = new SolidBrush(ColorShanDi);
                brush_Boss[209] = new SolidBrush(ColorShanDi);
                brush_Boss[210] = new SolidBrush(ColorShanDi);
                brush_Boss[211] = new SolidBrush(ColorShanDi);
                brush_Boss[212] = new SolidBrush(ColorShanDi);
                brush_Boss[213] = new SolidBrush(ColorShanDi);
                brush_Boss[214] = new SolidBrush(ColorShanDi);
                brush_Boss[215] = new SolidBrush(ColorShanDi);
                brush_Boss[216] = new SolidBrush(ColorShanDi);
                brush_Boss[217] = new SolidBrush(ColorShanDi);
                brush_Boss[218] = new SolidBrush(ColorShanDi);
                brush_Boss[219] = new SolidBrush(ColorShiTou);
                brush_Boss[220] = new SolidBrush(ColorShiTou);
                brush_Boss[221] = new SolidBrush(ColorShiTou);
                brush_Boss[222] = new SolidBrush(ColorShiTou);
                brush_Boss[223] = new SolidBrush(ColorShiTou);
                brush_Boss[224] = new SolidBrush(ColorShiTou);
                brush_Boss[225] = new SolidBrush(ColorShiTou);
                brush_Boss[226] = new SolidBrush(ColorShiTou);
                brush_Boss[227] = new SolidBrush(ColorShiTou);
                brush_Boss[228] = new SolidBrush(ColorShiTou);
                brush_Boss[229] = new SolidBrush(ColorShiTou);
                brush_Boss[230] = new SolidBrush(ColorShanDi);
                brush_Boss[231] = new SolidBrush(ColorShanDi);
                brush_Boss[232] = new SolidBrush(ColorShanDi);
                brush_Boss[233] = new SolidBrush(ColorShanDi);
                brush_Boss[234] = new SolidBrush(ColorShanDi);
                brush_Boss[235] = new SolidBrush(ColorShanDi);
                brush_Boss[236] = new SolidBrush(ColorShanDi);
                brush_Boss[237] = new SolidBrush(ColorShanDi);
                brush_Boss[238] = new SolidBrush(ColorShanDi);
                brush_Boss[239] = new SolidBrush(Color.White);
                brush_Boss[240] = new SolidBrush(Color.White);
                brush_Boss[241] = new SolidBrush(Color.White);
                brush_Boss[242] = new SolidBrush(Color.White);
                brush_Boss[243] = new SolidBrush(Color.White);
                brush_Boss[244] = new SolidBrush(Color.White);
                brush_Boss[245] = new SolidBrush(Color.White);
                brush_Boss[246] = new SolidBrush(Color.White);
                brush_Boss[247] = new SolidBrush(Color.White);
                brush_Boss[248] = new SolidBrush(Color.White);
                brush_Boss[249] = new SolidBrush(Color.White);
                brush_Boss[250] = new SolidBrush(Color.White);
                brush_Boss[251] = new SolidBrush(Color.White);
                brush_Boss[252] = new SolidBrush(Color.White);
                brush_Boss[253] = new SolidBrush(Color.White);
                brush_Boss[254] = new SolidBrush(Color.White);
                brush_Boss[255] = new SolidBrush(Color.White);


                #endregion

                #region 主题存入画刷队列

                BrushBlock.Add(brush_YiJi);
                BrushBlock.Add(brush_Coast);
                BrushBlock.Add(brush_Hilly);
                BrushBlock.Add(brush_Tower);
                BrushBlock.Add(brush_City);
                BrushBlock.Add(brush_Future);
                BrushBlock.Add(brush_Aether);
                BrushBlock.Add(brush_EDS);
                BrushBlock.Add(brush_Boss);

                #endregion

                #region 遗迹主题

                List<Bitmap> YijiImageList = new List<Bitmap>();
                YijiImageList.Add(Properties.Resources.GameGrid_我方基地);
                YijiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                YijiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                YijiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                YijiImageList.Add(Properties.Resources.GameGrid_树);
                YijiImageList.Add(Properties.Resources.GameGrid_草地);
                YijiImageList.Add(Properties.Resources.GameGrid_草地);
                YijiImageList.Add(Properties.Resources.GameGrid_草地);
                YijiImageList.Add(Properties.Resources.GameGrid_草地);
                YijiImageList.Add(Properties.Resources.GameGrid_空地);

                YijiImageList.Add(Properties.Resources.GameGrid_湿地);
                YijiImageList.Add(Properties.Resources.GameGrid_湿地);
                YijiImageList.Add(Properties.Resources.GameGrid_坑);

                YijiImageList.Add(Properties.Resources.GameGrid_敌方基地);
                YijiImageList.Add(Properties.Resources.GameGrid_旱地);
                YijiImageList.Add(Properties.Resources.GameGrid_草地);
                YijiImageList.Add(Properties.Resources.GameGrid_草地);
                YijiImageList.Add(Properties.Resources.GameGrid_草地);

                YijiImageList.Add(Properties.Resources.GameGrid_死地);
                YijiImageList.Add(Properties.Resources.GameGrid_旱地);

                YijiImageList.Add(Properties.Resources.GameGrid_火焰);

                YijiImageList.Add(Properties.Resources.GameGrid_石头);
                YijiImageList.Add(Properties.Resources.GameGrid_石头);
                YijiImageList.Add(Properties.Resources.GameGrid_树);

                YijiImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    YijiImageList.Add(Properties.Resources.GameGrid_水面);
                YijiImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    YijiImageList.Add(Properties.Resources.GameGrid_岩浆);

                YijiImageList.Add(Properties.Resources.GameGrid_空地);

                for (int i = 0; i <= 190 - 121; ++i)
                    YijiImageList.Add(Properties.Resources.GameGrid_山地);

                YijiImageList.Add(Properties.Resources.GameGrid_沙地);//191
                YijiImageList.Add(Properties.Resources.GameGrid_雪地);//192

                YijiImageList.Add(Properties.Resources.GameGrid_石头);//193
                YijiImageList.Add(Properties.Resources.GameGrid_山地);//194
                YijiImageList.Add(Properties.Resources.GameGrid_树);//195
                YijiImageList.Add(Properties.Resources.GameGrid_树);//196
                YijiImageList.Add(Properties.Resources.GameGrid_山地);//197
                YijiImageList.Add(Properties.Resources.GameGrid_石头);//198
                YijiImageList.Add(Properties.Resources.GameGrid_石头);//199
                YijiImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 208 - 201; ++i)
                    YijiImageList.Add(Properties.Resources.GameGrid_山地);
                for (int i = 0; i <= 255 - 209; ++i)
                    YijiImageList.Add(Properties.Resources.GameGrid_冰面);

                #endregion
                #region 海岸主题

                List<Bitmap> HaiAnImageList = new List<Bitmap>();
                HaiAnImageList.Add(Properties.Resources.GameGrid_我方基地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_藤蔓);
                HaiAnImageList.Add(Properties.Resources.GameGrid_藤蔓);
                HaiAnImageList.Add(Properties.Resources.GameGrid_藤蔓);
                HaiAnImageList.Add(Properties.Resources.GameGrid_树);
                HaiAnImageList.Add(Properties.Resources.GameGrid_草地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_草地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_草地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_草地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_空地);

                HaiAnImageList.Add(Properties.Resources.GameGrid_湿地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_湿地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_坑);

                HaiAnImageList.Add(Properties.Resources.GameGrid_敌方基地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_旱地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_草地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_草地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_草地);

                HaiAnImageList.Add(Properties.Resources.GameGrid_死地);
                HaiAnImageList.Add(Properties.Resources.GameGrid_旱地);

                HaiAnImageList.Add(Properties.Resources.GameGrid_火焰);

                HaiAnImageList.Add(Properties.Resources.GameGrid_石头);
                HaiAnImageList.Add(Properties.Resources.GameGrid_石头);
                HaiAnImageList.Add(Properties.Resources.GameGrid_树);
                HaiAnImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_水面);
                HaiAnImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_岩浆);

                HaiAnImageList.Add(Properties.Resources.GameGrid_空地);

                for (int i = 0; i <= 190 - 121; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_山地);

                HaiAnImageList.Add(Properties.Resources.GameGrid_沙地);//191
                HaiAnImageList.Add(Properties.Resources.GameGrid_雪地);//192

                HaiAnImageList.Add(Properties.Resources.GameGrid_石头);//193
                HaiAnImageList.Add(Properties.Resources.GameGrid_树);//194
                HaiAnImageList.Add(Properties.Resources.GameGrid_树);//195
                HaiAnImageList.Add(Properties.Resources.GameGrid_树);//196
                HaiAnImageList.Add(Properties.Resources.GameGrid_树);//197
                HaiAnImageList.Add(Properties.Resources.GameGrid_石头);//198
                HaiAnImageList.Add(Properties.Resources.GameGrid_石头);//199
                HaiAnImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 208 - 201; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_山地);
                for (int i = 0; i <= 255 - 209; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_冰面);

                #endregion
                #region 山地主题

                List<Bitmap> ShanDiImageList = new List<Bitmap>();
                ShanDiImageList.Add(Properties.Resources.GameGrid_我方基地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ShanDiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ShanDiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ShanDiImageList.Add(Properties.Resources.GameGrid_树);
                ShanDiImageList.Add(Properties.Resources.GameGrid_草地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_草地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_草地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_草地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_空地);

                ShanDiImageList.Add(Properties.Resources.GameGrid_湿地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_湿地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_坑);

                ShanDiImageList.Add(Properties.Resources.GameGrid_敌方基地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_旱地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_草地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_草地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_草地);

                ShanDiImageList.Add(Properties.Resources.GameGrid_死地);
                ShanDiImageList.Add(Properties.Resources.GameGrid_旱地);

                ShanDiImageList.Add(Properties.Resources.GameGrid_火焰);

                ShanDiImageList.Add(Properties.Resources.GameGrid_石头);
                ShanDiImageList.Add(Properties.Resources.GameGrid_石头);
                ShanDiImageList.Add(Properties.Resources.GameGrid_树);
                ShanDiImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    ShanDiImageList.Add(Properties.Resources.GameGrid_水面);
                ShanDiImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    ShanDiImageList.Add(Properties.Resources.GameGrid_岩浆);


                ShanDiImageList.Add(Properties.Resources.GameGrid_空地);

                for (int i = 0; i <= 186 - 121; ++i)
                    ShanDiImageList.Add(Properties.Resources.GameGrid_山地);

                ShanDiImageList.Add(Properties.Resources.GameGrid_死地);//187
                ShanDiImageList.Add(Properties.Resources.GameGrid_死地);//188
                ShanDiImageList.Add(Properties.Resources.GameGrid_山地);//189
                ShanDiImageList.Add(Properties.Resources.GameGrid_火焰);//190
                ShanDiImageList.Add(Properties.Resources.GameGrid_沙地);//191
                ShanDiImageList.Add(Properties.Resources.GameGrid_雪地);//192

                ShanDiImageList.Add(Properties.Resources.GameGrid_山地);//193
                ShanDiImageList.Add(Properties.Resources.GameGrid_树);//194
                ShanDiImageList.Add(Properties.Resources.GameGrid_山地);//195
                ShanDiImageList.Add(Properties.Resources.GameGrid_树);//196
                ShanDiImageList.Add(Properties.Resources.GameGrid_树);//197
                ShanDiImageList.Add(Properties.Resources.GameGrid_石头);//198
                ShanDiImageList.Add(Properties.Resources.GameGrid_石头);//199
                ShanDiImageList.Add(Properties.Resources.GameGrid_石头);//200

                ShanDiImageList.Add(Properties.Resources.GameGrid_树);//201
                ShanDiImageList.Add(Properties.Resources.GameGrid_树);//202

                for (int i = 0; i <= 255 - 203; ++i)
                    ShanDiImageList.Add(Properties.Resources.GameGrid_山地);

                #endregion
                #region 城堡主题

                List<Bitmap> ChengBaoImageList = new List<Bitmap>();
                ChengBaoImageList.Add(Properties.Resources.GameGrid_我方基地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_树);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_草地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_草地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_草地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_草地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_空地);

                ChengBaoImageList.Add(Properties.Resources.GameGrid_湿地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_湿地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_坑);

                ChengBaoImageList.Add(Properties.Resources.GameGrid_敌方基地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_旱地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_草地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_草地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_草地);

                ChengBaoImageList.Add(Properties.Resources.GameGrid_死地);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_旱地);

                ChengBaoImageList.Add(Properties.Resources.GameGrid_火焰);

                ChengBaoImageList.Add(Properties.Resources.GameGrid_石头);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_石头);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_树);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    ChengBaoImageList.Add(Properties.Resources.GameGrid_水面);
                ChengBaoImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    ChengBaoImageList.Add(Properties.Resources.GameGrid_岩浆);

                ChengBaoImageList.Add(Properties.Resources.GameGrid_空地); //120

                for (int i = 0; i <= 190 - 121; ++i)
                    ChengBaoImageList.Add(Properties.Resources.GameGrid_山地);

                ChengBaoImageList.Add(Properties.Resources.GameGrid_沙地);//191
                ChengBaoImageList.Add(Properties.Resources.GameGrid_雪地);//192

                ChengBaoImageList.Add(Properties.Resources.GameGrid_石头);//193
                ChengBaoImageList.Add(Properties.Resources.GameGrid_山地);//194
                ChengBaoImageList.Add(Properties.Resources.GameGrid_树);//195
                ChengBaoImageList.Add(Properties.Resources.GameGrid_树);//196
                ChengBaoImageList.Add(Properties.Resources.GameGrid_山地);//197
                ChengBaoImageList.Add(Properties.Resources.GameGrid_石头);//198
                ChengBaoImageList.Add(Properties.Resources.GameGrid_石头);//199
                ChengBaoImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 208 - 201; ++i)
                    ChengBaoImageList.Add(Properties.Resources.GameGrid_山地);
                for (int i = 0; i <= 255 - 209; ++i)
                    ChengBaoImageList.Add(Properties.Resources.GameGrid_冰面);

                #endregion
                #region 城市主题

                List<Bitmap> ChengShiImageList = new List<Bitmap>();
                ChengShiImageList.Add(Properties.Resources.GameGrid_我方基地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ChengShiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ChengShiImageList.Add(Properties.Resources.GameGrid_藤蔓);
                ChengShiImageList.Add(Properties.Resources.GameGrid_树);
                ChengShiImageList.Add(Properties.Resources.GameGrid_草地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_草地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_草地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_草地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_空地);

                ChengShiImageList.Add(Properties.Resources.GameGrid_湿地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_湿地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_坑);

                ChengShiImageList.Add(Properties.Resources.GameGrid_敌方基地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_旱地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_草地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_草地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_草地);

                ChengShiImageList.Add(Properties.Resources.GameGrid_死地);
                ChengShiImageList.Add(Properties.Resources.GameGrid_旱地);

                ChengShiImageList.Add(Properties.Resources.GameGrid_火焰);

                ChengShiImageList.Add(Properties.Resources.GameGrid_石头);
                ChengShiImageList.Add(Properties.Resources.GameGrid_石头);
                ChengShiImageList.Add(Properties.Resources.GameGrid_树);
                ChengShiImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    ChengShiImageList.Add(Properties.Resources.GameGrid_水面);
                ChengShiImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    ChengShiImageList.Add(Properties.Resources.GameGrid_岩浆);

                ChengShiImageList.Add(Properties.Resources.GameGrid_空地); //120

                for (int i = 0; i <= 190 - 121; ++i)
                    ChengShiImageList.Add(Properties.Resources.GameGrid_山地);

                ChengShiImageList.Add(Properties.Resources.GameGrid_沙地);//191
                ChengShiImageList.Add(Properties.Resources.GameGrid_雪地);//192

                ChengShiImageList.Add(Properties.Resources.GameGrid_石头);//193
                ChengShiImageList.Add(Properties.Resources.GameGrid_树);//194
                ChengShiImageList.Add(Properties.Resources.GameGrid_树);//195
                ChengShiImageList.Add(Properties.Resources.GameGrid_树);//196
                ChengShiImageList.Add(Properties.Resources.GameGrid_树);//197
                ChengShiImageList.Add(Properties.Resources.GameGrid_石头);//198
                ChengShiImageList.Add(Properties.Resources.GameGrid_石头);//199
                ChengShiImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 236 - 201; ++i)
                    ChengShiImageList.Add(Properties.Resources.GameGrid_死地);

                ChengShiImageList.Add(Properties.Resources.GameGrid_山地);//237
                ChengShiImageList.Add(Properties.Resources.GameGrid_山地);//238
                ChengShiImageList.Add(Properties.Resources.GameGrid_山地);//239
                ChengShiImageList.Add(Properties.Resources.GameGrid_山地);//240
                ChengShiImageList.Add(Properties.Resources.GameGrid_岩浆);//241
                ChengShiImageList.Add(Properties.Resources.GameGrid_岩浆);//242
                ChengShiImageList.Add(Properties.Resources.GameGrid_岩浆);//243
                ChengShiImageList.Add(Properties.Resources.GameGrid_岩浆);//244

                for (int i = 0; i <= 255 - 245; ++i)
                    ChengShiImageList.Add(Properties.Resources.GameGrid_冰面);

                #endregion
                #region 未来城主题

                List<Bitmap> FutureImageList = new List<Bitmap>();
                FutureImageList.Add(Properties.Resources.GameGrid_我方基地);
                FutureImageList.Add(Properties.Resources.GameGrid_藤蔓);
                FutureImageList.Add(Properties.Resources.GameGrid_藤蔓);
                FutureImageList.Add(Properties.Resources.GameGrid_藤蔓);
                FutureImageList.Add(Properties.Resources.GameGrid_树);
                FutureImageList.Add(Properties.Resources.GameGrid_草地);
                FutureImageList.Add(Properties.Resources.GameGrid_草地);
                FutureImageList.Add(Properties.Resources.GameGrid_草地);
                FutureImageList.Add(Properties.Resources.GameGrid_草地);
                FutureImageList.Add(Properties.Resources.GameGrid_空地);

                FutureImageList.Add(Properties.Resources.GameGrid_湿地);
                FutureImageList.Add(Properties.Resources.GameGrid_湿地);
                FutureImageList.Add(Properties.Resources.GameGrid_坑);

                FutureImageList.Add(Properties.Resources.GameGrid_敌方基地);
                FutureImageList.Add(Properties.Resources.GameGrid_旱地);
                FutureImageList.Add(Properties.Resources.GameGrid_草地);
                FutureImageList.Add(Properties.Resources.GameGrid_草地);
                FutureImageList.Add(Properties.Resources.GameGrid_草地);

                FutureImageList.Add(Properties.Resources.GameGrid_死地);
                FutureImageList.Add(Properties.Resources.GameGrid_旱地);

                FutureImageList.Add(Properties.Resources.GameGrid_火焰);

                FutureImageList.Add(Properties.Resources.GameGrid_石头);
                FutureImageList.Add(Properties.Resources.GameGrid_石头);
                FutureImageList.Add(Properties.Resources.GameGrid_树);
                FutureImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    FutureImageList.Add(Properties.Resources.GameGrid_水面);
                FutureImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    FutureImageList.Add(Properties.Resources.GameGrid_岩浆);

                FutureImageList.Add(Properties.Resources.GameGrid_空地); //120

                for (int i = 0; i <= 190 - 121; ++i)
                    FutureImageList.Add(Properties.Resources.GameGrid_山地);

                FutureImageList.Add(Properties.Resources.GameGrid_沙地);//191
                FutureImageList.Add(Properties.Resources.GameGrid_雪地);//192

                FutureImageList.Add(Properties.Resources.GameGrid_石头);//193
                FutureImageList.Add(Properties.Resources.GameGrid_树);//194
                FutureImageList.Add(Properties.Resources.GameGrid_树);//195
                FutureImageList.Add(Properties.Resources.GameGrid_石头);//196
                FutureImageList.Add(Properties.Resources.GameGrid_石头);//197
                FutureImageList.Add(Properties.Resources.GameGrid_石头);//198
                FutureImageList.Add(Properties.Resources.GameGrid_石头);//199
                FutureImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 255 - 201; ++i)
                    FutureImageList.Add(Properties.Resources.GameGrid_山地);

                #endregion
                #region 太空主题

                List<Bitmap> TaiKongImageList = new List<Bitmap>();
                TaiKongImageList.Add(Properties.Resources.GameGrid_我方基地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_藤蔓);
                TaiKongImageList.Add(Properties.Resources.GameGrid_藤蔓);
                TaiKongImageList.Add(Properties.Resources.GameGrid_藤蔓);
                TaiKongImageList.Add(Properties.Resources.GameGrid_树);
                TaiKongImageList.Add(Properties.Resources.GameGrid_草地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_草地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_草地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_草地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_空地);

                TaiKongImageList.Add(Properties.Resources.GameGrid_湿地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_湿地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_坑);

                TaiKongImageList.Add(Properties.Resources.GameGrid_敌方基地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_旱地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_草地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_草地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_草地);

                TaiKongImageList.Add(Properties.Resources.GameGrid_死地);
                TaiKongImageList.Add(Properties.Resources.GameGrid_旱地);

                TaiKongImageList.Add(Properties.Resources.GameGrid_火焰);

                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);
                TaiKongImageList.Add(Properties.Resources.GameGrid_树);
                TaiKongImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    TaiKongImageList.Add(Properties.Resources.GameGrid_水面);
                TaiKongImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    TaiKongImageList.Add(Properties.Resources.GameGrid_岩浆);

                TaiKongImageList.Add(Properties.Resources.GameGrid_空地); //120

                for (int i = 0; i <= 184 - 121; ++i)
                    TaiKongImageList.Add(Properties.Resources.GameGrid_山地);

                TaiKongImageList.Add(Properties.Resources.GameGrid_死地);//185
                TaiKongImageList.Add(Properties.Resources.GameGrid_死地);//186

                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//187
                TaiKongImageList.Add(Properties.Resources.GameGrid_树);//188
                TaiKongImageList.Add(Properties.Resources.GameGrid_山地);//189
                TaiKongImageList.Add(Properties.Resources.GameGrid_山地);//190
                TaiKongImageList.Add(Properties.Resources.GameGrid_沙地);//191
                TaiKongImageList.Add(Properties.Resources.GameGrid_雪地);//192

                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//193
                TaiKongImageList.Add(Properties.Resources.GameGrid_树);//194
                TaiKongImageList.Add(Properties.Resources.GameGrid_树);//195
                TaiKongImageList.Add(Properties.Resources.GameGrid_树);//196
                TaiKongImageList.Add(Properties.Resources.GameGrid_树);//197
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//198
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//199
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 248 - 201; ++i)
                    TaiKongImageList.Add(Properties.Resources.GameGrid_山地);

                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//249
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//250
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//251
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//252
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//253
                TaiKongImageList.Add(Properties.Resources.GameGrid_石头);//254
                TaiKongImageList.Add(Properties.Resources.GameGrid_山地);

                #endregion
                #region 异次元主题

                List<Bitmap> BECImageList = new List<Bitmap>();
                BECImageList.Add(Properties.Resources.GameGrid_我方基地);
                BECImageList.Add(Properties.Resources.GameGrid_藤蔓);
                BECImageList.Add(Properties.Resources.GameGrid_藤蔓);
                BECImageList.Add(Properties.Resources.GameGrid_藤蔓);
                BECImageList.Add(Properties.Resources.GameGrid_树);
                BECImageList.Add(Properties.Resources.GameGrid_草地);
                BECImageList.Add(Properties.Resources.GameGrid_草地);
                BECImageList.Add(Properties.Resources.GameGrid_草地);
                BECImageList.Add(Properties.Resources.GameGrid_草地);
                BECImageList.Add(Properties.Resources.GameGrid_空地);

                BECImageList.Add(Properties.Resources.GameGrid_湿地);
                BECImageList.Add(Properties.Resources.GameGrid_湿地);
                BECImageList.Add(Properties.Resources.GameGrid_坑);

                BECImageList.Add(Properties.Resources.GameGrid_敌方基地);
                BECImageList.Add(Properties.Resources.GameGrid_旱地);
                BECImageList.Add(Properties.Resources.GameGrid_草地);
                BECImageList.Add(Properties.Resources.GameGrid_草地);
                BECImageList.Add(Properties.Resources.GameGrid_草地);

                BECImageList.Add(Properties.Resources.GameGrid_死地);
                BECImageList.Add(Properties.Resources.GameGrid_旱地);

                BECImageList.Add(Properties.Resources.GameGrid_火焰);

                BECImageList.Add(Properties.Resources.GameGrid_石头);
                BECImageList.Add(Properties.Resources.GameGrid_石头);
                BECImageList.Add(Properties.Resources.GameGrid_树);
                BECImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    BECImageList.Add(Properties.Resources.GameGrid_水面);
                BECImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    BECImageList.Add(Properties.Resources.GameGrid_岩浆);

                BECImageList.Add(Properties.Resources.GameGrid_空地);

                for (int i = 0; i <= 184 - 121; ++i)
                    BECImageList.Add(Properties.Resources.GameGrid_山地);

                BECImageList.Add(Properties.Resources.GameGrid_死地);//185

                BECImageList.Add(Properties.Resources.GameGrid_石头);//186
                BECImageList.Add(Properties.Resources.GameGrid_石头);//187
                BECImageList.Add(Properties.Resources.GameGrid_死地);//188
                BECImageList.Add(Properties.Resources.GameGrid_死地);//189
                BECImageList.Add(Properties.Resources.GameGrid_火焰);//190
                BECImageList.Add(Properties.Resources.GameGrid_沙地);//191
                BECImageList.Add(Properties.Resources.GameGrid_雪地);//192

                BECImageList.Add(Properties.Resources.GameGrid_石头);//193
                BECImageList.Add(Properties.Resources.GameGrid_树);//194
                BECImageList.Add(Properties.Resources.GameGrid_树);//195
                BECImageList.Add(Properties.Resources.GameGrid_树);//196
                BECImageList.Add(Properties.Resources.GameGrid_树);//197
                BECImageList.Add(Properties.Resources.GameGrid_石头);//198
                BECImageList.Add(Properties.Resources.GameGrid_石头);//199
                BECImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 208 - 201; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_石头);
                for (int i = 0; i <= 255 - 209; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_冰面);

                #endregion
                #region 博士基地主题

                List<Bitmap> BossImageList = new List<Bitmap>();
                BossImageList.Add(Properties.Resources.GameGrid_我方基地);
                BossImageList.Add(Properties.Resources.GameGrid_藤蔓);
                BossImageList.Add(Properties.Resources.GameGrid_藤蔓);
                BossImageList.Add(Properties.Resources.GameGrid_藤蔓);
                BossImageList.Add(Properties.Resources.GameGrid_树);
                BossImageList.Add(Properties.Resources.GameGrid_草地);
                BossImageList.Add(Properties.Resources.GameGrid_草地);
                BossImageList.Add(Properties.Resources.GameGrid_草地);
                BossImageList.Add(Properties.Resources.GameGrid_草地);
                BossImageList.Add(Properties.Resources.GameGrid_空地);

                BossImageList.Add(Properties.Resources.GameGrid_湿地);
                BossImageList.Add(Properties.Resources.GameGrid_湿地);
                BossImageList.Add(Properties.Resources.GameGrid_坑);

                BossImageList.Add(Properties.Resources.GameGrid_敌方基地);
                BossImageList.Add(Properties.Resources.GameGrid_旱地);
                BossImageList.Add(Properties.Resources.GameGrid_草地);
                BossImageList.Add(Properties.Resources.GameGrid_草地);
                BossImageList.Add(Properties.Resources.GameGrid_草地);

                BossImageList.Add(Properties.Resources.GameGrid_死地);
                BossImageList.Add(Properties.Resources.GameGrid_旱地);

                BossImageList.Add(Properties.Resources.GameGrid_火焰);

                BossImageList.Add(Properties.Resources.GameGrid_石头);
                BossImageList.Add(Properties.Resources.GameGrid_石头);
                BossImageList.Add(Properties.Resources.GameGrid_树);
                BossImageList.Add(Properties.Resources.GameGrid_我方单位);

                for (int i = 0; i <= (int)(MapIdDefine.水面End - MapIdDefine.水面Start); ++i)
                    BossImageList.Add(Properties.Resources.GameGrid_水面);
                BossImageList.Add(Properties.Resources.GameGrid_敌方单位);

                for (int i = 0; i <= (int)(MapIdDefine.岩浆End - MapIdDefine.岩浆Start); ++i)
                    BossImageList.Add(Properties.Resources.GameGrid_岩浆);

                BossImageList.Add(Properties.Resources.GameGrid_空地);

                for (int i = 0; i <= 189 - 121; ++i)
                    BossImageList.Add(Properties.Resources.GameGrid_山地);

                BossImageList.Add(Properties.Resources.GameGrid_火焰);//190
                BossImageList.Add(Properties.Resources.GameGrid_沙地);//191
                BossImageList.Add(Properties.Resources.GameGrid_雪地);//192

                BossImageList.Add(Properties.Resources.GameGrid_石头);//193
                BossImageList.Add(Properties.Resources.GameGrid_石头);//194
                BossImageList.Add(Properties.Resources.GameGrid_树);//195
                BossImageList.Add(Properties.Resources.GameGrid_树);//196
                BossImageList.Add(Properties.Resources.GameGrid_石头);//197
                BossImageList.Add(Properties.Resources.GameGrid_石头);//198
                BossImageList.Add(Properties.Resources.GameGrid_石头);//199
                BossImageList.Add(Properties.Resources.GameGrid_石头);//200
                for (int i = 0; i <= 218 - 201; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_山地);

                for (int i = 0; i <= 229 - 219; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_石头);

                for (int i = 0; i <= 255 - 230; ++i)
                    HaiAnImageList.Add(Properties.Resources.GameGrid_山地);

                #endregion
                #region 存入队列
                GameGridImageList.Add(YijiImageList);
                GameGridImageList.Add(HaiAnImageList);
                GameGridImageList.Add(ShanDiImageList);
                GameGridImageList.Add(ChengBaoImageList);
                GameGridImageList.Add(ChengShiImageList);
                GameGridImageList.Add(FutureImageList);
                GameGridImageList.Add(TaiKongImageList);
                GameGridImageList.Add(BECImageList);
                GameGridImageList.Add(BossImageList);
                #endregion

        }

    }
}
