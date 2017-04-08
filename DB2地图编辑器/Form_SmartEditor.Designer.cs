namespace DB2地图编辑器
{
    partial class Form_SmartEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SmartEditor));
            this.生成编辑 = new System.Windows.Forms.Button();
            this.全部清空 = new System.Windows.Forms.Button();
            this.label草地 = new System.Windows.Forms.Label();
            this.label死地 = new System.Windows.Forms.Label();
            this.label水面 = new System.Windows.Forms.Label();
            this.label岩浆 = new System.Windows.Forms.Label();
            this.草地Color = new System.Windows.Forms.PictureBox();
            this.死地Color = new System.Windows.Forms.PictureBox();
            this.水面Color = new System.Windows.Forms.PictureBox();
            this.岩浆Color = new System.Windows.Forms.PictureBox();
            this.显示网格 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.选择颜色 = new System.Windows.Forms.ColorDialog();
            this.X坐标 = new System.Windows.Forms.Label();
            this.Y坐标 = new System.Windows.Forms.Label();
            this.label_山顶 = new System.Windows.Forms.Label();
            this.山顶Color = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myPanel1 = new MyPanel.MyPanel();
            ((System.ComponentModel.ISupportInitialize)(this.草地Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.死地Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.水面Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.岩浆Color)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.山顶Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // 生成编辑
            // 
            this.生成编辑.Location = new System.Drawing.Point(480, 411);
            this.生成编辑.Name = "生成编辑";
            this.生成编辑.Size = new System.Drawing.Size(75, 23);
            this.生成编辑.TabIndex = 1;
            this.生成编辑.Text = "生成编辑";
            this.生成编辑.UseVisualStyleBackColor = true;
            this.生成编辑.Click += new System.EventHandler(this.生成编辑_Click);
            // 
            // 全部清空
            // 
            this.全部清空.Location = new System.Drawing.Point(480, 382);
            this.全部清空.Name = "全部清空";
            this.全部清空.Size = new System.Drawing.Size(75, 23);
            this.全部清空.TabIndex = 2;
            this.全部清空.Text = "全部清空";
            this.全部清空.UseVisualStyleBackColor = true;
            this.全部清空.Click += new System.EventHandler(this.全部清空_Click);
            // 
            // label草地
            // 
            this.label草地.AutoSize = true;
            this.label草地.Location = new System.Drawing.Point(483, 55);
            this.label草地.Name = "label草地";
            this.label草地.Size = new System.Drawing.Size(53, 12);
            this.label草地.TabIndex = 5;
            this.label草地.Text = "水面颜色";
            // 
            // label死地
            // 
            this.label死地.AutoSize = true;
            this.label死地.Location = new System.Drawing.Point(483, 74);
            this.label死地.Name = "label死地";
            this.label死地.Size = new System.Drawing.Size(53, 12);
            this.label死地.TabIndex = 5;
            this.label死地.Text = "岩浆颜色";
            // 
            // label水面
            // 
            this.label水面.AutoSize = true;
            this.label水面.Location = new System.Drawing.Point(483, 93);
            this.label水面.Name = "label水面";
            this.label水面.Size = new System.Drawing.Size(53, 12);
            this.label水面.TabIndex = 5;
            this.label水面.Text = "冰面颜色";
            // 
            // label岩浆
            // 
            this.label岩浆.AutoSize = true;
            this.label岩浆.Location = new System.Drawing.Point(483, 112);
            this.label岩浆.Name = "label岩浆";
            this.label岩浆.Size = new System.Drawing.Size(53, 12);
            this.label岩浆.TabIndex = 5;
            this.label岩浆.Text = "宇宙颜色";
            // 
            // 草地Color
            // 
            this.草地Color.BackColor = System.Drawing.Color.Cyan;
            this.草地Color.Location = new System.Drawing.Point(542, 54);
            this.草地Color.Name = "草地Color";
            this.草地Color.Size = new System.Drawing.Size(13, 13);
            this.草地Color.TabIndex = 6;
            this.草地Color.TabStop = false;
            this.草地Color.Tag = "0";
            this.草地Color.Click += new System.EventHandler(this.ColorSel_Click);
            // 
            // 死地Color
            // 
            this.死地Color.BackColor = System.Drawing.Color.Red;
            this.死地Color.Location = new System.Drawing.Point(542, 74);
            this.死地Color.Name = "死地Color";
            this.死地Color.Size = new System.Drawing.Size(13, 13);
            this.死地Color.TabIndex = 6;
            this.死地Color.TabStop = false;
            this.死地Color.Tag = "1";
            this.死地Color.Click += new System.EventHandler(this.ColorSel_Click);
            // 
            // 水面Color
            // 
            this.水面Color.BackColor = System.Drawing.Color.DarkCyan;
            this.水面Color.Location = new System.Drawing.Point(542, 93);
            this.水面Color.Name = "水面Color";
            this.水面Color.Size = new System.Drawing.Size(13, 13);
            this.水面Color.TabIndex = 6;
            this.水面Color.TabStop = false;
            this.水面Color.Tag = "2";
            this.水面Color.Click += new System.EventHandler(this.ColorSel_Click);
            // 
            // 岩浆Color
            // 
            this.岩浆Color.BackColor = System.Drawing.Color.SlateGray;
            this.岩浆Color.Location = new System.Drawing.Point(542, 112);
            this.岩浆Color.Name = "岩浆Color";
            this.岩浆Color.Size = new System.Drawing.Size(13, 13);
            this.岩浆Color.TabIndex = 6;
            this.岩浆Color.TabStop = false;
            this.岩浆Color.Tag = "3";
            this.岩浆Color.Click += new System.EventHandler(this.ColorSel_Click);
            // 
            // 显示网格
            // 
            this.显示网格.AutoSize = true;
            this.显示网格.Checked = true;
            this.显示网格.CheckState = System.Windows.Forms.CheckState.Checked;
            this.显示网格.Location = new System.Drawing.Point(483, 170);
            this.显示网格.Name = "显示网格";
            this.显示网格.Size = new System.Drawing.Size(72, 16);
            this.显示网格.TabIndex = 7;
            this.显示网格.Text = "显示网格";
            this.显示网格.UseVisualStyleBackColor = true;
            this.显示网格.CheckedChanged += new System.EventHandler(this.显示网格_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(483, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(72, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 116);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 16);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.Tag = "5";
            this.radioButton6.Text = "画公路";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.SelColorChange);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 97);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 16);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Tag = "5";
            this.radioButton5.Text = "画山顶";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.SelColorChange);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 78);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 16);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "画宇宙";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.SelColorChange);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 16);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "画冰面";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.SelColorChange);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "画岩浆";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.SelColorChange);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "画水面";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.SelColorChange);
            // 
            // 选择颜色
            // 
            this.选择颜色.AnyColor = true;
            // 
            // X坐标
            // 
            this.X坐标.AutoSize = true;
            this.X坐标.Location = new System.Drawing.Point(340, 428);
            this.X坐标.Name = "X坐标";
            this.X坐标.Size = new System.Drawing.Size(41, 12);
            this.X坐标.TabIndex = 9;
            this.X坐标.Text = "X坐标:";
            // 
            // Y坐标
            // 
            this.Y坐标.AutoSize = true;
            this.Y坐标.Location = new System.Drawing.Point(406, 428);
            this.Y坐标.Name = "Y坐标";
            this.Y坐标.Size = new System.Drawing.Size(47, 12);
            this.Y坐标.TabIndex = 9;
            this.Y坐标.Text = "Y坐标：";
            // 
            // label_山顶
            // 
            this.label_山顶.AutoSize = true;
            this.label_山顶.Location = new System.Drawing.Point(483, 131);
            this.label_山顶.Name = "label_山顶";
            this.label_山顶.Size = new System.Drawing.Size(53, 12);
            this.label_山顶.TabIndex = 5;
            this.label_山顶.Text = "山顶颜色";
            // 
            // 山顶Color
            // 
            this.山顶Color.BackColor = System.Drawing.Color.Maroon;
            this.山顶Color.Location = new System.Drawing.Point(542, 131);
            this.山顶Color.Name = "山顶Color";
            this.山顶Color.Size = new System.Drawing.Size(13, 13);
            this.山顶Color.TabIndex = 6;
            this.山顶Color.TabStop = false;
            this.山顶Color.Tag = "3";
            this.山顶Color.Click += new System.EventHandler(this.ColorSel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "公路颜色";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(542, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(13, 13);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "3";
            this.pictureBox1.Click += new System.EventHandler(this.ColorSel_Click);
            // 
            // myPanel1
            // 
            this.myPanel1.Location = new System.Drawing.Point(20, 37);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(442, 378);
            this.myPanel1.TabIndex = 10;
            // 
            // Form_SmartEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 460);
            this.Controls.Add(this.myPanel1);
            this.Controls.Add(this.Y坐标);
            this.Controls.Add(this.X坐标);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.显示网格);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.山顶Color);
            this.Controls.Add(this.岩浆Color);
            this.Controls.Add(this.水面Color);
            this.Controls.Add(this.死地Color);
            this.Controls.Add(this.草地Color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_山顶);
            this.Controls.Add(this.label岩浆);
            this.Controls.Add(this.label水面);
            this.Controls.Add(this.label死地);
            this.Controls.Add(this.label草地);
            this.Controls.Add(this.全部清空);
            this.Controls.Add(this.生成编辑);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_SmartEditor";
            this.Text = "智能编辑";
            this.Load += new System.EventHandler(this.Form_SmartEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.草地Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.死地Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.水面Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.岩浆Color)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.山顶Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 生成编辑;
        private System.Windows.Forms.Button 全部清空;
        private System.Windows.Forms.Label label草地;
        private System.Windows.Forms.Label label死地;
        private System.Windows.Forms.Label label水面;
        private System.Windows.Forms.Label label岩浆;
        private System.Windows.Forms.PictureBox 草地Color;
        private System.Windows.Forms.PictureBox 死地Color;
        private System.Windows.Forms.PictureBox 水面Color;
        private System.Windows.Forms.PictureBox 岩浆Color;
        private System.Windows.Forms.CheckBox 显示网格;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ColorDialog 选择颜色;
        private System.Windows.Forms.Label X坐标;
        private System.Windows.Forms.Label Y坐标;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label_山顶;
        private System.Windows.Forms.PictureBox 山顶Color;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyPanel.MyPanel myPanel1;
    }
}