namespace DarkMessenger
{
    partial class frmMainUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainUI));
            this.mf_panel_user = new System.Windows.Forms.Panel();
            this.mf_panel_MessMiniPane = new System.Windows.Forms.Panel();
            this.mf_pictureBox_message = new System.Windows.Forms.PictureBox();
            this.mf_pictureBox_avatarFront = new System.Windows.Forms.PictureBox();
            this.mf_panel_settMiniPane = new System.Windows.Forms.Panel();
            this.mf_pictureBox_settings = new System.Windows.Forms.PictureBox();
            this.mf_pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mf_toolStripStatusLabel_polaczony = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.mf_pictureBox_contacts = new System.Windows.Forms.PictureBox();
            this.mf_panel_contactsMiniPane = new System.Windows.Forms.Panel();
            this.ucSettings1 = new DarkMessenger.ucSettings();
            this.mf_panel_user.SuspendLayout();
            this.mf_panel_MessMiniPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_avatarFront)).BeginInit();
            this.mf_panel_settMiniPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_avatar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_contacts)).BeginInit();
            this.mf_panel_contactsMiniPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // mf_panel_user
            // 
            this.mf_panel_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_panel_user.AutoSize = true;
            this.mf_panel_user.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mf_panel_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mf_panel_user.Controls.Add(this.mf_panel_contactsMiniPane);
            this.mf_panel_user.Controls.Add(this.mf_panel_MessMiniPane);
            this.mf_panel_user.Controls.Add(this.mf_pictureBox_avatarFront);
            this.mf_panel_user.Controls.Add(this.mf_panel_settMiniPane);
            this.mf_panel_user.Controls.Add(this.mf_pictureBox_avatar);
            this.mf_panel_user.Location = new System.Drawing.Point(0, 0);
            this.mf_panel_user.Name = "mf_panel_user";
            this.mf_panel_user.Size = new System.Drawing.Size(585, 185);
            this.mf_panel_user.TabIndex = 0;
            // 
            // mf_panel_MessMiniPane
            // 
            this.mf_panel_MessMiniPane.Controls.Add(this.mf_pictureBox_message);
            this.mf_panel_MessMiniPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.mf_panel_MessMiniPane.Location = new System.Drawing.Point(356, 0);
            this.mf_panel_MessMiniPane.Name = "mf_panel_MessMiniPane";
            this.mf_panel_MessMiniPane.Size = new System.Drawing.Size(125, 181);
            this.mf_panel_MessMiniPane.TabIndex = 4;
            // 
            // mf_pictureBox_message
            // 
            this.mf_pictureBox_message.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_pictureBox_message.BackgroundImage = global::DarkMessenger.Properties.Resources.message_w;
            this.mf_pictureBox_message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mf_pictureBox_message.Location = new System.Drawing.Point(0, 54);
            this.mf_pictureBox_message.Name = "mf_pictureBox_message";
            this.mf_pictureBox_message.Size = new System.Drawing.Size(64, 64);
            this.mf_pictureBox_message.TabIndex = 0;
            this.mf_pictureBox_message.TabStop = false;
            this.mf_pictureBox_message.MouseLeave += new System.EventHandler(this.mf_pictureBox_message_MouseLeave);
            this.mf_pictureBox_message.MouseHover += new System.EventHandler(this.mf_pictureBox_message_MouseHover);
            // 
            // mf_pictureBox_avatarFront
            // 
            this.mf_pictureBox_avatarFront.BackColor = System.Drawing.Color.Transparent;
            this.mf_pictureBox_avatarFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mf_pictureBox_avatarFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mf_pictureBox_avatarFront.Image = ((System.Drawing.Image)(resources.GetObject("mf_pictureBox_avatarFront.Image")));
            this.mf_pictureBox_avatarFront.Location = new System.Drawing.Point(43, 54);
            this.mf_pictureBox_avatarFront.Name = "mf_pictureBox_avatarFront";
            this.mf_pictureBox_avatarFront.Size = new System.Drawing.Size(100, 100);
            this.mf_pictureBox_avatarFront.TabIndex = 3;
            this.mf_pictureBox_avatarFront.TabStop = false;
            // 
            // mf_panel_settMiniPane
            // 
            this.mf_panel_settMiniPane.Controls.Add(this.mf_pictureBox_settings);
            this.mf_panel_settMiniPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.mf_panel_settMiniPane.Location = new System.Drawing.Point(481, 0);
            this.mf_panel_settMiniPane.Name = "mf_panel_settMiniPane";
            this.mf_panel_settMiniPane.Size = new System.Drawing.Size(100, 181);
            this.mf_panel_settMiniPane.TabIndex = 1;
            // 
            // mf_pictureBox_settings
            // 
            this.mf_pictureBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_pictureBox_settings.BackgroundImage = global::DarkMessenger.Properties.Resources.settings_w1;
            this.mf_pictureBox_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mf_pictureBox_settings.Location = new System.Drawing.Point(0, 54);
            this.mf_pictureBox_settings.Name = "mf_pictureBox_settings";
            this.mf_pictureBox_settings.Size = new System.Drawing.Size(64, 64);
            this.mf_pictureBox_settings.TabIndex = 0;
            this.mf_pictureBox_settings.TabStop = false;
            this.mf_pictureBox_settings.Click += new System.EventHandler(this.pictureBox_settings_Click);
            this.mf_pictureBox_settings.MouseLeave += new System.EventHandler(this.pictureBox_settings_MouseLeave);
            this.mf_pictureBox_settings.MouseHover += new System.EventHandler(this.pictureBox_settings_MouseHover);
            // 
            // mf_pictureBox_avatar
            // 
            this.mf_pictureBox_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mf_pictureBox_avatar.Image = global::DarkMessenger.Properties.Resources.unknown_person_100;
            this.mf_pictureBox_avatar.Location = new System.Drawing.Point(35, 38);
            this.mf_pictureBox_avatar.Name = "mf_pictureBox_avatar";
            this.mf_pictureBox_avatar.Size = new System.Drawing.Size(100, 100);
            this.mf_pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mf_pictureBox_avatar.TabIndex = 2;
            this.mf_pictureBox_avatar.TabStop = false;
            this.mf_pictureBox_avatar.Click += new System.EventHandler(this.mf_pictureBox_avatar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mf_toolStripStatusLabel_polaczony});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(0, 50);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(584, 50);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mf_toolStripStatusLabel_polaczony
            // 
            this.mf_toolStripStatusLabel_polaczony.AutoSize = false;
            this.mf_toolStripStatusLabel_polaczony.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mf_toolStripStatusLabel_polaczony.Image = global::DarkMessenger.Properties.Resources.Disconnect_15;
            this.mf_toolStripStatusLabel_polaczony.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mf_toolStripStatusLabel_polaczony.Name = "mf_toolStripStatusLabel_polaczony";
            this.mf_toolStripStatusLabel_polaczony.Size = new System.Drawing.Size(120, 45);
            this.mf_toolStripStatusLabel_polaczony.Text = "Rozłączony";
            // 
            // panel_content
            // 
            this.panel_content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_content.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_content.Controls.Add(this.ucSettings1);
            this.panel_content.Location = new System.Drawing.Point(0, 185);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(585, 280);
            this.panel_content.TabIndex = 2;
            // 
            // mf_pictureBox_contacts
            // 
            this.mf_pictureBox_contacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mf_pictureBox_contacts.BackgroundImage = global::DarkMessenger.Properties.Resources.book_w;
            this.mf_pictureBox_contacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mf_pictureBox_contacts.Location = new System.Drawing.Point(0, 54);
            this.mf_pictureBox_contacts.Name = "mf_pictureBox_contacts";
            this.mf_pictureBox_contacts.Size = new System.Drawing.Size(64, 64);
            this.mf_pictureBox_contacts.TabIndex = 0;
            this.mf_pictureBox_contacts.TabStop = false;
            this.mf_pictureBox_contacts.MouseLeave += new System.EventHandler(this.mf_pictureBox_contacts_MouseLeave);
            this.mf_pictureBox_contacts.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // mf_panel_contactsMiniPane
            // 
            this.mf_panel_contactsMiniPane.Controls.Add(this.mf_pictureBox_contacts);
            this.mf_panel_contactsMiniPane.Dock = System.Windows.Forms.DockStyle.Right;
            this.mf_panel_contactsMiniPane.Location = new System.Drawing.Point(231, 0);
            this.mf_panel_contactsMiniPane.Name = "mf_panel_contactsMiniPane";
            this.mf_panel_contactsMiniPane.Size = new System.Drawing.Size(125, 181);
            this.mf_panel_contactsMiniPane.TabIndex = 5;
            // 
            // ucSettings1
            // 
            this.ucSettings1.AutoScroll = true;
            this.ucSettings1.AutoSize = true;
            this.ucSettings1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSettings1.Location = new System.Drawing.Point(0, 0);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(581, 276);
            this.ucSettings1.TabIndex = 0;
            this.ucSettings1.Visible = false;
            // 
            // frmMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mf_panel_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "frmMainUI";
            this.Text = "DarkMessenger";
            this.mf_panel_user.ResumeLayout(false);
            this.mf_panel_user.PerformLayout();
            this.mf_panel_MessMiniPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_avatarFront)).EndInit();
            this.mf_panel_settMiniPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_avatar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mf_pictureBox_contacts)).EndInit();
            this.mf_panel_contactsMiniPane.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mf_panel_user;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mf_toolStripStatusLabel_polaczony;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.PictureBox mf_pictureBox_settings;
        private System.Windows.Forms.Panel mf_panel_settMiniPane;
        private ucSettings ucSettings1;
        private System.Windows.Forms.PictureBox mf_pictureBox_avatar;
        private System.Windows.Forms.PictureBox mf_pictureBox_avatarFront;
        private System.Windows.Forms.Panel mf_panel_MessMiniPane;
        private System.Windows.Forms.PictureBox mf_pictureBox_message;
        private System.Windows.Forms.Panel mf_panel_contactsMiniPane;
        private System.Windows.Forms.PictureBox mf_pictureBox_contacts;

        private string avatar;
        private int skin=0;
    }
}