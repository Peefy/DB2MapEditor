namespace DB2地图编辑器
{
    partial class Form_MapIdHexShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MapIdHexShow));
            this.labelMapIdShow = new CCWin.SkinControl.SkinLabel();
            this.labelMapId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMapIdShow
            // 
            this.labelMapIdShow.AutoSize = true;
            this.labelMapIdShow.BackColor = System.Drawing.Color.Transparent;
            this.labelMapIdShow.BorderColor = System.Drawing.Color.White;
            this.labelMapIdShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMapIdShow.Location = new System.Drawing.Point(34, 35);
            this.labelMapIdShow.Name = "labelMapIdShow";
            this.labelMapIdShow.Size = new System.Drawing.Size(0, 17);
            this.labelMapIdShow.TabIndex = 0;
            // 
            // labelMapId
            // 
            this.labelMapId.AutoSize = true;
            this.labelMapId.Location = new System.Drawing.Point(28, 35);
            this.labelMapId.Name = "labelMapId";
            this.labelMapId.Size = new System.Drawing.Size(0, 12);
            this.labelMapId.TabIndex = 1;
            // 
            // Form_MapIdHexShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 549);
            this.Controls.Add(this.labelMapId);
            this.Controls.Add(this.labelMapIdShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MapIdHexShow";
            this.Text = "地图十六进制代码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel labelMapIdShow;
        private System.Windows.Forms.Label labelMapId;
    }
}