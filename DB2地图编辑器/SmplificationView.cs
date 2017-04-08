using CCWin.SkinControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2地图编辑器
{
    class SmplificationView
    {
        private Size bigsize = new Size(1070, 700);
        private Size smallsize = new Size(810, 700);
        public SmplificationView() { }
        public Size ChangeFormSize(bool _check,
            CCWin.SkinControl.ChatListBox control,
            ChatListBox.ChatListClickEventHandler fuc,
                        KeyEventHandler keydownfuc,
            KeyEventHandler keyupfuc,
            PreviewKeyDownEventHandler keyprefuc,
            Form_Main mainForm)
        {
            CreateRelevantForm(_check, control, fuc, keydownfuc, keyupfuc, keyprefuc,mainForm);
            return (_check == false) ? bigsize : smallsize;

        }

        private void CreateRelevantForm(bool _check,
            CCWin.SkinControl.ChatListBox control,
            ChatListBox.ChatListClickEventHandler fuc,
                        KeyEventHandler keydownfuc,
            KeyEventHandler keyupfuc,
            PreviewKeyDownEventHandler keyprefuc,
            Form_Main mainform)
        {
            if (_check == true)
            {
                //Form_MapListBoxShow Form_Temp =
                //    new Form_MapListBoxShow(mainform);
                //Form_Temp.Show();
            }
            else
            {

            }
        }
    }
}
