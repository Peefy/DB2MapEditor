using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace DB2地图编辑器
{
    public partial class Form_MapListBoxShow : CCSkinMain
    {
        private Form_Main parentForm;
        public Form_MapListBoxShow(Form_Main pForm)
        {
            InitializeComponent();
            parentForm = pForm;
            this.MdiParent = parentForm;
            this.WindowState = FormWindowState.Maximized;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowDrawIcon = false;

            MapListBox.Location = new Point(1, 1);
            MapListBox.Width = this.Width - 10;

        }

        private void MapListBox_ClickSubItem(object sender, CCWin.SkinControl.ChatListClickEventArgs e, MouseEventArgs es)
        {
            parentForm.MapListBox_ClickSubItem(sender, e,es);
        }

        private void Form_MapListBoxShow_Load(object sender, EventArgs e)
        {
            new MapListBoxInitClass().Init(MapListBox, parentForm.MyMapEditor);
        }

        private void 加入快捷放置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parentForm.加入快捷放置ToolStripMenuItem_Click(sender, e);
        }

        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            parentForm.复制ToolStripMenuItem1_Click(sender, e);
        }

        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parentForm.属性ToolStripMenuItem_Click(sender, e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parentForm.删除ToolStripMenuItem_Click(sender, e);
        }
    }
}
