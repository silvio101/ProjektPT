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
        private DarkMessenger.contolers.DarkBL helper;
        public ucSettings()
        {   
            helper = new contolers.DarkBL();
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
                MessageBox.Show("Problem z zapisem wyglądu do pliku konfiguracyjnego");
            }
            this.Invalidate();
            
        }

        private void ucSettings_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = helper.whichColor();
        }


    }
}
