using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Messenger
{
    public partial class frmWelcomeUI : Form
    {
        private Controlers.MessagerBL messBL;
        public frmWelcomeUI()
        {
            InitializeComponent();
            messBL = new Controlers.MessagerBL();
            messBL.Connected += new EventHandler(Connected);
            messBL.Disconnect += new EventHandler(Disconnect);
            messBL.LoginOK += new EventHandler(LoginOK);
            messBL.LoginNOK += new EventHandler(LoginNOK);
            messBL.RegOK += new EventHandler(RegistryOK);
            messBL.Login_exist += new EventHandler(LoginExist);

            this.frm2_timer.Interval = 2000;
            this.frm2_timer.Tick+= new EventHandler(timer_Tick);
            this.frm2_timer.Start();
        }

        private bool checkValidInput(System.Windows.Forms.TextBox textbox, String nieregularne)
        {
            Regex walidacjakodu = new Regex(nieregularne);
            if (walidacjakodu.Match(textbox.Text).Success) return true;
            else return false;
        }

        private void clearRegForm()
        {
            this.frm2_p3_textBox_login.Text = string.Empty;
            this.frm2_p3_textBox_imie.Text = string.Empty;
            this.frm2_p3_textBox_nazwisko.Text = string.Empty;
            this.frm2_p3_textBox_haslo.Text = string.Empty;
            this.frm2_p3_textBox_rehaslo.Text = string.Empty;
            this.frm2_p3_textBox_email.Text = string.Empty;
        }
        private void cleanLogForm()
        {
            this.frm2_p2_textBox_login.Text = string.Empty;
            this.frm2_p2_textBox_haslo.Text = string.Empty;
        }

        private bool validateP3Form()
        {
            if(this.frm2_p3_textBox_login.Text == string.Empty) return false;
            if(this.frm2_p3_textBox_imie.Text == string.Empty) return false;
            if(this.frm2_p3_textBox_nazwisko.Text == string.Empty) return false;
            if(this.frm2_p3_textBox_haslo.Text == string.Empty) return false;
            if(this.frm2_p3_textBox_rehaslo.Text == string.Empty) return false;
            if(this.frm2_p3_textBox_email.Text == string.Empty) return false;
            return true;
        }

        private bool validateP2LogIn()
        {
            if(this.frm2_p2_textBox_login.Text==string.Empty) return false;
            if(this.frm2_p2_textBox_haslo.Text==string.Empty) return false;
            return true;
        }

        #region form events
        private void uc3_button_zaloguj_Click(object sender, EventArgs e)
        {
            this.frm2_panel3.Hide();
            this.frm2_panel2.Show();
            this.frm2_panel1.Hide();
        }

        private void uc4_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.frm2_panel3.Hide();
            this.frm2_panel2.Hide();
            this.frm2_panel1.Show();
        }

        private void frm2_pictureBox_back_MouseHover(object sender, EventArgs e)
        {
            this.frm2_p2_pictureBox_back.Image = Properties.Resources.back_b;
        }

        private void frm2_pictureBox_back_MouseLeave(object sender, EventArgs e)
        {
            this.frm2_p2_pictureBox_back.Image = Properties.Resources.back_w;
        }

        private void frm2_pictureBox_fwd_MouseHover(object sender, EventArgs e)
        {
            this.frm2_p2_pictureBox_fwd.Image = Properties.Resources.back_b2;
        }

        private void frm2_pictureBox_fwd_MouseLeave(object sender, EventArgs e)
        {
            this.frm2_p2_pictureBox_fwd.Image = Properties.Resources.back_w2;
        }

        private void frm2_pictureBox_fwd_Click(object sender, EventArgs e)
        {
            if (validateP2LogIn())
            {
                String login, pass;
                login = this.frm2_p2_textBox_login.Text;
                pass = this.frm2_p2_textBox_haslo.Text;
                messBL.Login(login,pass);
                
            }
            else
            {
                MessageBox.Show("Nie podano prawidłowych danych logowania");
            }
            
        }

        private void frm2_p3_textBox_imie_Leave(object sender, EventArgs e)
        {
            if (!checkValidInput(frm2_p3_textBox_imie, "^[A-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+$|(^$)"))
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_imie,"Błąd w imieniu\n bez spacji i cyfr");
                frm2_p3_textBox_imie.BackColor = System.Drawing.Color.Red;
            }
            else 
            {   
                frm2_p3_errorProvider.SetError(frm2_p3_label_imie,string.Empty);
                frm2_p3_textBox_imie.BackColor = System.Drawing.Color.White;
            }
        }

        private void frm2_p1_button_zarejestruj_Click(object sender, EventArgs e)
        {
            this.frm2_panel3.Show();
            this.frm2_panel2.Hide();
            this.frm2_panel1.Hide();
        }

        private void frm2_p3_pictureBox_back_MouseHover(object sender, EventArgs e)
        {
            this.frm2_p3_pictureBox_back.Image = Properties.Resources.back_b;
        }

        private void frm2_p3_pictureBox_back_MouseLeave(object sender, EventArgs e)
        {
            this.frm2_p3_pictureBox_back.Image = Properties.Resources.back_w;
        }

        private void frm2_p3_pictureBox_back_Click(object sender, EventArgs e)
        {
            this.frm2_panel3.Hide();
            this.frm2_panel2.Hide();
            this.frm2_panel1.Show();
            clearRegForm();
        }

        private void frm2_p3_textBox_nazwisko_Leave(object sender, EventArgs e)
        {
            if (!checkValidInput(frm2_p3_textBox_nazwisko, @"^[A-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+$|^[A-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+\-[A-zżźćńółęąśŻŹĆĄŚĘŁÓŃ]+$|(^$)"))
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_nazwisko, "Błąd w nazwisku\n bez spacji i cyfr");
                frm2_p3_textBox_nazwisko.BackColor = System.Drawing.Color.Red;
            }
            else 
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_nazwisko, string.Empty);
                frm2_p3_textBox_nazwisko.BackColor = System.Drawing.Color.White;
            }
        }

        private void frm2_p3_textBox_login_Leave(object sender, EventArgs e)
        {
            if (!checkValidInput(frm2_p3_textBox_login, @"^[A-z0-9]+$|(^$)"))
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_login, "Błąd w loginie\n bez spacji i znaków specjalnych");
                frm2_p3_textBox_login.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_login, string.Empty);
                frm2_p3_textBox_login.BackColor = System.Drawing.Color.White;
            }
        }

        private void frm2_p3_textBox_haslo_Leave(object sender, EventArgs e)
        {
            if (!checkValidInput(frm2_p3_textBox_haslo, @"^[A-z0-9\d$@$!%*#?&]{8,}$|(^$)"))
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_haslo, "Błąd w haśle\n bez spacji i minimum 8 znaków");
                frm2_p3_textBox_haslo.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_haslo, string.Empty);
                frm2_p3_textBox_haslo.BackColor = System.Drawing.Color.White;
            }
        }

        private void frm2_p3_textBox_rehaslo_Leave(object sender, EventArgs e)
        {
            if(!frm2_p3_textBox_haslo.Text.Equals(frm2_p3_textBox_rehaslo.Text))
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_rehaslo,"Podane hasła się różnią");
                frm2_p3_textBox_rehaslo.BackColor = System.Drawing.Color.Red;
                frm2_p3_textBox_haslo.BackColor = System.Drawing.Color.Red;
            }
            else
            {
               frm2_p3_errorProvider.SetError(frm2_p3_label_rehaslo,string.Empty);
               frm2_p3_textBox_rehaslo.BackColor = System.Drawing.Color.White;
               frm2_p3_textBox_haslo.BackColor = System.Drawing.Color.White;
            }
        }

        private void frm2_p3_textBox_email_Leave(object sender, EventArgs e)
        {
            if (!checkValidInput(frm2_p3_textBox_email, @"([a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)|(^$)"))
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_email, "Email nieprawidłowy");
                frm2_p3_textBox_email.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                frm2_p3_errorProvider.SetError(frm2_p3_label_email, string.Empty);
                frm2_p3_textBox_email.BackColor = System.Drawing.Color.White;
            }
        }

        private void frm2_p3_button_zarejestruj_Click(object sender, EventArgs e)
        {
            if (validateP3Form())
            {
                String login, pass, name, surname, email;
                login = this.frm2_p3_textBox_login.Text;
                pass = this.frm2_p3_textBox_haslo.Text;
                name = this.frm2_p3_textBox_imie.Text;
                surname = this.frm2_p3_textBox_nazwisko.Text;
                email = this.frm2_p3_textBox_email.Text;
                messBL.Registry(login, pass, name, surname, email);
            }
            else
            {
                MessageBox.Show("Nie podanno wszystkich wartości");
            }
        }
        private void frm2_p2_textBox_haslo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                frm2_pictureBox_fwd_Click(this, EventArgs.Empty);
        }


        #endregion


        #region events
        private void Connected(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate{
                this.Text = "PT Messenger - Welcome (Connected)";
                this.frm2_p1_button_zaloguj.Enabled = true;
                this.frm2_p1_button_zarejestruj.Enabled = true;
                //this.frm2_timer.Interval = 2000;
                this.frm2_timer.Stop();
                this.frm2_p2_label_serwernie.Visible = false;
            }));   
        }
        private void Disconnect(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate{
                this.Text = "PT Messenger - Welcome (Disconnented)";
                this.frm2_p1_button_zaloguj.Enabled = false;
                this.frm2_p1_button_zarejestruj.Enabled = false;
                this.frm2_timer.Interval = 1000;
                this.frm2_p2_label_serwernie.Visible = true;
            }));
        }
        private void LoginOK(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate{
                this.Hide();
                frmMainUI mainFrame = new frmMainUI(messBL,this);
                mainFrame.ShowDialog(this);
                
            }));
        }
        private void LoginNOK(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate{
                MessageBox.Show("Logowanie nieprawidłowe");
                this.cleanLogForm();
            }));
        }
        private void RegistryOK(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate{
                this.frm2_panel3.Hide();
                this.frm2_panel2.Show();
                this.clearRegForm();
            }));
        }
        private void LoginExist(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate{
                this.frm2_p2_errorProvider.SetError(frm2_p3_label_login,"Login jest już zajęty");
                this.frm2_p3_textBox_login.BackColor = System.Drawing.Color.Red;
            }));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            messBL.connect();
        }
        #endregion
        
    }
}
