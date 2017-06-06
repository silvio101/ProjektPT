namespace DarkMessenger
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
            this.SuspendLayout();
            // 
            // uc2_label_ksiazka
            // 
            this.uc2_label_ksiazka.AutoSize = true;
            this.uc2_label_ksiazka.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc2_label_ksiazka.Location = new System.Drawing.Point(202, 29);
            this.uc2_label_ksiazka.Name = "uc2_label_ksiazka";
            this.uc2_label_ksiazka.Size = new System.Drawing.Size(150, 19);
            this.uc2_label_ksiazka.TabIndex = 0;
            this.uc2_label_ksiazka.Text = "Książka Adresowa";
            // 
            // ucAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc2_label_ksiazka);
            this.Name = "ucAddressBook";
            this.Size = new System.Drawing.Size(580, 500);
            this.Load += new System.EventHandler(this.ucAddressBook_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ucAddressBook_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uc2_label_ksiazka;

    }
}
