﻿using System;
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
            uc_textbox_serwer.Text = System.Drawing.SystemColors.MenuHighlight.R.ToString() + " " + System.Drawing.SystemColors.MenuHighlight.G.ToString() + " " +System.Drawing.SystemColors.MenuHighlight.B.ToString();
        }


    }
}
