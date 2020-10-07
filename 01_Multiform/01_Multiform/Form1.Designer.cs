namespace _01_Multiform
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.FormModale = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtBNomefm = new System.Windows.Forms.TextBox();
            this.txtBEtàfm = new System.Windows.Forms.TextBox();
            this.Età = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "apri form 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "passa a form 2 titolo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "apri form 2 il testo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormModale
            // 
            this.FormModale.Location = new System.Drawing.Point(298, 12);
            this.FormModale.Name = "FormModale";
            this.FormModale.Size = new System.Drawing.Size(174, 38);
            this.FormModale.TabIndex = 4;
            this.FormModale.Text = "form modale";
            this.FormModale.UseVisualStyleBackColor = true;
            this.FormModale.Click += new System.EventHandler(this.FormModale_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(478, 22);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(38, 13);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Nome:";
            // 
            // TxtBNomefm
            // 
            this.TxtBNomefm.Location = new System.Drawing.Point(523, 22);
            this.TxtBNomefm.Name = "TxtBNomefm";
            this.TxtBNomefm.ReadOnly = true;
            this.TxtBNomefm.Size = new System.Drawing.Size(100, 20);
            this.TxtBNomefm.TabIndex = 6;
            // 
            // txtBEtàfm
            // 
            this.txtBEtàfm.Location = new System.Drawing.Point(523, 48);
            this.txtBEtàfm.Name = "txtBEtàfm";
            this.txtBEtàfm.ReadOnly = true;
            this.txtBEtàfm.Size = new System.Drawing.Size(100, 20);
            this.txtBEtàfm.TabIndex = 8;
            // 
            // Età
            // 
            this.Età.AutoSize = true;
            this.Età.Location = new System.Drawing.Point(478, 48);
            this.Età.Name = "Età";
            this.Età.Size = new System.Drawing.Size(26, 13);
            this.Età.TabIndex = 7;
            this.Età.Text = "Età:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBEtàfm);
            this.Controls.Add(this.Età);
            this.Controls.Add(this.TxtBNomefm);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.FormModale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button FormModale;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtBNomefm;
        private System.Windows.Forms.TextBox txtBEtàfm;
        private System.Windows.Forms.Label Età;
    }
}

