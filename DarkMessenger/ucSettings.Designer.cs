namespace DarkMessenger
{
    partial class ucSettings
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
            this.uc_label_skin = new System.Windows.Forms.Label();
            this.uc_comboBox_skin = new System.Windows.Forms.ComboBox();
            this.uc_label_serwer = new System.Windows.Forms.Label();
            this.uc_groupBox_settings = new System.Windows.Forms.GroupBox();
            this.uc_textbox_serwer = new System.Windows.Forms.TextBox();
            this.uc_backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uc_groupBox_avatar = new System.Windows.Forms.GroupBox();
            this.uc_button_usun = new System.Windows.Forms.Button();
            this.uc_button_zmien = new System.Windows.Forms.Button();
            this.uc_label_filename = new System.Windows.Forms.Label();
            this.uc_pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uc_groupBox_dessign = new System.Windows.Forms.GroupBox();
            this.uc_button_save = new System.Windows.Forms.Button();
            this.uc_button_cancel = new System.Windows.Forms.Button();
            this.uc_groupBox_settings.SuspendLayout();
            this.uc_groupBox_avatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc_pictureBox_avatar)).BeginInit();
            this.uc_groupBox_dessign.SuspendLayout();
            this.SuspendLayout();
            // 
            // uc_label_skin
            // 
            this.uc_label_skin.AutoSize = true;
            this.uc_label_skin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_label_skin.Location = new System.Drawing.Point(54, 44);
            this.uc_label_skin.Name = "uc_label_skin";
            this.uc_label_skin.Size = new System.Drawing.Size(42, 16);
            this.uc_label_skin.TabIndex = 0;
            this.uc_label_skin.Text = "Skin:";
            // 
            // uc_comboBox_skin
            // 
            this.uc_comboBox_skin.FormattingEnabled = true;
            this.uc_comboBox_skin.Items.AddRange(new object[] {
            "Niebieski",
            "Zielony",
            "Szary"});
            this.uc_comboBox_skin.Location = new System.Drawing.Point(143, 43);
            this.uc_comboBox_skin.Name = "uc_comboBox_skin";
            this.uc_comboBox_skin.Size = new System.Drawing.Size(312, 21);
            this.uc_comboBox_skin.TabIndex = 1;
            // 
            // uc_label_serwer
            // 
            this.uc_label_serwer.AutoSize = true;
            this.uc_label_serwer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_label_serwer.Location = new System.Drawing.Point(6, 35);
            this.uc_label_serwer.Name = "uc_label_serwer";
            this.uc_label_serwer.Size = new System.Drawing.Size(136, 15);
            this.uc_label_serwer.TabIndex = 2;
            this.uc_label_serwer.Text = "Serwer wiadomości:";
            // 
            // uc_groupBox_settings
            // 
            this.uc_groupBox_settings.Controls.Add(this.uc_textbox_serwer);
            this.uc_groupBox_settings.Controls.Add(this.uc_label_serwer);
            this.uc_groupBox_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_groupBox_settings.Location = new System.Drawing.Point(23, 170);
            this.uc_groupBox_settings.Name = "uc_groupBox_settings";
            this.uc_groupBox_settings.Size = new System.Drawing.Size(534, 87);
            this.uc_groupBox_settings.TabIndex = 3;
            this.uc_groupBox_settings.TabStop = false;
            this.uc_groupBox_settings.Text = "Połączenie";
            // 
            // uc_textbox_serwer
            // 
            this.uc_textbox_serwer.Location = new System.Drawing.Point(143, 34);
            this.uc_textbox_serwer.Name = "uc_textbox_serwer";
            this.uc_textbox_serwer.Size = new System.Drawing.Size(312, 20);
            this.uc_textbox_serwer.TabIndex = 3;
            // 
            // uc_groupBox_avatar
            // 
            this.uc_groupBox_avatar.Controls.Add(this.uc_button_usun);
            this.uc_groupBox_avatar.Controls.Add(this.uc_button_zmien);
            this.uc_groupBox_avatar.Controls.Add(this.uc_label_filename);
            this.uc_groupBox_avatar.Controls.Add(this.uc_pictureBox_avatar);
            this.uc_groupBox_avatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_groupBox_avatar.Location = new System.Drawing.Point(23, 263);
            this.uc_groupBox_avatar.Name = "uc_groupBox_avatar";
            this.uc_groupBox_avatar.Size = new System.Drawing.Size(534, 151);
            this.uc_groupBox_avatar.TabIndex = 4;
            this.uc_groupBox_avatar.TabStop = false;
            this.uc_groupBox_avatar.Text = "Avatar";
            // 
            // uc_button_usun
            // 
            this.uc_button_usun.Location = new System.Drawing.Point(348, 79);
            this.uc_button_usun.Name = "uc_button_usun";
            this.uc_button_usun.Size = new System.Drawing.Size(100, 25);
            this.uc_button_usun.TabIndex = 3;
            this.uc_button_usun.Text = "Usuń";
            this.uc_button_usun.UseVisualStyleBackColor = true;
            // 
            // uc_button_zmien
            // 
            this.uc_button_zmien.Location = new System.Drawing.Point(223, 79);
            this.uc_button_zmien.Name = "uc_button_zmien";
            this.uc_button_zmien.Size = new System.Drawing.Size(100, 25);
            this.uc_button_zmien.TabIndex = 2;
            this.uc_button_zmien.Text = "Zmień";
            this.uc_button_zmien.UseVisualStyleBackColor = true;
            this.uc_button_zmien.Click += new System.EventHandler(this.uc_button_zmien_Click);
            // 
            // uc_label_filename
            // 
            this.uc_label_filename.AutoSize = true;
            this.uc_label_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_label_filename.Location = new System.Drawing.Point(229, 45);
            this.uc_label_filename.Name = "uc_label_filename";
            this.uc_label_filename.Size = new System.Drawing.Size(87, 15);
            this.uc_label_filename.TabIndex = 1;
            this.uc_label_filename.Text = "nazwa_pliku";
            this.uc_label_filename.Click += new System.EventHandler(this.uc_label_filename_Click);
            // 
            // uc_pictureBox_avatar
            // 
            this.uc_pictureBox_avatar.Image = global::DarkMessenger.Properties.Resources.unknown_person_100;
            this.uc_pictureBox_avatar.Location = new System.Drawing.Point(65, 29);
            this.uc_pictureBox_avatar.Name = "uc_pictureBox_avatar";
            this.uc_pictureBox_avatar.Size = new System.Drawing.Size(100, 100);
            this.uc_pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.uc_pictureBox_avatar.TabIndex = 0;
            this.uc_pictureBox_avatar.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "uc_openFileDialog_avatar";
            // 
            // uc_groupBox_dessign
            // 
            this.uc_groupBox_dessign.Controls.Add(this.uc_comboBox_skin);
            this.uc_groupBox_dessign.Controls.Add(this.uc_label_skin);
            this.uc_groupBox_dessign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_groupBox_dessign.Location = new System.Drawing.Point(23, 74);
            this.uc_groupBox_dessign.Name = "uc_groupBox_dessign";
            this.uc_groupBox_dessign.Size = new System.Drawing.Size(534, 90);
            this.uc_groupBox_dessign.TabIndex = 5;
            this.uc_groupBox_dessign.TabStop = false;
            this.uc_groupBox_dessign.Text = "Wygląd";
            // 
            // uc_button_save
            // 
            this.uc_button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_button_save.Location = new System.Drawing.Point(107, 26);
            this.uc_button_save.Name = "uc_button_save";
            this.uc_button_save.Size = new System.Drawing.Size(150, 35);
            this.uc_button_save.TabIndex = 6;
            this.uc_button_save.Text = "Zapisz";
            this.uc_button_save.UseVisualStyleBackColor = true;
            this.uc_button_save.Click += new System.EventHandler(this.uc_button_save_Click);
            // 
            // uc_button_cancel
            // 
            this.uc_button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_button_cancel.Location = new System.Drawing.Point(321, 26);
            this.uc_button_cancel.Name = "uc_button_cancel";
            this.uc_button_cancel.Size = new System.Drawing.Size(150, 35);
            this.uc_button_cancel.TabIndex = 7;
            this.uc_button_cancel.Text = "Cancel";
            this.uc_button_cancel.UseVisualStyleBackColor = true;
            this.uc_button_cancel.Click += new System.EventHandler(this.uc_button_cancel_Click);
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.uc_button_cancel);
            this.Controls.Add(this.uc_button_save);
            this.Controls.Add(this.uc_groupBox_dessign);
            this.Controls.Add(this.uc_groupBox_avatar);
            this.Controls.Add(this.uc_groupBox_settings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(580, 591);
            this.Load += new System.EventHandler(this.ucSettings_Load);
            this.uc_groupBox_settings.ResumeLayout(false);
            this.uc_groupBox_settings.PerformLayout();
            this.uc_groupBox_avatar.ResumeLayout(false);
            this.uc_groupBox_avatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc_pictureBox_avatar)).EndInit();
            this.uc_groupBox_dessign.ResumeLayout(false);
            this.uc_groupBox_dessign.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label uc_label_skin;
        private System.Windows.Forms.ComboBox uc_comboBox_skin;
        private System.Windows.Forms.Label uc_label_serwer;
        private System.Windows.Forms.GroupBox uc_groupBox_settings;
        private System.Windows.Forms.TextBox uc_textbox_serwer;
        private System.ComponentModel.BackgroundWorker uc_backgroundWorker1;
        private System.Windows.Forms.GroupBox uc_groupBox_avatar;
        private System.Windows.Forms.Label uc_label_filename;
        private System.Windows.Forms.PictureBox uc_pictureBox_avatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button uc_button_zmien;
        private System.Windows.Forms.Button uc_button_usun;
        private System.Windows.Forms.GroupBox uc_groupBox_dessign;
        private System.Windows.Forms.Button uc_button_save;
        private System.Windows.Forms.Button uc_button_cancel;
    }
}
