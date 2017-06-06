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
            mf_pictureBox_avatar.Controls.Add(mf_pictureBox_avatarFront);
            mf_pictureBox_avatarFront.Location=new Point(0,0);
            mf_pictureBox_avatarFront.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.mf_toolStripStatusLabel_polaczony.Image = Properties.Resources.Connect_15;
            this.mf_toolStripStatusLabel_polaczony.Text = "Połączony";
        }

        private void pictureBox_settings_MouseHover(object sender, EventArgs e)
        {
            this.mf_pictureBox_settings.Image = Properties.Resources.settings;
        }

        private void pictureBox_settings_MouseLeave(object sender, EventArgs e)
        {
            this.mf_pictureBox_settings.Image = Properties.Resources.settings_w1;
        }

        private void pictureBox_settings_Click(object sender, EventArgs e)
        {
            this.ucSettings1.Visible = true;
            this.ucAddressBook1.Visible=false;
        }

        private void mf_pictureBox_avatar_Click(object sender, EventArgs e)
        {

        }

        private void mf_pictureBox_message_MouseHover(object sender, EventArgs e)
        {
            this.mf_pictureBox_message.Image = Properties.Resources.message;
        }

        private void mf_pictureBox_message_MouseLeave(object sender, EventArgs e)
        {
            this.mf_pictureBox_message.Image = Properties.Resources.message_w;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            this.mf_pictureBox_contacts.Image = Properties.Resources.book;
        }

        private void mf_pictureBox_contacts_MouseLeave(object sender, EventArgs e)
        {
            this.mf_pictureBox_contacts.Image = Properties.Resources.book_w;
        }

        private void mf_pictureBox_contacts_Click(object sender, EventArgs e)
        {
            this.ucAddressBook1.Visible=true;
            this.ucSettings1.Visible=false;
        }
        
    }
}
