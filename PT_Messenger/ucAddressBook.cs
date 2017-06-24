using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

using PT_Messenger.Controlers;

namespace PT_Messenger
{
    public partial class ucAddressBook : UserControl
    {
        public List<Person> result {get;set;}
        public string activeContact { get;set; } 
        public MessagerBL messBL { get;set; }
        public event EventHandler addPersonToConvers;

        private int activeCell;
        private string database;
        private HelperBL helper;
        
        public ucAddressBook()
        {
            helper = new HelperBL();
            this.activeContact = String.Empty;
            InitializeComponent();
        }

        private void cleanSearchForm()
        {
            this.uc2_tab2_textBox_login.Text=String.Empty;
            this.uc2_tab2_textBox_imie.Text=String.Empty;
            this.uc2_tab2_textBox_nazwisko.Text=String.Empty;
            this.uc2_tab2_textBox_email.Text=String.Empty;
        }
        private List<Person> getPersonFromDB()
        {
            List<Person> r = new List<Person>();
            using (var db = new LiteDatabase(database))
            {
                var persons = db.GetCollection<Person>("persons");
                r = persons.FindAll().ToList();
            }
            return r;
        }
        private Person getPersonFromDB(string login)
        {
            Person r = new Person();
            using (var db = new LiteDatabase(database))
            {
                var persons = db.GetCollection<Person>("persons");
                r = persons.Find(x=>x.login == login).First();
            }
            return r;
        }
        private void removePersonFromDB(string login)
        {
            using (var db = new LiteDatabase(database))
            {
                var persons = db.GetCollection<Person>("persons");
                persons.Delete(x=>x.login == login);
            }
        }
        public void setAktUser(int ile)
        {
            this.uc2_label_aktUser_view.Text = ile.ToString();
        }

        private void ucAddressBook_Load(object sender, EventArgs e)
        {
            this.database = this.messBL.database;
            this.uc2_tab_label_imie_view.Text=String.Empty;
            this.uc2_tab_label_login_view.Text = String.Empty;
            this.uc2_tab_label_nazwisko_view.Text = String.Empty;
            this.uc2_tab_label_email_view.Text = String.Empty;
            this.uc2_label_aktUser_view.Text = String.Empty;
            foreach (var a in getPersonFromDB())
            {
                var contact = new TreeNode(a.login);
                uc2_treeView_kontakty.Nodes.Add(contact);
            }
        }

        private void ucAddressBook_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = helper.whichColor();
        }

        private void uc2_tab2_button_czysc_Click(object sender, EventArgs e)
        {
            this.cleanSearchForm();
        }

        private void uc2_tab2_button_szukaj_Click(object sender, EventArgs e)
        {   
            Person who = new Person();
            who.login = uc2_tab2_textBox_login.Text;
            who.username = uc2_tab2_textBox_imie.Text;
            who.surname= uc2_tab2_textBox_nazwisko.Text;
            who.email = uc2_tab2_textBox_email.Text;
            result = messBL.searchPerson(who);
            var bList = new BindingList<Person>(result);
            var source = new BindingSource(bList, null);
            this.uc2_tab2_dataGridView.DataSource=source;
            this.uc2_tab2_dataGridView.Columns[0].HeaderText="Login";
            this.uc2_tab2_dataGridView.Columns[1].HeaderText = "Imie";
            this.uc2_tab2_dataGridView.Columns[2].HeaderText = "Nazwisko";
            this.uc2_tab2_dataGridView.Columns[3].HeaderText = "E-Mail";
            this.uc2_tab2_dataGridView.Visible=true;
            this.uc2_tab2_button_dodajKs.Visible = true;
            this.uc2_tab2_dataGridView.Refresh();



        }

        private void uc2_tab2_button_dodajKs_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDatabase(database))
            {
                var persons = db.GetCollection<Person>("persons");
                var p = new Person
                {
                    login=result[activeCell].login,
                    username = result[activeCell].username,
                    surname = result[activeCell].surname,
                    email = result[activeCell].email
                };
                var r = persons.Find(x=>x.login==p.login).Count();
                if(r>0) MessageBox.Show("Kontakt już istnieje w książce","Problem!");
                else 
                {
                    persons.Insert(p);
                    this.uc2_treeView_kontakty.Nodes.Add(new TreeNode(p.login));
                    //MessageBox.Show("Dodano nowy kontakt: "+p.login.ToString());
                    this.uc2_tabControl.SelectTab(0);
                }
            }
        }

        private void uc2_tab2_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.uc2_tab2_button_dodajKs.Enabled=true;
            this.activeCell = uc2_tab2_dataGridView.CurrentCell.RowIndex;
        }

        private void uc2_treeView_kontakty_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.uc2_tab_button_usun.Enabled = true;
            this.uc2_tab_button_start.Enabled = true;
            this.activeContact = uc2_treeView_kontakty.SelectedNode.Text;
            var person = getPersonFromDB(e.Node.Text);
            uc2_tab_label_login_view.Text = person.login;
            uc2_tab_label_imie_view.Text = person.username;
            uc2_tab_label_nazwisko_view.Text = person.surname;
            uc2_tab_label_email_view.Text = person.email;
        }

        private void uc2_tab_button_usun_Click(object sender, EventArgs e)
        {
            if(this.uc2_treeView_kontakty.SelectedNode.Index>-1)
            {
                removePersonFromDB(this.uc2_treeView_kontakty.SelectedNode.Text);
                this.uc2_treeView_kontakty.SelectedNode.Remove();
            }
        }

        private void uc2_tabPage_szukaj_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = helper.whichColor();
        }

        private void uc2_tab_button_start_Click(object sender, EventArgs e)
        {
            if(this.uc2_treeView_kontakty.SelectedNode.Index>-1)
            {
                OnAddPersonToConvers();
            }
            
        }

        protected void OnAddPersonToConvers()
        {
            if(addPersonToConvers!=null)
                addPersonToConvers(this,EventArgs.Empty);
        }


    }
}
