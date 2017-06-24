using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Messenger.Controlers;
using LiteDB;
using System.Collections;

namespace PT_Messenger
{
    
    public partial class ucMessage : UserControl
    {
        public MessagerBL messBL;

        private string database;
        private HelperBL helper;
        private string activeConvers;
        private frmMainUI parent;
        
        public ucMessage(frmMainUI p)
        {
            this.parent = p;
            this.messBL = parent.messBL;
            helper = new HelperBL();
            InitializeComponent();
        }
        public void addPersonToConvers(string _login)
        {
            using (var db = new LiteDatabase(database))
            {
                var conv = db.GetCollection<Convers>("conv");
                var c = new Convers
                {
                    dst_login = _login,
                    src_login = this.messBL.login,
                    texts = "Rozpocząłeś konwersacje",
                    date = DateTime.Now
                };
                var count = conv.Find(x=>x.dst_login == c.dst_login).Count();
                if(count==0)
                {
                    conv.Insert(c);
                    var tmp = new ListViewItem(_login,2);
                    tmp.StateImageIndex = 2;
                    this.uc3_listView_ostatnie.Items.Add(tmp);
                    this.uc3_textBox_konwersacjeZ.Clear();
                    this.uc3_textBox_konwersacjeZ.AppendText(c.texts);
                    this.uc3_textBox_konwersacjeZ.Invalidate();
                    //messBL.checkClientsStatus();
                }   
                else
                    MessageBox.Show("Rozmawiales juz z "+_login);
            }
        }
        public void getConversersFromDB()
        {
            List<Convers> rez = new List<Convers>();
            using (var db = new LiteDatabase(database))
            {
                var conv = db.GetCollection<Convers>("conv");
                rez = conv.FindAll().GroupBy(x=>x.dst_login).Select(g=>g.First()).ToList();
                            
            }
            foreach(var v in rez)
            {
                if (v.dst_login == this.messBL.login) continue;
                var tmp = new ListViewItem(v.dst_login, 2);
                tmp.StateImageIndex = 2;
                this.uc3_listView_ostatnie.Items.Add(tmp);
            }
        }
        public List<Convers> getConvers(string _login)
        {
            List<Convers> rez = new List<Convers>();
            using (var db = new LiteDatabase(database))
            {
                var conv = db.GetCollection<Convers>("conv");
                rez = conv.Find(x=>x.src_login == _login || x.dst_login == _login ).ToList();
                rez.Sort();
            }
            return rez;
        }
        public void newMessageView(Convers c)
        {
            this.uc3_textBox_konwersacjeZ.AppendText(Environment.NewLine + c.date + " " + c.src_login + " napisał: ");
            this.uc3_textBox_konwersacjeZ.AppendText(Environment.NewLine);
            this.uc3_textBox_konwersacjeZ.AppendText(c.texts);
            this.uc3_textBox_konwersacjeZ.AppendText(Environment.NewLine);
            this.uc3_textBox_konwersacjeZ.Invalidate();
            
        }
        public void newMessage(Convers c)
        {
            using (var db = new LiteDatabase(database))
            {
                var conv = db.GetCollection<Convers>("conv");
                conv.Insert(c);
            }
            newMessageView(c);
        }
        public void anyNewMsg(List<Convers> cL)
        {
            if(cL==null)
                return;
            foreach(var v in cL)
            {
                newMessage(v);
                var tmp = new ListViewItem(v.src_login, 2);
                tmp.StateImageIndex = 2;
                if(this.uc3_listView_ostatnie.FindItemWithText(v.src_login)==null)
                    uc3_listView_ostatnie.Items.Add(tmp);
            }


            this.uc3_pictureBox_message.Visible = true;
            this.uc3_label_infonewmess.Text = "Dostałeś nowych" + Environment.NewLine +cL.Count+" wiadomości";
            //MessageBox.Show("Dostałeś "+cL.Count+" nowych wiadomości");
        }


        private void ucMessage_Load(object sender, EventArgs e)
        {
            this.database = this.messBL.database;
            getConversersFromDB();
        }
        private void ucMessage_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = helper.whichColor();
        }
        private void uc3_button_wyczysc_Click(object sender, EventArgs e)
        {
            this.uc3_textBox_wiadomosc.Clear();
            using (var db = new LiteDatabase(database))
            {
                var conv = db.GetCollection<Convers>("conv");
                conv.Delete(x=>1==1);
            }
            this.Invalidate();
        }

        private void uc3_textBox_wiadomosc_TextChanged(object sender, EventArgs e)
        {
            if(this.uc3_textBox_wiadomosc.Text!=String.Empty)
                this.uc3_button_wyslij.Enabled = true;
            else
                this.uc3_button_wyslij.Enabled = false;
        }

        private void uc3_button_wyslij_Click(object sender, EventArgs e)
        {
            Convers c = new Convers();
            c.src_login = this.messBL.login;
            c.texts = uc3_textBox_wiadomosc.Text;
            c.date = DateTime.Now;
            if(activeConvers!=null)
            {
                c.dst_login=activeConvers;
                var msg_succ=messBL.msgSend(c.dst_login,c.texts);
                if(msg_succ)
                {
                    this.newMessage(c);
                }
                else
                {
                    MessageBox.Show("Nie mogłem dostarczyć wiadomości, spróbuj ponownie","Błąd");
                }
            }
            else
            {
                MessageBox.Show("Musisz podać odbiorcę wiadomości przez kliknięcie na jego imie", "Brak nadawcy");
            }
            this.uc3_textBox_wiadomosc.Clear();
        }
        private void uc3_listView_ostatnie_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.uc3_listView_ostatnie.SelectedItems.Count > 0)
            {
                var item = this.uc3_listView_ostatnie.SelectedItems[0];
                this.activeConvers = item.Text;
                this.uc3_label_konwersacjaZ.Text="Konwersacja z "+this.activeConvers;
                this.uc3_textBox_konwersacjeZ.Clear();
                var list = this.getConvers(activeConvers);
                foreach(var v in list)
                {
                    newMessageView(v);
                }
            }
        }

        private void uc3_textBox_konwersacjeZ_TextChanged(object sender, EventArgs e)
        {
            this.uc3_textBox_konwersacjeZ.SelectionStart=this.uc3_textBox_konwersacjeZ.Text.Length;
            this.uc3_textBox_konwersacjeZ.ScrollToCaret();
        }

        private void uc3_listView_ostatnie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.uc3_pictureBox_message.Visible=false;
            this.uc3_label_infonewmess.Visible=false;
        }

        private void uc3_pictureBox_message_MouseHover(object sender, EventArgs e)
        {
            this.uc3_label_infonewmess.Visible=true;
            
        }

        private void uc3_pictureBox_message_MouseLeave(object sender, EventArgs e)
        {
            this.uc3_label_infonewmess.Visible = false;
        }

    }
}
