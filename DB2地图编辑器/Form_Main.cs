using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CCWin;
using System.Drawing.Imaging;
using System.Drawing;
using System.Threading;

namespace DB2地图编辑器
{
    public partial class Form_Main : CCSkinMain
    {

        #region Variables

        public MapPanelEditor MyMapEditor;        
        //const float DragSpeed = 1.0f;
        Form_MapListBoxShow mapListBox;

        #endregion
        #region Constructor

        public Form_Main()
        {
            InitializeComponent();
        }

        #endregion
        #region Init
        /// <summary>
        /// 地图编辑器初始化
        /// </summary>
        /// <returns>无返回值</returns>
        public void Init()
        {

            #region MapEditorInit

            MyMapEditor = new MapPanelEditor();
            MyMapEditor.OnPanelRefresh += () => { MapPanel?.Refresh(); };

            #endregion
            #region MapPanelInit

            MapPanel.MouseRightDownMenu = MapPanelMenu;

            MapPanel.Paint += (sender , e) =>
            {
                new MapPanelShow(MyMapEditor)
                  .DrawMapPicture(e.Graphics)
                  .DrawSelectedIndex(e.Graphics)
                  .DrawImagenaryAndBlock(e.Graphics)
                  .DrawOver(e.Graphics)
                  .DrawPasteHover(e.Graphics);
            };

            MapPanel.DragDrop += (sender, e) =>
            {
                MapPanelMouse.DragDropEvent(e, MyMapEditor, MapPanel);
                MapPanel.Refresh();
            };

            MapPanel.DragEnter += (sender, e) =>
            {
                MapPanelMouse.DragEnterEvent(e, MyMapEditor, MapPanel);
                MapPanel.Refresh();
            };

            MapPanel.DragLeave += (sender, e) =>
            {
                MapPanelMouse.DragLeaveEvent(e, MyMapEditor, MapPanel);
                MapPanel.Refresh();
            };

            MapPanel.MouseDown += (sender, e) =>
            {
                MapPanelMouse.DownEvent(e, MyMapEditor, MapPanel);
                MapPanel.Refresh();
            };

            MapPanel.MouseUp += (sender, e) =>
            {
                MapPanelMouse.UpEvent(e, MyMapEditor, MapPanel);
                this.Cursor = Cursors.Default;
                MapPanel.Refresh();

            };

            MapPanel.MouseClick += (sender, e) =>
            {
                MapPanelMouse.ClickEvent(e, MyMapEditor, MapPanel);
                MapPanel.Refresh();
            };

            MapPanel.MouseMove += (sender, e) =>
            {
                MapPanelMouse.MoveEvent(e, MyMapEditor, MapPanel, Map_VScrollBar, Map_HScrollBar);
            };

            MapPanel.MouseWheel += (sender, e) =>
            {
                if (MyMapEditor.ControlWheel == true)
                {
                    this.Cursor = Cursors.Cross;
                    MyMapEditor.DataInit();
                    MyMapEditor.PictureSize = MapPanelMouse.WheelChangePicSize(e,MyMapEditor);
                    new MapScrollBar(Map_VScrollBar, Map_HScrollBar,MyMapEditor)
                        .ChangeInfo().AutoDudge();
                    MapPanel.Refresh();
                }
            };

            MapPanel.MouseDoubleClick += (sender, e) =>
            {
                int MapTotalSizeX = MyMapEditor.PictureSize * MapPanelEditor.RowNum + MyMapEditor.MapLeft;
                int MapTotalSizeY = MyMapEditor.PictureSize * MapPanelEditor.RowNum + MyMapEditor.MapTop;
                if (e.X >= MapTotalSizeX || e.Y >= MapTotalSizeY)
                    return;
                if (e.X < 0 || e.Y < 0)
                    return;
                if (e.Button == MouseButtons.Left)
                {
                    if (MyMapEditor.SelectedIndex == -1)
                        return;
                    MapEditorRedo();
                    MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex] = MyMapEditor.MapCathe;
                    MapPlaceCom();
                }
            };

            MapPanel.KeyUp += delegate
            {
                MyMapEditor.ControlWheel = false;
                this.Cursor = Cursors.Default;
            };

            #endregion        
            #region MapFileInit

           // try
            {
                FileMap.LoadSaveAppInfo(MyMapEditor);
                MapPanel.Refresh();
            }
          //  catch (Exception ex)
         //   {
          //      MessageBox.Show(ex.Message);
          //  }

            #endregion
            #region MapListBoxInit

            mapListBox = new Form_MapListBoxShow(this);

            #endregion
            #region ScollBarInit

            new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor)
                      .ChangeInfo();

            #endregion 
            #region ToolStripMenuInit

            MapThemeChange.ListoolStripInfo.Add(遗迹主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(海岸主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(山地主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(城堡主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(城市主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(未来城主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(太空主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(异次元主题ToolStripMenuItem);
            MapThemeChange.ListoolStripInfo.Add(博士基地主题ToolStripMenuItem);

            for (int i = 0; i < MapThemeChange.ListoolStripInfo.Count; ++i)
                MapThemeChange.ListoolStripInfo[i].Tag = i;

            ChangeToolStripInfo();
            ChangeToolMenuItemInfo();
            TimerPublicInfoRenew.Start();

            #endregion
        }

        #endregion
        #region FormEvent

        private void Form_Main_Load(object sender, EventArgs e)
        {
            mapListBox.Show();

        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FileMap.ClosingSaveAppInfo(MyMapEditor);
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
         
        }

        #endregion
        #region Scroll

        private void Map_VScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            MyMapEditor.MapTop = -Map_VScrollBar.Value;
            MapPanel.Refresh();
        }

        private void Map_HScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            MyMapEditor.MapLeft = -Map_HScrollBar.Value;
            MapPanel.Refresh();
        }

        public void RenewMapScrollInfo()
        {
            new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor)
                .ChangeInfo()
                .AutoDudge();
        }

        #endregion
        #region Menu

        #region File

        private void 保存地图方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new FileMap().MapSave(MyMapEditor,saveFileDialog);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 载入地图方案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new FileMap().MapLoad(MyMapEditor, openFileDialog);
                MapPlaceCom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void 生成地图代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new FileMap().GenerateMapCode(MyMapEditor,folderBrowserDialog,true);
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void 保存并生成代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var fileMap = new FileMap();
                fileMap.MapSave(MyMapEditor, saveFileDialog);
                MapPanel.Refresh();
                fileMap.GenerateMapCode(MyMapEditor, folderBrowserDialog, false); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        #region Edit

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapEditorUndo();
            MapPlaceCom();
            MapPanel.Refresh();
        }

        private void 重做ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnceOperation.Resume(MyMapEditor);
            new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor)
                .AutoDudge();
            MapPlaceCom();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyMapEditor.SelectedIndex == -1)
                return;
            if (MyMapEditor.ImagBlockCus == false)
            {
                MyMapEditor.MapCathe = MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex];
                mapListBox.PasteBox.Image = MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex];
            }
            else
            {
                var NowPaste = new SmartPaste(SmartPasteCopyKind.CtrlC,MyMapEditor);
                mapListBox.SmartPasteBox.Image = SmartPaste.PasteImage;
                mapListBox.label_SmartPasteNum.Text = SmartPaste.TextShowStr;              
            }
            MapPanel.Refresh();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyMapEditor.SelectedIndex == -1)
                return;
            if (MyMapEditor.ImagBlockCus == false)
            {
                MyMapEditor.MapCathe = MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex];
                mapListBox.PasteBox.Image = MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex];
            }
            else
            {
                var NowPaste = new SmartPaste(SmartPasteCopyKind.CtrlX, MyMapEditor);
                mapListBox.SmartPasteBox.Image = SmartPaste.PasteImage;
                mapListBox.label_SmartPasteNum.Text = SmartPaste.TextShowStr;
            }
            MapPanel.Refresh();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SmartPaste.Paste(MyMapEditor) == false)
                MessageBox.Show("智能粘贴不完全成功！\r\n" + "原因选择坐标不合适！");//+ 
            if (SmartPaste.State == null)
            {
                mapListBox.SmartPasteBox.Image = null;
                mapListBox.label_SmartPasteNum.Text = "智能粘贴:Null";
            }
            OnceOperation.ClearResume();
            MapPlaceCom();
        }

        private void 检索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MyMapEditor.SelectedIndex == -1)
            {
                MessageBox.Show("请选择一个地图块！！");
                return;
            }
            List<int> list = new List<int>();list.Clear();
            int ctrlfIndex = MyMapEditor.MapImage2Int(MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex]);
            for(int i=0;i< MapPanelEditor.PictureTotal;++i)
            {
                if (MyMapEditor.MapIMG_Block[i] ==
                    MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][ctrlfIndex])
                    list.Add(i);
            }

            new Form_Message(list, ctrlfIndex, MyMapEditor,(s, t) =>
            {
                 var form = s as Form_Message;
                 if (Form_Message.GlobalFlag == true)
                 {
                    MyMapEditor.SelectedIndex = form.PassIndex;
                    new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor)
                      .AutoDudge();
                    MapPanel.Refresh();
                    this.Focus();
                 }
            }).Show();

        }

        private void 取消选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMapEditor.SelectedIndex = -1;
            MapPanel.Refresh();
        }

        #endregion
        #region View

        Form_Grid formGrid;
        private void 编辑缩略图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGrid = new Form_Grid();
            formGrid.UpdateDataMapView += (s, t) => 
            {
                try
                {
                    new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor).AutoDudge();
                    MapPanel.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            formGrid.SpaceKeyDown += (s, t) =>
            {
                MapEditorRedo();
                MyMapEditor.NowSelectedImg = MyMapEditor.MapCathe;
                MapPlaceCom();
            };
            this.Text = AppInfo.GetName() + "（正在打开编辑缩略图，稍等..）";
            this.UseWaitCursor = true;
            Thread startupWork1 = new Thread(new ThreadStart(() =>
            {
                formGrid?.Init(MyMapEditor);
                RenewFormMainUI(AppInfo.GetName(), false);
            }));
            startupWork1.Start();
        }

        private void 适应屏幕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyMapEditor.SelectedIndex = 0;
            MyMapEditor.PictureSize = MapPanelEditor.MapImgSuitSize;
            new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor)
                .AutoDudge()
                .ChangeInfo();
            MapPanel.Refresh();
        }

        private void 适应选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor)
                .AutoDudge();
            MapPanel.Refresh();
        }

        private void 精简视图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var control = sender as ToolStripMenuItem;
            control.Checked = !control.Checked;
            SmplificationView view = new SmplificationView();
            this.Size = view.ChangeFormSize(
                control.Checked,
                mapListBox.MapListBox,
                MapListBox_ClickSubItem,
                Form_Main_KeyDown,
                Form_Main_KeyUp,
                MapPanel_PreviewKeyDown,
                this
                    );
        }

        Form_MapIdHexShow formIdShow;
        private void 地图Hex代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formIdShow = new Form_MapIdHexShow(MyMapEditor);
            this.Text = AppInfo.GetName() + "（正在打开地图十六进制代码，稍等..）";
            this.UseWaitCursor = true;
            Thread startupWork1 = new Thread(new ThreadStart( ()=> {
                formIdShow.Init();
                RenewFormMainUI(AppInfo.GetName(),true);
            } ));
            startupWork1.Start();

        }

        delegate void FinishTask(string str,bool isGameGrid);
        void RenewFormMainUI(string str,bool isGamegrid)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new FinishTask(RenewFormMainUI), new object[] { str , isGamegrid});
                return;
            }
            this.Text = str;
            this.UseWaitCursor = false;
            if (isGamegrid == true) formIdShow?.Show();
            else formGrid?.Show();
        }

        
        #endregion
        #region Tool

        private void 全部变为空地ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否全部变为空地", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                OnceOperation.RedoAllMap(MyMapEditor);
                for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                    MyMapEditor.MapIMG_Block[i] = MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][(int)MapIdDefine.空地];
                OnceOperation.ClearResume();
                MapPlaceCom();
            }
        }

        private void 全部变为花地ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否全部变为空地", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                OnceOperation.RedoAllMap(MyMapEditor);
                for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                    MyMapEditor.MapIMG_Block[i] = MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][(int)MapIdDefine.花地Start + 2];
                OnceOperation.ClearResume();
                MapPlaceCom();
            }
        }

        private void 修改快速放置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 地图其他修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        Form_SmartEditor formSmart;
        private void 智能编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            formSmart = new Form_SmartEditor(MyMapEditor);

            this.Text = AppInfo.GetName() + "（正在打开智能编辑，稍等..）";
            this.UseWaitCursor = true;
            Thread startupWork1 = new Thread(new ThreadStart(() =>
            {
                formSmart?.Init();
                RenewFormMainUIBehindSmart(AppInfo.GetName(), true);
            }));
            startupWork1.Start();
          
        }

        void RenewFormMainUIBehindSmart(string str, bool isGamegrid)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new FinishTask(RenewFormMainUIBehindSmart), new object[] { str, isGamegrid });
                return;
            }
            this.Text = str;
            this.UseWaitCursor = false;
            if (isGamegrid == true) FormSmartEditorShow();
            else formSmart?.Show();
        }

        void FormSmartEditorShow()
        {
            if (formSmart.ShowDialog() == DialogResult.OK)
            {
                PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.PastePlace, MyMapEditor);
                int CountTemp = formSmart.DesBrushRanc.Count;
                for (int i = 0; i <= CountTemp - 1; ++i)
                {
                    int IndexTemp = formSmart.DesBrushRanc[i].clickindex;
                    OperationTemp.Items.Add(IndexTemp);
                    if (formSmart.DesBrushRanc[i].color == SmartEditor.ColorBlock[0].BackColor)
                    {
                        SmartEditor NowSE = new SmartEditor(MyMapEditor);
                        NowSE.Start(MapStructureKind.Water, formSmart.DesBrushRanc, i);
                    }
                    if (formSmart.DesBrushRanc[i].color == SmartEditor.ColorBlock[1].BackColor)
                    {
                        SmartEditor NowSE = new SmartEditor(MyMapEditor);
                        NowSE.Start(MapStructureKind.Magma, formSmart.DesBrushRanc, i);
                    }
                    if (formSmart.DesBrushRanc[i].color == SmartEditor.ColorBlock[2].BackColor)
                    {
                        SmartEditor NowSE = new SmartEditor(MyMapEditor);
                        NowSE.Start(MapStructureKind.Ice, formSmart.DesBrushRanc, i);
                    }
                    if (formSmart.DesBrushRanc[i].color == SmartEditor.ColorBlock[3].BackColor)
                    {
                        SmartEditor NowSE = new SmartEditor(MyMapEditor);
                        //NowSE.Start(MapStructureKind.Universe, Form_Temp, i);
                    }
                    if (formSmart.DesBrushRanc[i].color == SmartEditor.ColorBlock[4].BackColor)
                    {
                        SmartEditor NowSE = new SmartEditor(MyMapEditor);
                        NowSE.Start(MapStructureKind.MountainTop, formSmart.DesBrushRanc, i);
                    }
                }
                OnceOperation.Redo(OperationTemp);
                MapPlaceCom();
                formSmart.Close();
            }
        }

        private void 智能连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<PointBrush> DesBrushRanc = new List<PointBrush>();

            int WaterMin = (int)MapIdDefine.水面Start;
            int WaterMax = (int)MapIdDefine.水面End;
            int MagmaMin = (int)MapIdDefine.岩浆Start;
            int MagmaMax = (int)MapIdDefine.岩浆End;

            SmartEditor.ColorBlock.Clear();
            for (int i = 0; i < 6; ++i)
                SmartEditor.ColorBlock.Add(new PictureBox());
            SmartEditor.ColorBlock[0].BackColor = Color.Blue;
            SmartEditor.ColorBlock[1].BackColor = Color.Red;
            SmartEditor.ColorBlock[2].BackColor = Color.LightBlue;
            SmartEditor.ColorBlock[3].BackColor = Color.Gray;
            SmartEditor.ColorBlock[4].BackColor = Color.Yellow;
            SmartEditor.ColorBlock[5].BackColor = Color.LightCyan;

            for (int i = 0; i < MapPanelEditor.PictureTotal; ++i)
            {
                int index = MyMapEditor.MapImage2Int(MyMapEditor.MapIMG_Block[i]);
                if (MyPublicFuntion.MathFunctionDefine.IsInRange(index, WaterMin, WaterMax) == true)
                {
                    int xnum = i / 40 + 1; int ynum = i % 40 + 1;
                    DesBrushRanc.Add(new PointBrush(new Point(xnum, ynum), SmartEditor.ColorBlock[0].BackColor, i));
                }
                else if (MyPublicFuntion.MathFunctionDefine.IsInRange(index, MagmaMin, MagmaMax) == true)
                {
                    int xnum = i / 40 + 1; int ynum = i % 40 + 1;
                    DesBrushRanc.Add(new PointBrush(new Point(xnum, ynum), SmartEditor.ColorBlock[1].BackColor, i));
                }
            }
            PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.PastePlace,MyMapEditor);
            int CountTemp = DesBrushRanc.Count;
            for (int i = 0; i <= CountTemp - 1; ++i)
            {
                int IndexTemp = DesBrushRanc[i].clickindex;
                OperationTemp.Items.Add(IndexTemp);
                if (DesBrushRanc[i].color == SmartEditor.ColorBlock[0].BackColor)
                {
                    SmartEditor NowSE = new SmartEditor(MyMapEditor);
                    NowSE.Start(MapStructureKind.Water, DesBrushRanc, i);
                }
                if (DesBrushRanc[i].color == SmartEditor.ColorBlock[1].BackColor)
                {
                    SmartEditor NowSE = new SmartEditor(MyMapEditor);
                    NowSE.Start(MapStructureKind.Magma, DesBrushRanc, i);
                }
                if (DesBrushRanc[i].color == SmartEditor.ColorBlock[2].BackColor)
                {
                    SmartEditor NowSE = new SmartEditor(MyMapEditor);
                    NowSE.Start(MapStructureKind.Ice, DesBrushRanc, i);
                }
                if (DesBrushRanc[i].color == SmartEditor.ColorBlock[3].BackColor)
                {
                    SmartEditor NowSE = new SmartEditor(MyMapEditor);
                    //NowSE.Start(MapStructureKind.Universe, Form_Temp, i);
                }
                if (DesBrushRanc[i].color == SmartEditor.ColorBlock[4].BackColor)
                {
                    SmartEditor NowSE = new SmartEditor(MyMapEditor);
                    NowSE.Start(MapStructureKind.MountainTop, DesBrushRanc, i);
                }
            }
            OnceOperation.Redo(OperationTemp);
            MapPlaceCom();
        }

        private void 画草稿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Draft(MyMapEditor).Show();

        }
        
        private void 软件设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Option formtemp = new Form_Option(MyMapEditor);
            formtemp.MdiParent = this;
            formtemp.BtnOkClickHandler += () =>
            {
                MyMapEditor.PictureSize = formtemp.SetPictureSize;
            };
            formtemp.MainWindowRefresh += () => { MapPanel.Refresh(); };
            formtemp.Show();
        }

        private void 输出地图图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string GtPath = "";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                GtPath = folderBrowserDialog.SelectedPath;
            }
            else
                return;

            new OutPutMapImg(MyMapEditor).GenerateImg(GtPath, ImageFormat.Png);

            MessageBox.Show("生成成功！");
        }

        #endregion
        #region About

        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 版本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_AboutBox().Show();
        }

        #endregion
        #region Help

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_Instructions().Show();
        }

        private void eC地图代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion
        #region Others

        private void 打开ECToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenEC.StartInfo = new System.Diagnostics.ProcessStartInfo(Application.StartupPath + "\\EC" + "\\EC.exe");
                OpenEC.Start();
            }
            catch
            {
                MessageBox.Show("请按要求放置EC路径!");
            }
        }

        private void dB音乐盒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new Form_Music().Show();
        }

        private void 编辑器皮肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion
        #region MapSelectedIndex



        #endregion
        #region KeyBoard

        private void MapPanel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Modifiers.CompareTo(Keys.Shift) == 0 && e.KeyCode == Keys.C)
            {
                MyMapEditor.SelectedIndex = -1;
            }
            else if (e.Modifiers.CompareTo(Keys.Control) == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Z:
                        撤销ToolStripMenuItem_Click(null, null);
                        break;
                    case Keys.V:
                        粘贴ToolStripMenuItem_Click(null, null);
                        break;
                    case Keys.S:
                        FileMap.ClosingSaveAppInfo(MyMapEditor);
                        break;
                    case Keys.X:
                        剪切ToolStripMenuItem_Click(null, null);
                        break;
                    case Keys.Y:
                        重做ToolStripMenuItem_Click(null, null);
                        break;
                    case Keys.F:
                        检索ToolStripMenuItem_Click(null, null);
                        break;
                    case Keys.C:
                        复制ToolStripMenuItem_Click(null, null);
                        break;
                    case Keys.Space:
                        粘贴ToolStripMenuItem_Click(null, null);
                        break;
                }
                MapPlaceCom();
                MyMapEditor.ControlWheel = true;
            }
            else if (e.Modifiers.CompareTo(Keys.Alt) == 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        SmartPaste.State = null;
                        mapListBox.label_SmartPasteNum.Text = "智能编辑:Null";
                        mapListBox.SmartPasteBox.Image = null;
                        break;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (MyMapEditor.ImagBlockCus == false)
                {
                    if (MyMapEditor.SelectedIndex == -1)
                        return;
                    MapEditorRedo();
                    MapPlaceCom();
                    MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex] = MyMapEditor.MapCathe;
                }
                else
                {
                    if (new MapMorePictures(MyMapEditor).Place() == false) return;
                    MapPlaceCom();
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (MyMapEditor.ImagBlockCus == false)
                {
                    MyMapEditor.DataInit();
                }
                else
                {
                    if (new MapMorePictures(MyMapEditor).MoveOperation(AroundMap.MapLeft) == false) return;
                    MapPlaceCom();
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if (MyMapEditor.ImagBlockCus == false)
                {
                    MyMapEditor.DataInit();
                }
                else
                {
                    if (new MapMorePictures(MyMapEditor).MoveOperation(AroundMap.MapRight) == false) return;
                    MapPlaceCom();
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                if (MyMapEditor.ImagBlockCus == false)
                {
                    MyMapEditor.DataInit();
                }
                else
                {
                    if (new MapMorePictures(MyMapEditor).MoveOperation(AroundMap.MapUp) == false) return;
                    MapPlaceCom();

                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (MyMapEditor.ImagBlockCus == false)
                {
                    MyMapEditor.DataInit();
                }
                else
                {
                    if (new MapMorePictures(MyMapEditor).MoveOperation(AroundMap.MapDown) == false) return;
                    MapPlaceCom();
                }
            }
            MapPanel.Focus();
            MapPanel.Refresh();

        }

        private List<Keys> PressedKeys = new List<Keys>();
        private void Form_Main_KeyDown(object sender, KeyEventArgs e)
        {
            this.Focus();
            MapPanel.Focus();
            if (PressedKeys.Contains(e.KeyCode) == false)
                PressedKeys.Add(e.KeyCode);
            foreach (Keys k in PressedKeys)
            {
                switch (k)
                {
                    case Keys.W://按下W键的行为
                        MyMapEditor.UpMapSeIndex(); 
                        break;
                    case Keys.A://按下A键的行为
                        MyMapEditor.LeftMapSeIndex();
                        break;
                    case Keys.S://按下W键的行为
                        MyMapEditor.DownMapSeIndex();
                        break;
                    case Keys.D://按下A键的行为
                        MyMapEditor.RightMapSeIndex();
                        break;
                    case Keys.M:
                        适应屏幕ToolStripMenuItem_Click(null, null);
                        break;
                    case Keys.D1:
                    case Keys.D2:
                    case Keys.D3:
                    case Keys.D4:
                    case Keys.D5:
                    case Keys.D6:
                    case Keys.D7:
                    case Keys.D8:
                    case Keys.D9:
                    case Keys.D0:
                        new QuickPlaceKey(MyMapEditor).KeyNumQuickPlace(k);
                        MapPlaceCom();
                        break;
                }
            }
            MapPanel.Refresh();
        }

        private void Form_Main_KeyUp(object sender, KeyEventArgs e)
        {
            PressedKeys.Clear();
        }

        #endregion
        #region MapListBox

        public void MapListBox_ClickSubItem(object sender, CCWin.SkinControl.ChatListClickEventArgs e, MouseEventArgs es)
        {
            if (es.Button == MouseButtons.Left)
            {
                if (e.SelectSubItem.ID < 256)
                {
                    if (MyMapEditor.SelectedIndex == -1)
                        return;
                    MapEditorRedo();
                    MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex] =
                        MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][Convert.ToInt32(e.SelectSubItem.ID)];
                    MapPlaceCom();
                }
                else
                {
                    if (MyMapEditor.SelectedIndex == -1)
                        return;
                    PlaceOperation OperationTemp = new PlaceOperation(PlaceOperation.Kind.PastePlace,MyMapEditor);
                    try
                    {

                        int minIndex = ComposePlace.List[(int)e.SelectSubItem.ID - 256].MinIndex;
                        if (minIndex == -1) return;
                        int num = MapPanelEditor.RowNum;
                        int width = ComposePlace.List[(int)e.SelectSubItem.ID - 256].Size.Width;
                        int height = ComposePlace.List[(int)e.SelectSubItem.ID - 256].Size.Height;
                        int iterator = 0;
                        foreach (int IndexTemp in ComposePlace.List[(int)e.SelectSubItem.ID - 256].Items.Index)
                        {
                            int Index = MyMapEditor.SelectedIndex + IndexTemp - minIndex;
                            int x = Index % num; int y = Index / num;
                            if ((x + width) > num || (y + height) > num)
                                continue;
                            OperationTemp.Items.Add(Index);
                            MyMapEditor.MapIMG_Block[Index] = ComposePlace.List[(int)e.SelectSubItem.ID - 256].Items.Image[iterator++];
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        OnceOperation.Redo(OperationTemp);
                    }
                    OnceOperation.ClearResume();
                    MapPlaceCom();
                }
            }
            else
            {
                MapListBoxInitClass.ItemDownId = (int)e.SelectSubItem.ID;
            }
        }

        public void 加入快捷放置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MapListBoxInitClass.ItemDownId == -1) return;
            if (MapListBoxInitClass.ItemDownId < 256)
                ToolSrtipSpeedPlaceAdd((int)MapListBoxInitClass.ItemDownId);
            else
                MessageBox.Show("组合放置不能加入快捷放置栏!");
            return;
        }

        public void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MapListBoxInitClass.ItemDownId == -1) return;
            if (MapListBoxInitClass.ItemDownId < 256)
            {
                MyMapEditor.MapCathe =
                    MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][MapListBoxInitClass.ItemDownId];
                mapListBox.PasteBox.Image = MyMapEditor.MapCathe;
            }
            else
            {
                SmartPaste NowPaste = new SmartPaste(SmartPasteCopyKind.CtrlC,MyMapEditor);
                NowPaste.Items = ComposePlace.List[MapListBoxInitClass.ItemDownId - 256].Items;
                Size sizetemp = ComposePlace.List[MapListBoxInitClass.ItemDownId - 256].Size;
                NowPaste.Size = sizetemp;
                SmartPaste.State = NowPaste;
                SmartPaste.IsPasteIng = true;
                mapListBox.SmartPasteBox.Image =
                    mapListBox.MapListBox.Items[MapListBoxInitClass.ComPlaceId].
                        SubItems[MapListBoxInitClass.ItemDownId - 256].HeadImage;
                mapListBox.label_SmartPasteNum.Text = "智能粘贴:" + "有" + SmartPaste.State.Items.Index.Count +
                    "个图片元素 " + sizetemp.Width.ToString() + "×" + sizetemp.Height.ToString() + " 复制";
            }
        }

        public void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MapListBoxInitClass.ItemDownId == -1) return;
            var formProperty = new Form_Property(new PictureProperty(MapListBoxInitClass.ItemDownId, MyMapEditor));
            formProperty.MdiParent = this;
            formProperty.Show();
        }

        public void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MapListBoxInitClass.ItemDownId == -1) return;
            if (MapListBoxInitClass.ItemDownId < 256)
                MessageBox.Show("非组合放置不能删除!");
            else
            {
                ComposePlace.List.RemoveAt(MapListBoxInitClass.ItemDownId - 256);
                new MapListBoxInitClass().RenewComposePlace(mapListBox.MapListBox,MyMapEditor);
            }
            return;
        }

        #endregion
        #region UndoAndRedo

        private void MapPlaceCom()
        {
            MapPanel.Refresh();
            SmartPaste.HoverPasteInit();
        }

        private void MapEditorRedo()
        {
            try
            {
                OnceOperation.ClearResume();
                OnceOperation.RedoOneMap(MyMapEditor.SelectedIndex,MyMapEditor);
            }
            catch { }
            MapPlaceCom();
        }

        private void MapEditorUndo()
        {
            if (OnceOperation.Undo(MyMapEditor) == false) return;

            MyMapEditor.DataInit();
            new MapScrollBar(Map_VScrollBar, Map_HScrollBar, MyMapEditor)
                .AutoDudge();
            MapPlaceCom();
        }

        private void MapAllClrUndo()
        {
            if (MyMapEditor.MapAllClrImgList.Count == 0)
                return;
            for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
            {
                try
                {
                    MyMapEditor.MapIMG_Block[i] = MyMapEditor.MapAllClrImgList[i];

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            MyMapEditor.MapAllClrImgList.Clear();
            MyMapEditor.ALLClrUndoFlag = false;
        }

        private void MapAllClrRedo()
        {
            for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
            {
                MyMapEditor.MapAllClrImgList.Add(MyMapEditor.MapIMG_Block[i]);
            }
            OnceOperation.ClearResume();
            MapPlaceCom();
            MyMapEditor.ALLClrUndoFlag = true;
        }










        #endregion
        #region FastPlace

        private void 快速放置栏_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem ToolButtonTemp = e.ClickedItem;
            if ((int)(ToolButtonTemp.Tag) < ToolStripOperation.AssistantConstant * ToolStripOperation.minenum)
            {
                if (MyMapEditor.SelectedIndex == -1)
                    return;
                MapEditorRedo();
                MyMapEditor.MapIMG_Block[MyMapEditor.SelectedIndex] =
                    MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][Convert.ToInt32(ToolButtonTemp.Tag)];
                //MainAnalyzer[TempTag]();
                MapPlaceCom();
            }
            else
            {
                ToolStripOperation.KindEnum tag = (ToolStripOperation.KindEnum)(ToolButtonTemp.Tag);
                switch (tag)
                {
                    case ToolStripOperation.KindEnum.Copy:
                        复制ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Cut:
                        剪切ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Export:
                        生成地图代码ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Grid:
                        编辑缩略图ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Open:
                        载入地图方案ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Paste:
                        粘贴ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Resume:
                        重做ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Save:
                        保存地图方案ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.SmartEdi:
                        智能编辑ToolStripMenuItem_Click(null, null);
                        break;
                    case ToolStripOperation.KindEnum.Undo:
                        撤销ToolStripMenuItem_Click(null, null);
                        break;
                }
            }
        }

        private void ChangeToolStripInfo()
        {
            int CountTemp = ToolStripOperation.IndexList.Count - 1;
            快速放置栏.Items.Clear();

            for (int i = ToolStripOperation.minenum;
                i < ToolStripOperation.TsCount + ToolStripOperation.minenum; ++i)
            {
                ToolStripMenuItem Temp = new ToolStripMenuItem();
                Temp.Image = ToolStripOperation.ImgList[i - ToolStripOperation.minenum];
                Temp.ToolTipText = ToolStripOperation.StrList[i - ToolStripOperation.minenum];
                Temp.Tag = i * ToolStripOperation.AssistantConstant;
                快速放置栏.Items.Add(Temp);
            }
            for (int i = 0; i <= ToolStripOperation.IndexList.Count - 1; ++i)
            {
                ToolSrtipSpeedPlaceAdd(ToolStripOperation.IndexList[i], true);
            }
        }

        void ToolSrtipSpeedPlaceAdd(int id)
        {
            ToolStripMenuItem Temp = new ToolStripMenuItem();
            int TagTemp = id;
            Temp.Tag = TagTemp;
            Temp.Image =
                MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][TagTemp];
            Temp.MouseUp += (sender, e) =>
            {
                var now = sender as ToolStripMenuItem;
                ToolStripOperation.MouseDownItemId = (int)now.Tag;
                ToolStripOperation.MouseDownItemIndex = 快速放置栏.Items.IndexOf(Temp);
            };
            Temp.ToolTipText = "Bin:" + TagTemp.ToString() + " Hex:" + TagTemp.ToString("X2");
            快速放置栏.Items.Add(Temp);
            ToolStripOperation.IndexList.Add(TagTemp);
        }

        void ToolSrtipSpeedPlaceAdd(int id, bool init)
        {
            ToolStripMenuItem Temp = new ToolStripMenuItem();
            int TagTemp = id;
            Temp.Tag = TagTemp;
            Temp.Image =
                MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][TagTemp];
            Temp.MouseUp += (sender, e) =>
            {
                var now = sender as ToolStripMenuItem;
                ToolStripOperation.MouseDownItemId = (int)now.Tag;
                ToolStripOperation.MouseDownItemIndex = 快速放置栏.Items.IndexOf(Temp);
            };
            Temp.ToolTipText = "Bin:" + TagTemp.ToString() + " Hex:" + TagTemp.ToString("X2");
            快速放置栏.Items.Add(Temp);
        }

        #endregion
        #region MapThemeChange

        private void ChangeToolMenuItemInfo()
        {
            int CountTemp = MapThemeChange.ListoolStripInfo.Count - 1;
            for (int i = 0; i <= CountTemp; ++i)
            {
                MapThemeChange.ListoolStripInfo[i].Checked = false;
            }
            MapThemeChange.ListoolStripInfo[MyMapEditor.ThemeNum].Checked = true;
        }

        /// <summary>
        /// 改变地图主题
        /// </summary>
        /// <param name="sender">参数array注释</param>
        /// <param name="e">参数num注释</param>
        /// <returns>返回值注释</returns>
        private void ChangeMapTheme(object sender, EventArgs e)
        {
            ToolStripMenuItem ToolMenuItemTemp = (ToolStripMenuItem)sender;

            MyMapEditor.PreThemeNum = MyMapEditor.ThemeNum;
            MyMapEditor.ThemeNum = Convert.ToInt32(ToolMenuItemTemp.Tag);
            int IndexTemp;
            for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
            {
                IndexTemp = MyMapEditor.ThemeBar[MyMapEditor.PreThemeNum].IndexOf(MyMapEditor.MapIMG_Block[i]);
                MyMapEditor.MapIMG_Block[i] = MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][IndexTemp];
            }
            MyMapEditor.MapCathe = MyMapEditor.ThemeBar[MyMapEditor.ThemeNum][(int)MapIdDefine.空地];
            mapListBox.PasteBox.Image = null;
            mapListBox.SmartPasteBox.Image = SmartPaste.PasteImage;
            ChangeToolStripInfo();
            ChangeToolMenuItemInfo();
            new MapListBoxInitClass().Init(mapListBox.MapListBox,MyMapEditor);
            MapPanel.Refresh();
        }



        #endregion
        #region MapPanelRightMenu

        private void 复制ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            复制ToolStripMenuItem_Click(null,null);
        }

        private void 剪切ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            剪切ToolStripMenuItem_Click(null, null);
        }

        private void 粘贴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            粘贴ToolStripMenuItem_Click(null, null);
        }

        private void 加入组合放置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MyMapEditor.SelectedIndex == -1)
                return;
            if (MyMapEditor.ImagBlockCus == false)
            {
                return;
            }
            ComposePlace.List.Add(new ComposePlace(MyMapEditor));
            new MapListBoxInitClass().RenewComposePlace(mapListBox.MapListBox,MyMapEditor);
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ToolStripOperation.MouseDownItemIndex >= ToolStripOperation.TsCount)
                {
                    快速放置栏.Items.RemoveAt(ToolStripOperation.MouseDownItemIndex);
                    ToolStripOperation.IndexList.RemoveAt(ToolStripOperation.MouseDownItemIndex - ToolStripOperation.TsCount);
                }
                else
                    MessageBox.Show(ToolStripOperation.GetKeepOutDeleteStr());
            }
            catch
            {
                MessageBox.Show(ToolStripOperation.GetKeepOutDeleteStr());
            }
        }

        #endregion
        #region Timer

        private void TimerPublicInfoRenew_Tick(object sender, EventArgs e)
        {
            try
            {
                if (SmartPaste.State == null)
                {
                    粘贴ToolStripMenuItem.Enabled = false;
                    快速放置栏.Items[(int)(ToolStripOperation.KindEnum.Paste) /
                        ToolStripOperation.AssistantConstant - ToolStripOperation.minenum].Enabled = false;
                }
                else
                {
                    粘贴ToolStripMenuItem.Enabled = true;
                    快速放置栏.Items[(int)(ToolStripOperation.KindEnum.Paste) /
                        ToolStripOperation.AssistantConstant - ToolStripOperation.minenum].Enabled = true;

                }

                重做ToolStripMenuItem.Enabled = !OnceOperation.ResumeStackIsNull();
                快速放置栏.Items[(int)(ToolStripOperation.KindEnum.Resume) /
                    ToolStripOperation.AssistantConstant - ToolStripOperation.minenum].Enabled = !OnceOperation.ResumeStackIsNull();


                撤销ToolStripMenuItem.Enabled = !OnceOperation.StackIsNull();
                快速放置栏.Items[(int)(ToolStripOperation.KindEnum.Undo) /
                    ToolStripOperation.AssistantConstant - ToolStripOperation.minenum].Enabled = !OnceOperation.StackIsNull();

                SmartPaste.ShowHoverPaste();
                MapPanel.Refresh();
            }
            catch
            {

            }
        }

        #endregion

    }
}
