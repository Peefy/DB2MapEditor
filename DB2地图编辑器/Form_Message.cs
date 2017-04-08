using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;


namespace DB2地图编辑器
{
    public partial class Form_Message : CCWin.CCSkinMain
    {

        private List<int> IndexInfoList = new List<int>();
        private int CtrlfMapId = -1;
        public int PassIndex { get; set; } = 0;

        public event EventHandler UpdateDataGridView = null;
        public static bool GlobalFlag { get; set; } = false; //该变量用来标识是否创建新的子窗体

        int NextIndex = 0;
        const int MaxNum = 88;

        MapPanelEditor MapEditor;

        private void CtrlFInfoShow()
        {
            InfoBox.Text = "";
            int Count_Temp = IndexInfoList.Count;
            if (Count_Temp == 0)
            {
                InfoBox.AppendText("没有检索到地图块！");
                this.Text = "";
                return;
            }
            InfoBox.AppendText("一共有" + Count_Temp + "个检索地图块！");
            InfoBox.AppendText(System.Environment.NewLine);
            for (int i = 0; i <= Count_Temp - 1; ++i) 
            {
                int x = IndexInfoList[i] % (MapPanelEditor.RowNum) + 1;
                int y = IndexInfoList[i] / (MapPanelEditor.LineNum) + 1;
                int count = i + 1;
                InfoBox.AppendText("检索地图块" + count + "的坐标为（"+x+","+y+")");
                InfoBox.AppendText(System.Environment.NewLine);
            }
            this.Text ="";
        }

        Form_Message()
        {
            InitializeComponent();
        }

        Form_Message(List<int> list)
        {
            InitializeComponent();
            IndexInfoList = list;
            CtrlFInfoShow();
        }

        public Form_Message(List<int> list,int id,MapPanelEditor mapedi)
        {
            InitializeComponent();
            MapEditor = mapedi;
            IndexInfoList = list;
            CtrlfMapId = id;
            nmUD_CtrlfMapId.Value = CtrlfMapId;
            
            CtrlFInfoShow();
        }

        public Form_Message(List<int> list, int id,MapPanelEditor mapedi,EventHandler updateHandler)
        {
            InitializeComponent();
            MapEditor = mapedi;
            IndexInfoList = list;
            CtrlfMapId = id;
            nmUD_CtrlfMapId.Value = CtrlfMapId;      
            UpdateDataGridView += updateHandler;
            CtrlFInfoShow();
        }

        private void Next_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Next_MouseDown(object sender, MouseEventArgs e)
        {
            if (IndexInfoList.Count == 0)
            {
                MessageBox.Show("未发现检索地图块");
                return;
            }
            GlobalFlag = true;
            this.PassIndex = IndexInfoList[NextIndex];
            UpdateDataGridView(this, EventArgs.Empty);          
            ++NextIndex;
            if (NextIndex > IndexInfoList.Count - 1)
                NextIndex = 0;
            if (NextIndex == 0)
                MessageBox.Show("到达了检索的起点");
        }

        delegate void FinishTask(int i);
        void RenewFormMainUI(int i)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new FinishTask(RenewFormMainUI), new object[] { i });
                return;
            }
            if (IndexInfoList.Count >= MaxNum)
            {
                MessageBox.Show("检索数量过多，只显示部分检索");
                IndexInfoList.RemoveRange(MaxNum, IndexInfoList.Count - MaxNum);
            }
            CtrlFInfoShow();
        }

        private void 刷新信息_Click(object sender, EventArgs e)
        {
            IndexInfoList.Clear();
            
            this.Text = "正在刷新，请稍等.....";
            Thread startupWork1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i <= MapPanelEditor.PictureTotal - 1; ++i)
                {
                    if (MapEditor.MapIMG_Block[i] == MapEditor.ThemeBar[MapEditor.ThemeNum][CtrlfMapId])
                    {
                        IndexInfoList.Add(i);
                    }
                }
                RenewFormMainUI(0);
            }));
            startupWork1.Start();
                       
        }

        private void Form_Message_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void nmUD_CtrlfMapId_ValueChanged(object sender, EventArgs e)
        {
            CtrlfMapId = (int)nmUD_CtrlfMapId.Value;
            //刷新信息_Click(null, EventArgs.Empty);
        }

        private void btn_CtrlFLost_Click(object sender, EventArgs e)
        {
            IndexInfoList.Clear();
            this.Text = "正在刷新，请稍等.....";
            Thread startupWork1 = new Thread(new ThreadStart(() =>
            {
                IndexInfoList = new LostMap().ReturnLostMapPictureId(MapEditor);
                RenewFormMainUI(0);
            }));
            startupWork1.Start();
            
        }

        private void Form_Message_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown)
                Next_MouseDown(null, null);
        }

    }
}
