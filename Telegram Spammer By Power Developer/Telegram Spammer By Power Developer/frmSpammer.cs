using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Telegram_Spammer_By_Power_Developer
{
    public partial class frmSpammer : Form
    {
        public frmSpammer()
        {
            InitializeComponent();
        }
        //set telegram as foreground window with windows api
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr handel);
        [DllImport("User32.dll")]
        private static extern bool IsIconic(IntPtr handel);
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr handel, int nCmdShow);
        // ... Button Code for Find Path of Telegram Desktop .exe File
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetDirectoryName(ofd.FileName);
                string filename = Path.GetFileName(ofd.FileName);
                txtPath.Text = $@"{path}\{filename}";
            }
        }
        //this button Add usernames from txtUserName to lbUserNames
        private void btnAddUserName_Click(object sender, EventArgs e)
        {
            lbUserNames.Items.Add(txtUserName.Text);
            txtUserName.Clear();
            this.AcceptButton = btnAddUserName;
        }
        //this button Remove selected usernames from lbUserNames
        private void remove(ListBox lb)
        {
            ListBox.SelectedObjectCollection selected = new ListBox.SelectedObjectCollection(lb);
            selected = lb.SelectedItems;
            if (lb.SelectedIndex != -1)
            {
                for (int i = selected.Count - 1; i >= 0; i--)
                {
                    lb.Items.Remove(selected[i]);
                }
            }
        }
        private void btnRemoveUserName_Click(object sender, EventArgs e)
        {
            remove(lbUserNames);
        }
        //this button Add Messages from txtMessage to lbMessages
        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            lbMessages.Items.Add(txtMessage.Text);
            txtMessage.Clear();
            this.AcceptButton = btnAddMessage;
        }

        private void btnRemoveMessage_Click(object sender, EventArgs e)
        {
            remove(lbMessages);
        }        
        const int TIME = 100;
        //Spamming Method
        private void Posting()
        {
            foreach (string item in lbUserNames.Items)
            {
                Thread.Sleep(TIME);
                SendKeys.Send("{ESCAPE}");
                Thread.Sleep(TIME);
                SendKeys.Send("{ESCAPE}");
                Thread.Sleep(TIME);
                SendKeys.Send("{ESCAPE}");
                SendKeys.Send(item);
                Thread.Sleep(TIME);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(TIME);
                int count = (int)(nudMessagesCount.Value);
                for (int i = 0; i < count; i++)
                {
                    SendKeys.Send(txtMessage.Text);
                    SendKeys.Send("{ENTER}");
                }
                Thread.Sleep(TIME);
                foreach (string items in lbMessages.Items)
                {
                    SendKeys.Send(items);
                    SendKeys.Send("{ENTER}");
                }
            }

        }
        //Run program and start spamming
        const int SW_Restore = 9;
        private void btnRun_Click(object sender, EventArgs e)
        {
            Process RunApp = Process.Start(@txtPath.Text);
            IntPtr handel = RunApp.MainWindowHandle;
            SetForegroundWindow(handel);
            if (IsIconic(handel))
            {
                ShowWindow(handel, SW_Restore);
            }
            Posting();
        }
        //get .txt file (UserNames without "@") from double click on listbox then set the txt informations as listbox DataSource
        private void lbUserNames_DoubleClick(object sender, EventArgs e)
        {
            string FilePath = "";
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetDirectoryName(op.FileName);
                string filename = Path.GetFileName(op.FileName);
                FilePath = $@"{path}\{filename}";
            }
            StreamReader UserNameList = new StreamReader(@FilePath);
            List<string> Users = new List<string>();
            lbUserNames.DataSource = null;
            string line;
            while ((line = UserNameList.ReadLine()) != null)
            {

                Users.Add(line);

            }
            lbUserNames.DataSource = Users;
        }
        //get .txt file (Messages To send) from double click on listbox then set the txt informations as listbox DataSource
        private void lbMessages_DoubleClick(object sender, EventArgs e)
        {
            string FilePath = "";
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetDirectoryName(op.FileName);
                string filename = Path.GetFileName(op.FileName);
                FilePath = $@"{path}\{filename}";
            }
            StreamReader MessageList = new StreamReader(@FilePath);
            List<string> Users = new List<string>();
            lbMessages.DataSource = null;
            string line;
            while ((line = MessageList.ReadLine()) != null)
            {

                Users.Add(line);

            }
            lbMessages.DataSource = Users;
        }
    }
}