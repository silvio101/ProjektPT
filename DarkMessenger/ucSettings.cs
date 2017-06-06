using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMessenger
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();

        }

        private void ucSettings_Load(object sender, EventArgs e)
        {
            String filename = Properties.Settings.Default.avatar;
            int skin=Properties.Settings.Default.skin;
            if (filename.Length > 0)
            {
                this.uc_label_filename.Text=filename;
            }
            else
            {
                MessageBox.Show("Nieprawidłowa nazwa avatara w pliku konfiguracyjnym"); 
            }
            this.uc_comboBox_skin.SelectedIndex=skin;
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
                MessageBox.Show("Problem z zapisem wyglądu do pliku konfiguracyjnego");
            }
            
        }


    }
}
