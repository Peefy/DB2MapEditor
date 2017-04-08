using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    public class MapPanelEditor
    {
        public MapPanelEditor()
        {
            #region 图片存入队列

            #region 遗迹主题地图图片

            YiJiMaplist.Add(MapPictureHelper.Relic_00_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_01_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_02_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_03_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_04_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_05_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_06_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_07_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_08_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_09_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_10_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_11_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_12_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_13_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_14_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_15_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_16_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_17_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_18_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_19_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_20_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_21_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_22_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_23_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_24_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_25_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_26_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_27_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_28_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_29_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_30_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_31_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_32_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_33_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_34_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_35_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_36_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_37_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_38_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_39_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_40_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_41_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_42_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_43_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_44_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_45_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_46_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_47_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_48_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_49_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_50_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_51_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_52_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_53_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_54_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_55_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_56_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_57_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_58_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_59_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_60_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_61_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_62_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_63_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_64_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_65_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_66_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_67_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_68_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_69_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_70_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_71_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_72_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_73_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_74_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_75_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_76_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_77_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_78_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_79_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_80_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_81_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_82_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_83_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_84_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_85_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_86_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_87_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_88_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_89_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_90_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_91_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_92_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_93_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_94_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_95_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_96_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_97_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_98_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_99_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_100_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_101_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_102_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_103_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_104_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_105_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_106_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_107_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_108_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_109_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_110_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_111_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_112_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_113_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_114_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_115_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_116_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_117_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_118_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_119_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_120_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_121_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_122_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_123_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_124_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_125_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_126_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_127_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_128_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_129_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_130_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_131_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_132_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_133_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_134_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_135_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_136_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_137_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_138_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_139_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_140_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_141_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_142_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_143_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_144_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_145_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_146_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_147_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_148_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_149_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_150_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_151_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_152_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_153_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_154_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_155_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_156_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_157_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_158_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_159_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_160_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_161_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_162_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_163_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_164_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_165_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_166_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_167_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_168_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_169_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_170_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_171_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_172_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_173_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_174_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_175_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_176_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_177_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_178_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_179_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_180_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_181_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_182_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_183_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_184_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_185_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_186_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_187_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_188_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_189_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_190_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_191_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_192_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_193_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_194_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_195_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_196_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_197_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_198_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_199_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_200_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_201_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_202_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_203_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_204_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_205_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_206_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_207_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_208_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_209_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_210_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_211_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_212_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_213_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_214_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_215_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_216_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_217_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_218_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_219_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_220_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_221_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_222_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_223_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_224_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_225_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_226_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_227_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_228_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_229_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_230_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_231_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_232_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_233_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_234_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_235_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_236_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_237_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_238_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_239_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_240_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_241_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_242_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_243_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_244_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_245_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_246_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_247_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_248_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_249_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_250_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_251_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_252_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_253_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_254_);  //00
            YiJiMaplist.Add(MapPictureHelper.Relic_255_);  //00

            #endregion
            #region 海岸主题地图图片

            //Coast_Maplist.Add(MapPictureHelper.Coast_草地3);  //00
            //Coast_Maplist.Add(MapPictureHelper.Coast_水面);   //01
            //Coast_Maplist.Add(MapPictureHelper.Coast_树);     //02
            //Coast_Maplist.Add(MapPictureHelper.Coast_基地);   //03
            //Coast_Maplist.Add(MapPictureHelper.Coast_山地7F); //04
            //Coast_Maplist.Add(MapPictureHelper.Coast_空地);   //05
            //Coast_Maplist.Add(MapPictureHelper.Coast_轻旱地); //06

            Coast_Maplist.Add(MapPictureHelper.Coast_00_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_01_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_02_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_03_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_04_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_05_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_06_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_07_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_08_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_09_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_10_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_11_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_12_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_13_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_14_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_15_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_16_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_17_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_18_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_19_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_20_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_21_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_22_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_23_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_24_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_25_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_26_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_27_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_28_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_29_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_30_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_31_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_32_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_33_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_34_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_35_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_36_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_37_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_38_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_39_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_40_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_41_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_42_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_43_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_44_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_45_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_46_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_47_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_48_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_49_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_50_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_51_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_52_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_53_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_54_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_55_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_56_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_57_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_58_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_59_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_60_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_61_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_62_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_63_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_64_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_65_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_66_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_67_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_68_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_69_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_70_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_71_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_72_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_73_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_74_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_75_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_76_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_77_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_78_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_79_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_80_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_81_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_82_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_83_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_84_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_85_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_86_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_87_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_88_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_89_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_90_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_91_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_92_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_93_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_94_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_95_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_96_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_97_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_98_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_99_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_100_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_101_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_102_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_103_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_104_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_105_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_106_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_107_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_108_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_109_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_110_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_111_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_112_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_113_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_114_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_115_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_116_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_117_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_118_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_119_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_120_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_121_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_122_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_123_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_124_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_125_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_126_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_127_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_128_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_129_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_130_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_131_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_132_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_133_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_134_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_135_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_136_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_137_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_138_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_139_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_140_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_141_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_142_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_143_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_144_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_145_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_146_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_147_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_148_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_149_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_150_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_151_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_152_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_153_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_154_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_155_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_156_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_157_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_158_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_159_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_160_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_161_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_162_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_163_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_164_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_165_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_166_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_167_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_168_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_169_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_170_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_171_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_172_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_173_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_174_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_175_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_176_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_177_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_178_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_179_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_180_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_181_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_182_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_183_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_184_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_185_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_186_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_187_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_188_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_189_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_190_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_191_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_192_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_193_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_194_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_195_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_196_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_197_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_198_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_199_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_200_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_201_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_202_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_203_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_204_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_205_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_206_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_207_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_208_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_209_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_210_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_211_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_212_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_213_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_214_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_215_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_216_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_217_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_218_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_219_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_220_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_221_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_222_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_223_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_224_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_225_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_226_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_227_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_228_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_229_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_230_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_231_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_232_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_233_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_234_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_235_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_236_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_237_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_238_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_239_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_240_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_241_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_242_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_243_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_244_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_245_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_246_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_247_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_248_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_249_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_250_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_251_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_252_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_253_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_254_); //00
            Coast_Maplist.Add(MapPictureHelper.Coast_255_); //00

            #endregion
            #region 山地主题地图图片

            //Hilly_Maplist.Add(MapPictureHelper.Hilly_草地3);  //00
            //Hilly_Maplist.Add(MapPictureHelper.Hilly_墙7F);   //01
            //Hilly_Maplist.Add(MapPictureHelper.Hilly_墙A5);   //02
            //Hilly_Maplist.Add(MapPictureHelper.Hilly_墙E3);   //03
            //Hilly_Maplist.Add(MapPictureHelper.Hilly_轻旱地); //04
            //Hilly_Maplist.Add(MapPictureHelper.Hilly_树15);   //05
            //Hilly_Maplist.Add(MapPictureHelper.Hilly_重旱地); //06

            Hilly_Maplist.Add(MapPictureHelper.Hilly_00_);  //0
            Hilly_Maplist.Add(MapPictureHelper.Hilly_01_);  //1
            Hilly_Maplist.Add(MapPictureHelper.Hilly_02_);  //2
            Hilly_Maplist.Add(MapPictureHelper.Hilly_03_);  //3
            Hilly_Maplist.Add(MapPictureHelper.Hilly_04_);  //4
            Hilly_Maplist.Add(MapPictureHelper.Hilly_05_);  //5
            Hilly_Maplist.Add(MapPictureHelper.Hilly_06_);  //6
            Hilly_Maplist.Add(MapPictureHelper.Hilly_07_);  //7
            Hilly_Maplist.Add(MapPictureHelper.Hilly_08_);  //8
            Hilly_Maplist.Add(MapPictureHelper.Hilly_09_);  //9
            Hilly_Maplist.Add(MapPictureHelper.Hilly_10_);  //10
            Hilly_Maplist.Add(MapPictureHelper.Hilly_11_);  //11
            Hilly_Maplist.Add(MapPictureHelper.Hilly_12_);  //12
            Hilly_Maplist.Add(MapPictureHelper.Hilly_13_);  //13
            Hilly_Maplist.Add(MapPictureHelper.Hilly_14_);  //14
            Hilly_Maplist.Add(MapPictureHelper.Hilly_15_);  //15
            Hilly_Maplist.Add(MapPictureHelper.Hilly_16_);  //16
            Hilly_Maplist.Add(MapPictureHelper.Hilly_17_);  //17
            Hilly_Maplist.Add(MapPictureHelper.Hilly_18_);  //18
            Hilly_Maplist.Add(MapPictureHelper.Hilly_19_);  //19
            Hilly_Maplist.Add(MapPictureHelper.Hilly_20_);  //20
            Hilly_Maplist.Add(MapPictureHelper.Hilly_21_);  //21
            Hilly_Maplist.Add(MapPictureHelper.Hilly_22_);  //22
            Hilly_Maplist.Add(MapPictureHelper.Hilly_23_);  //23
            Hilly_Maplist.Add(MapPictureHelper.Hilly_24_);  //24
            Hilly_Maplist.Add(MapPictureHelper.Hilly_25_);  //25
            Hilly_Maplist.Add(MapPictureHelper.Hilly_26_);  //26
            Hilly_Maplist.Add(MapPictureHelper.Hilly_27_);  //27
            Hilly_Maplist.Add(MapPictureHelper.Hilly_28_);  //28
            Hilly_Maplist.Add(MapPictureHelper.Hilly_29_);  //29
            Hilly_Maplist.Add(MapPictureHelper.Hilly_30_);  //30
            Hilly_Maplist.Add(MapPictureHelper.Hilly_31_);  //31
            Hilly_Maplist.Add(MapPictureHelper.Hilly_32_);  //32
            Hilly_Maplist.Add(MapPictureHelper.Hilly_33_);  //33
            Hilly_Maplist.Add(MapPictureHelper.Hilly_34_);  //34
            Hilly_Maplist.Add(MapPictureHelper.Hilly_35_);  //35
            Hilly_Maplist.Add(MapPictureHelper.Hilly_36_);  //36
            Hilly_Maplist.Add(MapPictureHelper.Hilly_37_);  //37
            Hilly_Maplist.Add(MapPictureHelper.Hilly_38_);  //38
            Hilly_Maplist.Add(MapPictureHelper.Hilly_39_);  //39
            Hilly_Maplist.Add(MapPictureHelper.Hilly_40_);  //40
            Hilly_Maplist.Add(MapPictureHelper.Hilly_41_);  //41
            Hilly_Maplist.Add(MapPictureHelper.Hilly_42_);  //42
            Hilly_Maplist.Add(MapPictureHelper.Hilly_43_);  //43
            Hilly_Maplist.Add(MapPictureHelper.Hilly_44_);  //44
            Hilly_Maplist.Add(MapPictureHelper.Hilly_45_);  //45
            Hilly_Maplist.Add(MapPictureHelper.Hilly_46_);  //46
            Hilly_Maplist.Add(MapPictureHelper.Hilly_47_);  //47
            Hilly_Maplist.Add(MapPictureHelper.Hilly_48_);  //48
            Hilly_Maplist.Add(MapPictureHelper.Hilly_49_);  //49
            Hilly_Maplist.Add(MapPictureHelper.Hilly_50_);  //50
            Hilly_Maplist.Add(MapPictureHelper.Hilly_51_);  //51
            Hilly_Maplist.Add(MapPictureHelper.Hilly_52_);  //52
            Hilly_Maplist.Add(MapPictureHelper.Hilly_53_);  //53
            Hilly_Maplist.Add(MapPictureHelper.Hilly_54_);  //54
            Hilly_Maplist.Add(MapPictureHelper.Hilly_55_);  //55
            Hilly_Maplist.Add(MapPictureHelper.Hilly_56_);  //56
            Hilly_Maplist.Add(MapPictureHelper.Hilly_57_);  //57
            Hilly_Maplist.Add(MapPictureHelper.Hilly_58_);  //58
            Hilly_Maplist.Add(MapPictureHelper.Hilly_59_);  //59
            Hilly_Maplist.Add(MapPictureHelper.Hilly_60_);  //60
            Hilly_Maplist.Add(MapPictureHelper.Hilly_61_);  //61
            Hilly_Maplist.Add(MapPictureHelper.Hilly_62_);  //62
            Hilly_Maplist.Add(MapPictureHelper.Hilly_63_);  //63
            Hilly_Maplist.Add(MapPictureHelper.Hilly_64_);  //64
            Hilly_Maplist.Add(MapPictureHelper.Hilly_65_);  //65
            Hilly_Maplist.Add(MapPictureHelper.Hilly_66_);  //66
            Hilly_Maplist.Add(MapPictureHelper.Hilly_67_);  //67
            Hilly_Maplist.Add(MapPictureHelper.Hilly_68_);  //68
            Hilly_Maplist.Add(MapPictureHelper.Hilly_69_);  //69
            Hilly_Maplist.Add(MapPictureHelper.Hilly_70_);  //70
            Hilly_Maplist.Add(MapPictureHelper.Hilly_71_);  //71
            Hilly_Maplist.Add(MapPictureHelper.Hilly_72_);  //72
            Hilly_Maplist.Add(MapPictureHelper.Hilly_73_);  //73
            Hilly_Maplist.Add(MapPictureHelper.Hilly_74_);  //74
            Hilly_Maplist.Add(MapPictureHelper.Hilly_75_);  //75
            Hilly_Maplist.Add(MapPictureHelper.Hilly_76_);  //76
            Hilly_Maplist.Add(MapPictureHelper.Hilly_77_);  //77
            Hilly_Maplist.Add(MapPictureHelper.Hilly_78_);  //78
            Hilly_Maplist.Add(MapPictureHelper.Hilly_79_);  //79
            Hilly_Maplist.Add(MapPictureHelper.Hilly_80_);  //80
            Hilly_Maplist.Add(MapPictureHelper.Hilly_81_);  //81
            Hilly_Maplist.Add(MapPictureHelper.Hilly_82_);  //82
            Hilly_Maplist.Add(MapPictureHelper.Hilly_83_);  //83
            Hilly_Maplist.Add(MapPictureHelper.Hilly_84_);  //84
            Hilly_Maplist.Add(MapPictureHelper.Hilly_85_);  //85
            Hilly_Maplist.Add(MapPictureHelper.Hilly_86_);  //86
            Hilly_Maplist.Add(MapPictureHelper.Hilly_87_);  //87
            Hilly_Maplist.Add(MapPictureHelper.Hilly_88_);  //88
            Hilly_Maplist.Add(MapPictureHelper.Hilly_89_);  //89
            Hilly_Maplist.Add(MapPictureHelper.Hilly_90_);  //90
            Hilly_Maplist.Add(MapPictureHelper.Hilly_91_);  //91
            Hilly_Maplist.Add(MapPictureHelper.Hilly_92_);  //92
            Hilly_Maplist.Add(MapPictureHelper.Hilly_93_);  //93
            Hilly_Maplist.Add(MapPictureHelper.Hilly_94_);  //94
            Hilly_Maplist.Add(MapPictureHelper.Hilly_95_);  //95
            Hilly_Maplist.Add(MapPictureHelper.Hilly_96_);  //96
            Hilly_Maplist.Add(MapPictureHelper.Hilly_97_);  //97
            Hilly_Maplist.Add(MapPictureHelper.Hilly_98_);  //98
            Hilly_Maplist.Add(MapPictureHelper.Hilly_99_);  //99
            Hilly_Maplist.Add(MapPictureHelper.Hilly_100_);  //100
            Hilly_Maplist.Add(MapPictureHelper.Hilly_101_);  //101
            Hilly_Maplist.Add(MapPictureHelper.Hilly_102_);  //102
            Hilly_Maplist.Add(MapPictureHelper.Hilly_103_);  //103
            Hilly_Maplist.Add(MapPictureHelper.Hilly_104_);  //104
            Hilly_Maplist.Add(MapPictureHelper.Hilly_105_);  //105
            Hilly_Maplist.Add(MapPictureHelper.Hilly_106_);  //106
            Hilly_Maplist.Add(MapPictureHelper.Hilly_107_);  //107
            Hilly_Maplist.Add(MapPictureHelper.Hilly_108_);  //108
            Hilly_Maplist.Add(MapPictureHelper.Hilly_109_);  //109
            Hilly_Maplist.Add(MapPictureHelper.Hilly_110_);  //110
            Hilly_Maplist.Add(MapPictureHelper.Hilly_111_);  //111
            Hilly_Maplist.Add(MapPictureHelper.Hilly_112_);  //112
            Hilly_Maplist.Add(MapPictureHelper.Hilly_113_);  //113
            Hilly_Maplist.Add(MapPictureHelper.Hilly_114_);  //114
            Hilly_Maplist.Add(MapPictureHelper.Hilly_115_);  //115
            Hilly_Maplist.Add(MapPictureHelper.Hilly_116_);  //116
            Hilly_Maplist.Add(MapPictureHelper.Hilly_117_);  //117
            Hilly_Maplist.Add(MapPictureHelper.Hilly_118_);  //118
            Hilly_Maplist.Add(MapPictureHelper.Hilly_119_);  //119
            Hilly_Maplist.Add(MapPictureHelper.Hilly_120_);  //120
            Hilly_Maplist.Add(MapPictureHelper.Hilly_121_);  //121
            Hilly_Maplist.Add(MapPictureHelper.Hilly_122_);  //122
            Hilly_Maplist.Add(MapPictureHelper.Hilly_123_);  //123
            Hilly_Maplist.Add(MapPictureHelper.Hilly_124_);  //124
            Hilly_Maplist.Add(MapPictureHelper.Hilly_125_);  //125
            Hilly_Maplist.Add(MapPictureHelper.Hilly_126_);  //126
            Hilly_Maplist.Add(MapPictureHelper.Hilly_127_);  //127
            Hilly_Maplist.Add(MapPictureHelper.Hilly_128_);  //128
            Hilly_Maplist.Add(MapPictureHelper.Hilly_129_);  //129
            Hilly_Maplist.Add(MapPictureHelper.Hilly_130_);  //130
            Hilly_Maplist.Add(MapPictureHelper.Hilly_131_);  //131
            Hilly_Maplist.Add(MapPictureHelper.Hilly_132_);  //132
            Hilly_Maplist.Add(MapPictureHelper.Hilly_133_);  //133
            Hilly_Maplist.Add(MapPictureHelper.Hilly_134_);  //134
            Hilly_Maplist.Add(MapPictureHelper.Hilly_135_);  //135
            Hilly_Maplist.Add(MapPictureHelper.Hilly_136_);  //136
            Hilly_Maplist.Add(MapPictureHelper.Hilly_137_);  //137
            Hilly_Maplist.Add(MapPictureHelper.Hilly_138_);  //138
            Hilly_Maplist.Add(MapPictureHelper.Hilly_139_);  //139
            Hilly_Maplist.Add(MapPictureHelper.Hilly_140_);  //140
            Hilly_Maplist.Add(MapPictureHelper.Hilly_141_);  //141
            Hilly_Maplist.Add(MapPictureHelper.Hilly_142_);  //142
            Hilly_Maplist.Add(MapPictureHelper.Hilly_143_);  //143
            Hilly_Maplist.Add(MapPictureHelper.Hilly_144_);  //144
            Hilly_Maplist.Add(MapPictureHelper.Hilly_145_);  //145
            Hilly_Maplist.Add(MapPictureHelper.Hilly_146_);  //146
            Hilly_Maplist.Add(MapPictureHelper.Hilly_147_);  //147
            Hilly_Maplist.Add(MapPictureHelper.Hilly_148_);  //148
            Hilly_Maplist.Add(MapPictureHelper.Hilly_149_);  //149
            Hilly_Maplist.Add(MapPictureHelper.Hilly_150_);  //150
            Hilly_Maplist.Add(MapPictureHelper.Hilly_151_);  //151
            Hilly_Maplist.Add(MapPictureHelper.Hilly_152_);  //152
            Hilly_Maplist.Add(MapPictureHelper.Hilly_153_);  //153
            Hilly_Maplist.Add(MapPictureHelper.Hilly_154_);  //154
            Hilly_Maplist.Add(MapPictureHelper.Hilly_155_);  //155
            Hilly_Maplist.Add(MapPictureHelper.Hilly_156_);  //156
            Hilly_Maplist.Add(MapPictureHelper.Hilly_157_);  //157
            Hilly_Maplist.Add(MapPictureHelper.Hilly_158_);  //158
            Hilly_Maplist.Add(MapPictureHelper.Hilly_159_);  //159
            Hilly_Maplist.Add(MapPictureHelper.Hilly_160_);  //160
            Hilly_Maplist.Add(MapPictureHelper.Hilly_161_);  //161
            Hilly_Maplist.Add(MapPictureHelper.Hilly_162_);  //162
            Hilly_Maplist.Add(MapPictureHelper.Hilly_163_);  //163
            Hilly_Maplist.Add(MapPictureHelper.Hilly_164_);  //164
            Hilly_Maplist.Add(MapPictureHelper.Hilly_165_);  //165
            Hilly_Maplist.Add(MapPictureHelper.Hilly_166_);  //166
            Hilly_Maplist.Add(MapPictureHelper.Hilly_167_);  //167
            Hilly_Maplist.Add(MapPictureHelper.Hilly_168_);  //168
            Hilly_Maplist.Add(MapPictureHelper.Hilly_169_);  //169
            Hilly_Maplist.Add(MapPictureHelper.Hilly_170_);  //170
            Hilly_Maplist.Add(MapPictureHelper.Hilly_171_);  //171
            Hilly_Maplist.Add(MapPictureHelper.Hilly_172_);  //172
            Hilly_Maplist.Add(MapPictureHelper.Hilly_173_);  //173
            Hilly_Maplist.Add(MapPictureHelper.Hilly_174_);  //174
            Hilly_Maplist.Add(MapPictureHelper.Hilly_175_);  //175
            Hilly_Maplist.Add(MapPictureHelper.Hilly_176_);  //176
            Hilly_Maplist.Add(MapPictureHelper.Hilly_177_);  //177
            Hilly_Maplist.Add(MapPictureHelper.Hilly_178_);  //178
            Hilly_Maplist.Add(MapPictureHelper.Hilly_179_);  //179
            Hilly_Maplist.Add(MapPictureHelper.Hilly_180_);  //180
            Hilly_Maplist.Add(MapPictureHelper.Hilly_181_);  //181
            Hilly_Maplist.Add(MapPictureHelper.Hilly_182_);  //182
            Hilly_Maplist.Add(MapPictureHelper.Hilly_183_);  //183
            Hilly_Maplist.Add(MapPictureHelper.Hilly_184_);  //184
            Hilly_Maplist.Add(MapPictureHelper.Hilly_185_);  //185
            Hilly_Maplist.Add(MapPictureHelper.Hilly_186_);  //186
            Hilly_Maplist.Add(MapPictureHelper.Hilly_187_);  //187
            Hilly_Maplist.Add(MapPictureHelper.Hilly_188_);  //188
            Hilly_Maplist.Add(MapPictureHelper.Hilly_189_);  //189
            Hilly_Maplist.Add(MapPictureHelper.Hilly_190_);  //190
            Hilly_Maplist.Add(MapPictureHelper.Hilly_191_);  //191
            Hilly_Maplist.Add(MapPictureHelper.Hilly_192_);  //192
            Hilly_Maplist.Add(MapPictureHelper.Hilly_193_);  //193
            Hilly_Maplist.Add(MapPictureHelper.Hilly_194_);  //194
            Hilly_Maplist.Add(MapPictureHelper.Hilly_195_);  //195
            Hilly_Maplist.Add(MapPictureHelper.Hilly_196_);  //196
            Hilly_Maplist.Add(MapPictureHelper.Hilly_197_);  //197
            Hilly_Maplist.Add(MapPictureHelper.Hilly_198_);  //198
            Hilly_Maplist.Add(MapPictureHelper.Hilly_199_);  //199
            Hilly_Maplist.Add(MapPictureHelper.Hilly_200_);  //200
            Hilly_Maplist.Add(MapPictureHelper.Hilly_201_);  //201
            Hilly_Maplist.Add(MapPictureHelper.Hilly_202_);  //202
            Hilly_Maplist.Add(MapPictureHelper.Hilly_203_);  //203
            Hilly_Maplist.Add(MapPictureHelper.Hilly_204_);  //204
            Hilly_Maplist.Add(MapPictureHelper.Hilly_205_);  //205
            Hilly_Maplist.Add(MapPictureHelper.Hilly_206_);  //206
            Hilly_Maplist.Add(MapPictureHelper.Hilly_207_);  //207
            Hilly_Maplist.Add(MapPictureHelper.Hilly_208_);  //208
            Hilly_Maplist.Add(MapPictureHelper.Hilly_209_);  //209
            Hilly_Maplist.Add(MapPictureHelper.Hilly_210_);  //210
            Hilly_Maplist.Add(MapPictureHelper.Hilly_211_);  //211
            Hilly_Maplist.Add(MapPictureHelper.Hilly_212_);  //212
            Hilly_Maplist.Add(MapPictureHelper.Hilly_213_);  //213
            Hilly_Maplist.Add(MapPictureHelper.Hilly_214_);  //214
            Hilly_Maplist.Add(MapPictureHelper.Hilly_215_);  //215
            Hilly_Maplist.Add(MapPictureHelper.Hilly_216_);  //216
            Hilly_Maplist.Add(MapPictureHelper.Hilly_217_);  //217
            Hilly_Maplist.Add(MapPictureHelper.Hilly_218_);  //218
            Hilly_Maplist.Add(MapPictureHelper.Hilly_219_);  //219
            Hilly_Maplist.Add(MapPictureHelper.Hilly_220_);  //220
            Hilly_Maplist.Add(MapPictureHelper.Hilly_221_);  //221
            Hilly_Maplist.Add(MapPictureHelper.Hilly_222_);  //222
            Hilly_Maplist.Add(MapPictureHelper.Hilly_223_);  //223
            Hilly_Maplist.Add(MapPictureHelper.Hilly_224_);  //224
            Hilly_Maplist.Add(MapPictureHelper.Hilly_225_);  //225
            Hilly_Maplist.Add(MapPictureHelper.Hilly_226_);  //226
            Hilly_Maplist.Add(MapPictureHelper.Hilly_227_);  //227
            Hilly_Maplist.Add(MapPictureHelper.Hilly_228_);  //228
            Hilly_Maplist.Add(MapPictureHelper.Hilly_229_);  //229
            Hilly_Maplist.Add(MapPictureHelper.Hilly_230_);  //230
            Hilly_Maplist.Add(MapPictureHelper.Hilly_231_);  //231
            Hilly_Maplist.Add(MapPictureHelper.Hilly_232_);  //232
            Hilly_Maplist.Add(MapPictureHelper.Hilly_233_);  //233
            Hilly_Maplist.Add(MapPictureHelper.Hilly_234_);  //234
            Hilly_Maplist.Add(MapPictureHelper.Hilly_235_);  //235
            Hilly_Maplist.Add(MapPictureHelper.Hilly_236_);  //236
            Hilly_Maplist.Add(MapPictureHelper.Hilly_237_);  //237
            Hilly_Maplist.Add(MapPictureHelper.Hilly_238_);  //238
            Hilly_Maplist.Add(MapPictureHelper.Hilly_239_);  //239
            Hilly_Maplist.Add(MapPictureHelper.Hilly_240_);  //240
            Hilly_Maplist.Add(MapPictureHelper.Hilly_241_);  //241
            Hilly_Maplist.Add(MapPictureHelper.Hilly_242_);  //242
            Hilly_Maplist.Add(MapPictureHelper.Hilly_243_);  //243
            Hilly_Maplist.Add(MapPictureHelper.Hilly_244_);  //244
            Hilly_Maplist.Add(MapPictureHelper.Hilly_245_);  //245
            Hilly_Maplist.Add(MapPictureHelper.Hilly_246_);  //246
            Hilly_Maplist.Add(MapPictureHelper.Hilly_247_);  //247
            Hilly_Maplist.Add(MapPictureHelper.Hilly_248_);  //248
            Hilly_Maplist.Add(MapPictureHelper.Hilly_249_);  //249
            Hilly_Maplist.Add(MapPictureHelper.Hilly_250_);  //250
            Hilly_Maplist.Add(MapPictureHelper.Hilly_251_);  //251
            Hilly_Maplist.Add(MapPictureHelper.Hilly_252_);  //252
            Hilly_Maplist.Add(MapPictureHelper.Hilly_253_);  //253
            Hilly_Maplist.Add(MapPictureHelper.Hilly_254_);  //254
            Hilly_Maplist.Add(MapPictureHelper.Hilly_255_);  //255


            #endregion
            #region 城堡主题地图图片

            //Tower_Maplist.Add(MapPictureHelper.Tower_树57);  //00
            //Tower_Maplist.Add(MapPictureHelper.Tower_死地);   //01
            //Tower_Maplist.Add(MapPictureHelper.Tower_藤蔓1);   //02
            //Tower_Maplist.Add(MapPictureHelper.Tower_岩浆E3);   //03
            //Tower_Maplist.Add(MapPictureHelper.Tower_岩浆E4); //04
            //Tower_Maplist.Add(MapPictureHelper.Tower_空地);   //05
            //Tower_Maplist.Add(MapPictureHelper.Tower_轻旱地); //06

            Tower_Maplist.Add(MapPictureHelper.Tower_00_); //0
            Tower_Maplist.Add(MapPictureHelper.Tower_01_); //1
            Tower_Maplist.Add(MapPictureHelper.Tower_02_); //2
            Tower_Maplist.Add(MapPictureHelper.Tower_03_); //3
            Tower_Maplist.Add(MapPictureHelper.Tower_04_); //4
            Tower_Maplist.Add(MapPictureHelper.Tower_05_); //5
            Tower_Maplist.Add(MapPictureHelper.Tower_06_); //6
            Tower_Maplist.Add(MapPictureHelper.Tower_07_); //7
            Tower_Maplist.Add(MapPictureHelper.Tower_08_); //8
            Tower_Maplist.Add(MapPictureHelper.Tower_09_); //9
            Tower_Maplist.Add(MapPictureHelper.Tower_10_); //10
            Tower_Maplist.Add(MapPictureHelper.Tower_11_); //11
            Tower_Maplist.Add(MapPictureHelper.Tower_12_); //12
            Tower_Maplist.Add(MapPictureHelper.Tower_13_); //13
            Tower_Maplist.Add(MapPictureHelper.Tower_14_); //14
            Tower_Maplist.Add(MapPictureHelper.Tower_15_); //15
            Tower_Maplist.Add(MapPictureHelper.Tower_16_); //16
            Tower_Maplist.Add(MapPictureHelper.Tower_17_); //17
            Tower_Maplist.Add(MapPictureHelper.Tower_18_); //18
            Tower_Maplist.Add(MapPictureHelper.Tower_19_); //19
            Tower_Maplist.Add(MapPictureHelper.Tower_20_); //20
            Tower_Maplist.Add(MapPictureHelper.Tower_21_); //21
            Tower_Maplist.Add(MapPictureHelper.Tower_22_); //22
            Tower_Maplist.Add(MapPictureHelper.Tower_23_); //23
            Tower_Maplist.Add(MapPictureHelper.Tower_24_); //24
            Tower_Maplist.Add(MapPictureHelper.Tower_25_); //25
            Tower_Maplist.Add(MapPictureHelper.Tower_26_); //26
            Tower_Maplist.Add(MapPictureHelper.Tower_27_); //27
            Tower_Maplist.Add(MapPictureHelper.Tower_28_); //28
            Tower_Maplist.Add(MapPictureHelper.Tower_29_); //29
            Tower_Maplist.Add(MapPictureHelper.Tower_30_); //30
            Tower_Maplist.Add(MapPictureHelper.Tower_31_); //31
            Tower_Maplist.Add(MapPictureHelper.Tower_32_); //32
            Tower_Maplist.Add(MapPictureHelper.Tower_33_); //33
            Tower_Maplist.Add(MapPictureHelper.Tower_34_); //34
            Tower_Maplist.Add(MapPictureHelper.Tower_35_); //35
            Tower_Maplist.Add(MapPictureHelper.Tower_36_); //36
            Tower_Maplist.Add(MapPictureHelper.Tower_37_); //37
            Tower_Maplist.Add(MapPictureHelper.Tower_38_); //38
            Tower_Maplist.Add(MapPictureHelper.Tower_39_); //39
            Tower_Maplist.Add(MapPictureHelper.Tower_40_); //40
            Tower_Maplist.Add(MapPictureHelper.Tower_41_); //41
            Tower_Maplist.Add(MapPictureHelper.Tower_42_); //42
            Tower_Maplist.Add(MapPictureHelper.Tower_43_); //43
            Tower_Maplist.Add(MapPictureHelper.Tower_44_); //44
            Tower_Maplist.Add(MapPictureHelper.Tower_45_); //45
            Tower_Maplist.Add(MapPictureHelper.Tower_46_); //46
            Tower_Maplist.Add(MapPictureHelper.Tower_47_); //47
            Tower_Maplist.Add(MapPictureHelper.Tower_48_); //48
            Tower_Maplist.Add(MapPictureHelper.Tower_49_); //49
            Tower_Maplist.Add(MapPictureHelper.Tower_50_); //50
            Tower_Maplist.Add(MapPictureHelper.Tower_51_); //51
            Tower_Maplist.Add(MapPictureHelper.Tower_52_); //52
            Tower_Maplist.Add(MapPictureHelper.Tower_53_); //53
            Tower_Maplist.Add(MapPictureHelper.Tower_54_); //54
            Tower_Maplist.Add(MapPictureHelper.Tower_55_); //55
            Tower_Maplist.Add(MapPictureHelper.Tower_56_); //56
            Tower_Maplist.Add(MapPictureHelper.Tower_57_); //57
            Tower_Maplist.Add(MapPictureHelper.Tower_58_); //58
            Tower_Maplist.Add(MapPictureHelper.Tower_59_); //59
            Tower_Maplist.Add(MapPictureHelper.Tower_60_); //60
            Tower_Maplist.Add(MapPictureHelper.Tower_61_); //61
            Tower_Maplist.Add(MapPictureHelper.Tower_62_); //62
            Tower_Maplist.Add(MapPictureHelper.Tower_63_); //63
            Tower_Maplist.Add(MapPictureHelper.Tower_64_); //64
            Tower_Maplist.Add(MapPictureHelper.Tower_65_); //65
            Tower_Maplist.Add(MapPictureHelper.Tower_66_); //66
            Tower_Maplist.Add(MapPictureHelper.Tower_67_); //67
            Tower_Maplist.Add(MapPictureHelper.Tower_68_); //68
            Tower_Maplist.Add(MapPictureHelper.Tower_69_); //69
            Tower_Maplist.Add(MapPictureHelper.Tower_70_); //70
            Tower_Maplist.Add(MapPictureHelper.Tower_71_); //71
            Tower_Maplist.Add(MapPictureHelper.Tower_72_); //72
            Tower_Maplist.Add(MapPictureHelper.Tower_73_); //73
            Tower_Maplist.Add(MapPictureHelper.Tower_74_); //74
            Tower_Maplist.Add(MapPictureHelper.Tower_75_); //75
            Tower_Maplist.Add(MapPictureHelper.Tower_76_); //76
            Tower_Maplist.Add(MapPictureHelper.Tower_77_); //77
            Tower_Maplist.Add(MapPictureHelper.Tower_78_); //78
            Tower_Maplist.Add(MapPictureHelper.Tower_79_); //79
            Tower_Maplist.Add(MapPictureHelper.Tower_80_); //80
            Tower_Maplist.Add(MapPictureHelper.Tower_81_); //81
            Tower_Maplist.Add(MapPictureHelper.Tower_82_); //82
            Tower_Maplist.Add(MapPictureHelper.Tower_83_); //83
            Tower_Maplist.Add(MapPictureHelper.Tower_84_); //84
            Tower_Maplist.Add(MapPictureHelper.Tower_85_); //85
            Tower_Maplist.Add(MapPictureHelper.Tower_86_); //86
            Tower_Maplist.Add(MapPictureHelper.Tower_87_); //87
            Tower_Maplist.Add(MapPictureHelper.Tower_88_); //88
            Tower_Maplist.Add(MapPictureHelper.Tower_89_); //89
            Tower_Maplist.Add(MapPictureHelper.Tower_90_); //90
            Tower_Maplist.Add(MapPictureHelper.Tower_91_); //91
            Tower_Maplist.Add(MapPictureHelper.Tower_92_); //92
            Tower_Maplist.Add(MapPictureHelper.Tower_93_); //93
            Tower_Maplist.Add(MapPictureHelper.Tower_94_); //94
            Tower_Maplist.Add(MapPictureHelper.Tower_95_); //95
            Tower_Maplist.Add(MapPictureHelper.Tower_96_); //96
            Tower_Maplist.Add(MapPictureHelper.Tower_97_); //97
            Tower_Maplist.Add(MapPictureHelper.Tower_98_); //98
            Tower_Maplist.Add(MapPictureHelper.Tower_99_); //99
            Tower_Maplist.Add(MapPictureHelper.Tower_100_); //100
            Tower_Maplist.Add(MapPictureHelper.Tower_101_); //101
            Tower_Maplist.Add(MapPictureHelper.Tower_102_); //102
            Tower_Maplist.Add(MapPictureHelper.Tower_103_); //103
            Tower_Maplist.Add(MapPictureHelper.Tower_104_); //104
            Tower_Maplist.Add(MapPictureHelper.Tower_105_); //105
            Tower_Maplist.Add(MapPictureHelper.Tower_106_); //106
            Tower_Maplist.Add(MapPictureHelper.Tower_107_); //107
            Tower_Maplist.Add(MapPictureHelper.Tower_108_); //108
            Tower_Maplist.Add(MapPictureHelper.Tower_109_); //109
            Tower_Maplist.Add(MapPictureHelper.Tower_110_); //110
            Tower_Maplist.Add(MapPictureHelper.Tower_111_); //111
            Tower_Maplist.Add(MapPictureHelper.Tower_112_); //112
            Tower_Maplist.Add(MapPictureHelper.Tower_113_); //113
            Tower_Maplist.Add(MapPictureHelper.Tower_114_); //114
            Tower_Maplist.Add(MapPictureHelper.Tower_115_); //115
            Tower_Maplist.Add(MapPictureHelper.Tower_116_); //116
            Tower_Maplist.Add(MapPictureHelper.Tower_117_); //117
            Tower_Maplist.Add(MapPictureHelper.Tower_118_); //118
            Tower_Maplist.Add(MapPictureHelper.Tower_119_); //119
            Tower_Maplist.Add(MapPictureHelper.Tower_120_); //120
            Tower_Maplist.Add(MapPictureHelper.Tower_121_); //121
            Tower_Maplist.Add(MapPictureHelper.Tower_122_); //122
            Tower_Maplist.Add(MapPictureHelper.Tower_123_); //123
            Tower_Maplist.Add(MapPictureHelper.Tower_124_); //124
            Tower_Maplist.Add(MapPictureHelper.Tower_125_); //125
            Tower_Maplist.Add(MapPictureHelper.Tower_126_); //126
            Tower_Maplist.Add(MapPictureHelper.Tower_127_); //127
            Tower_Maplist.Add(MapPictureHelper.Tower_128_); //128
            Tower_Maplist.Add(MapPictureHelper.Tower_129_); //129
            Tower_Maplist.Add(MapPictureHelper.Tower_130_); //130
            Tower_Maplist.Add(MapPictureHelper.Tower_131_); //131
            Tower_Maplist.Add(MapPictureHelper.Tower_132_); //132
            Tower_Maplist.Add(MapPictureHelper.Tower_133_); //133
            Tower_Maplist.Add(MapPictureHelper.Tower_134_); //134
            Tower_Maplist.Add(MapPictureHelper.Tower_135_); //135
            Tower_Maplist.Add(MapPictureHelper.Tower_136_); //136
            Tower_Maplist.Add(MapPictureHelper.Tower_137_); //137
            Tower_Maplist.Add(MapPictureHelper.Tower_138_); //138
            Tower_Maplist.Add(MapPictureHelper.Tower_139_); //139
            Tower_Maplist.Add(MapPictureHelper.Tower_140_); //140
            Tower_Maplist.Add(MapPictureHelper.Tower_141_); //141
            Tower_Maplist.Add(MapPictureHelper.Tower_142_); //142
            Tower_Maplist.Add(MapPictureHelper.Tower_143_); //143
            Tower_Maplist.Add(MapPictureHelper.Tower_144_); //144
            Tower_Maplist.Add(MapPictureHelper.Tower_145_); //145
            Tower_Maplist.Add(MapPictureHelper.Tower_146_); //146
            Tower_Maplist.Add(MapPictureHelper.Tower_147_); //147
            Tower_Maplist.Add(MapPictureHelper.Tower_148_); //148
            Tower_Maplist.Add(MapPictureHelper.Tower_149_); //149
            Tower_Maplist.Add(MapPictureHelper.Tower_150_); //150
            Tower_Maplist.Add(MapPictureHelper.Tower_151_); //151
            Tower_Maplist.Add(MapPictureHelper.Tower_152_); //152
            Tower_Maplist.Add(MapPictureHelper.Tower_153_); //153
            Tower_Maplist.Add(MapPictureHelper.Tower_154_); //154
            Tower_Maplist.Add(MapPictureHelper.Tower_155_); //155
            Tower_Maplist.Add(MapPictureHelper.Tower_156_); //156
            Tower_Maplist.Add(MapPictureHelper.Tower_157_); //157
            Tower_Maplist.Add(MapPictureHelper.Tower_158_); //158
            Tower_Maplist.Add(MapPictureHelper.Tower_159_); //159
            Tower_Maplist.Add(MapPictureHelper.Tower_160_); //160
            Tower_Maplist.Add(MapPictureHelper.Tower_161_); //161
            Tower_Maplist.Add(MapPictureHelper.Tower_162_); //162
            Tower_Maplist.Add(MapPictureHelper.Tower_163_); //163
            Tower_Maplist.Add(MapPictureHelper.Tower_164_); //164
            Tower_Maplist.Add(MapPictureHelper.Tower_165_); //165
            Tower_Maplist.Add(MapPictureHelper.Tower_166_); //166
            Tower_Maplist.Add(MapPictureHelper.Tower_167_); //167
            Tower_Maplist.Add(MapPictureHelper.Tower_168_); //168
            Tower_Maplist.Add(MapPictureHelper.Tower_169_); //169
            Tower_Maplist.Add(MapPictureHelper.Tower_170_); //170
            Tower_Maplist.Add(MapPictureHelper.Tower_171_); //171
            Tower_Maplist.Add(MapPictureHelper.Tower_172_); //172
            Tower_Maplist.Add(MapPictureHelper.Tower_173_); //173
            Tower_Maplist.Add(MapPictureHelper.Tower_174_); //174
            Tower_Maplist.Add(MapPictureHelper.Tower_175_); //175
            Tower_Maplist.Add(MapPictureHelper.Tower_176_); //176
            Tower_Maplist.Add(MapPictureHelper.Tower_177_); //177
            Tower_Maplist.Add(MapPictureHelper.Tower_178_); //178
            Tower_Maplist.Add(MapPictureHelper.Tower_179_); //179
            Tower_Maplist.Add(MapPictureHelper.Tower_180_); //180
            Tower_Maplist.Add(MapPictureHelper.Tower_181_); //181
            Tower_Maplist.Add(MapPictureHelper.Tower_182_); //182
            Tower_Maplist.Add(MapPictureHelper.Tower_183_); //183
            Tower_Maplist.Add(MapPictureHelper.Tower_184_); //184
            Tower_Maplist.Add(MapPictureHelper.Tower_185_); //185
            Tower_Maplist.Add(MapPictureHelper.Tower_186_); //186
            Tower_Maplist.Add(MapPictureHelper.Tower_187_); //187
            Tower_Maplist.Add(MapPictureHelper.Tower_188_); //188
            Tower_Maplist.Add(MapPictureHelper.Tower_189_); //189
            Tower_Maplist.Add(MapPictureHelper.Tower_190_); //190
            Tower_Maplist.Add(MapPictureHelper.Tower_191_); //191
            Tower_Maplist.Add(MapPictureHelper.Tower_192_); //192
            Tower_Maplist.Add(MapPictureHelper.Tower_193_); //193
            Tower_Maplist.Add(MapPictureHelper.Tower_194_); //194
            Tower_Maplist.Add(MapPictureHelper.Tower_195_); //195
            Tower_Maplist.Add(MapPictureHelper.Tower_196_); //196
            Tower_Maplist.Add(MapPictureHelper.Tower_197_); //197
            Tower_Maplist.Add(MapPictureHelper.Tower_198_); //198
            Tower_Maplist.Add(MapPictureHelper.Tower_199_); //199
            Tower_Maplist.Add(MapPictureHelper.Tower_200_); //200
            Tower_Maplist.Add(MapPictureHelper.Tower_201_); //201
            Tower_Maplist.Add(MapPictureHelper.Tower_202_); //202
            Tower_Maplist.Add(MapPictureHelper.Tower_203_); //203
            Tower_Maplist.Add(MapPictureHelper.Tower_204_); //204
            Tower_Maplist.Add(MapPictureHelper.Tower_205_); //205
            Tower_Maplist.Add(MapPictureHelper.Tower_206_); //206
            Tower_Maplist.Add(MapPictureHelper.Tower_207_); //207
            Tower_Maplist.Add(MapPictureHelper.Tower_208_); //208
            Tower_Maplist.Add(MapPictureHelper.Tower_209_); //209
            Tower_Maplist.Add(MapPictureHelper.Tower_210_); //210
            Tower_Maplist.Add(MapPictureHelper.Tower_211_); //211
            Tower_Maplist.Add(MapPictureHelper.Tower_212_); //212
            Tower_Maplist.Add(MapPictureHelper.Tower_213_); //213
            Tower_Maplist.Add(MapPictureHelper.Tower_214_); //214
            Tower_Maplist.Add(MapPictureHelper.Tower_215_); //215
            Tower_Maplist.Add(MapPictureHelper.Tower_216_); //216
            Tower_Maplist.Add(MapPictureHelper.Tower_217_); //217
            Tower_Maplist.Add(MapPictureHelper.Tower_218_); //218
            Tower_Maplist.Add(MapPictureHelper.Tower_219_); //219
            Tower_Maplist.Add(MapPictureHelper.Tower_220_); //220
            Tower_Maplist.Add(MapPictureHelper.Tower_221_); //221
            Tower_Maplist.Add(MapPictureHelper.Tower_222_); //222
            Tower_Maplist.Add(MapPictureHelper.Tower_223_); //223
            Tower_Maplist.Add(MapPictureHelper.Tower_224_); //224
            Tower_Maplist.Add(MapPictureHelper.Tower_225_); //225
            Tower_Maplist.Add(MapPictureHelper.Tower_226_); //226
            Tower_Maplist.Add(MapPictureHelper.Tower_227_); //227
            Tower_Maplist.Add(MapPictureHelper.Tower_228_); //228
            Tower_Maplist.Add(MapPictureHelper.Tower_229_); //229
            Tower_Maplist.Add(MapPictureHelper.Tower_230_); //230
            Tower_Maplist.Add(MapPictureHelper.Tower_231_); //231
            Tower_Maplist.Add(MapPictureHelper.Tower_232_); //232
            Tower_Maplist.Add(MapPictureHelper.Tower_233_); //233
            Tower_Maplist.Add(MapPictureHelper.Tower_234_); //234
            Tower_Maplist.Add(MapPictureHelper.Tower_235_); //235
            Tower_Maplist.Add(MapPictureHelper.Tower_236_); //236
            Tower_Maplist.Add(MapPictureHelper.Tower_237_); //237
            Tower_Maplist.Add(MapPictureHelper.Tower_238_); //238
            Tower_Maplist.Add(MapPictureHelper.Tower_239_); //239
            Tower_Maplist.Add(MapPictureHelper.Tower_240_); //240
            Tower_Maplist.Add(MapPictureHelper.Tower_241_); //241
            Tower_Maplist.Add(MapPictureHelper.Tower_242_); //242
            Tower_Maplist.Add(MapPictureHelper.Tower_243_); //243
            Tower_Maplist.Add(MapPictureHelper.Tower_244_); //244
            Tower_Maplist.Add(MapPictureHelper.Tower_245_); //245
            Tower_Maplist.Add(MapPictureHelper.Tower_246_); //246
            Tower_Maplist.Add(MapPictureHelper.Tower_247_); //247
            Tower_Maplist.Add(MapPictureHelper.Tower_248_); //248
            Tower_Maplist.Add(MapPictureHelper.Tower_249_); //249
            Tower_Maplist.Add(MapPictureHelper.Tower_250_); //250
            Tower_Maplist.Add(MapPictureHelper.Tower_251_); //251
            Tower_Maplist.Add(MapPictureHelper.Tower_252_); //252
            Tower_Maplist.Add(MapPictureHelper.Tower_253_); //253
            Tower_Maplist.Add(MapPictureHelper.Tower_254_); //254
            Tower_Maplist.Add(MapPictureHelper.Tower_255_); //255


            #endregion
            #region 城市主题地图图片

            //City_Maplist.Add(MapPictureHelper.City_死地1);  //00
            //City_Maplist.Add(MapPictureHelper.City_死地2);   //01
            //City_Maplist.Add(MapPictureHelper.City_死地3);   //02
            //City_Maplist.Add(MapPictureHelper.City_树13);   //03
            //City_Maplist.Add(MapPictureHelper.City_树14); //04
            //City_Maplist.Add(MapPictureHelper.City_空地);   //05
            //City_Maplist.Add(MapPictureHelper.City_水面25); //06

            City_Maplist.Add(MapPictureHelper.City_00_);  //00
            City_Maplist.Add(MapPictureHelper.City_01_);  //00
            City_Maplist.Add(MapPictureHelper.City_02_);  //00
            City_Maplist.Add(MapPictureHelper.City_03_);  //00
            City_Maplist.Add(MapPictureHelper.City_04_);  //00
            City_Maplist.Add(MapPictureHelper.City_05_);  //00
            City_Maplist.Add(MapPictureHelper.City_06_);  //00
            City_Maplist.Add(MapPictureHelper.City_07_);  //00
            City_Maplist.Add(MapPictureHelper.City_08_);  //00
            City_Maplist.Add(MapPictureHelper.City_09_);  //00
            City_Maplist.Add(MapPictureHelper.City_10_);  //00
            City_Maplist.Add(MapPictureHelper.City_11_);  //00
            City_Maplist.Add(MapPictureHelper.City_12_);  //00
            City_Maplist.Add(MapPictureHelper.City_13_);  //00
            City_Maplist.Add(MapPictureHelper.City_14_);  //00
            City_Maplist.Add(MapPictureHelper.City_15_);  //00
            City_Maplist.Add(MapPictureHelper.City_16_);  //00
            City_Maplist.Add(MapPictureHelper.City_17_);  //00
            City_Maplist.Add(MapPictureHelper.City_18_);  //00
            City_Maplist.Add(MapPictureHelper.City_19_);  //00
            City_Maplist.Add(MapPictureHelper.City_20_);  //00
            City_Maplist.Add(MapPictureHelper.City_21_);  //00
            City_Maplist.Add(MapPictureHelper.City_22_);  //00
            City_Maplist.Add(MapPictureHelper.City_23_);  //00
            City_Maplist.Add(MapPictureHelper.City_24_);  //00
            City_Maplist.Add(MapPictureHelper.City_25_);  //00
            City_Maplist.Add(MapPictureHelper.City_26_);  //00
            City_Maplist.Add(MapPictureHelper.City_27_);  //00
            City_Maplist.Add(MapPictureHelper.City_28_);  //00
            City_Maplist.Add(MapPictureHelper.City_29_);  //00
            City_Maplist.Add(MapPictureHelper.City_30_);  //00
            City_Maplist.Add(MapPictureHelper.City_31_);  //00
            City_Maplist.Add(MapPictureHelper.City_32_);  //00
            City_Maplist.Add(MapPictureHelper.City_33_);  //00
            City_Maplist.Add(MapPictureHelper.City_34_);  //00
            City_Maplist.Add(MapPictureHelper.City_35_);  //00
            City_Maplist.Add(MapPictureHelper.City_36_);  //00
            City_Maplist.Add(MapPictureHelper.City_37_);  //00
            City_Maplist.Add(MapPictureHelper.City_38_);  //00
            City_Maplist.Add(MapPictureHelper.City_39_);  //00
            City_Maplist.Add(MapPictureHelper.City_40_);  //00
            City_Maplist.Add(MapPictureHelper.City_41_);  //00
            City_Maplist.Add(MapPictureHelper.City_42_);  //00
            City_Maplist.Add(MapPictureHelper.City_43_);  //00
            City_Maplist.Add(MapPictureHelper.City_44_);  //00
            City_Maplist.Add(MapPictureHelper.City_45_);  //00
            City_Maplist.Add(MapPictureHelper.City_46_);  //00
            City_Maplist.Add(MapPictureHelper.City_47_);  //00
            City_Maplist.Add(MapPictureHelper.City_48_);  //00
            City_Maplist.Add(MapPictureHelper.City_49_);  //00
            City_Maplist.Add(MapPictureHelper.City_50_);  //00
            City_Maplist.Add(MapPictureHelper.City_51_);  //00
            City_Maplist.Add(MapPictureHelper.City_52_);  //00
            City_Maplist.Add(MapPictureHelper.City_53_);  //00
            City_Maplist.Add(MapPictureHelper.City_54_);  //00
            City_Maplist.Add(MapPictureHelper.City_55_);  //00
            City_Maplist.Add(MapPictureHelper.City_56_);  //00
            City_Maplist.Add(MapPictureHelper.City_57_);  //00
            City_Maplist.Add(MapPictureHelper.City_58_);  //00
            City_Maplist.Add(MapPictureHelper.City_59_);  //00
            City_Maplist.Add(MapPictureHelper.City_60_);  //00
            City_Maplist.Add(MapPictureHelper.City_61_);  //00
            City_Maplist.Add(MapPictureHelper.City_62_);  //00
            City_Maplist.Add(MapPictureHelper.City_63_);  //00
            City_Maplist.Add(MapPictureHelper.City_64_);  //00
            City_Maplist.Add(MapPictureHelper.City_65_);  //00
            City_Maplist.Add(MapPictureHelper.City_66_);  //00
            City_Maplist.Add(MapPictureHelper.City_67_);  //00
            City_Maplist.Add(MapPictureHelper.City_68_);  //00
            City_Maplist.Add(MapPictureHelper.City_69_);  //00
            City_Maplist.Add(MapPictureHelper.City_70_);  //00
            City_Maplist.Add(MapPictureHelper.City_71_);  //00
            City_Maplist.Add(MapPictureHelper.City_72_);  //00
            City_Maplist.Add(MapPictureHelper.City_73_);  //00
            City_Maplist.Add(MapPictureHelper.City_74_);  //00
            City_Maplist.Add(MapPictureHelper.City_75_);  //00
            City_Maplist.Add(MapPictureHelper.City_76_);  //00
            City_Maplist.Add(MapPictureHelper.City_77_);  //00
            City_Maplist.Add(MapPictureHelper.City_78_);  //00
            City_Maplist.Add(MapPictureHelper.City_79_);  //00
            City_Maplist.Add(MapPictureHelper.City_80_);  //00
            City_Maplist.Add(MapPictureHelper.City_81_);  //00
            City_Maplist.Add(MapPictureHelper.City_82_);  //00
            City_Maplist.Add(MapPictureHelper.City_83_);  //00
            City_Maplist.Add(MapPictureHelper.City_84_);  //00
            City_Maplist.Add(MapPictureHelper.City_85_);  //00
            City_Maplist.Add(MapPictureHelper.City_86_);  //00
            City_Maplist.Add(MapPictureHelper.City_87_);  //00
            City_Maplist.Add(MapPictureHelper.City_88_);  //00
            City_Maplist.Add(MapPictureHelper.City_89_);  //00
            City_Maplist.Add(MapPictureHelper.City_90_);  //00
            City_Maplist.Add(MapPictureHelper.City_91_);  //00
            City_Maplist.Add(MapPictureHelper.City_92_);  //00
            City_Maplist.Add(MapPictureHelper.City_93_);  //00
            City_Maplist.Add(MapPictureHelper.City_94_);  //00
            City_Maplist.Add(MapPictureHelper.City_95_);  //00
            City_Maplist.Add(MapPictureHelper.City_96_);  //00
            City_Maplist.Add(MapPictureHelper.City_97_);  //00
            City_Maplist.Add(MapPictureHelper.City_98_);  //00
            City_Maplist.Add(MapPictureHelper.City_99_);  //00
            City_Maplist.Add(MapPictureHelper.City_100_);  //00
            City_Maplist.Add(MapPictureHelper.City_101_);  //00
            City_Maplist.Add(MapPictureHelper.City_102_);  //00
            City_Maplist.Add(MapPictureHelper.City_103_);  //00
            City_Maplist.Add(MapPictureHelper.City_104_);  //00
            City_Maplist.Add(MapPictureHelper.City_105_);  //00
            City_Maplist.Add(MapPictureHelper.City_106_);  //00
            City_Maplist.Add(MapPictureHelper.City_107_);  //00
            City_Maplist.Add(MapPictureHelper.City_108_);  //00
            City_Maplist.Add(MapPictureHelper.City_109_);  //00
            City_Maplist.Add(MapPictureHelper.City_110_);  //00
            City_Maplist.Add(MapPictureHelper.City_111_);  //00
            City_Maplist.Add(MapPictureHelper.City_112_);  //00
            City_Maplist.Add(MapPictureHelper.City_113_);  //00
            City_Maplist.Add(MapPictureHelper.City_114_);  //00
            City_Maplist.Add(MapPictureHelper.City_115_);  //00
            City_Maplist.Add(MapPictureHelper.City_116_);  //00
            City_Maplist.Add(MapPictureHelper.City_117_);  //00
            City_Maplist.Add(MapPictureHelper.City_118_);  //00
            City_Maplist.Add(MapPictureHelper.City_119_);  //00
            City_Maplist.Add(MapPictureHelper.City_120_);  //00
            City_Maplist.Add(MapPictureHelper.City_121_);  //00
            City_Maplist.Add(MapPictureHelper.City_122_);  //00
            City_Maplist.Add(MapPictureHelper.City_123_);  //00
            City_Maplist.Add(MapPictureHelper.City_124_);  //00
            City_Maplist.Add(MapPictureHelper.City_125_);  //00
            City_Maplist.Add(MapPictureHelper.City_126_);  //00
            City_Maplist.Add(MapPictureHelper.City_127_);  //00
            City_Maplist.Add(MapPictureHelper.City_128_);  //00
            City_Maplist.Add(MapPictureHelper.City_129_);  //00
            City_Maplist.Add(MapPictureHelper.City_130_);  //00
            City_Maplist.Add(MapPictureHelper.City_131_);  //00
            City_Maplist.Add(MapPictureHelper.City_132_);  //00
            City_Maplist.Add(MapPictureHelper.City_133_);  //00
            City_Maplist.Add(MapPictureHelper.City_134_);  //00
            City_Maplist.Add(MapPictureHelper.City_135_);  //00
            City_Maplist.Add(MapPictureHelper.City_136_);  //00
            City_Maplist.Add(MapPictureHelper.City_137_);  //00
            City_Maplist.Add(MapPictureHelper.City_138_);  //00
            City_Maplist.Add(MapPictureHelper.City_139_);  //00
            City_Maplist.Add(MapPictureHelper.City_140_);  //00
            City_Maplist.Add(MapPictureHelper.City_141_);  //00
            City_Maplist.Add(MapPictureHelper.City_142_);  //00
            City_Maplist.Add(MapPictureHelper.City_143_);  //00
            City_Maplist.Add(MapPictureHelper.City_144_);  //00
            City_Maplist.Add(MapPictureHelper.City_145_);  //00
            City_Maplist.Add(MapPictureHelper.City_146_);  //00
            City_Maplist.Add(MapPictureHelper.City_147_);  //00
            City_Maplist.Add(MapPictureHelper.City_148_);  //00
            City_Maplist.Add(MapPictureHelper.City_149_);  //00
            City_Maplist.Add(MapPictureHelper.City_150_);  //00
            City_Maplist.Add(MapPictureHelper.City_151_);  //00
            City_Maplist.Add(MapPictureHelper.City_152_);  //00
            City_Maplist.Add(MapPictureHelper.City_153_);  //00
            City_Maplist.Add(MapPictureHelper.City_154_);  //00
            City_Maplist.Add(MapPictureHelper.City_155_);  //00
            City_Maplist.Add(MapPictureHelper.City_156_);  //00
            City_Maplist.Add(MapPictureHelper.City_157_);  //00
            City_Maplist.Add(MapPictureHelper.City_158_);  //00
            City_Maplist.Add(MapPictureHelper.City_159_);  //00
            City_Maplist.Add(MapPictureHelper.City_160_);  //00
            City_Maplist.Add(MapPictureHelper.City_161_);  //00
            City_Maplist.Add(MapPictureHelper.City_162_);  //00
            City_Maplist.Add(MapPictureHelper.City_163_);  //00
            City_Maplist.Add(MapPictureHelper.City_164_);  //00
            City_Maplist.Add(MapPictureHelper.City_165_);  //00
            City_Maplist.Add(MapPictureHelper.City_166_);  //00
            City_Maplist.Add(MapPictureHelper.City_167_);  //00
            City_Maplist.Add(MapPictureHelper.City_168_);  //00
            City_Maplist.Add(MapPictureHelper.City_169_);  //00
            City_Maplist.Add(MapPictureHelper.City_170_);  //00
            City_Maplist.Add(MapPictureHelper.City_171_);  //00
            City_Maplist.Add(MapPictureHelper.City_172_);  //00
            City_Maplist.Add(MapPictureHelper.City_173_);  //00
            City_Maplist.Add(MapPictureHelper.City_174_);  //00
            City_Maplist.Add(MapPictureHelper.City_175_);  //00
            City_Maplist.Add(MapPictureHelper.City_176_);  //00
            City_Maplist.Add(MapPictureHelper.City_177_);  //00
            City_Maplist.Add(MapPictureHelper.City_178_);  //00
            City_Maplist.Add(MapPictureHelper.City_179_);  //00
            City_Maplist.Add(MapPictureHelper.City_180_);  //00
            City_Maplist.Add(MapPictureHelper.City_181_);  //00
            City_Maplist.Add(MapPictureHelper.City_182_);  //00
            City_Maplist.Add(MapPictureHelper.City_183_);  //00
            City_Maplist.Add(MapPictureHelper.City_184_);  //00
            City_Maplist.Add(MapPictureHelper.City_185_);  //00
            City_Maplist.Add(MapPictureHelper.City_186_);  //00
            City_Maplist.Add(MapPictureHelper.City_187_);  //00
            City_Maplist.Add(MapPictureHelper.City_188_);  //00
            City_Maplist.Add(MapPictureHelper.City_189_);  //00
            City_Maplist.Add(MapPictureHelper.City_190_);  //00
            City_Maplist.Add(MapPictureHelper.City_191_);  //00
            City_Maplist.Add(MapPictureHelper.City_192_);  //00
            City_Maplist.Add(MapPictureHelper.City_193_);  //00
            City_Maplist.Add(MapPictureHelper.City_194_);  //00
            City_Maplist.Add(MapPictureHelper.City_195_);  //00
            City_Maplist.Add(MapPictureHelper.City_196_);  //00
            City_Maplist.Add(MapPictureHelper.City_197_);  //00
            City_Maplist.Add(MapPictureHelper.City_198_);  //00
            City_Maplist.Add(MapPictureHelper.City_199_);  //00
            City_Maplist.Add(MapPictureHelper.City_200_);  //00
            City_Maplist.Add(MapPictureHelper.City_201_);  //00
            City_Maplist.Add(MapPictureHelper.City_202_);  //00
            City_Maplist.Add(MapPictureHelper.City_203_);  //00
            City_Maplist.Add(MapPictureHelper.City_204_);  //00
            City_Maplist.Add(MapPictureHelper.City_205_);  //00
            City_Maplist.Add(MapPictureHelper.City_206_);  //00
            City_Maplist.Add(MapPictureHelper.City_207_);  //00
            City_Maplist.Add(MapPictureHelper.City_208_);  //00
            City_Maplist.Add(MapPictureHelper.City_209_);  //00
            City_Maplist.Add(MapPictureHelper.City_210_);  //00
            City_Maplist.Add(MapPictureHelper.City_211_);  //00
            City_Maplist.Add(MapPictureHelper.City_212_);  //00
            City_Maplist.Add(MapPictureHelper.City_213_);  //00
            City_Maplist.Add(MapPictureHelper.City_214_);  //00
            City_Maplist.Add(MapPictureHelper.City_215_);  //00
            City_Maplist.Add(MapPictureHelper.City_216_);  //00
            City_Maplist.Add(MapPictureHelper.City_217_);  //00
            City_Maplist.Add(MapPictureHelper.City_218_);  //00
            City_Maplist.Add(MapPictureHelper.City_219_);  //00
            City_Maplist.Add(MapPictureHelper.City_220_);  //00
            City_Maplist.Add(MapPictureHelper.City_221_);  //00
            City_Maplist.Add(MapPictureHelper.City_222_);  //00
            City_Maplist.Add(MapPictureHelper.City_223_);  //00
            City_Maplist.Add(MapPictureHelper.City_224_);  //00
            City_Maplist.Add(MapPictureHelper.City_225_);  //00
            City_Maplist.Add(MapPictureHelper.City_226_);  //00
            City_Maplist.Add(MapPictureHelper.City_227_);  //00
            City_Maplist.Add(MapPictureHelper.City_228_);  //00
            City_Maplist.Add(MapPictureHelper.City_229_);  //00
            City_Maplist.Add(MapPictureHelper.City_230_);  //00
            City_Maplist.Add(MapPictureHelper.City_231_);  //00
            City_Maplist.Add(MapPictureHelper.City_232_);  //00
            City_Maplist.Add(MapPictureHelper.City_233_);  //00
            City_Maplist.Add(MapPictureHelper.City_234_);  //00
            City_Maplist.Add(MapPictureHelper.City_235_);  //00
            City_Maplist.Add(MapPictureHelper.City_236_);  //00
            City_Maplist.Add(MapPictureHelper.City_237_);  //00
            City_Maplist.Add(MapPictureHelper.City_238_);  //00
            City_Maplist.Add(MapPictureHelper.City_239_);  //00
            City_Maplist.Add(MapPictureHelper.City_240_);  //00
            City_Maplist.Add(MapPictureHelper.City_241_);  //00
            City_Maplist.Add(MapPictureHelper.City_242_);  //00
            City_Maplist.Add(MapPictureHelper.City_243_);  //00
            City_Maplist.Add(MapPictureHelper.City_244_);  //00
            City_Maplist.Add(MapPictureHelper.City_245_);  //00
            City_Maplist.Add(MapPictureHelper.City_246_);  //00
            City_Maplist.Add(MapPictureHelper.City_247_);  //00
            City_Maplist.Add(MapPictureHelper.City_248_);  //00
            City_Maplist.Add(MapPictureHelper.City_249_);  //00
            City_Maplist.Add(MapPictureHelper.City_250_);  //00
            City_Maplist.Add(MapPictureHelper.City_251_);  //00
            City_Maplist.Add(MapPictureHelper.City_252_);  //00
            City_Maplist.Add(MapPictureHelper.City_253_);  //00
            City_Maplist.Add(MapPictureHelper.City_254_);  //00
            City_Maplist.Add(MapPictureHelper.City_255_);  //00


            #endregion
            #region 未来城地图图片

            //Future_Maplist.Add(MapPictureHelper.Future_墙E2);  //00
            //Future_Maplist.Add(MapPictureHelper.Future_死地);   //01
            //Future_Maplist.Add(MapPictureHelper.Future_草地4);   //02
            //Future_Maplist.Add(MapPictureHelper.Future_草地1);   //03
            //Future_Maplist.Add(MapPictureHelper.Future_树CD); //04
            //Future_Maplist.Add(MapPictureHelper.Future_空地);   //05
            //Future_Maplist.Add(MapPictureHelper.Future_水面28); //06

            Future_Maplist.Add(MapPictureHelper.Future_00_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_01_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_02_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_03_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_04_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_05_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_06_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_07_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_08_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_09_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_10_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_11_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_12_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_13_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_14_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_15_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_16_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_17_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_18_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_19_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_20_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_21_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_22_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_23_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_24_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_25_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_26_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_27_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_28_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_29_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_30_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_31_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_32_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_33_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_34_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_35_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_36_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_37_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_38_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_39_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_40_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_41_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_42_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_43_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_44_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_45_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_46_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_47_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_48_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_49_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_50_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_51_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_52_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_53_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_54_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_55_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_56_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_57_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_58_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_59_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_60_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_61_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_62_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_63_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_64_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_65_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_66_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_67_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_68_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_69_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_70_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_71_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_72_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_73_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_74_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_75_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_76_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_77_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_78_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_79_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_80_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_81_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_82_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_83_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_84_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_85_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_86_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_87_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_88_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_89_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_90_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_91_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_92_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_93_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_94_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_95_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_96_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_97_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_98_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_99_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_100_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_101_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_102_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_103_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_104_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_105_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_106_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_107_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_108_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_109_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_110_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_111_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_112_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_113_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_114_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_115_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_116_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_117_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_118_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_119_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_120_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_121_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_122_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_123_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_124_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_125_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_126_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_127_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_128_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_129_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_130_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_131_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_132_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_133_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_134_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_135_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_136_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_137_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_138_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_139_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_140_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_141_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_142_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_143_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_144_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_145_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_146_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_147_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_148_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_149_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_150_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_151_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_152_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_153_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_154_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_155_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_156_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_157_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_158_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_159_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_160_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_161_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_162_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_163_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_164_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_165_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_166_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_167_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_168_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_169_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_170_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_171_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_172_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_173_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_174_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_175_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_176_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_177_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_178_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_179_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_180_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_181_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_182_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_183_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_184_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_185_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_186_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_187_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_188_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_189_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_190_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_191_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_192_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_193_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_194_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_195_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_196_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_197_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_198_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_199_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_200_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_201_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_202_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_203_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_204_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_205_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_206_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_207_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_208_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_209_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_210_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_211_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_212_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_213_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_214_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_215_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_216_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_217_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_218_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_219_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_220_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_221_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_222_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_223_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_224_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_225_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_226_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_227_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_228_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_229_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_230_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_231_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_232_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_233_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_234_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_235_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_236_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_237_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_238_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_239_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_240_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_241_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_242_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_243_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_244_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_245_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_246_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_247_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_248_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_249_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_250_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_251_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_252_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_253_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_254_);  //00
            Future_Maplist.Add(MapPictureHelper.Future_255_);  //00


            #endregion
            #region 太空主题地图图片

            //Aether_Maplist.Add(MapPictureHelper.Aether_草地3);  //00
            //Aether_Maplist.Add(MapPictureHelper.Aether_墙A2);   //01
            //Aether_Maplist.Add(MapPictureHelper.Aether_墙A4);   //02
            //Aether_Maplist.Add(MapPictureHelper.Aether_石头C5);   //03
            //Aether_Maplist.Add(MapPictureHelper.Aether_水面25); //04
            //Aether_Maplist.Add(MapPictureHelper.Aether_空地);   //05
            //Aether_Maplist.Add(MapPictureHelper.Aether_死地); //06

            Aether_Maplist.Add(MapPictureHelper.Aether_00_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_01_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_02_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_03_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_04_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_05_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_06_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_07_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_08_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_09_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_10_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_11_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_12_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_13_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_14_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_15_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_16_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_17_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_18_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_19_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_20_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_21_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_22_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_23_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_24_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_25_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_26_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_27_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_28_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_29_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_30_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_31_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_32_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_33_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_34_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_35_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_36_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_37_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_38_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_39_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_40_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_41_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_42_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_43_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_44_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_45_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_46_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_47_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_48_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_49_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_50_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_51_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_52_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_53_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_54_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_55_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_56_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_57_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_58_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_59_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_60_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_61_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_62_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_63_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_64_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_65_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_66_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_67_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_68_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_69_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_70_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_71_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_72_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_73_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_74_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_75_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_76_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_77_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_78_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_79_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_80_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_81_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_82_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_83_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_84_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_85_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_86_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_87_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_88_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_89_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_90_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_91_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_92_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_93_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_94_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_95_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_96_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_97_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_98_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_99_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_100_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_101_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_102_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_103_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_104_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_105_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_106_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_107_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_108_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_109_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_110_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_111_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_112_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_113_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_114_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_115_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_116_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_117_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_118_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_119_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_120_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_121_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_122_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_123_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_124_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_125_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_126_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_127_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_128_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_129_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_130_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_131_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_132_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_133_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_134_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_135_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_136_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_137_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_138_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_139_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_140_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_141_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_142_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_143_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_144_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_145_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_146_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_147_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_148_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_149_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_150_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_151_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_152_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_153_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_154_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_155_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_156_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_157_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_158_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_159_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_160_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_161_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_162_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_163_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_164_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_165_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_166_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_167_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_168_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_169_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_170_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_171_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_172_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_173_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_174_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_175_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_176_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_177_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_178_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_179_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_180_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_181_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_182_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_183_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_184_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_185_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_186_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_187_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_188_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_189_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_190_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_191_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_192_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_193_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_194_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_195_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_196_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_197_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_198_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_199_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_200_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_201_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_202_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_203_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_204_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_205_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_206_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_207_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_208_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_209_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_210_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_211_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_212_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_213_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_214_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_215_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_216_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_217_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_218_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_219_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_220_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_221_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_222_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_223_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_224_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_225_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_226_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_227_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_228_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_229_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_230_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_231_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_232_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_233_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_234_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_235_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_236_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_237_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_238_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_239_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_240_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_241_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_242_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_243_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_244_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_245_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_246_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_247_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_248_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_249_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_250_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_251_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_252_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_253_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_254_); //00
            Aether_Maplist.Add(MapPictureHelper.Aether_255_); //00


            #endregion
            #region 异次元主题地图图片

            //EDS_Maplist.Add(MapPictureHelper.EDS_树15);  //00
            //EDS_Maplist.Add(MapPictureHelper.EDS_石头DD);   //01
            //EDS_Maplist.Add(MapPictureHelper.EDS_石头CC);   //02
            //EDS_Maplist.Add(MapPictureHelper.EDS_草地4);   //03
            //EDS_Maplist.Add(MapPictureHelper.EDS_重旱地); //04
            //EDS_Maplist.Add(MapPictureHelper.EDS_空地);   //05
            //EDS_Maplist.Add(MapPictureHelper.EDS_水面25); //06

            EDS_Maplist.Add(MapPictureHelper.EDS_00_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_01_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_02_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_03_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_04_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_05_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_06_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_07_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_08_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_09_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_10_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_11_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_12_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_13_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_14_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_15_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_16_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_17_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_18_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_19_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_20_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_21_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_22_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_23_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_24_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_25_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_26_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_27_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_28_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_29_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_30_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_31_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_32_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_33_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_34_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_35_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_36_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_37_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_38_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_39_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_40_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_41_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_42_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_43_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_44_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_45_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_46_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_47_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_48_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_49_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_50_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_51_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_52_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_53_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_54_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_55_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_56_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_57_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_58_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_59_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_60_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_61_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_62_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_63_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_64_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_65_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_66_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_67_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_68_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_69_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_70_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_71_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_72_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_73_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_74_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_75_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_76_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_77_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_78_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_79_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_80_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_81_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_82_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_83_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_84_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_85_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_86_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_87_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_88_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_89_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_90_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_91_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_92_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_93_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_94_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_95_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_96_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_97_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_98_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_99_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_100_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_101_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_102_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_103_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_104_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_105_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_106_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_107_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_108_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_109_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_110_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_111_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_112_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_113_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_114_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_115_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_116_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_117_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_118_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_119_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_120_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_121_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_122_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_123_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_124_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_125_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_126_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_127_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_128_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_129_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_130_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_131_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_132_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_133_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_134_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_135_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_136_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_137_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_138_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_139_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_140_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_141_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_142_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_143_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_144_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_145_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_146_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_147_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_148_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_149_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_150_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_151_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_152_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_153_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_154_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_155_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_156_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_157_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_158_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_159_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_160_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_161_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_162_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_163_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_164_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_165_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_166_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_167_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_168_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_169_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_170_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_171_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_172_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_173_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_174_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_175_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_176_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_177_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_178_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_179_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_180_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_181_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_182_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_183_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_184_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_185_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_186_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_187_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_188_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_189_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_190_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_191_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_192_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_193_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_194_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_195_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_196_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_197_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_198_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_199_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_200_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_201_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_202_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_203_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_204_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_205_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_206_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_207_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_208_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_209_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_210_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_211_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_212_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_213_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_214_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_215_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_216_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_217_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_218_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_219_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_220_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_221_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_222_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_223_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_224_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_225_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_226_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_227_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_228_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_229_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_230_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_231_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_232_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_233_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_234_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_235_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_236_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_237_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_238_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_239_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_240_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_241_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_242_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_243_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_244_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_245_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_246_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_247_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_248_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_249_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_250_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_251_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_252_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_253_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_254_); //00
            EDS_Maplist.Add(MapPictureHelper.EDS_255_); //00


            #endregion
            #region 博士基地主题地图图片

            //Boss_Maplist.Add(MapPictureHelper.Boss_树12);  //00
            //Boss_Maplist.Add(MapPictureHelper.Boss_岩浆75);   //01
            //Boss_Maplist.Add(MapPictureHelper.Boss_岩浆70);   //02
            //Boss_Maplist.Add(MapPictureHelper.Boss_岩浆71);   //03
            //Boss_Maplist.Add(MapPictureHelper.Boss_岩浆72); //04
            //Boss_Maplist.Add(MapPictureHelper.Boss_空地);   //05
            //Boss_Maplist.Add(MapPictureHelper.Boss_死地); //06

            Boss_Maplist.Add(MapPictureHelper.Boss_00_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_01_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_02_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_03_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_04_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_05_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_06_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_07_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_08_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_09_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_10_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_11_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_12_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_13_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_14_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_15_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_16_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_17_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_18_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_19_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_20_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_21_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_22_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_23_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_24_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_25_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_26_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_27_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_28_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_29_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_30_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_31_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_32_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_33_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_34_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_35_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_36_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_37_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_38_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_39_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_40_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_41_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_42_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_43_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_44_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_45_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_46_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_47_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_48_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_49_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_50_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_51_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_52_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_53_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_54_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_55_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_56_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_57_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_58_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_59_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_60_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_61_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_62_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_63_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_64_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_65_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_66_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_67_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_68_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_69_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_70_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_71_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_72_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_73_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_74_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_75_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_76_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_77_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_78_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_79_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_80_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_81_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_82_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_83_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_84_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_85_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_86_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_87_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_88_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_89_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_90_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_91_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_92_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_93_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_94_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_95_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_96_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_97_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_98_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_99_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_100_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_101_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_102_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_103_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_104_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_105_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_106_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_107_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_108_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_109_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_110_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_111_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_112_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_113_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_114_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_115_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_116_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_117_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_118_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_119_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_120_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_121_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_122_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_123_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_124_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_125_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_126_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_127_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_128_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_129_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_130_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_131_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_132_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_133_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_134_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_135_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_136_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_137_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_138_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_139_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_140_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_141_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_142_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_143_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_144_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_145_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_146_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_147_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_148_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_149_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_150_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_151_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_152_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_153_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_154_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_155_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_156_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_157_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_158_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_159_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_160_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_161_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_162_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_163_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_164_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_165_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_166_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_167_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_168_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_169_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_170_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_171_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_172_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_173_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_174_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_175_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_176_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_177_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_178_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_179_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_180_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_181_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_182_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_183_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_184_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_185_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_186_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_187_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_188_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_189_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_190_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_191_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_192_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_193_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_194_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_195_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_196_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_197_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_198_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_199_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_200_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_201_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_202_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_203_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_204_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_205_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_206_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_207_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_208_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_209_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_210_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_211_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_212_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_213_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_214_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_215_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_216_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_217_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_218_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_219_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_220_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_221_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_222_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_223_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_224_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_225_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_226_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_227_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_228_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_229_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_230_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_231_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_232_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_233_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_234_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_235_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_236_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_237_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_238_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_239_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_240_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_241_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_242_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_243_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_244_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_245_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_246_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_247_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_248_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_249_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_250_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_251_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_252_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_253_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_254_);  //00
            Boss_Maplist.Add(MapPictureHelper.Boss_255_);  //00


            #endregion
            #region 主题队列存入队列

            ThemeBar.Add(YiJiMaplist);    //遗迹主题
            ThemeBar.Add(Coast_Maplist);  //海岸主题
            ThemeBar.Add(Hilly_Maplist);  //山地主题
            ThemeBar.Add(Tower_Maplist);  //城堡主题
            ThemeBar.Add(City_Maplist);   //城市主题
            ThemeBar.Add(Future_Maplist); //未来城主题
            ThemeBar.Add(Aether_Maplist); //太空主题
            ThemeBar.Add(EDS_Maplist);    //异次元主题
            ThemeBar.Add(Boss_Maplist);   //博士基地主题

            #endregion

            #endregion
            Image img = ThemeBar[ThemeNum][(int)MapIdDefine.空地];
            for (int i = 0; i <= PictureTotal - 1; ++i)
                MapIMG_Block.Add(img);

            MapCathe = img;

        }

        private const int mapPanelSizeX = 780;
        private const int mapPanelSizeY = 592;
        private const int pointX = 21;
        private const int pointy = 84;

        public const int PictureTotal = 1600;
        public const int MapImgSuitSize = 14;
        public const int RowNum = 40;
        public const int LineNum = 40;
        public const int GridLenth = 9;
        public const int AutoAjgStep = 80;
        public const string GtCodeMapName = "\\MapPictureHelperCheat.cht";
        public const string RegisterLicense = "DB2MapPictureHelper";

        public int PictureSize = 40;
        public int ThemeNum = 0;
        public int PreThemeNum = 0;
        public int SelectedIndex = -1;
        public int ImLineXOld, ImLineYOld, ImLineXNow, ImLineYNow;
        public int ImagBlockCusx1, ImagBlockCusy1, ImagBlockCusx2, ImagBlockCusy2;
        public bool ALLClrUndoFlag = false;
        public bool MapDragEN = false;
        public bool Magnify = false;
        public bool Imaginary = false;
        public bool ImagBlockCus = false;
        public bool IsHoverShow = false;
        public bool ControlWheel = false;

        public int MapLeft = 0;
        public int MapTop = 0;
        public int MapClickXnum = 0;
        public int MapClickYnum = 0;
        public int MapCusorWidth = 2;
        public int IsRegister = 1;   
        public int IsFixedPath = 1;
        public Color MapCusorColor = Color.Turquoise;
        public Color MapImColor = Color.Turquoise;

        public Point Location = new Point(pointX,pointy);

        public Size Size = new Size(mapPanelSizeX,mapPanelSizeY);

        public Point NowMouseDownLocation = new Point();
        public Point NowMouseMoveLocation = new Point();

        public List<Image> MapIMG_Block = new List<Image>();
        public Image[] MapSmartE = new Image[PictureTotal];

        public List<Image> YiJiMaplist = new List<Image>();
        public List<Image> Coast_Maplist = new List<Image>();
        public List<Image> Hilly_Maplist = new List<Image>();
        public List<Image> Tower_Maplist = new List<Image>();
        public List<Image> City_Maplist = new List<Image>();
        public List<Image> Future_Maplist = new List<Image>();
        public List<Image> Aether_Maplist = new List<Image>();
        public List<Image> EDS_Maplist = new List<Image>();
        public List<Image> Boss_Maplist = new List<Image>();

        public List<List<Image>> ThemeBar = new List<List<Image>>();

        public Stack<Image> MapImgStack = new Stack<Image>();
        public Stack<int> MapSleStack = new Stack<int>();
        public List<Image> MapAllClrImgList = new List<Image>();
        public List<int> MapAllClrSleList = new List<int>();
        public Image MapCathe = null;
        public Image MapNull = null;

        public delegate void PanelRefresh();
        public PanelRefresh OnPanelRefresh;

        public int MapTotalSizeX
        {
            get
            {
                return PictureSize * LineNum + MapLeft;
            }
                
        }
        public int MapTotalSizeY
        {
            get
            {
                return PictureSize * RowNum + MapTop;
            }
        } 

        public Image NowSelectedImg
        {
            get
            {
                if (SelectedIndex == -1) return null;
                return MapIMG_Block[SelectedIndex];
            }
            set
            {
                if(SelectedIndex != -1)
                    MapIMG_Block[SelectedIndex] = value;
            }

        }

        public void DataInit()
        {
            ImLineXNow = 0;
            ImLineYNow = 0;
            ImLineXOld = 0;
            ImLineYOld = 0;
            ImagBlockCus = false;
        }

        #region 方法

        public void UpMapSeIndex()
        {
            if (SelectedIndex < 0)
                return;
            SelectedIndex -= RowNum;
            if (SelectedIndex < 0)
                SelectedIndex += RowNum;
        }

        public void DownMapSeIndex()
        {
            if (SelectedIndex < 0)
                return;
            SelectedIndex += RowNum;
            if (SelectedIndex > PictureTotal - 1)
                SelectedIndex -= RowNum;
        }

        public void LeftMapSeIndex()
        {
            if (SelectedIndex < 0)
                return;
            --SelectedIndex;
            if (SelectedIndex < 0)
                SelectedIndex = 0;
        }

        public void RightMapSeIndex()
        {
            if (SelectedIndex < 0)
                return;
            ++SelectedIndex;
            if (SelectedIndex > PictureTotal - 1)
                SelectedIndex = PictureTotal - 1;
        }

        public void NorthWestMapSeIndex()
        {
            LeftMapSeIndex();
            UpMapSeIndex();
        }

        private void NorthEastMap光标()
        {
            RightMapSeIndex();
            UpMapSeIndex();
        }

        private void SorthWestMap光标()
        {
            LeftMapSeIndex();
            DownMapSeIndex();
        }

        private void SorthEastMap光标()
        {
            RightMapSeIndex();
            DownMapSeIndex();
        }

        private void NoneMove光标()
        {
            return;
        }

        public int Bitmap2Int(PictureBox pic)
        {
            return ThemeBar[ThemeNum].IndexOf(pic.Image);
        }

        public Image Int2MapImage(int read)
        {
            return ThemeBar[ThemeNum][read];
        }

        public int MapImage2Int(Image img)
        {
            return ThemeBar[ThemeNum].IndexOf(img);
        }

        public Image ImgAutoImg(Image img,int themeNum)
        {
            return Int2MapImage(ThemeBar[themeNum].IndexOf(img));
        }

        public string Bitmapt2HexStr(Image pic)
        {
            int ing = ThemeBar[ThemeNum].IndexOf(pic);
            if (ing == (int)MapIdDefine.我方基地) ing = (int)MapIdDefine.空地;
            if (ing == (int)MapIdDefine.敌方基地) ing = (int)MapIdDefine.空地;
            if (ing == (int)MapIdDefine.我方单位) ing = (int)MapIdDefine.草地Start + 2;
            if (ing == (int)MapIdDefine.敌方单位) ing = (int)MapIdDefine.草地Start + 2;
            return ing > 9 ? (ing.ToString("X2")) : ("0" + ing.ToString());
        }

        public Point[] GetRectanglePointsFromDiagonalPoints(Point old, Point now)
        {
            int ImagOldTop = MapTop;
            int ImagOldLeft = MapLeft;
            if ((now.Y - old.Y) > 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapDownRight;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) < 0)
            {
                // NowMap = AroundMap.MapUpLeft;

                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else if ((now.Y - old.Y) > 0 && (now.X - old.X) < 0)
            {
                // NowMap = AroundMap.MapDownLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) > 0)
            {
                // NowMap = AroundMap.MapUpRight;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else
            {

            }
            ImagBlockCusx1 = old.X;
            ImagBlockCusy1 = old.Y;
            ImagBlockCusx2 = now.X;
            ImagBlockCusy2 = now.Y;

            return new Point[]
            {
                new Point(ImagBlockCusx1,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy1),
            };
        }

        public Point[] GetExpandRectanglePointsFromDiagonalPoints(Point old, Point now)
        {

            int ImagOldTop = MapTop;
            int ImagOldLeft = MapLeft;
            if ((now.Y - old.Y) > 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapDownRight;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapUpLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else if ((now.Y - old.Y) > 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapDownLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapUpRight;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else
            {

            }
            ImagBlockCusx1 = old.X - (old.X - ImagOldLeft) % PictureSize + PictureSize - PictureSize;
            ImagBlockCusy1 = old.Y - (old.Y - ImagOldTop) % PictureSize + PictureSize - PictureSize;
            ImagBlockCusx2 = now.X - (now.X - ImagOldLeft) % PictureSize + PictureSize;
            ImagBlockCusy2 = now.Y - (now.Y - ImagOldTop) % PictureSize + PictureSize;

            return new Point[]
            {
                new Point(ImagBlockCusx1,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy1),
                new Point(ImagBlockCusx2,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy2),
                new Point(ImagBlockCusx1,ImagBlockCusy1),
            };
        }

        public Rectangle GetExpandRectanglePointsFromSinglePoint(Point now)
        {
            int lenth = PictureSize;

            int MapTotalSizeX = PictureSize * RowNum + MapLeft;
            int MapTotalSizeY = PictureSize * RowNum + MapTop;

            int mapClickXnum = now.X - (now.X - MapLeft) % PictureSize;
            int mapClickYnum = now.Y - (now.Y - MapTop) % PictureSize;

            int selectedIndex = (mapClickXnum - MapLeft) / PictureSize +
                (mapClickYnum - MapTop) / PictureSize * RowNum;

            int Left = MapLeft + selectedIndex % (RowNum) * lenth;
            int Top = MapTop + selectedIndex / (LineNum) * lenth - PictureSize;

            return new Rectangle(Left, Top, lenth, lenth);

        }

        public Rectangle GetExpandRectangleFromDiagonalPoints(Point old, Point now)
        {

            int ImagOldTop = MapTop;
            int ImagOldLeft = MapLeft;
            if ((now.Y - old.Y) > 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapDownRight;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapUpLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else if ((now.Y - old.Y) > 0 && (now.X - old.X) < 0)
            {
                //NowMap = AroundMap.MapDownLeft;
                old.X ^= now.X; now.X ^= old.X; old.X ^= now.X;
            }
            else if ((now.Y - old.Y) < 0 && (now.X - old.X) > 0)
            {
                //NowMap = AroundMap.MapUpRight;
                old.Y ^= now.Y; now.Y ^= old.Y; old.Y ^= now.Y;
            }
            else
            {

            }
            ImagBlockCusx1 = old.X - (old.X - ImagOldLeft) % PictureSize + PictureSize - PictureSize;
            ImagBlockCusy1 = old.Y - (old.Y - ImagOldTop) % PictureSize + PictureSize - PictureSize;
            ImagBlockCusx2 = now.X - (now.X - ImagOldLeft) % PictureSize + PictureSize;
            ImagBlockCusy2 = now.Y - (now.Y - ImagOldTop) % PictureSize + PictureSize;

            int Width = Math.Abs(ImagBlockCusx2 - ImagBlockCusx1);
            int Height = Math.Abs(ImagBlockCusy2 - ImagBlockCusy1);

            return new Rectangle(ImagBlockCusx1, ImagBlockCusy1, Width, Height);
        }

        public bool RectangleContainsPoint(Rectangle rec, Point p)
        {
            if (rec.Left < p.X && p.X < rec.Left + rec.Width && rec.Top < p.Y && p.Y < rec.Top + rec.Height)
                return true;
            else
                return false;
        }

        #endregion

    }

    public enum MapThemeIdEnum 
    {
        遗迹主题 = 0,
        海岸主题 = 1,
        山地主题 = 2,
        城堡主题 = 3,
        城市主题 = 4,
        未来城主题 = 5,
        太空主题 = 6,
        异次元主题 = 7,
        博士基地主题 = 8,

    }

    public enum MapIdDefine 
    {
        我方基地 = 0,
        藤蔓Start = 1,
        草地Start = 5,
        空地 = 9,
        湿地Start = 10,
        空地墙 = 13,
        轻旱地 = 14,
        重旱地 = 19,
        花地Start = 15,
        水面Start = 25,
        水面End = 71,
        岩浆Start = 73,
        岩浆End = 119,
        山地顶Start = 121,
        山地顶End = 167,
        山地底Start = 169,
        山地底End = 190,
        沙地Start = 191,
        雪地Start = 192,
        冰面Start = 209,
        冰面End = 255,
        敌方基地 = 13,
        我方单位 = 24,
        敌方单位 = 72,
        水面Count = 水面End - 水面Start + 1,
        岩浆Count = 岩浆End - 岩浆Start + 1,

    }

}
