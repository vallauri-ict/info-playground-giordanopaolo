namespace _20_Classiderivate
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsesso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txteta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVisulizza = new System.Windows.Forms.Button();
            this.listStudenti = new System.Windows.Forms.ListView();
            this.TxtVoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(65, 12);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 1;
            // 
            // txtcognome
            // 
            this.txtcognome.Location = new System.Drawing.Point(65, 48);
            this.txtcognome.Name = "txtcognome";
            this.txtcognome.Size = new System.Drawing.Size(100, 20);
            this.txtcognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // txtsesso
            // 
            this.txtsesso.Location = new System.Drawing.Point(65, 122);
            this.txtsesso.Name = "txtsesso";
            this.txtsesso.Size = new System.Drawing.Size(100, 20);
            this.txtsesso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sesso";
            // 
            // txteta
            // 
            this.txteta.Location = new System.Drawing.Point(65, 86);
            this.txteta.Name = "txteta";
            this.txteta.Size = new System.Drawing.Size(100, 20);
            this.txteta.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Eta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVisulizza
            // 
            this.btnVisulizza.Location = new System.Drawing.Point(319, 12);
            this.btnVisulizza.Name = "btnVisulizza";
            this.btnVisulizza.Size = new System.Drawing.Size(135, 56);
            this.btnVisulizza.TabIndex = 9;
            this.btnVisulizza.Text = "Visualizza";
            this.btnVisulizza.UseVisualStyleBackColor = true;
            this.btnVisulizza.Click += new System.EventHandler(this.btnVisulizza_Click);
            // 
            // listStudenti
            // 
            this.listStudenti.HideSelection = false;
            this.listStudenti.Location = new System.Drawing.Point(582, 12);
            this.listStudenti.Name = "listStudenti";
            this.listStudenti.Size = new System.Drawing.Size(206, 363);
            this.listStudenti.TabIndex = 10;
            this.listStudenti.UseCompatibleStateImageBehavior = false;
            this.listStudenti.View = System.Windows.Forms.View.List;
            // 
            // TxtVoto
            // 
            this.TxtVoto.Location = new System.Drawing.Point(65, 349);
            this.TxtVoto.Name = "TxtVoto";
            this.TxtVoto.Size = new System.Drawing.Size(100, 20);
            this.TxtVoto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Voto";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 56);
            this.button3.TabIndex = 13;
            this.button3.Text = "Inserisci voto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TxtVoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listStudenti);
            this.Controls.Add(this.btnVisulizza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txteta);
            this.Controls.Add(this.txtcognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txteta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVisulizza;
        private System.Windows.Forms.ListView listStudenti;
        private System.Windows.Forms.TextBox TxtVoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}

