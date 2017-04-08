using CCWin.SkinControl;
using System.Drawing;

namespace DB2地图编辑器
{
    class MapListBoxInitClass
    {
        public static int ItemDownId = -1;

        public const int ComPlaceId = 19;

        int MapAddNumber = 0;

        //int MapStartNumber = 0;

        int ADDacc = 0;

        string[] MapListBoxItemStr = 
        {
            "空地" ,
            "草地" ,
            "花地" ,
            "藤蔓" ,
            "湿地",
            "旱地" ,
            "沙地" ,
            "雪地" ,
            "死地" ,
            "树" ,
            "石头" ,
            "火焰" ,
            "坑" ,
            "水面" ,
            "岩浆" ,
            "山地顶" ,
            "山地底",
            "冰面",
            "基地与龙种标识" ,
            "常用放置" ,
        };

        public MapListBoxInitClass() { }

        public void RenewComposePlace(ChatListBox MapListBox,MapPanelEditor mapEditor)
        {
            #region 常用放置
            ADDacc = ComPlaceId;

            MapListBox.Items[ADDacc].SubItems.Clear();
            MapAddNumber = ComposePlace.List.Count;
            MapListBoxItemAdd(ADDacc, MapAddNumber, MapListBox);

            foreach (ComposePlace com in ComposePlace.List)
            {
                com.RenewShowImgAndItemImage();
            }

            for (int i = 0; i < MapAddNumber; ++i)
            {
                MapListBoxComposePlaceItemMessegeRenew(ComposePlace.List[i].ShowImg, ADDacc, i, i, "组合",
                    ComposePlace.List[i].Size, MapListBox);
            }

            ++ADDacc;

            #endregion
        }

        private void InitMapListJudgeTheme(ChatListBox MapListBox,MapPanelEditor mapEditor)
        {

            #region 共有的
            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.基地与龙种标识, 0, 1, "我方基地", MapListBox, mapEditor);//0
            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.基地与龙种标识, 13, 1, "敌方基地", MapListBox, mapEditor);//0
            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.基地与龙种标识, 24, 1, "我方单位", MapListBox, mapEditor);//0
            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.基地与龙种标识, 72, 1, "敌方单位", MapListBox, mapEditor);//0

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.藤蔓, 1, 3, "藤蔓", MapListBox, mapEditor);//1 2 3

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.树, 4, 1, "树地", MapListBox, mapEditor);//4

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.草地, 5, 4, "草地", MapListBox, mapEditor);//5 6 7 8

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.空地, 9, 1, "空地", MapListBox,mapEditor);//9

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.湿地, 10, 2, "湿地", MapListBox, mapEditor);//10 11

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.坑, 12, 1, "坑", MapListBox, mapEditor);//12
            //13暂时不可用
            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.旱地, 14, 1, "旱地", MapListBox, mapEditor);//14
            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.旱地, 19, 1, "旱地", MapListBox, mapEditor);//19

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.花地, 15, 3, "花地", MapListBox, mapEditor);//15 16 17

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.死地, 18, 1, "死地", MapListBox, mapEditor);//18

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.火焰, 20, 1, "火焰", MapListBox, mapEditor);//20

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.石头, 21, 2, "石头", MapListBox, mapEditor);//21 22

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.树, 23, 1, "树", MapListBox, mapEditor);//23

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.水面, (int)MapIdDefine.水面Start,
                (int)MapIdDefine.水面Count, "水面", MapListBox, mapEditor);//shuiming

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.岩浆, (int)MapIdDefine.岩浆Start,
               (int)MapIdDefine.岩浆Count, "岩浆", MapListBox, mapEditor);//yanjaing

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.沙地, 191, 1, "沙地", MapListBox, mapEditor);//191

            MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.雪地, 192, 1, "雪地", MapListBox, mapEditor);//192

            #endregion

            #region 单独的

            switch (mapEditor.ThemeNum)
            {
                case (int)MapThemeIdEnum.遗迹主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    #endregion
                    #region 树


                    #endregion
                    #region 石头


                    #endregion
                    #region 火焰

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.山地顶,
                        121, 167 - 121 + 1, "山地顶", MapListBox, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.山地顶,
                        186, 190 - 186 + 1, "山地顶", MapListBox, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.山地顶,
                        194, 0 - 0 + 1, "山地顶", MapListBox, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.山地顶,
                        197, 0 - 0 + 1, "山地顶", MapListBox, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                        201, 208, "山地顶", mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange((int)MapListBoxItemId.山地底,
                        169, 185 - 169 + 1, "山地底", MapListBox, mapEditor);

                    #endregion
                    #region 冰面

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.冰面,
                       (int)MapIdDefine.冰面Start, (int)MapIdDefine.冰面End, "冰面", mapEditor);

                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.海岸主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                        194, 197, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                       198, 199, mapEditor);

                    #endregion
                    #region 火焰

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                        121, 167, "山地顶", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                       201, 206, mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                        169, 189, "山地底", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                       207, 208, mapEditor);

                    #endregion
                    #region 冰面

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.冰面,
                       209, 255, mapEditor);

                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.山地主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                     194, 194, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                        196, 197, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                      201, 202, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                198, 199, mapEditor);

                    #endregion
                    #region 火焰

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.火焰,
                       190, 190, mapEditor);

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                        121, 167, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                     203, 214, mapEditor);


                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                     219, 230, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                      235, 251, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    234, 255, mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                        169, 189, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                     193, 193, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                     195, 195, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                     215, 218, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                    231, 234, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                    252, 253, mapEditor);

                    #endregion
                    #region 冰面


                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.城堡主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                     195, 196, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                    193, 193, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                     198, 200, mapEditor);

                    #endregion
                    #region 火焰

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                     121, 167, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                     186, 190, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                      194, 194, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                      197, 197, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                      201, 208, mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                     169, 185, mapEditor);

                    #endregion
                    #region 冰面

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.冰面,
                        209, 255, mapEditor);

                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.城市主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    182, 182, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    212, 220, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                     201, 211, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    221, 236, mapEditor);

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                    194, 197, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                        193, 193, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                        198, 200, mapEditor);

                    #endregion
                    #region 火焰

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.岩浆,
                    241, 244, mapEditor);

                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                        121, 167, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                        178, 181, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    185, 185, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    237, 240, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    245, 255, mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                        169, 177, mapEditor);

                    #endregion
                    #region 冰面


                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.未来城主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                    194, 195, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                   193, 193, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                        196, 200, mapEditor);

                    #endregion
                    #region 火焰

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                     121, 167, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                    201, 223, mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                                       169, 190, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                                  224, 255, mapEditor);

                    #endregion
                    #region 冰面


                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.太空主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.死地,
                       185, 186, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.死地,
                     189, 189, "宇宙", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.死地,
                       201, 248, "宇宙", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.死地,
                    255, 255, "宇宙", mapEditor);

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                       188, 188, mapEditor);


                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                       194, 197, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                       187, 187, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                     193, 193, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                       198, 200, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                    249, 254, mapEditor);

                    #endregion
                    #region 火焰

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                      121, 167, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                      177, 184, mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                                   169, 176, mapEditor);

                    #endregion
                    #region 冰面


                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.异次元主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.死地,
                       185, 185, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.死地,
                     188, 189, mapEditor);

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                        194, 197, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                      186, 187, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                       193, 193, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                   198, 208, mapEditor);

                    #endregion
                    #region 火焰

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.火焰,
                       190, 190, mapEditor);

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                        121, 167, "山地顶", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                       177, 184, mapEditor);

                    #endregion
                    #region 山地底

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                        169, 176, "山地底", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                       207, 208, mapEditor);

                    #endregion
                    #region 冰面

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.冰面,
                       209, 255, mapEditor);

                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
                case (int)MapThemeIdEnum.博士基地主题:
                    #region 空地

                    #endregion
                    #region 草地

                    #endregion
                    #region 花地

                    #endregion
                    #region 藤蔓


                    #endregion
                    #region 湿地


                    #endregion
                    #region 旱地

                    #endregion
                    #region 沙地

                    #endregion
                    #region 雪地

                    #endregion
                    #region 死地

                    #endregion
                    #region 树

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.树,
                       195, 196, mapEditor);

                    #endregion
                    #region 石头

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                    193, 194, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                     197, 200, mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.石头,
                    219, 229, mapEditor);

                    #endregion
                    #region 火焰

                    #endregion
                    #region 坑


                    #endregion
                    #region 水面

                    #endregion
                    #region 岩浆


                    #endregion
                    #region 山地顶

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                   121, 168, "山地顶", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                    201, 218, "山地顶", mapEditor);

                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地顶,
                   230, 242, "山地顶", mapEditor);

                    #endregion
                    #region 山地底


                    MapListBoxItemBaseAddAndRenewRange(MapListBox, (int)MapListBoxItemId.山地底,
                        169, 176, "山地底", mapEditor);

                    #endregion
                    #region 冰面


                    #endregion
                    #region 基地与龙种标识

                    #endregion
                    #region 常用放置

                    #endregion
                    break;
            }
            #endregion

        }

        public MapListBoxInitClass Init(ChatListBox MapListBox,MapPanelEditor mapEditor)
        {
            MapListBox.Items.Clear();
            foreach(string str in this.MapListBoxItemStr)
            {
                MapListBox.Items.Add(new ChatListItem(str));
            }           
            foreach (ChatListItem item in MapListBox.Items)
            {
                item.SubItems.Clear();
            }
            InitMapListJudgeTheme(MapListBox,mapEditor);
            RenewComposePlace(MapListBox,mapEditor);
            return this;
        }

        void MapListBoxItemMessegeRenew(int addacc, int order, int id, string displayname, ChatListBox MapListBox,MapPanelEditor mapEditor)
        {
            MapListBox.Items[addacc].SubItems[order].HeadImage = mapEditor.ThemeBar[mapEditor.ThemeNum][id];
            MapListBox.Items[addacc].SubItems[order].ID = (uint)id;
            MapListBox.Items[addacc].SubItems[order].NicName =
               "Hex:" + MapListBox.Items[addacc].SubItems[order].ID.ToString("X2");
            MapListBox.Items[addacc].SubItems[order].PersonalMsg = "十进制代码:" + id.ToString();
            MapListBox.Items[addacc].SubItems[order].DisplayName = displayname;
            //MapListBox.Items[addacc].SubItems[order].PersonalMsg = "";
        }

        void MapListBoxItemAdd(int addacc, int num, ChatListBox MapListBox)
        {
            for (int i = 0; i < num; ++i)
                MapListBox.Items[addacc].SubItems.Add(new CCWin.SkinControl.ChatListSubItem());
        }

        void MapListBoxItemMessegeRenewRange(int addacc, int startid, string displayname, ChatListBox MapListBox,MapPanelEditor mapEditor)
        {
            int startless = startid - 1;
            foreach (CCWin.SkinControl.ChatListSubItem item in MapListBox.Items[addacc].SubItems)
            {
                item.HeadImage = mapEditor.ThemeBar[mapEditor.ThemeNum][startid];
                item.ID = (uint)startid;
                item.NicName = "Hex:" + item.ID.ToString("X2");
                item.PersonalMsg = "十进制代码:" + item.ID.ToString();
                item.DisplayName = displayname + (startid - startless).ToString();
                //item.PersonalMsg = "";
                startid++;
            }
        }

        void MapListBoxComposePlaceItemMessegeRenew(Image img, int addacc, int order, int id, string displayname, Size size, ChatListBox MapListBox)
        {
            MapListBox.Items[addacc].SubItems[order].HeadImage = img;
            MapListBox.Items[addacc].SubItems[order].ID = (uint)(id + 256);
            MapListBox.Items[addacc].SubItems[order].NicName =
               "组合放置" + (id + 1).ToString();
            MapListBox.Items[addacc].SubItems[order].PersonalMsg = "组合元素个数:" + size.Width.ToString() + "×" + size.Height.ToString();
            MapListBox.Items[addacc].SubItems[order].DisplayName = displayname;
            //MapListBox.Items[addacc].SubItems[order].PersonalMsg = "";
        }

        void MapListBoxItemBaseAddAndRenewRange(int addacc, int startid, int num, string displayname, ChatListBox MapListBox,MapPanelEditor mapEditor)
        {
            int BaseCount = MapListBox.Items[addacc].SubItems.Count;
            MapListBoxItemAdd(addacc, num, MapListBox);
            for (int i = BaseCount; i < BaseCount + num; ++i)
            {
                MapListBox.Items[addacc].SubItems[i].HeadImage = mapEditor.ThemeBar[mapEditor.ThemeNum][startid];
                MapListBox.Items[addacc].SubItems[i].ID = (uint)startid;
                MapListBox.Items[addacc].SubItems[i].NicName =
                   "Hex:" + MapListBox.Items[addacc].SubItems[i].ID.ToString("X2");
                MapListBox.Items[addacc].SubItems[i].PersonalMsg = "十进制代码:" + startid.ToString();
                MapListBox.Items[addacc].SubItems[i].DisplayName = displayname + (i + 1);
                startid++;
            }
        }

        void MapListBoxItemBaseAddAndRenewRange(ChatListBox MapListBox, int addacc, int startid, int endid, string displayname,MapPanelEditor mapEditor)
        {
            int BaseCount = MapListBox.Items[addacc].SubItems.Count;
            int num = endid - startid + 1;
            MapListBoxItemAdd(addacc, num, MapListBox);
            for (int i = BaseCount; i < BaseCount + num; ++i)
            {
                MapListBox.Items[addacc].SubItems[i].HeadImage = mapEditor.ThemeBar[mapEditor.ThemeNum][startid];
                MapListBox.Items[addacc].SubItems[i].ID = (uint)startid;
                MapListBox.Items[addacc].SubItems[i].NicName =
                   "Hex:" + MapListBox.Items[addacc].SubItems[i].ID.ToString("X2");
                MapListBox.Items[addacc].SubItems[i].PersonalMsg = "十进制代码:" + startid.ToString();
                MapListBox.Items[addacc].SubItems[i].DisplayName = displayname + (i + 1);
                startid++;
            }
        }

        void MapListBoxItemBaseAddAndRenewRange(ChatListBox MapListBox, int addacc, int startid, int endid,MapPanelEditor mapEditor)
        {
            int BaseCount = MapListBox.Items[addacc].SubItems.Count;
            int num = endid - startid + 1;
            MapListBoxItemAdd(addacc, num, MapListBox);
            for (int i = BaseCount; i < BaseCount + num; ++i)
            {
                MapListBox.Items[addacc].SubItems[i].HeadImage = mapEditor.ThemeBar[mapEditor.ThemeNum][startid];
                MapListBox.Items[addacc].SubItems[i].ID = (uint)startid;
                MapListBox.Items[addacc].SubItems[i].NicName =
                   "Hex:" + MapListBox.Items[addacc].SubItems[i].ID.ToString("X2");
                MapListBox.Items[addacc].SubItems[i].PersonalMsg = "十进制代码:" + startid.ToString();
                MapListBox.Items[addacc].SubItems[i].DisplayName = MapListBoxItemStr[addacc] + (i + 1);
                startid++;
            }
        }

    }

    enum MapListBoxItemId : int
    {
        空地 = 0,
        草地 = 1,
        花地 = 2,
        藤蔓 = 3,
        湿地 = 4,
        旱地 = 5,
        沙地 = 6,
        雪地 = 7,
        死地 = 8,
        树 = 9,
        石头 = 10,
        火焰 = 11,
        坑 = 12,
        水面 = 13,
        岩浆 = 14,
        山地顶 = 15,
        山地底 = 16,
        冰面 = 17,
        基地与龙种标识 = 18,
        常用放置 = 19,
    }
}

