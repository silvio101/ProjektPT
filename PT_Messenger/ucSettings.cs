using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PT_Messenger
{
    public partial class ucSettings : UserControl
    {
        private PT_Messenger.Controlers.HelperBL helper;
        public PT_Messenger.Controlers.MessagerBL messBL;

        public event EventHandler changeAvatar;

        public ucSettings()
        {   
            this.helper = new Controlers.HelperBL();
            InitializeComponent();
        }

        public void setUserInfo(string login, string imie, string nazwisko, string email)
        {
            this.uc_textBox_login.Text = login;
            this.uc_textBox_imie.Text = imie;
            this.uc_textBox_nazwisko.Text = nazwisko;
            this.uc_textBox_email.Text = email;
        }
        public List<string> getUserInfo()
        {
            List<string> newUserInfo = new List<string>();
            newUserInfo.Add(uc_textBox_imie.Text);
            newUserInfo.Add(uc_textBox_nazwisko.Text);
            newUserInfo.Add(uc_textBox_email.Text);
            return newUserInfo;
        }
        private bool checkValidInput(System.Windows.Forms.TextBox textbox, string nieregularne)
        {
            Regex walidacjakodu = new Regex(nieregularne);
            if (walidacjakodu.Match(textbox.Text).Success) return true;
            else return false;
        }

        #region form events
        private void ucSettings_Load(object sender, EventArgs e)
        {
            this.BackColor=helper.whichColor();
            string filename = Properties.Settings.Default.avatar;
            this.uc_comboBox_skin.SelectedIndex=Properties.Settings.Default.skin;
            if(Properties.Settings.Default.avatar_path!="local")
                this.uc_pictureBox_avatar.Image = Image.FromFile(Properties.Settings.Default.avatar_path);
            else 
                this.uc_pictureBox_avatar.Image = Properties.Resources.unknown_person_100;
            this.uc_textbox_serwer.Text = Properties.Settings.Default.server;
            if (filename.Length > 0)
            {
                this.uc_label_filename.Text=filename;
            }
            else
            {
                MessageBox.Show("Nieprawidłowa nazwa avatara w pliku konfiguracyjnym"); 
            }
            
        }

        private void uc_button_zmien_Click(object sender, EventArgs e)
        {
            if(uc_openFileDialog_avatar.ShowDialog()==DialogResult.OK)
            {
                if (uc_openFileDialog_avatar.SafeFileName.Length<120)
                    uc_label_filename.Text = uc_openFileDialog_avatar.SafeFileName;
                else
                    uc_label_filename.Text = uc_openFileDialog_avatar.SafeFileName.Substring(0,120);
                //helper.changeAvatar(uc_openFileDialog_avatar.SafeFileName, uc_openFileDialog_avatar.FileName);
                Properties.Settings.Default.avatar = uc_openFileDialog_avatar.SafeFileName;
                Properties.Settings.Default.avatar_path = uc_openFileDialog_avatar.FileName;
                Properties.Settings.Default.Save();
            }
            this.uc_pictureBox_avatar.Image = Image.FromFile(Properties.Settings.Default.avatar_path);
            this.OnChangeAvatar();
            this.Invalidate();
        }

        private void ucSettings_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = helper.whichColor();
        }

        private void uc_button_usun_Click(object sender, EventArgs e)
        {
            this.uc_pictureBox_avatar.Image = Properties.Resources.unknown_person_100;
            helper.restoreDefaultAvatar();
            this.uc_label_filename.Text = helper.getAvatarName();
        }

        private void uc_comboBox_skin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.helper.changeSkin(this.uc_comboBox_skin.SelectedIndex);
            this.Invalidate();
        }

        private void uc_textbox_serwer_TextChanged(object sender, EventArgs e)
        {
            this.helper.changeServer(uc_textbox_serwer.Text);
        }

        private void uc_button_passZmien_Click(object sender, EventArgs e)
        {
            List<string> changeList = new List<string>();
            if(!uc_textBox_imie.Text.Equals(messBL.username)) 
                changeList.Add(uc_textBox_imie.Text);
            else 
                changeList.Add(messBL.username);
            if(!uc_textBox_nazwisko.Text.Equals(messBL.surname))
                changeList.Add(uc_textBox_nazwisko.Text);
            else
                changeList.Add(messBL.surname);
            if(!uc_textBox_email.Text.Equals(messBL.email))
                changeList.Add(uc_textBox_email.Text);
            else
                changeList.Add(messBL.email);
            var list = messBL.checkUserDiff(changeList);
            if(list.Count>0) 
            {
                if(messBL.setUserInfo(changeList)) 
                    MessageBox.Show("Zaaktualizowano dane poprawnie");
                else
                    MessageBox.Show("Aktualizacja niepoprawna","Problem!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                messBL.getUserInfo();
            }
            if(uc_textBox_password.Text.Equals(uc_textBox_repassword.Text)&&(!uc_textBox_password.Text.Equals(messBL.passwd)))
            {
                if(messBL.passChange(uc_textBox_password.Text))
                    MessageBox.Show("Zaaktualizowano hasło poprawnie");
                else
                    MessageBox.Show("Aktualizacja niepoprawna","Problem!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void uc_button_passclean_Click(object sender, EventArgs e)
        {
            uc_textBox_login.Text = messBL.login;
            uc_textBox_imie.Text = messBL.username;
            uc_textBox_nazwisko.Text = messBL.surname;
            uc_textBox_email.Text = messBL.email;
            uc_textBox_password.Text = String.Empty;
            uc_textBox_repassword.Text = String.Empty;
            uc_errorProvider.SetError(uc_label_potwierdzhaslo, string.Empty);
            uc_textBox_password.BackColor = System.Drawing.Color.White;
            uc_textBox_repassword.BackColor = System.Drawing.Color.White;
        }
        

        private void uc_textBox_password_Leave(object sender, EventArgs e)
        {
            if (!checkValidInput(uc_textBox_password, @"^[A-z0-9\d$@$!%*#?&]{8,}$|(^$)"))
            {
                uc_errorProvider.SetError(uc_label_nowehaslo, "Błąd w haśle\n bez spacji i minimum 8 znaków");
                uc_textBox_password.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                uc_errorProvider.SetError(uc_label_nowehaslo, string.Empty);
                uc_textBox_password.BackColor = System.Drawing.Color.White;
            }
        }

        private void uc_textBox_repassword_Leave(object sender, EventArgs e)
        {
            if (!uc_textBox_password.Text.Equals(uc_textBox_repassword.Text))
            {
                uc_errorProvider.SetError(uc_label_potwierdzhaslo, "Podane hasła się różnią");
                uc_textBox_repassword.BackColor = System.Drawing.Color.Red;
                uc_textBox_password.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                uc_errorProvider.SetError(uc_label_potwierdzhaslo, string.Empty);
                uc_textBox_repassword.BackColor = System.Drawing.Color.White;
                uc_textBox_password.BackColor = System.Drawing.Color.White;
            }
        }

        #endregion
    
        virtual protected void OnChangeAvatar()
        {
            if (changeAvatar != null)
                changeAvatar(this, EventArgs.Empty);
        }
    }
}
