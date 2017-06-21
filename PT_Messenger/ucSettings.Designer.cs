namespace PT_Messenger
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
            this.components = new System.ComponentModel.Container();
            this.uc_label_skin = new System.Windows.Forms.Label();
            this.uc_comboBox_skin = new System.Windows.Forms.ComboBox();
            this.uc_label_serwer = new System.Windows.Forms.Label();
            this.uc_groupBox_settings = new System.Windows.Forms.GroupBox();
            this.uc_textbox_serwer = new System.Windows.Forms.TextBox();
            this.uc_backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uc_groupBox_user = new System.Windows.Forms.GroupBox();
            this.uc_button_passclean = new System.Windows.Forms.Button();
            this.uc_groupBox_password = new System.Windows.Forms.GroupBox();
            this.uc_textBox_repassword = new System.Windows.Forms.TextBox();
            this.uc_textBox_password = new System.Windows.Forms.TextBox();
            this.uc_label_potwierdzhaslo = new System.Windows.Forms.Label();
            this.uc_label_nowehaslo = new System.Windows.Forms.Label();
            this.uc_button_passZmien = new System.Windows.Forms.Button();
            this.uc_groupBox_userinfo = new System.Windows.Forms.GroupBox();
            this.uc_textBox_email = new System.Windows.Forms.TextBox();
            this.uc_textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.uc_textBox_imie = new System.Windows.Forms.TextBox();
            this.uc_textBox_login = new System.Windows.Forms.TextBox();
            this.uc_label_email = new System.Windows.Forms.Label();
            this.uc_label_login = new System.Windows.Forms.Label();
            this.uc_label_nazwisko = new System.Windows.Forms.Label();
            this.uc_label_imie = new System.Windows.Forms.Label();
            this.uc_groupBox_avatar = new System.Windows.Forms.GroupBox();
            this.uc_pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.uc_button_usun = new System.Windows.Forms.Button();
            this.uc_button_zmien = new System.Windows.Forms.Button();
            this.uc_label_filename = new System.Windows.Forms.Label();
            this.uc_openFileDialog_avatar = new System.Windows.Forms.OpenFileDialog();
            this.uc_groupBox_dessign = new System.Windows.Forms.GroupBox();
            this.uc_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.uc_label_ustawienia = new System.Windows.Forms.Label();
            this.uc_groupBox_settings.SuspendLayout();
            this.uc_groupBox_user.SuspendLayout();
            this.uc_groupBox_password.SuspendLayout();
            this.uc_groupBox_userinfo.SuspendLayout();
            this.uc_groupBox_avatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc_pictureBox_avatar)).BeginInit();
            this.uc_groupBox_dessign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_label_skin
            // 
            this.uc_label_skin.AutoSize = true;
            this.uc_label_skin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_label_skin.Location = new System.Drawing.Point(62, 44);
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
            this.uc_comboBox_skin.Location = new System.Drawing.Point(166, 43);
            this.uc_comboBox_skin.Name = "uc_comboBox_skin";
            this.uc_comboBox_skin.Size = new System.Drawing.Size(312, 21);
            this.uc_comboBox_skin.TabIndex = 1;
            this.uc_comboBox_skin.SelectionChangeCommitted += new System.EventHandler(this.uc_comboBox_skin_SelectionChangeCommitted);
            // 
            // uc_label_serwer
            // 
            this.uc_label_serwer.AutoSize = true;
            this.uc_label_serwer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_label_serwer.Location = new System.Drawing.Point(29, 35);
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
            this.uc_groupBox_settings.Location = new System.Drawing.Point(15, 132);
            this.uc_groupBox_settings.Name = "uc_groupBox_settings";
            this.uc_groupBox_settings.Size = new System.Drawing.Size(534, 87);
            this.uc_groupBox_settings.TabIndex = 3;
            this.uc_groupBox_settings.TabStop = false;
            this.uc_groupBox_settings.Text = "Połączenie";
            // 
            // uc_textbox_serwer
            // 
            this.uc_textbox_serwer.Location = new System.Drawing.Point(166, 34);
            this.uc_textbox_serwer.Name = "uc_textbox_serwer";
            this.uc_textbox_serwer.Size = new System.Drawing.Size(312, 20);
            this.uc_textbox_serwer.TabIndex = 3;
            this.uc_textbox_serwer.TextChanged += new System.EventHandler(this.uc_textbox_serwer_TextChanged);
            // 
            // uc_groupBox_user
            // 
            this.uc_groupBox_user.Controls.Add(this.uc_button_passclean);
            this.uc_groupBox_user.Controls.Add(this.uc_groupBox_password);
            this.uc_groupBox_user.Controls.Add(this.uc_button_passZmien);
            this.uc_groupBox_user.Controls.Add(this.uc_groupBox_userinfo);
            this.uc_groupBox_user.Controls.Add(this.uc_groupBox_avatar);
            this.uc_groupBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_groupBox_user.Location = new System.Drawing.Point(15, 225);
            this.uc_groupBox_user.Name = "uc_groupBox_user";
            this.uc_groupBox_user.Size = new System.Drawing.Size(534, 549);
            this.uc_groupBox_user.TabIndex = 4;
            this.uc_groupBox_user.TabStop = false;
            this.uc_groupBox_user.Text = "Użytkownik";
            // 
            // uc_button_passclean
            // 
            this.uc_button_passclean.Location = new System.Drawing.Point(263, 504);
            this.uc_button_passclean.Name = "uc_button_passclean";
            this.uc_button_passclean.Size = new System.Drawing.Size(100, 25);
            this.uc_button_passclean.TabIndex = 12;
            this.uc_button_passclean.Text = "Wyczyść";
            this.uc_button_passclean.UseVisualStyleBackColor = true;
            this.uc_button_passclean.Click += new System.EventHandler(this.uc_button_passclean_Click);
            // 
            // uc_groupBox_password
            // 
            this.uc_groupBox_password.Controls.Add(this.uc_textBox_repassword);
            this.uc_groupBox_password.Controls.Add(this.uc_textBox_password);
            this.uc_groupBox_password.Controls.Add(this.uc_label_potwierdzhaslo);
            this.uc_groupBox_password.Controls.Add(this.uc_label_nowehaslo);
            this.uc_groupBox_password.Location = new System.Drawing.Point(7, 388);
            this.uc_groupBox_password.Name = "uc_groupBox_password";
            this.uc_groupBox_password.Size = new System.Drawing.Size(520, 110);
            this.uc_groupBox_password.TabIndex = 6;
            this.uc_groupBox_password.TabStop = false;
            this.uc_groupBox_password.Text = "Zmien Hasło";
            // 
            // uc_textBox_repassword
            // 
            this.uc_textBox_repassword.Location = new System.Drawing.Point(170, 66);
            this.uc_textBox_repassword.Name = "uc_textBox_repassword";
            this.uc_textBox_repassword.PasswordChar = '*';
            this.uc_textBox_repassword.Size = new System.Drawing.Size(239, 20);
            this.uc_textBox_repassword.TabIndex = 10;
            this.uc_textBox_repassword.WordWrap = false;
            this.uc_textBox_repassword.Leave += new System.EventHandler(this.uc_textBox_repassword_Leave);
            // 
            // uc_textBox_password
            // 
            this.uc_textBox_password.Location = new System.Drawing.Point(170, 38);
            this.uc_textBox_password.Name = "uc_textBox_password";
            this.uc_textBox_password.PasswordChar = '*';
            this.uc_textBox_password.Size = new System.Drawing.Size(239, 20);
            this.uc_textBox_password.TabIndex = 8;
            this.uc_textBox_password.WordWrap = false;
            this.uc_textBox_password.Leave += new System.EventHandler(this.uc_textBox_password_Leave);
            // 
            // uc_label_potwierdzhaslo
            // 
            this.uc_label_potwierdzhaslo.AutoSize = true;
            this.uc_label_potwierdzhaslo.Location = new System.Drawing.Point(48, 70);
            this.uc_label_potwierdzhaslo.Name = "uc_label_potwierdzhaslo";
            this.uc_label_potwierdzhaslo.Size = new System.Drawing.Size(102, 13);
            this.uc_label_potwierdzhaslo.TabIndex = 9;
            this.uc_label_potwierdzhaslo.Text = "Potwierdź hasło:";
            // 
            // uc_label_nowehaslo
            // 
            this.uc_label_nowehaslo.AutoSize = true;
            this.uc_label_nowehaslo.Location = new System.Drawing.Point(71, 42);
            this.uc_label_nowehaslo.Name = "uc_label_nowehaslo";
            this.uc_label_nowehaslo.Size = new System.Drawing.Size(79, 13);
            this.uc_label_nowehaslo.TabIndex = 8;
            this.uc_label_nowehaslo.Text = "Nowe hasło:";
            // 
            // uc_button_passZmien
            // 
            this.uc_button_passZmien.Location = new System.Drawing.Point(119, 504);
            this.uc_button_passZmien.Name = "uc_button_passZmien";
            this.uc_button_passZmien.Size = new System.Drawing.Size(100, 25);
            this.uc_button_passZmien.TabIndex = 11;
            this.uc_button_passZmien.Text = "Zmień";
            this.uc_button_passZmien.UseVisualStyleBackColor = true;
            this.uc_button_passZmien.Click += new System.EventHandler(this.uc_button_passZmien_Click);
            // 
            // uc_groupBox_userinfo
            // 
            this.uc_groupBox_userinfo.Controls.Add(this.uc_textBox_email);
            this.uc_groupBox_userinfo.Controls.Add(this.uc_textBox_nazwisko);
            this.uc_groupBox_userinfo.Controls.Add(this.uc_textBox_imie);
            this.uc_groupBox_userinfo.Controls.Add(this.uc_textBox_login);
            this.uc_groupBox_userinfo.Controls.Add(this.uc_label_email);
            this.uc_groupBox_userinfo.Controls.Add(this.uc_label_login);
            this.uc_groupBox_userinfo.Controls.Add(this.uc_label_nazwisko);
            this.uc_groupBox_userinfo.Controls.Add(this.uc_label_imie);
            this.uc_groupBox_userinfo.Location = new System.Drawing.Point(7, 201);
            this.uc_groupBox_userinfo.Name = "uc_groupBox_userinfo";
            this.uc_groupBox_userinfo.Size = new System.Drawing.Size(520, 180);
            this.uc_groupBox_userinfo.TabIndex = 5;
            this.uc_groupBox_userinfo.TabStop = false;
            this.uc_groupBox_userinfo.Text = "Dane użytkownika";
            // 
            // uc_textBox_email
            // 
            this.uc_textBox_email.Location = new System.Drawing.Point(170, 129);
            this.uc_textBox_email.Name = "uc_textBox_email";
            this.uc_textBox_email.Size = new System.Drawing.Size(239, 20);
            this.uc_textBox_email.TabIndex = 7;
            // 
            // uc_textBox_nazwisko
            // 
            this.uc_textBox_nazwisko.Location = new System.Drawing.Point(170, 99);
            this.uc_textBox_nazwisko.Name = "uc_textBox_nazwisko";
            this.uc_textBox_nazwisko.Size = new System.Drawing.Size(239, 20);
            this.uc_textBox_nazwisko.TabIndex = 6;
            // 
            // uc_textBox_imie
            // 
            this.uc_textBox_imie.Location = new System.Drawing.Point(170, 69);
            this.uc_textBox_imie.Name = "uc_textBox_imie";
            this.uc_textBox_imie.Size = new System.Drawing.Size(239, 20);
            this.uc_textBox_imie.TabIndex = 5;
            // 
            // uc_textBox_login
            // 
            this.uc_textBox_login.Enabled = false;
            this.uc_textBox_login.Location = new System.Drawing.Point(170, 39);
            this.uc_textBox_login.Name = "uc_textBox_login";
            this.uc_textBox_login.Size = new System.Drawing.Size(239, 20);
            this.uc_textBox_login.TabIndex = 4;
            // 
            // uc_label_email
            // 
            this.uc_label_email.AutoSize = true;
            this.uc_label_email.Location = new System.Drawing.Point(109, 133);
            this.uc_label_email.Name = "uc_label_email";
            this.uc_label_email.Size = new System.Drawing.Size(41, 13);
            this.uc_label_email.TabIndex = 3;
            this.uc_label_email.Text = "Email:";
            // 
            // uc_label_login
            // 
            this.uc_label_login.AutoSize = true;
            this.uc_label_login.Location = new System.Drawing.Point(108, 43);
            this.uc_label_login.Name = "uc_label_login";
            this.uc_label_login.Size = new System.Drawing.Size(42, 13);
            this.uc_label_login.TabIndex = 2;
            this.uc_label_login.Text = "Login:";
            // 
            // uc_label_nazwisko
            // 
            this.uc_label_nazwisko.AutoSize = true;
            this.uc_label_nazwisko.Location = new System.Drawing.Point(85, 103);
            this.uc_label_nazwisko.Name = "uc_label_nazwisko";
            this.uc_label_nazwisko.Size = new System.Drawing.Size(65, 13);
            this.uc_label_nazwisko.TabIndex = 1;
            this.uc_label_nazwisko.Text = "Nazwisko:";
            // 
            // uc_label_imie
            // 
            this.uc_label_imie.AutoSize = true;
            this.uc_label_imie.Location = new System.Drawing.Point(116, 73);
            this.uc_label_imie.Name = "uc_label_imie";
            this.uc_label_imie.Size = new System.Drawing.Size(34, 13);
            this.uc_label_imie.TabIndex = 0;
            this.uc_label_imie.Text = "Imie:";
            // 
            // uc_groupBox_avatar
            // 
            this.uc_groupBox_avatar.Controls.Add(this.uc_pictureBox_avatar);
            this.uc_groupBox_avatar.Controls.Add(this.uc_button_usun);
            this.uc_groupBox_avatar.Controls.Add(this.uc_button_zmien);
            this.uc_groupBox_avatar.Controls.Add(this.uc_label_filename);
            this.uc_groupBox_avatar.Location = new System.Drawing.Point(6, 30);
            this.uc_groupBox_avatar.Name = "uc_groupBox_avatar";
            this.uc_groupBox_avatar.Size = new System.Drawing.Size(520, 163);
            this.uc_groupBox_avatar.TabIndex = 4;
            this.uc_groupBox_avatar.TabStop = false;
            this.uc_groupBox_avatar.Text = "Avatar";
            // 
            // uc_pictureBox_avatar
            // 
            this.uc_pictureBox_avatar.Image = global::PT_Messenger.Properties.Resources.unknown_person_100;
            this.uc_pictureBox_avatar.Location = new System.Drawing.Point(51, 34);
            this.uc_pictureBox_avatar.Name = "uc_pictureBox_avatar";
            this.uc_pictureBox_avatar.Size = new System.Drawing.Size(100, 100);
            this.uc_pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uc_pictureBox_avatar.TabIndex = 0;
            this.uc_pictureBox_avatar.TabStop = false;
            // 
            // uc_button_usun
            // 
            this.uc_button_usun.Location = new System.Drawing.Point(334, 90);
            this.uc_button_usun.Name = "uc_button_usun";
            this.uc_button_usun.Size = new System.Drawing.Size(100, 25);
            this.uc_button_usun.TabIndex = 3;
            this.uc_button_usun.Text = "Usuń";
            this.uc_button_usun.UseVisualStyleBackColor = true;
            this.uc_button_usun.Click += new System.EventHandler(this.uc_button_usun_Click);
            // 
            // uc_button_zmien
            // 
            this.uc_button_zmien.Location = new System.Drawing.Point(209, 90);
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
            this.uc_label_filename.Location = new System.Drawing.Point(215, 56);
            this.uc_label_filename.Name = "uc_label_filename";
            this.uc_label_filename.Size = new System.Drawing.Size(87, 15);
            this.uc_label_filename.TabIndex = 1;
            this.uc_label_filename.Text = "nazwa_pliku";
            // 
            // uc_openFileDialog_avatar
            // 
            this.uc_openFileDialog_avatar.FileName = "uc_openFileDialog_avatar";
            this.uc_openFileDialog_avatar.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // uc_groupBox_dessign
            // 
            this.uc_groupBox_dessign.Controls.Add(this.uc_comboBox_skin);
            this.uc_groupBox_dessign.Controls.Add(this.uc_label_skin);
            this.uc_groupBox_dessign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_groupBox_dessign.Location = new System.Drawing.Point(15, 36);
            this.uc_groupBox_dessign.Name = "uc_groupBox_dessign";
            this.uc_groupBox_dessign.Size = new System.Drawing.Size(534, 90);
            this.uc_groupBox_dessign.TabIndex = 5;
            this.uc_groupBox_dessign.TabStop = false;
            this.uc_groupBox_dessign.Text = "Wygląd";
            // 
            // uc_errorProvider
            // 
            this.uc_errorProvider.ContainerControl = this;
            // 
            // uc_label_ustawienia
            // 
            this.uc_label_ustawienia.AutoSize = true;
            this.uc_label_ustawienia.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uc_label_ustawienia.Location = new System.Drawing.Point(220, 11);
            this.uc_label_ustawienia.Name = "uc_label_ustawienia";
            this.uc_label_ustawienia.Size = new System.Drawing.Size(110, 22);
            this.uc_label_ustawienia.TabIndex = 6;
            this.uc_label_ustawienia.Text = "Ustawienia";
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.uc_label_ustawienia);
            this.Controls.Add(this.uc_groupBox_dessign);
            this.Controls.Add(this.uc_groupBox_user);
            this.Controls.Add(this.uc_groupBox_settings);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(563, 777);
            this.Load += new System.EventHandler(this.ucSettings_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucSettings_Paint);
            this.uc_groupBox_settings.ResumeLayout(false);
            this.uc_groupBox_settings.PerformLayout();
            this.uc_groupBox_user.ResumeLayout(false);
            this.uc_groupBox_password.ResumeLayout(false);
            this.uc_groupBox_password.PerformLayout();
            this.uc_groupBox_userinfo.ResumeLayout(false);
            this.uc_groupBox_userinfo.PerformLayout();
            this.uc_groupBox_avatar.ResumeLayout(false);
            this.uc_groupBox_avatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc_pictureBox_avatar)).EndInit();
            this.uc_groupBox_dessign.ResumeLayout(false);
            this.uc_groupBox_dessign.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uc_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uc_label_skin;
        private System.Windows.Forms.ComboBox uc_comboBox_skin;
        private System.Windows.Forms.Label uc_label_serwer;
        private System.Windows.Forms.GroupBox uc_groupBox_settings;
        private System.Windows.Forms.TextBox uc_textbox_serwer;
        private System.ComponentModel.BackgroundWorker uc_backgroundWorker1;
        private System.Windows.Forms.GroupBox uc_groupBox_user;
        private System.Windows.Forms.Label uc_label_filename;
        private System.Windows.Forms.PictureBox uc_pictureBox_avatar;
        private System.Windows.Forms.OpenFileDialog uc_openFileDialog_avatar;
        private System.Windows.Forms.Button uc_button_zmien;
        private System.Windows.Forms.Button uc_button_usun;
        private System.Windows.Forms.GroupBox uc_groupBox_dessign;
        private System.Windows.Forms.GroupBox uc_groupBox_userinfo;
        private System.Windows.Forms.Label uc_label_imie;
        private System.Windows.Forms.GroupBox uc_groupBox_avatar;
        private System.Windows.Forms.GroupBox uc_groupBox_password;
        private System.Windows.Forms.TextBox uc_textBox_repassword;
        private System.Windows.Forms.TextBox uc_textBox_password;
        private System.Windows.Forms.Label uc_label_potwierdzhaslo;
        private System.Windows.Forms.Label uc_label_nowehaslo;
        private System.Windows.Forms.TextBox uc_textBox_email;
        private System.Windows.Forms.TextBox uc_textBox_nazwisko;
        private System.Windows.Forms.TextBox uc_textBox_imie;
        private System.Windows.Forms.TextBox uc_textBox_login;
        private System.Windows.Forms.Label uc_label_email;
        private System.Windows.Forms.Label uc_label_login;
        private System.Windows.Forms.Label uc_label_nazwisko;
        private System.Windows.Forms.Button uc_button_passclean;
        private System.Windows.Forms.Button uc_button_passZmien;
        private System.Windows.Forms.ErrorProvider uc_errorProvider;
        private System.Windows.Forms.Label uc_label_ustawienia;
    }
}
