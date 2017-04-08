using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    public partial class Form_Splash : CCWin.CCSkinMain
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {
            labelVersion.Text = "Version:V0.X";
        }
    }
}
