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
            this.label_skin = new System.Windows.Forms.Label();
            this.uc_comboBox_skin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uc_textbox_serwer = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_skin
            // 
            this.label_skin.AutoSize = true;
            this.label_skin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_skin.Location = new System.Drawing.Point(77, 38);
            this.label_skin.Name = "label_skin";
            this.label_skin.Size = new System.Drawing.Size(42, 16);
            this.label_skin.TabIndex = 0;
            this.label_skin.Text = "Skin:";
            // 
            // uc_comboBox_skin
            // 
            this.uc_comboBox_skin.FormattingEnabled = true;
            this.uc_comboBox_skin.Items.AddRange(new object[] {
            "Jasny",
            "Ciemny"});
            this.uc_comboBox_skin.Location = new System.Drawing.Point(166, 37);
            this.uc_comboBox_skin.Name = "uc_comboBox_skin";
            this.uc_comboBox_skin.Size = new System.Drawing.Size(312, 21);
            this.uc_comboBox_skin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serwer wiadomości";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uc_textbox_serwer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Połączenie";
            // 
            // uc_textbox_serwer
            // 
            this.uc_textbox_serwer.Location = new System.Drawing.Point(143, 24);
            this.uc_textbox_serwer.Name = "uc_textbox_serwer";
            this.uc_textbox_serwer.Size = new System.Drawing.Size(312, 20);
            this.uc_textbox_serwer.TabIndex = 3;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uc_comboBox_skin);
            this.Controls.Add(this.label_skin);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(585, 284);
            this.Load += new System.EventHandler(this.ucSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_skin;
        private System.Windows.Forms.ComboBox uc_comboBox_skin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox uc_textbox_serwer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
