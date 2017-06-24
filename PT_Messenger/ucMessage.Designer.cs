namespace PT_Messenger
{
    partial class ucMessage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMessage));
            this.uc3_label_komunikator = new System.Windows.Forms.Label();
            this.uc3_listView_ostatnie = new System.Windows.Forms.ListView();
            this.uc3_imageList = new System.Windows.Forms.ImageList(this.components);
            this.uc3_label_ostatnieKonw = new System.Windows.Forms.Label();
            this.uc3_label_konwersacjaZ = new System.Windows.Forms.Label();
            this.uc3_textBox_wiadomosc = new System.Windows.Forms.TextBox();
            this.uc3_button_wyslij = new System.Windows.Forms.Button();
            this.uc3_button_wyczysc = new System.Windows.Forms.Button();
            this.uc3_groupBox_wiadomosc = new System.Windows.Forms.GroupBox();
            this.uc3_textBox_konwersacjeZ = new System.Windows.Forms.RichTextBox();
            this.uc3_pictureBox_message = new System.Windows.Forms.PictureBox();
            this.uc3_label_infonewmess = new System.Windows.Forms.Label();
            this.uc3_groupBox_wiadomosc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc3_pictureBox_message)).BeginInit();
            this.SuspendLayout();
            // 
            // uc3_label_komunikator
            // 
            this.uc3_label_komunikator.AutoSize = true;
            this.uc3_label_komunikator.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc3_label_komunikator.Location = new System.Drawing.Point(198, 14);
            this.uc3_label_komunikator.Name = "uc3_label_komunikator";
            this.uc3_label_komunikator.Size = new System.Drawing.Size(130, 22);
            this.uc3_label_komunikator.TabIndex = 7;
            this.uc3_label_komunikator.Text = "Komunikator";
            // 
            // uc3_listView_ostatnie
            // 
            this.uc3_listView_ostatnie.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.uc3_listView_ostatnie.AllowColumnReorder = true;
            this.uc3_listView_ostatnie.AutoArrange = false;
            this.uc3_listView_ostatnie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc3_listView_ostatnie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc3_listView_ostatnie.FullRowSelect = true;
            this.uc3_listView_ostatnie.GridLines = true;
            this.uc3_listView_ostatnie.Location = new System.Drawing.Point(17, 69);
            this.uc3_listView_ostatnie.Name = "uc3_listView_ostatnie";
            this.uc3_listView_ostatnie.Size = new System.Drawing.Size(178, 325);
            this.uc3_listView_ostatnie.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.uc3_listView_ostatnie.StateImageList = this.uc3_imageList;
            this.uc3_listView_ostatnie.TabIndex = 0;
            this.uc3_listView_ostatnie.TileSize = new System.Drawing.Size(146, 10);
            this.uc3_listView_ostatnie.UseCompatibleStateImageBehavior = false;
            this.uc3_listView_ostatnie.View = System.Windows.Forms.View.SmallIcon;
            this.uc3_listView_ostatnie.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.uc3_listView_ostatnie_ItemSelectionChanged);
            this.uc3_listView_ostatnie.SelectedIndexChanged += new System.EventHandler(this.uc3_listView_ostatnie_SelectedIndexChanged);
            // 
            // uc3_imageList
            // 
            this.uc3_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("uc3_imageList.ImageStream")));
            this.uc3_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.uc3_imageList.Images.SetKeyName(0, "bullet_ball_green.png");
            this.uc3_imageList.Images.SetKeyName(1, "bullet_ball_red.png");
            this.uc3_imageList.Images.SetKeyName(2, "bullet_ball_grey.png");
            // 
            // uc3_label_ostatnieKonw
            // 
            this.uc3_label_ostatnieKonw.AutoSize = true;
            this.uc3_label_ostatnieKonw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc3_label_ostatnieKonw.Location = new System.Drawing.Point(34, 48);
            this.uc3_label_ostatnieKonw.Name = "uc3_label_ostatnieKonw";
            this.uc3_label_ostatnieKonw.Size = new System.Drawing.Size(146, 15);
            this.uc3_label_ostatnieKonw.TabIndex = 9;
            this.uc3_label_ostatnieKonw.Text = "Ostatnie Konwersacje";
            // 
            // uc3_label_konwersacjaZ
            // 
            this.uc3_label_konwersacjaZ.AutoSize = true;
            this.uc3_label_konwersacjaZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc3_label_konwersacjaZ.Location = new System.Drawing.Point(217, 48);
            this.uc3_label_konwersacjaZ.Name = "uc3_label_konwersacjaZ";
            this.uc3_label_konwersacjaZ.Size = new System.Drawing.Size(104, 15);
            this.uc3_label_konwersacjaZ.TabIndex = 11;
            this.uc3_label_konwersacjaZ.Text = "Konwersacja z ";
            // 
            // uc3_textBox_wiadomosc
            // 
            this.uc3_textBox_wiadomosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uc3_textBox_wiadomosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc3_textBox_wiadomosc.Location = new System.Drawing.Point(14, 19);
            this.uc3_textBox_wiadomosc.Multiline = true;
            this.uc3_textBox_wiadomosc.Name = "uc3_textBox_wiadomosc";
            this.uc3_textBox_wiadomosc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.uc3_textBox_wiadomosc.Size = new System.Drawing.Size(232, 81);
            this.uc3_textBox_wiadomosc.TabIndex = 2;
            this.uc3_textBox_wiadomosc.TextChanged += new System.EventHandler(this.uc3_textBox_wiadomosc_TextChanged);
            // 
            // uc3_button_wyslij
            // 
            this.uc3_button_wyslij.Enabled = false;
            this.uc3_button_wyslij.Location = new System.Drawing.Point(257, 28);
            this.uc3_button_wyslij.Name = "uc3_button_wyslij";
            this.uc3_button_wyslij.Size = new System.Drawing.Size(75, 23);
            this.uc3_button_wyslij.TabIndex = 3;
            this.uc3_button_wyslij.Text = "Wyślij";
            this.uc3_button_wyslij.UseVisualStyleBackColor = true;
            this.uc3_button_wyslij.Click += new System.EventHandler(this.uc3_button_wyslij_Click);
            // 
            // uc3_button_wyczysc
            // 
            this.uc3_button_wyczysc.Location = new System.Drawing.Point(257, 67);
            this.uc3_button_wyczysc.Name = "uc3_button_wyczysc";
            this.uc3_button_wyczysc.Size = new System.Drawing.Size(75, 23);
            this.uc3_button_wyczysc.TabIndex = 4;
            this.uc3_button_wyczysc.Text = "Wyczyść";
            this.uc3_button_wyczysc.UseVisualStyleBackColor = true;
            this.uc3_button_wyczysc.Click += new System.EventHandler(this.uc3_button_wyczysc_Click);
            // 
            // uc3_groupBox_wiadomosc
            // 
            this.uc3_groupBox_wiadomosc.Controls.Add(this.uc3_textBox_wiadomosc);
            this.uc3_groupBox_wiadomosc.Controls.Add(this.uc3_button_wyczysc);
            this.uc3_groupBox_wiadomosc.Controls.Add(this.uc3_button_wyslij);
            this.uc3_groupBox_wiadomosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc3_groupBox_wiadomosc.Location = new System.Drawing.Point(201, 286);
            this.uc3_groupBox_wiadomosc.Name = "uc3_groupBox_wiadomosc";
            this.uc3_groupBox_wiadomosc.Size = new System.Drawing.Size(352, 108);
            this.uc3_groupBox_wiadomosc.TabIndex = 12;
            this.uc3_groupBox_wiadomosc.TabStop = false;
            this.uc3_groupBox_wiadomosc.Text = "Wiadomość";
            // 
            // uc3_textBox_konwersacjeZ
            // 
            this.uc3_textBox_konwersacjeZ.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc3_textBox_konwersacjeZ.Location = new System.Drawing.Point(202, 69);
            this.uc3_textBox_konwersacjeZ.Name = "uc3_textBox_konwersacjeZ";
            this.uc3_textBox_konwersacjeZ.ReadOnly = true;
            this.uc3_textBox_konwersacjeZ.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.uc3_textBox_konwersacjeZ.ShowSelectionMargin = true;
            this.uc3_textBox_konwersacjeZ.Size = new System.Drawing.Size(351, 211);
            this.uc3_textBox_konwersacjeZ.TabIndex = 1;
            this.uc3_textBox_konwersacjeZ.Text = "";
            this.uc3_textBox_konwersacjeZ.TextChanged += new System.EventHandler(this.uc3_textBox_konwersacjeZ_TextChanged);
            // 
            // uc3_pictureBox_message
            // 
            this.uc3_pictureBox_message.Image = global::PT_Messenger.Properties.Resources.post_32;
            this.uc3_pictureBox_message.Location = new System.Drawing.Point(500, 7);
            this.uc3_pictureBox_message.Name = "uc3_pictureBox_message";
            this.uc3_pictureBox_message.Size = new System.Drawing.Size(33, 32);
            this.uc3_pictureBox_message.TabIndex = 13;
            this.uc3_pictureBox_message.TabStop = false;
            this.uc3_pictureBox_message.Visible = false;
            this.uc3_pictureBox_message.Click += new System.EventHandler(this.pictureBox1_Click);
            this.uc3_pictureBox_message.MouseLeave += new System.EventHandler(this.uc3_pictureBox_message_MouseLeave);
            this.uc3_pictureBox_message.MouseHover += new System.EventHandler(this.uc3_pictureBox_message_MouseHover);
            // 
            // uc3_label_infonewmess
            // 
            this.uc3_label_infonewmess.AutoSize = true;
            this.uc3_label_infonewmess.Location = new System.Drawing.Point(440, 39);
            this.uc3_label_infonewmess.Name = "uc3_label_infonewmess";
            this.uc3_label_infonewmess.Size = new System.Drawing.Size(29, 13);
            this.uc3_label_infonewmess.TabIndex = 14;
            this.uc3_label_infonewmess.Text = "label";
            this.uc3_label_infonewmess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uc3_label_infonewmess.Visible = false;
            // 
            // ucMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.uc3_pictureBox_message);
            this.Controls.Add(this.uc3_textBox_konwersacjeZ);
            this.Controls.Add(this.uc3_groupBox_wiadomosc);
            this.Controls.Add(this.uc3_label_konwersacjaZ);
            this.Controls.Add(this.uc3_label_ostatnieKonw);
            this.Controls.Add(this.uc3_listView_ostatnie);
            this.Controls.Add(this.uc3_label_komunikator);
            this.Controls.Add(this.uc3_label_infonewmess);
            this.Name = "ucMessage";
            this.Size = new System.Drawing.Size(570, 410);
            this.Load += new System.EventHandler(this.ucMessage_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucMessage_Paint);
            this.uc3_groupBox_wiadomosc.ResumeLayout(false);
            this.uc3_groupBox_wiadomosc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc3_pictureBox_message)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uc3_label_komunikator;
        private System.Windows.Forms.ListView uc3_listView_ostatnie;
        private System.Windows.Forms.Label uc3_label_ostatnieKonw;
        private System.Windows.Forms.Label uc3_label_konwersacjaZ;
        private System.Windows.Forms.TextBox uc3_textBox_wiadomosc;
        private System.Windows.Forms.Button uc3_button_wyslij;
        private System.Windows.Forms.Button uc3_button_wyczysc;
        private System.Windows.Forms.GroupBox uc3_groupBox_wiadomosc;
        private System.Windows.Forms.ImageList uc3_imageList;
        private System.Windows.Forms.RichTextBox uc3_textBox_konwersacjeZ;
        private System.Windows.Forms.PictureBox uc3_pictureBox_message;
        private System.Windows.Forms.Label uc3_label_infonewmess;
    }
}
