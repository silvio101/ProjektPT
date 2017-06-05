using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMessenger
{
    public partial class frmMainUI : Form
    {
        public frmMainUI()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Image = Properties.Resources.Connect_15;
            this.toolStripStatusLabel1.Text = "Połączony";
        }

        private void pictureBox_settings_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox_settings.Image = Properties.Resources.settings;
        }

        private void pictureBox_settings_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox_settings.Image = Properties.Resources.settings_w1;
        }

        private void pictureBox_settings_Click(object sender, EventArgs e)
        {
            this.ucSettings1.Visible = true;
        }
    }
}
