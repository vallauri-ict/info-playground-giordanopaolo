namespace _21_EsercizioNumeri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtreale = new System.Windows.Forms.TextBox();
            this.txtQuaternione = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModulo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REale";
            // 
            // txtreale
            // 
            this.txtreale.Location = new System.Drawing.Point(178, 99);
            this.txtreale.Name = "txtreale";
            this.txtreale.Size = new System.Drawing.Size(100, 20);
            this.txtreale.TabIndex = 1;
            // 
            // txtQuaternione
            // 
            this.txtQuaternione.Location = new System.Drawing.Point(178, 135);
            this.txtQuaternione.Name = "txtQuaternione";
            this.txtQuaternione.Size = new System.Drawing.Size(100, 20);
            this.txtQuaternione.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quaternione";
            // 
            // txtJ
            // 
            this.txtJ.Location = new System.Drawing.Point(178, 170);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(100, 20);
            this.txtJ.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "J";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(178, 205);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "K";
            // 
            // btnModulo
            // 
            this.btnModulo.Location = new System.Drawing.Point(343, 88);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(196, 60);
            this.btnModulo.TabIndex = 8;
            this.btnModulo.Text = "Calcola modulo";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calcola modulo quaternione";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModulo);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuaternione);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtreale);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreale;
        private System.Windows.Forms.TextBox txtQuaternione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button button1;
    }
}

