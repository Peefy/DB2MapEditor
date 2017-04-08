using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DB2地图编辑器
{
    class FileMap
    {

        public struct FileOperator
        {
            public string MapSaveFilter 
            {
                get { return "地图保存文件（*.MapSave）|*.MapSave"; }
            }
            public string MapLoadFilter
            {
                get { return "地图保存文件（*.MapSave）|*.MapSave"; }
            }
        }

        public const string ConfigPath = "C:\\ProgramData\\MapEditorConfig";
        public const string ConfigSaveFileName = "\\config.cfg";
        public const string OptionsSaveFileName = "\\apopt.opt";

        public static bool LoadMapInfo(string path, MapPanelEditor mapEditor)
        {
            if (File.Exists(path))
            {
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Open);
                    BinaryReader r = new BinaryReader(fs);
                    OnceOperation.RedoAllMap(mapEditor);

                    for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                        mapEditor.MapIMG_Block[i] = mapEditor.Int2MapImage(r.ReadInt32());

                    OnceOperation.ClearResume();

                    SmartPaste.HoverPasteInit();

                    r.Close();
                    fs.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 载入配置文件
        /// </summary>
        public static bool LoadSaveAppInfo(MapPanelEditor mapEditor)
        {
            #region 读取配置数据
            if (File.Exists(ConfigPath + ConfigSaveFileName))
            {
               // try
                {
                    FileStream fs = new FileStream(ConfigPath + ConfigSaveFileName, FileMode.Open);
                    BinaryReader r = new BinaryReader(fs);
                    #region 读取的数据或字符串
                    mapEditor.ThemeNum = r.ReadInt32();
                    for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                        mapEditor.MapIMG_Block[i] = mapEditor.Int2MapImage(r.ReadInt32());
                    int CountTemp = r.ReadInt32();
                    ToolStripOperation.IndexList.Clear();
                    for (int i = 0; i <= CountTemp - 1; ++i)
                    {
                        ToolStripOperation.IndexList.Add(r.ReadInt32());
                    }

                    CountTemp = r.ReadInt32();
                    ComposePlace.List.Clear();
                    for (int i = 0; i <= CountTemp - 1; ++i)
                    {
                        ComposePlace add = new ComposePlace(false,mapEditor);
                        add.ReadFromFile(r, i.ToString());
                        ComposePlace.List.Add(add);
                    }

                    #endregion
                    r.Close();
                    fs.Close();
                }
               // catch (Exception ex)
              //  {
              //      throw (ex);
               // }

            }
            mapEditor.MapCathe = mapEditor.ThemeBar[mapEditor.ThemeNum][(int)MapIdDefine.空地];

            #endregion
            #region 读取软件设置
            if (File.Exists(ConfigPath + OptionsSaveFileName))
            {
                try
                {
                    FileStream fs = new FileStream(ConfigPath + OptionsSaveFileName, FileMode.Open);
                    BinaryReader r = new BinaryReader(fs);
                    #region 读取的数据或字符串

                    for (int i = 0; i < QuickPlaceKey.KeyValueToMapId.LongLength; i++)
                        QuickPlaceKey.KeyValueToMapId[i] = r.ReadInt32();

                    mapEditor.PictureSize = r.ReadInt32();
                    mapEditor.MapCusorWidth = r.ReadInt32();

                    #endregion
                    r.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
            #endregion
            return true;
        }

        /// <summary>
        /// 存入配置文件
        /// </summary>
        public static bool ClosingSaveAppInfo(MapPanelEditor mapEditor)
        {
            #region 存入配置文件
            try
            {
                if (Directory.Exists(ConfigPath) == false) Directory.CreateDirectory(ConfigPath);
                FileStream fs = new FileStream(ConfigPath + ConfigSaveFileName, FileMode.Create);
                BinaryWriter w = new BinaryWriter(fs);
                #region 要存入的参数或者字符串

                w.Write(mapEditor.ThemeNum);
                for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                    w.Write(mapEditor.MapImage2Int(mapEditor.MapIMG_Block[i]));

                w.Write(ToolStripOperation.IndexList.Count);
                for (int i = 0; i <= ToolStripOperation.IndexList.Count - 1; ++i)
                    w.Write(ToolStripOperation.IndexList[i]);

                string path = AppInfo.GetConfigPath() + "\\ComPlace";
                if (Directory.Exists(path) == false)
                    Directory.CreateDirectory(path);

                w.Write(ComposePlace.List.Count);
                for (int i = 0; i <= ComposePlace.List.Count - 1; ++i)
                {
                    ComposePlace.List[i].WriteToFile(w);
                }

                #endregion
                w.Flush();
                w.Close();
                fs.Close();
            }
            catch (Exception es)
            {
                throw (es);
            }
            #endregion
            #region 存入软件设置
            try
            {
                if (Directory.Exists(ConfigPath) == false) Directory.CreateDirectory(ConfigPath);
                FileStream fs = new FileStream(ConfigPath + OptionsSaveFileName, FileMode.Create);
                BinaryWriter w = new BinaryWriter(fs);
                #region 要存入的参数或者字符串                
                foreach (int id in QuickPlaceKey.KeyValueToMapId)
                {
                    w.Write(id);
                }

                w.Write(mapEditor.PictureSize);
                w.Write(mapEditor.MapCusorWidth);       

                #endregion
                w.Flush();
                w.Close();
                fs.Close();
            }
            catch (Exception es)
            {
                throw (es);
            }
            #endregion
            return true;
        }

        public void MapSave(MapPanelEditor mapEditor, SaveFileDialog saveFileDialog)
        {
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Filter = new FileOperator().MapSaveFilter;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fst = (System.IO.FileStream)saveFileDialog.OpenFile();//输出文件
                fst.Close();
                var savePath = saveFileDialog.FileName.ToString(); //获得文件路径           
                try
                {
                    FileStream fs = new FileStream(savePath, FileMode.Create);
                    BinaryWriter w = new BinaryWriter(fs);
                    for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                        w.Write(mapEditor.MapImage2Int(mapEditor.MapIMG_Block[i]));
                    w.Flush();
                    w.Close();
                    fs.Close();
                    MessageBox.Show("保存地图方案成功！");
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            } 
        }

        public void MapLoad(MapPanelEditor mapEditor,OpenFileDialog openFileDialog)
        {
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = new FileMap.FileOperator().MapSaveFilter;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string resultFile = openFileDialog.FileName;
                if (File.Exists(resultFile))
                {
                    try
                    {
                        FileStream fs = new FileStream(resultFile, FileMode.Open);
                        BinaryReader r = new BinaryReader(fs);

                        OnceOperation.RedoAllMap(mapEditor);

                        for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                            mapEditor.MapIMG_Block[i] = mapEditor.Int2MapImage(r.ReadInt32());

                        OnceOperation.ClearResume();
                        r.Close();
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        throw (ex);
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void GenerateMapCode(MapPanelEditor mapEditor,FolderBrowserDialog folderDialog,bool isMessgeBoxShow)
        {
            string GtPath = "";
            if (mapEditor.IsFixedPath == 0)
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    GtPath = folderDialog.SelectedPath;
                }
                else
                    return;
            }
            else
            {
                GtPath = Application.StartupPath + "\\EC" + "\\Chnchts" + "\\MD";

            }
            FileStream fs = new FileStream(GtPath + MapPanelEditor.GtCodeMapName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            #region 生成的地图代码
            int j = 0;

            sw.WriteLine("[Music]");
            for (int i = 0; i <= 50; ++i)
                sw.WriteLine("Music" + i.ToString() + "=2BB," + i.ToString("X2"));

            sw.WriteLine("");

            sw.WriteLine("[MapColor]");
            for (int i = 0; i <= 10; ++i)
                sw.WriteLine("Color" + i.ToString() + "=2D7," + i.ToString("X2"));
            sw.WriteLine("");

            //sw.WriteLine("[The Egg P Value]");
            //sw.WriteLine("OnChange=2C1,00");
            //sw.WriteLine("");

            sw.WriteLine("[MapEditor]");
            sw.Write("MapEditor=9FC6,");
            for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
            {

                if (i != MapPanelEditor.PictureTotal - 1)
                    sw.Write(mapEditor.Bitmapt2HexStr(mapEditor.MapIMG_Block[i]) + ",00" + ",");
                else
                    sw.WriteLine(mapEditor.Bitmapt2HexStr(mapEditor.MapIMG_Block[i]) + ",00");
            }
            sw.Write("Test=9FC6,");
            for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
            {
                if (i != MapPanelEditor.PictureTotal - 1)
                {
                    if (i % 10 == 0 || i % 10 == 1 || i % 10 == 8 || i % 10 == 9 || i < 80)
                    {
                        sw.Write("09" + ",00" + ",");
                    }
                    else
                    {
                        if (j <= 255)
                        {
                            sw.Write(j.ToString("X2") + ",00" + ",");
                            ++j;
                        }
                        else
                        {
                            sw.Write("09" + ",00" + ",");
                        }
                    }
                }
                else
                    sw.WriteLine("09" + ",00");
            }
            sw.WriteLine("");
            //sw.WriteLine("[Theme]");
            //sw.WriteLine("ON=2B5,3");
            //sw.WriteLine("Theme1=2B5,01");
            //sw.WriteLine("Theme2=2B5,02");
            //sw.WriteLine("Theme3=2B5,03");
            //sw.WriteLine("Theme4=2B5,04");
            //sw.WriteLine("Theme5=2B5,05");
            //sw.WriteLine("Theme6=2B5,06");
            //sw.WriteLine("Theme7=2B5,07");
            //sw.WriteLine("Theme8=2B5,08");
            sw.WriteLine("");
            sw.WriteLine("[GameInfo]");
            sw.WriteLine("Name=DynaBrothers2");
            sw.WriteLine("System=MD");
            sw.WriteLine("Text=DynaBrothers2");
            #endregion
            #region 关闭文件
            sw.Flush();
            sw.Close();
            fs.Close();
            #endregion
            if (isMessgeBoxShow == true) MessageBox.Show("生成成功！！");
            ClosingSaveAppInfo(mapEditor);
        }

    }
}
