using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Messenger
{
    public partial class frmMainUI : Form
    {
        public Controlers.MessagerBL messBL { get;set;}
        public frmWelcomeUI parentFrm;

        private List<string> userinfo;
        
        public int counter=0;

        public frmMainUI(Controlers.MessagerBL m, frmWelcomeUI parentFrm)
        {
            this.messBL = m;
            this.parentFrm = parentFrm;
            InitializeComponent();
            if(PT_Messenger.Properties.Settings.Default.avatar_path!="local") mf_pictureBox_avatar.Image = Image.FromFile(Properties.Settings.Default.avatar_path);
            mf_pictureBox_avatar.Controls.Add(mf_pictureBox_avatarFront);
            mf_pictureBox_avatarFront.Location=new Point(0,0);
            mf_pictureBox_avatarFront.BackColor = Color.Transparent;

            this.ucSettings1.changeAvatar += new EventHandler(ChangeAvatar);
        }
        protected override void OnClosed(EventArgs e)
        {
            //this.parentFrm.Show();
            this.parentFrm.Dispose();
            base.OnClosed(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            userinfo = messBL.getUserInfo();
            this.ucSettings1.setUserInfo(userinfo[0],userinfo[1],userinfo[2],userinfo[3]);
            this.changeConnState();
            this.ucAddressBook1.messBL = messBL;
            this.ucSettings1.messBL = messBL;
            base.OnLoad(e);
        }

        #region formevents

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

        private void mf_toolStripStatusLabel_polaczony_Click(object sender, EventArgs e)
        {
            //TODO wznowienie połącznia
            //mssBL = new Controlers.MessagerBL("silvio","trojan1");
        }
        private void mf_pictureBox_avatarFront_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter % 2 == 0)
            {
                parentFrm.Hide();
            }
            else
            {
                parentFrm.Show();
            }
        }
        #endregion

        public void changeConnState()
        {
            if (messBL.isConnect)
            {
                this.mf_toolStripStatusLabel_polaczony.Image = Properties.Resources.Connect_15;
                this.mf_toolStripStatusLabel_polaczony.Text = "Połączony";
            }
            else
            {
                this.mf_toolStripStatusLabel_polaczony.Image = Properties.Resources.Disconnect_15;
                this.mf_toolStripStatusLabel_polaczony.Text = "Rozłączony";
            }
            
        }

        private void ChangeAvatar(object sender, EventArgs e)
        {
            if (PT_Messenger.Properties.Settings.Default.avatar_path != "local") mf_pictureBox_avatar.Image = Image.FromFile(Properties.Settings.Default.avatar_path);
            mf_pictureBox_avatar.Controls.Add(mf_pictureBox_avatarFront);
            mf_pictureBox_avatarFront.Location = new Point(0, 0);
            mf_pictureBox_avatarFront.BackColor = Color.Transparent;
        }
        
    }
}
