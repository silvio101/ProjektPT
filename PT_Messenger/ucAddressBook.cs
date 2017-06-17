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
    public partial class ucAddressBook : UserControl
    {
        private PT_Messenger.contolers.HelperBL helper;
        public ucAddressBook()
        {
            helper = new contolers.HelperBL();
            InitializeComponent();
            label1.Text=System.Drawing.SystemColors.MenuHighlight.R+" "+System.Drawing.SystemColors.MenuHighlight.G+" "+System.Drawing.SystemColors.MenuHighlight.B+" "+System.Drawing.SystemColors.MenuHighlight.A+" "+System.Drawing.SystemColors.MenuHighlight.GetHashCode();
        }

        private void ucAddressBook_Load(object sender, EventArgs e)
        {
            this.BackColor=helper.whichColor();
        }

        private void ucAddressBook_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = helper.whichColor();
        }
    }
}
