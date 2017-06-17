using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Messenger
{
    public partial class ucSettings : UserControl
    {
        private PT_Messenger.contolers.HelperBL helper;
        public ucSettings()
        {   
            helper = new contolers.HelperBL();
            InitializeComponent();
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {
            this.BackColor=helper.whichColor();
            String filename = Properties.Settings.Default.avatar;
            this.uc_comboBox_skin.SelectedIndex=Properties.Settings.Default.skin;
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

        private void uc_label_filename_Click(object sender, EventArgs e)
        {

        }

        private void uc_button_zmien_Click(object sender, EventArgs e)
        {

        }

        private void uc_button_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void uc_button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.skin = this.uc_comboBox_skin.SelectedIndex;
                Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Problem z zapisem wyglądu do pliku konfiguracyjnego", "Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Invalidate();
            
        }

        private void ucSettings_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = helper.whichColor();
        }

        private void uc_button_usun_Click(object sender, EventArgs e)
        {
            try
            {
                this.uc_pictureBox_avatar.Image = Properties.Resources.unknown_person_100;
                Properties.Settings.Default.avatar = "unknown_person_100";
                Properties.Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Nie można zmienić avatar'a, prawdopodobny błąd zapisu pliku konfiguracyjnego","Problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
