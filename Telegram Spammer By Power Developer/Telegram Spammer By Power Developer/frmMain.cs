using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;

namespace Telegram_Spammer_By_Power_Developer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        ChangeFormClass form = new ChangeFormClass();
        //drag form code with windows api
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //Drag Form By Top Pannel Code
        private void pnlDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            //Drag and drop
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        //Exit Button Code
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimize Button Code
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //by click on this picturebox program refreshed then show main form
        private void picShowMainForm_Click(object sender, EventArgs e)
        {
            frmSpammer frm = new frmSpammer();
            form.FormShow(frm, pnlChangeForm);
        }
        //show tutorial use this tool from Youtube please Don't forget to like and subscribe 
        private void btnShowTutorial_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://youtu.be/1ixFKbfU2BU");
        }
        //show form About me and how to contact with me
        private void btnAboutME_Click(object sender, EventArgs e)
        {
            frmAboutME frm = new frmAboutME();
            form.FormShow(frm, pnlChangeForm);
        }
        //open spammer form in pannel while main form is loading
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmSpammer frm = new frmSpammer();
            form.FormShow(frm, pnlChangeForm);
        }
    }
}
