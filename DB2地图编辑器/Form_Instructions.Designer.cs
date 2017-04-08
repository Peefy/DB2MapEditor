namespace DB2地图编辑器
{
    partial class Form_Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Instructions));
            this.TextBoxInstrution = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // TextBoxInstrution
            // 
            this.TextBoxInstrution.BackColor = System.Drawing.Color.DarkGreen;
            this.TextBoxInstrution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxInstrution.DownBack = null;
            this.TextBoxInstrution.Icon = null;
            this.TextBoxInstrution.IconIsButton = false;
            this.TextBoxInstrution.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBoxInstrution.IsPasswordChat = '\0';
            this.TextBoxInstrution.IsSystemPasswordChar = false;
            this.TextBoxInstrution.Lines = new string[0];
            this.TextBoxInstrution.Location = new System.Drawing.Point(4, 28);
            this.TextBoxInstrution.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxInstrution.MaxLength = 32767;
            this.TextBoxInstrution.MinimumSize = new System.Drawing.Size(28, 28);
            this.TextBoxInstrution.MouseBack = null;
            this.TextBoxInstrution.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.TextBoxInstrution.Multiline = true;
            this.TextBoxInstrution.Name = "TextBoxInstrution";
            this.TextBoxInstrution.NormlBack = null;
            this.TextBoxInstrution.Padding = new System.Windows.Forms.Padding(5);
            this.TextBoxInstrution.ReadOnly = true;
            this.TextBoxInstrution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInstrution.Size = new System.Drawing.Size(408, 374);
            // 
            // 
            // 
            this.TextBoxInstrution.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxInstrution.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxInstrution.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.TextBoxInstrution.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.TextBoxInstrution.SkinTxt.Multiline = true;
            this.TextBoxInstrution.SkinTxt.Name = "BaseText";
            this.TextBoxInstrution.SkinTxt.ReadOnly = true;
            this.TextBoxInstrution.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInstrution.SkinTxt.Size = new System.Drawing.Size(398, 364);
            this.TextBoxInstrution.SkinTxt.TabIndex = 0;
            this.TextBoxInstrution.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBoxInstrution.SkinTxt.WaterText = "";
            this.TextBoxInstrution.TabIndex = 0;
            this.TextBoxInstrution.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxInstrution.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.TextBoxInstrution.WaterText = "";
            this.TextBoxInstrution.WordWrap = true;
            // 
            // Form_Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 406);
            this.Controls.Add(this.TextBoxInstrution);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Instructions";
            this.Text = "使用说明";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox TextBoxInstrution;
    }
}