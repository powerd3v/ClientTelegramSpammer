using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Telegram_Spammer_By_Power_Developer
{
    public class ChangeFormClass
    {
        public void FormShow(Form f, Panel p)
        {
            p.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            p.Controls.Add(f);
            f.Show();
        }
    }
}
