namespace DB2地图编辑器
{
    partial class Form_Draft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Draft));
            this.保存草稿 = new System.Windows.Forms.Button();
            this.载入草稿 = new System.Windows.Forms.Button();
            this.显示网格 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.X坐标 = new System.Windows.Forms.Label();
            this.Y坐标 = new System.Windows.Forms.Label();
            this.保存草稿Dialog = new System.Windows.Forms.SaveFileDialog();
            this.载入草稿Dialog = new System.Windows.Forms.OpenFileDialog();
            this.全部清空 = new System.Windows.Forms.Button();
            this.TopMostEN = new System.Windows.Forms.CheckBox();
            this.btn_Grid2Draft = new System.Windows.Forms.Button();
            this.skinColorSelectPanel1 = new CCWin.SkinControl.SkinColorSelectPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myPanel1 = new MyPanel.MyPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 保存草稿
            // 
            this.保存草稿.BackColor = System.Drawing.Color.Lime;
            this.保存草稿.Location = new System.Drawing.Point(397, 327);
            this.保存草稿.Name = "保存草稿";
            this.保存草稿.Size = new System.Drawing.Size(75, 38);
            this.保存草稿.TabIndex = 0;
            this.保存草稿.Text = "保存草稿";
            this.保存草稿.UseVisualStyleBackColor = false;
            this.保存草稿.Click += new System.EventHandler(this.保存草稿_Click);
            // 
            // 载入草稿
            // 
            this.载入草稿.BackColor = System.Drawing.Color.Lime;
            this.载入草稿.Location = new System.Drawing.Point(397, 371);
            this.载入草稿.Name = "载入草稿";
            this.载入草稿.Size = new System.Drawing.Size(75, 38);
            this.载入草稿.TabIndex = 1;
            this.载入草稿.Text = "载入草稿";
            this.载入草稿.UseVisualStyleBackColor = false;
            this.载入草稿.Click += new System.EventHandler(this.载入草稿_Click);
            // 
            // 显示网格
            // 
            this.显示网格.AutoSize = true;
            this.显示网格.Checked = true;
            this.显示网格.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示网格.Location = new System.Drawing.Point(400, 259);
            this.显示网格.Name = "显示网格";
            this.显示网格.Size = new System.Drawing.Size(72, 16);
            this.显示网格.TabIndex = 2;
            this.显示网格.Text = "显示网格";
            this.显示网格.UseVisualStyleBackColor = true;
            this.显示网格.CheckedChanged += new System.EventHandler(this.显示网格_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ColorSelect";
            // 
            // X坐标
            // 
            this.X坐标.AutoSize = true;
            this.X坐标.Location = new System.Drawing.Point(398, 188);
            this.X坐标.Name = "X坐标";
            this.X坐标.Size = new System.Drawing.Size(41, 12);
            this.X坐标.TabIndex = 5;
            this.X坐标.Text = "X坐标:";
            // 
            // Y坐标
            // 
            this.Y坐标.AutoSize = true;
            this.Y坐标.Location = new System.Drawing.Point(398, 211);
            this.Y坐标.Name = "Y坐标";
            this.Y坐标.Size = new System.Drawing.Size(41, 12);
            this.Y坐标.TabIndex = 6;
            this.Y坐标.Text = "Y坐标:";
            // 
            // 全部清空
            // 
            this.全部清空.BackColor = System.Drawing.Color.Lime;
            this.全部清空.Location = new System.Drawing.Point(397, 415);
            this.全部清空.Name = "全部清空";
            this.全部清空.Size = new System.Drawing.Size(75, 35);
            this.全部清空.TabIndex = 7;
            this.全部清空.Text = "全部清空";
            this.全部清空.UseVisualStyleBackColor = false;
            this.全部清空.Click += new System.EventHandler(this.全部清空_Click);
            // 
            // TopMostEN
            // 
            this.TopMostEN.AutoSize = true;
            this.TopMostEN.Location = new System.Drawing.Point(400, 237);
            this.TopMostEN.Name = "TopMostEN";
            this.TopMostEN.Size = new System.Drawing.Size(66, 16);
            this.TopMostEN.TabIndex = 8;
            this.TopMostEN.Text = "TopMost";
            this.TopMostEN.UseVisualStyleBackColor = true;
            this.TopMostEN.CheckedChanged += new System.EventHandler(this.TopMost_CheckedChanged);
            // 
            // btn_Grid2Draft
            // 
            this.btn_Grid2Draft.BackColor = System.Drawing.Color.Lime;
            this.btn_Grid2Draft.Location = new System.Drawing.Point(397, 281);
            this.btn_Grid2Draft.Name = "btn_Grid2Draft";
            this.btn_Grid2Draft.Size = new System.Drawing.Size(75, 40);
            this.btn_Grid2Draft.TabIndex = 9;
            this.btn_Grid2Draft.Text = "缩略图\r\n转草稿\r\n";
            this.btn_Grid2Draft.UseVisualStyleBackColor = false;
            this.btn_Grid2Draft.Click += new System.EventHandler(this.btn_Grid2Draft_Click);
            // 
            // skinColorSelectPanel1
            // 
            this.skinColorSelectPanel1.Location = new System.Drawing.Point(400, 42);
            this.skinColorSelectPanel1.Name = "skinColorSelectPanel1";
            this.skinColorSelectPanel1.Size = new System.Drawing.Size(75, 70);
            this.skinColorSelectPanel1.TabIndex = 10;
            this.skinColorSelectPanel1.Text = "skinColorSelectPanel1";
            this.skinColorSelectPanel1.Click += new System.EventHandler(this.skinColorSelectPanel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(402, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // myPanel1
            // 
            this.myPanel1.Location = new System.Drawing.Point(8, 32);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(388, 418);
            this.myPanel1.TabIndex = 12;
            this.myPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel1_Paint);
            this.myPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPanel1_MouseDown);
            this.myPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myPanel1_MouseMove);
            this.myPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myPanel1_MouseUp);
            // 
            // Form_Draft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 457);
            this.Controls.Add(this.myPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skinColorSelectPanel1);
            this.Controls.Add(this.btn_Grid2Draft);
            this.Controls.Add(this.TopMostEN);
            this.Controls.Add(this.全部清空);
            this.Controls.Add(this.Y坐标);
            this.Controls.Add(this.X坐标);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.显示网格);
            this.Controls.Add(this.载入草稿);
            this.Controls.Add(this.保存草稿);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Draft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "草稿";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Draft_FormClosing);
            this.Load += new System.EventHandler(this.Form_Draft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 保存草稿;
        private System.Windows.Forms.Button 载入草稿;
        private System.Windows.Forms.CheckBox 显示网格;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label X坐标;
        private System.Windows.Forms.Label Y坐标;
        private System.Windows.Forms.SaveFileDialog 保存草稿Dialog;
        private System.Windows.Forms.OpenFileDialog 载入草稿Dialog;
        private System.Windows.Forms.Button 全部清空;
        private System.Windows.Forms.CheckBox TopMostEN;
        private System.Windows.Forms.Button btn_Grid2Draft;
        private CCWin.SkinControl.SkinColorSelectPanel skinColorSelectPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyPanel.MyPanel myPanel1;
    }
}