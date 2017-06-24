using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string database;
        private List<string> userinfo;
        
        public int counter=0;

        public frmMainUI(Controlers.MessagerBL m, frmWelcomeUI parentFrm)
        {
            this.messBL = m;
            this.parentFrm = parentFrm;
            this.database = m.database;
            InitializeComponent();
            reloadAvatar();
            
            mf_pictureBox_avatar.Controls.Add(mf_pictureBox_avatarFront);
            mf_pictureBox_avatarFront.Location=new Point(0,0);
            mf_pictureBox_avatarFront.BackColor = Color.Transparent;
            this.timer.Interval=3000;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Start();

            this.ucSettings1.changeAvatar += new EventHandler(ChangeAvatar);
            this.ucAddressBook1.addPersonToConvers += new EventHandler(AddPersonToConvers);
        }

        private void reloadAvatar()
        {
            using (var db = new LiteDatabase(this.database))
            {
                var stream = db.FileStorage.FindById("avatar");
                if (stream != null)
                {
                    using (FileStream fs = File.Create(@"tmp"))
                    {
                        stream.CopyTo(fs);
                        this.mf_pictureBox_avatar.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    this.mf_pictureBox_avatar.Image = Properties.Resources.unknown_person_100;
                }
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            //this.parentFrm.Show();
            this.messBL.disconnect();
            this.parentFrm.Dispose();
            base.OnClosed(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            userinfo = messBL.getUserInfo();
            this.ucSettings1.setUserInfo(userinfo[0],userinfo[1],userinfo[2],userinfo[3]);
            this.changeConnState();
            //this.ucMessage1.messBL = messBL;
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
            this.ucMessage1.Visible = false;
        }

        private void mf_pictureBox_message_MouseHover(object sender, EventArgs e)
        {
            this.mf_pictureBox_message.Image = Properties.Resources.message;
        }

        private void mf_pictureBox_message_MouseLeave(object sender, EventArgs e)
        {
            this.mf_pictureBox_message.Image = Properties.Resources.message_w;
        }

        private void mf_pictureBox_message_Click(object sender, System.EventArgs e)
        {
            this.ucAddressBook1.Visible = false;
            this.ucMessage1.Visible = true;
            this.ucSettings1.Visible = false;
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
            this.ucMessage1.Visible = false;
        }

        private void mf_toolStripStatusLabel_polaczony_Click(object sender, EventArgs e)
        {

        }
        private void mf_pictureBox_avatarFront_Click(object sender, EventArgs e)
        {
           this.Close();
           parentFrm.Show();
           
        /*  counter++;
            if (counter % 2 == 0)
            {
                parentFrm.Hide();
                
            }
            else
            {
                parentFrm.Show();
            }
         */ 
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
            reloadAvatar();   
            mf_pictureBox_avatar.Controls.Add(mf_pictureBox_avatarFront);
            mf_pictureBox_avatarFront.Location = new Point(0, 0);
            mf_pictureBox_avatarFront.BackColor = Color.Transparent;
        }
        private void AddPersonToConvers(object sender, EventArgs e)
        {
            var tmpAB = (ucAddressBook)sender;
            this.ucAddressBook1.Visible = false;
            this.ucMessage1.Visible = true;
            this.ucMessage1.addPersonToConvers(tmpAB.activeContact);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.ucAddressBook1.setAktUser(this.messBL.howManyActUser());
            this.ucMessage1.anyNewMsg(this.messBL.anyNewMsg());

        }



        
    }
}
