﻿namespace _03_Esercizio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2ConNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstl = new System.Windows.Forms.ToolStripStatusLabel();
            this.apriForm2ContestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormModaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriForm2ToolStripMenuItem,
            this.apriForm2ConNToolStripMenuItem,
            this.apriForm2ContestoToolStripMenuItem,
            this.apriFormModaleToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menùToolStripMenuItem.Text = "&Menù";
            // 
            // apriForm2ToolStripMenuItem
            // 
            this.apriForm2ToolStripMenuItem.Name = "apriForm2ToolStripMenuItem";
            this.apriForm2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apriForm2ToolStripMenuItem.Text = "&Apri Form 2";
            this.apriForm2ToolStripMenuItem.Click += new System.EventHandler(this.apriForm2ToolStripMenuItem_Click);
            // 
            // apriForm2ConNToolStripMenuItem
            // 
            this.apriForm2ConNToolStripMenuItem.Name = "apriForm2ConNToolStripMenuItem";
            this.apriForm2ConNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apriForm2ConNToolStripMenuItem.Text = "Apri Form 2 con &n";
            this.apriForm2ConNToolStripMenuItem.Click += new System.EventHandler(this.apriForm2ConNToolStripMenuItem_Click);
            // 
            // tstl
            // 
            this.tstl.Name = "tstl";
            this.tstl.Size = new System.Drawing.Size(31, 17);
            this.tstl.Text = "Ciao";
            // 
            // apriForm2ContestoToolStripMenuItem
            // 
            this.apriForm2ContestoToolStripMenuItem.Name = "apriForm2ContestoToolStripMenuItem";
            this.apriForm2ContestoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.apriForm2ContestoToolStripMenuItem.Text = "Apri Form 2 con &figli";
            this.apriForm2ContestoToolStripMenuItem.Click += new System.EventHandler(this.apriForm2ContestoToolStripMenuItem_Click);
            // 
            // apriFormModaleToolStripMenuItem
            // 
            this.apriFormModaleToolStripMenuItem.Name = "apriFormModaleToolStripMenuItem";
            this.apriFormModaleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.apriFormModaleToolStripMenuItem.Text = "Apri Form Modale";
            this.apriFormModaleToolStripMenuItem.Click += new System.EventHandler(this.apriFormModaleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem apriForm2ConNToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tstl;
        private System.Windows.Forms.ToolStripMenuItem apriForm2ContestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFormModaleToolStripMenuItem;
    }
}

