using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Telegram_Spammer_By_Power_Developer
{
    public partial class frmAboutME : Form
    {
        public frmAboutME()
        {
            InitializeComponent();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/powerd3v");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.youtube.com/channel/UCUIKmutC5g9c5YgSKomV_SA");
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://instagram.com/power_developer");
        }

        private void btnTelegram_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://t.me/PowerDeveloper");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Email is:\npowerd3v@gmail.com","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
