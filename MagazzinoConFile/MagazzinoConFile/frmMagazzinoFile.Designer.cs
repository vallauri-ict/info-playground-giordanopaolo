namespace MagazzinoConFile
{
    partial class frmMagazzinoFile
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
            this.dgvArticoli = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVendite = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.txtNomeArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiacenza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtScorta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAziende = new System.Windows.Forms.ComboBox();
            this.btnInserisciArt = new System.Windows.Forms.Button();
            this.cmbCodForn = new System.Windows.Forms.ComboBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCittà = new System.Windows.Forms.ComboBox();
            this.btnInserisciCliente = new System.Windows.Forms.Button();
            this.cmbCodArt = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCodCliente = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.nudQta = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.btnInserisciVendita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticoli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticoli
            // 
            this.dgvArticoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticoli.Location = new System.Drawing.Point(16, 32);
            this.dgvArticoli.Name = "dgvArticoli";
            this.dgvArticoli.RowHeadersWidth = 62;
            this.dgvArticoli.RowTemplate.Height = 28;
            this.dgvArticoli.Size = new System.Drawing.Size(788, 192);
            this.dgvArticoli.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARTICOLI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CLIENTI";
            // 
            // dgvClienti
            // 
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(848, 32);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.RowHeadersWidth = 62;
            this.dgvClienti.RowTemplate.Height = 28;
            this.dgvClienti.Size = new System.Drawing.Size(454, 192);
            this.dgvClienti.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "VENDITE";
            // 
            // dgvVendite
            // 
            this.dgvVendite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendite.Location = new System.Drawing.Point(12, 597);
            this.dgvVendite.Name = "dgvVendite";
            this.dgvVendite.RowHeadersWidth = 62;
            this.dgvVendite.RowTemplate.Height = 28;
            this.dgvVendite.Size = new System.Drawing.Size(537, 192);
            this.dgvVendite.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "COD_ART";
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(118, 237);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(100, 26);
            this.txtCodArt.TabIndex = 7;
            // 
            // txtNomeArt
            // 
            this.txtNomeArt.Location = new System.Drawing.Point(118, 272);
            this.txtNomeArt.Name = "txtNomeArt";
            this.txtNomeArt.Size = new System.Drawing.Size(100, 26);
            this.txtNomeArt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "NOME";
            // 
            // txtGiacenza
            // 
            this.txtGiacenza.Location = new System.Drawing.Point(118, 370);
            this.txtGiacenza.Name = "txtGiacenza";
            this.txtGiacenza.Size = new System.Drawing.Size(100, 26);
            this.txtGiacenza.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "GIACENZA";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(118, 338);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 26);
            this.txtPrezzo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "PREZZO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "AZIENDA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "COD_FORN";
            // 
            // txtScorta
            // 
            this.txtScorta.Location = new System.Drawing.Point(118, 402);
            this.txtScorta.Name = "txtScorta";
            this.txtScorta.Size = new System.Drawing.Size(100, 26);
            this.txtScorta.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "SCORTA";
            // 
            // cmbAziende
            // 
            this.cmbAziende.FormattingEnabled = true;
            this.cmbAziende.Location = new System.Drawing.Point(118, 305);
            this.cmbAziende.Name = "cmbAziende";
            this.cmbAziende.Size = new System.Drawing.Size(100, 28);
            this.cmbAziende.TabIndex = 19;
            // 
            // btnInserisciArt
            // 
            this.btnInserisciArt.Location = new System.Drawing.Point(16, 490);
            this.btnInserisciArt.Name = "btnInserisciArt";
            this.btnInserisciArt.Size = new System.Drawing.Size(202, 31);
            this.btnInserisciArt.TabIndex = 20;
            this.btnInserisciArt.Text = "INSERISCI ARTICOLO";
            this.btnInserisciArt.UseVisualStyleBackColor = true;
            this.btnInserisciArt.Click += new System.EventHandler(this.btnInserisciArt_Click);
            // 
            // cmbCodForn
            // 
            this.cmbCodForn.FormattingEnabled = true;
            this.cmbCodForn.Location = new System.Drawing.Point(118, 438);
            this.cmbCodForn.Name = "cmbCodForn";
            this.cmbCodForn.Size = new System.Drawing.Size(100, 28);
            this.cmbCodForn.TabIndex = 21;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(970, 237);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(100, 26);
            this.txtCodCliente.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(844, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "COD_CLIENTE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(844, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "COGNOME";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(970, 272);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 26);
            this.txtCognome.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(844, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(970, 307);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 26);
            this.txtNome.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(844, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "CITTA\'";
            // 
            // cmbCittà
            // 
            this.cmbCittà.FormattingEnabled = true;
            this.cmbCittà.Location = new System.Drawing.Point(970, 344);
            this.cmbCittà.Name = "cmbCittà";
            this.cmbCittà.Size = new System.Drawing.Size(100, 28);
            this.cmbCittà.TabIndex = 29;
            // 
            // btnInserisciCliente
            // 
            this.btnInserisciCliente.Location = new System.Drawing.Point(848, 397);
            this.btnInserisciCliente.Name = "btnInserisciCliente";
            this.btnInserisciCliente.Size = new System.Drawing.Size(222, 31);
            this.btnInserisciCliente.TabIndex = 30;
            this.btnInserisciCliente.Text = "INSERISCI CLIENTE";
            this.btnInserisciCliente.UseVisualStyleBackColor = true;
            this.btnInserisciCliente.Click += new System.EventHandler(this.btnInserisciCliente_Click);
            // 
            // cmbCodArt
            // 
            this.cmbCodArt.FormattingEnabled = true;
            this.cmbCodArt.Location = new System.Drawing.Point(680, 597);
            this.cmbCodArt.Name = "cmbCodArt";
            this.cmbCodArt.Size = new System.Drawing.Size(100, 28);
            this.cmbCodArt.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(555, 597);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "COD_ART";
            // 
            // cmbCodCliente
            // 
            this.cmbCodCliente.FormattingEnabled = true;
            this.cmbCodCliente.Location = new System.Drawing.Point(680, 640);
            this.cmbCodCliente.Name = "cmbCodCliente";
            this.cmbCodCliente.Size = new System.Drawing.Size(100, 28);
            this.cmbCodCliente.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(555, 643);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "COD_CLIENTE";
            // 
            // nudQta
            // 
            this.nudQta.Location = new System.Drawing.Point(680, 681);
            this.nudQta.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudQta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQta.Name = "nudQta";
            this.nudQta.Size = new System.Drawing.Size(101, 26);
            this.nudQta.TabIndex = 35;
            this.nudQta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(555, 687);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "QUANTITA\'";
            // 
            // btnInserisciVendita
            // 
            this.btnInserisciVendita.Location = new System.Drawing.Point(559, 726);
            this.btnInserisciVendita.Name = "btnInserisciVendita";
            this.btnInserisciVendita.Size = new System.Drawing.Size(222, 31);
            this.btnInserisciVendita.TabIndex = 37;
            this.btnInserisciVendita.Text = "INSERISCI VENDITA";
            this.btnInserisciVendita.UseVisualStyleBackColor = true;
            this.btnInserisciVendita.Click += new System.EventHandler(this.btnInserisciVendita_Click);
            // 
            // frmMagazzinoFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 843);
            this.Controls.Add(this.btnInserisciVendita);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.nudQta);
            this.Controls.Add(this.cmbCodCliente);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbCodArt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnInserisciCliente);
            this.Controls.Add(this.cmbCittà);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.cmbCodForn);
            this.Controls.Add(this.btnInserisciArt);
            this.Controls.Add(this.cmbAziende);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtScorta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiacenza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomeArt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvVendite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClienti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvArticoli);
            this.Name = "frmMagazzinoFile";
            this.Text = "Gestione Magazzino con uso File";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMagazzinoFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticoli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticoli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVendite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.TextBox txtNomeArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiacenza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtScorta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAziende;
        private System.Windows.Forms.Button btnInserisciArt;
        private System.Windows.Forms.ComboBox cmbCodForn;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbCittà;
        private System.Windows.Forms.Button btnInserisciCliente;
        private System.Windows.Forms.ComboBox cmbCodArt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCodCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudQta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnInserisciVendita;
    }
}

