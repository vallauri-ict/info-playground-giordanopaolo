namespace _27_Interfacce
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnconnetti = new System.Windows.Forms.Button();
            this.btnDisocnnetti = new System.Windows.Forms.Button();
            this.btnstato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconnetti
            // 
            this.btnconnetti.Location = new System.Drawing.Point(12, 12);
            this.btnconnetti.Name = "btnconnetti";
            this.btnconnetti.Size = new System.Drawing.Size(75, 23);
            this.btnconnetti.TabIndex = 0;
            this.btnconnetti.Text = "connetti";
            this.btnconnetti.UseVisualStyleBackColor = true;
            this.btnconnetti.Click += new System.EventHandler(this.btnconnetti_Click);
            // 
            // btnDisocnnetti
            // 
            this.btnDisocnnetti.Location = new System.Drawing.Point(93, 12);
            this.btnDisocnnetti.Name = "btnDisocnnetti";
            this.btnDisocnnetti.Size = new System.Drawing.Size(75, 23);
            this.btnDisocnnetti.TabIndex = 1;
            this.btnDisocnnetti.Text = "disconnetti";
            this.btnDisocnnetti.UseVisualStyleBackColor = true;
            this.btnDisocnnetti.Click += new System.EventHandler(this.btnDisocnnetti_Click);
            // 
            // btnstato
            // 
            this.btnstato.Location = new System.Drawing.Point(174, 12);
            this.btnstato.Name = "btnstato";
            this.btnstato.Size = new System.Drawing.Size(75, 23);
            this.btnstato.TabIndex = 2;
            this.btnstato.Text = "Stato";
            this.btnstato.UseVisualStyleBackColor = true;
            this.btnstato.Click += new System.EventHandler(this.btnstato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 47);
            this.Controls.Add(this.btnstato);
            this.Controls.Add(this.btnDisocnnetti);
            this.Controls.Add(this.btnconnetti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnconnetti;
        private System.Windows.Forms.Button btnDisocnnetti;
        private System.Windows.Forms.Button btnstato;
    }
}

