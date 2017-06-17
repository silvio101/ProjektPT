namespace PT_Messenger
{
    partial class ucAddressBook
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
            this.uc2_label_ksiazka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uc2_label_ksiazka
            // 
            this.uc2_label_ksiazka.AutoSize = true;
            this.uc2_label_ksiazka.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc2_label_ksiazka.Location = new System.Drawing.Point(269, 36);
            this.uc2_label_ksiazka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uc2_label_ksiazka.Name = "uc2_label_ksiazka";
            this.uc2_label_ksiazka.Size = new System.Drawing.Size(181, 24);
            this.uc2_label_ksiazka.TabIndex = 0;
            this.uc2_label_ksiazka.Text = "Książka Adresowa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // ucAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uc2_label_ksiazka);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucAddressBook";
            this.Size = new System.Drawing.Size(773, 615);
            this.Load += new System.EventHandler(this.ucAddressBook_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucAddressBook_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uc2_label_ksiazka;
        private System.Windows.Forms.Label label1;

    }
}
