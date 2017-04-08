namespace DB2地图编辑器
{
    partial class Form_Grid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Grid));
            this.PaintTimer = new System.Windows.Forms.Timer(this.components);
            this.checkboxIsGameGrid = new CCWin.SkinControl.SkinCheckBox();
            this.checkboxIsLines = new CCWin.SkinControl.SkinCheckBox();
            this.checkboxShowKuang = new CCWin.SkinControl.SkinCheckBox();
            this.labelXpoint = new CCWin.SkinControl.SkinLabel();
            this.labelYpoint = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // PaintTimer
            // 
            this.PaintTimer.Enabled = true;
            this.PaintTimer.Interval = 250;
            this.PaintTimer.Tick += new System.EventHandler(this.PaintTimer_Tick);
            // 
            // checkboxIsGameGrid
            // 
            this.checkboxIsGameGrid.AutoSize = true;
            this.checkboxIsGameGrid.BackColor = System.Drawing.Color.Transparent;
            this.checkboxIsGameGrid.Checked = true;
            this.checkboxIsGameGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxIsGameGrid.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.checkboxIsGameGrid.DownBack = null;
            this.checkboxIsGameGrid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkboxIsGameGrid.Location = new System.Drawing.Point(20, 396);
            this.checkboxIsGameGrid.MouseBack = null;
            this.checkboxIsGameGrid.Name = "checkboxIsGameGrid";
            this.checkboxIsGameGrid.NormlBack = null;
            this.checkboxIsGameGrid.SelectedDownBack = null;
            this.checkboxIsGameGrid.SelectedMouseBack = null;
            this.checkboxIsGameGrid.SelectedNormlBack = null;
            this.checkboxIsGameGrid.Size = new System.Drawing.Size(87, 21);
            this.checkboxIsGameGrid.TabIndex = 0;
            this.checkboxIsGameGrid.Text = "游戏缩略图";
            this.checkboxIsGameGrid.UseVisualStyleBackColor = false;
            this.checkboxIsGameGrid.CheckedChanged += new System.EventHandler(this.checkboxIsGameGrid_CheckedChanged);
            // 
            // checkboxIsLines
            // 
            this.checkboxIsLines.AutoSize = true;
            this.checkboxIsLines.BackColor = System.Drawing.Color.Transparent;
            this.checkboxIsLines.Checked = true;
            this.checkboxIsLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxIsLines.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.checkboxIsLines.DownBack = null;
            this.checkboxIsLines.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkboxIsLines.Location = new System.Drawing.Point(110, 396);
            this.checkboxIsLines.MouseBack = null;
            this.checkboxIsLines.Name = "checkboxIsLines";
            this.checkboxIsLines.NormlBack = null;
            this.checkboxIsLines.SelectedDownBack = null;
            this.checkboxIsLines.SelectedMouseBack = null;
            this.checkboxIsLines.SelectedNormlBack = null;
            this.checkboxIsLines.Size = new System.Drawing.Size(87, 21);
            this.checkboxIsLines.TabIndex = 0;
            this.checkboxIsLines.Text = "显示网格线";
            this.checkboxIsLines.UseVisualStyleBackColor = false;
            this.checkboxIsLines.CheckedChanged += new System.EventHandler(this.checkboxIsLines_CheckedChanged);
            // 
            // checkboxShowKuang
            // 
            this.checkboxShowKuang.AutoSize = true;
            this.checkboxShowKuang.BackColor = System.Drawing.Color.Transparent;
            this.checkboxShowKuang.Checked = true;
            this.checkboxShowKuang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxShowKuang.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.checkboxShowKuang.DownBack = null;
            this.checkboxShowKuang.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkboxShowKuang.Location = new System.Drawing.Point(201, 396);
            this.checkboxShowKuang.MouseBack = null;
            this.checkboxShowKuang.Name = "checkboxShowKuang";
            this.checkboxShowKuang.NormlBack = null;
            this.checkboxShowKuang.SelectedDownBack = null;
            this.checkboxShowKuang.SelectedMouseBack = null;
            this.checkboxShowKuang.SelectedNormlBack = null;
            this.checkboxShowKuang.Size = new System.Drawing.Size(87, 21);
            this.checkboxShowKuang.TabIndex = 0;
            this.checkboxShowKuang.Text = "显示范围框";
            this.checkboxShowKuang.UseVisualStyleBackColor = false;
            this.checkboxShowKuang.CheckedChanged += new System.EventHandler(this.checkboxShowKuang_CheckedChanged);
            // 
            // labelXpoint
            // 
            this.labelXpoint.AutoSize = true;
            this.labelXpoint.BackColor = System.Drawing.Color.Transparent;
            this.labelXpoint.BorderColor = System.Drawing.Color.White;
            this.labelXpoint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelXpoint.Location = new System.Drawing.Point(22, 416);
            this.labelXpoint.Name = "labelXpoint";
            this.labelXpoint.Size = new System.Drawing.Size(43, 17);
            this.labelXpoint.TabIndex = 1;
            this.labelXpoint.Text = "X坐标:";
            // 
            // labelYpoint
            // 
            this.labelYpoint.AutoSize = true;
            this.labelYpoint.BackColor = System.Drawing.Color.Transparent;
            this.labelYpoint.BorderColor = System.Drawing.Color.White;
            this.labelYpoint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelYpoint.Location = new System.Drawing.Point(154, 416);
            this.labelYpoint.Name = "labelYpoint";
            this.labelYpoint.Size = new System.Drawing.Size(42, 17);
            this.labelYpoint.TabIndex = 1;
            this.labelYpoint.Text = "Y坐标:";
            // 
            // Form_Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 438);
            this.Controls.Add(this.labelYpoint);
            this.Controls.Add(this.labelXpoint);
            this.Controls.Add(this.checkboxShowKuang);
            this.Controls.Add(this.checkboxIsLines);
            this.Controls.Add(this.checkboxIsGameGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Grid";
            this.Text = "缩略图";
            this.Load += new System.EventHandler(this.Form_Grid_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Grid_Paint);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form_Grid_MouseDoubleClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Grid_MouseMove);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form_Grid_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer PaintTimer;
        private CCWin.SkinControl.SkinCheckBox checkboxIsGameGrid;
        private CCWin.SkinControl.SkinCheckBox checkboxIsLines;
        private CCWin.SkinControl.SkinCheckBox checkboxShowKuang;
        private CCWin.SkinControl.SkinLabel labelXpoint;
        private CCWin.SkinControl.SkinLabel labelYpoint;
    }
}