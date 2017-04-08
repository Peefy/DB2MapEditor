namespace DB2地图编辑器
{
    partial class Form_Property
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
            this.btnOk = new CCWin.SkinControl.SkinButton();
            this.picBoxImg = new System.Windows.Forms.PictureBox();
            this.label_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOk.DownBack = null;
            this.btnOk.Location = new System.Drawing.Point(163, 416);
            this.btnOk.MouseBack = null;
            this.btnOk.Name = "btnOk";
            this.btnOk.NormlBack = null;
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // picBoxImg
            // 
            this.picBoxImg.Location = new System.Drawing.Point(13, 35);
            this.picBoxImg.Name = "picBoxImg";
            this.picBoxImg.Size = new System.Drawing.Size(100, 97);
            this.picBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxImg.TabIndex = 1;
            this.picBoxImg.TabStop = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(13, 220);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(29, 12);
            this.label_id.TabIndex = 2;
            this.label_id.Text = "Bin:";
            // 
            // Form_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 472);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.picBoxImg);
            this.Controls.Add(this.btnOk);
            this.Name = "Form_Property";
            this.Text = "Form_Property";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnOk;
        private System.Windows.Forms.PictureBox picBoxImg;
        private System.Windows.Forms.Label label_id;
    }
}