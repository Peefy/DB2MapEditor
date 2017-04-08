using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MyPanel
{
    public partial class MyPanel: UserControl
    {
        public MyPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            MouseRightDownMenu = new ContextMenuStrip();
        }

        public ContextMenuStrip MouseRightDownMenu;

    }
}
