namespace DB2地图编辑器
{
    partial class Form_MapListBoxShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_SmartPasteNum = new System.Windows.Forms.Label();
            this.MapListBox = new CCWin.SkinControl.ChatListBox();
            this.MapListBoxItemMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.加入快捷放置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteBox = new System.Windows.Forms.PictureBox();
            this.SmartPasteBox = new System.Windows.Forms.PictureBox();
            this.MapListBoxItemMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartPasteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "智能粘贴板";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "粘贴板";
            // 
            // label_SmartPasteNum
            // 
            this.label_SmartPasteNum.AutoSize = true;
            this.label_SmartPasteNum.Location = new System.Drawing.Point(7, 594);
            this.label_SmartPasteNum.Name = "label_SmartPasteNum";
            this.label_SmartPasteNum.Size = new System.Drawing.Size(0, 12);
            this.label_SmartPasteNum.TabIndex = 17;
            // 
            // MapListBox
            // 
            this.MapListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MapListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MapListBox.ForeColor = System.Drawing.Color.Black;
            this.MapListBox.FriendsMobile = true;
            this.MapListBox.ListSubItemMenu = this.MapListBoxItemMenu;
            this.MapListBox.Location = new System.Drawing.Point(14, 3);
            this.MapListBox.Name = "MapListBox";
            this.MapListBox.ScrollArrowBackColor = System.Drawing.Color.Gainsboro;
            this.MapListBox.SelectSubItem = null;
            this.MapListBox.Size = new System.Drawing.Size(241, 477);
            this.MapListBox.SubItemMenu = this.MapListBoxItemMenu;
            this.MapListBox.TabIndex = 18;
            this.MapListBox.ClickSubItem += new CCWin.SkinControl.ChatListBox.ChatListClickEventHandler(this.MapListBox_ClickSubItem);
            // 
            // MapListBoxItemMenu
            // 
            this.MapListBoxItemMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入快捷放置ToolStripMenuItem,
            this.复制ToolStripMenuItem1,
            this.属性ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.MapListBoxItemMenu.Name = "MapListBoxItemMenu";
            this.MapListBoxItemMenu.Size = new System.Drawing.Size(149, 92);
            // 
            // 加入快捷放置ToolStripMenuItem
            // 
            this.加入快捷放置ToolStripMenuItem.Name = "加入快捷放置ToolStripMenuItem";
            this.加入快捷放置ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.加入快捷放置ToolStripMenuItem.Text = "加入快捷放置";
            this.加入快捷放置ToolStripMenuItem.Click += new System.EventHandler(this.加入快捷放置ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem1
            // 
            this.复制ToolStripMenuItem1.Name = "复制ToolStripMenuItem1";
            this.复制ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.复制ToolStripMenuItem1.Text = "复制";
            this.复制ToolStripMenuItem1.Click += new System.EventHandler(this.复制ToolStripMenuItem1_Click);
            // 
            // 属性ToolStripMenuItem
            // 
            this.属性ToolStripMenuItem.Name = "属性ToolStripMenuItem";
            this.属性ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.属性ToolStripMenuItem.Text = "属性";
            this.属性ToolStripMenuItem.Click += new System.EventHandler(this.属性ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // PasteBox
            // 
            this.PasteBox.Location = new System.Drawing.Point(9, 503);
            this.PasteBox.Name = "PasteBox";
            this.PasteBox.Size = new System.Drawing.Size(60, 60);
            this.PasteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasteBox.TabIndex = 13;
            this.PasteBox.TabStop = false;
            // 
            // SmartPasteBox
            // 
            this.SmartPasteBox.Location = new System.Drawing.Point(75, 502);
            this.SmartPasteBox.Name = "SmartPasteBox";
            this.SmartPasteBox.Size = new System.Drawing.Size(60, 60);
            this.SmartPasteBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SmartPasteBox.TabIndex = 14;
            this.SmartPasteBox.TabStop = false;
            // 
            // Form_MapListBoxShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 665);
            this.ControlBox = false;
            this.Controls.Add(this.MapListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SmartPasteNum);
            this.Controls.Add(this.PasteBox);
            this.Controls.Add(this.SmartPasteBox);
            this.Name = "Form_MapListBoxShow";
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form_MapListBoxShow_Load);
            this.MapListBoxItemMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartPasteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label_SmartPasteNum;
        public System.Windows.Forms.PictureBox PasteBox;
        public System.Windows.Forms.PictureBox SmartPasteBox;
        public CCWin.SkinControl.ChatListBox MapListBox;
        private System.Windows.Forms.ContextMenuStrip MapListBoxItemMenu;
        private System.Windows.Forms.ToolStripMenuItem 加入快捷放置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}