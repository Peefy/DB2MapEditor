namespace DB2地图编辑器
{
    partial class Form_Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Message));
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.刷新信息 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nmUD_CtrlfMapId = new System.Windows.Forms.NumericUpDown();
            this.btn_CtrlFLost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_CtrlfMapId)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.InfoBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoBox.Location = new System.Drawing.Point(-3, 26);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ReadOnly = true;
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoBox.Size = new System.Drawing.Size(529, 264);
            this.InfoBox.TabIndex = 0;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(438, 294);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(85, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "下个检索快";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Next_MouseDown);
            this.Next.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Next_MouseUp);
            // 
            // 刷新信息
            // 
            this.刷新信息.Location = new System.Drawing.Point(275, 295);
            this.刷新信息.Name = "刷新信息";
            this.刷新信息.Size = new System.Drawing.Size(75, 23);
            this.刷新信息.TabIndex = 2;
            this.刷新信息.Text = "刷新信息";
            this.刷新信息.UseVisualStyleBackColor = true;
            this.刷新信息.Click += new System.EventHandler(this.刷新信息_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "检索地图块代码";
            // 
            // nmUD_CtrlfMapId
            // 
            this.nmUD_CtrlfMapId.Location = new System.Drawing.Point(185, 295);
            this.nmUD_CtrlfMapId.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmUD_CtrlfMapId.Name = "nmUD_CtrlfMapId";
            this.nmUD_CtrlfMapId.Size = new System.Drawing.Size(84, 21);
            this.nmUD_CtrlfMapId.TabIndex = 4;
            this.nmUD_CtrlfMapId.ValueChanged += new System.EventHandler(this.nmUD_CtrlfMapId_ValueChanged);
            // 
            // btn_CtrlFLost
            // 
            this.btn_CtrlFLost.Location = new System.Drawing.Point(356, 295);
            this.btn_CtrlFLost.Name = "btn_CtrlFLost";
            this.btn_CtrlFLost.Size = new System.Drawing.Size(75, 23);
            this.btn_CtrlFLost.TabIndex = 2;
            this.btn_CtrlFLost.Text = "检索红叉";
            this.btn_CtrlFLost.UseVisualStyleBackColor = true;
            this.btn_CtrlFLost.Click += new System.EventHandler(this.btn_CtrlFLost_Click);
            // 
            // Form_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 321);
            this.Controls.Add(this.nmUD_CtrlfMapId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CtrlFLost);
            this.Controls.Add(this.刷新信息);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.InfoBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Message";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "检索信息";
            this.Load += new System.EventHandler(this.Form_Message_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_Message_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_CtrlfMapId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoBox;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button 刷新信息;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmUD_CtrlfMapId;
        private System.Windows.Forms.Button btn_CtrlFLost;

    }
}