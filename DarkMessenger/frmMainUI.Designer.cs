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
            this.panel_user = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel_content = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox_settings = new System.Windows.Forms.PictureBox();
            this.ucSettings1 = new DarkMessenger.ucSettings();
            this.panel_user.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_user
            // 
            this.panel_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_user.AutoSize = true;
            this.panel_user.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_user.Controls.Add(this.panel1);
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(585, 185);
            this.panel_user.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_settings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(481, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 181);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.MinimumSize = new System.Drawing.Size(0, 50);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(584, 50);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStripStatusLabel1.Image = global::DarkMessenger.Properties.Resources.Disconnect_15;
            this.toolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 45);
            this.toolStripStatusLabel1.Text = "Rozłączony";
            // 
            // pictureBox_settings
            // 
            this.pictureBox_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_settings.BackgroundImage = global::DarkMessenger.Properties.Resources.settings_w1;
            this.pictureBox_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_settings.Location = new System.Drawing.Point(0, 54);
            this.pictureBox_settings.Name = "pictureBox_settings";
            this.pictureBox_settings.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_settings.TabIndex = 0;
            this.pictureBox_settings.TabStop = false;
            this.pictureBox_settings.Click += new System.EventHandler(this.pictureBox_settings_Click);
            this.pictureBox_settings.MouseLeave += new System.EventHandler(this.pictureBox_settings_MouseLeave);
            this.pictureBox_settings.MouseHover += new System.EventHandler(this.pictureBox_settings_MouseHover);
            // 
            // ucSettings1
            // 
            this.ucSettings1.Location = new System.Drawing.Point(-3, -2);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(585, 284);
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
            this.Controls.Add(this.panel_user);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "frmMainUI";
            this.Text = "DarkMessenger";
            this.panel_user.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.PictureBox pictureBox_settings;
        private System.Windows.Forms.Panel panel1;
        private ucSettings ucSettings1;
    }
}