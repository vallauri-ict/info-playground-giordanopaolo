namespace _14_Esercizio_in_classe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInserisci = new System.Windows.Forms.Button();
            this.BtnVisualizza = new System.Windows.Forms.Button();
            this.BtnCerca = new System.Windows.Forms.Button();
            this.Lblnum = new System.Windows.Forms.Label();
            this.lblnomeart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value:";
            // 
            // BtnInserisci
            // 
            this.BtnInserisci.Location = new System.Drawing.Point(12, 83);
            this.BtnInserisci.Name = "BtnInserisci";
            this.BtnInserisci.Size = new System.Drawing.Size(132, 29);
            this.BtnInserisci.TabIndex = 4;
            this.BtnInserisci.Text = "Inserisci";
            this.BtnInserisci.UseVisualStyleBackColor = true;
            this.BtnInserisci.Click += new System.EventHandler(this.BtnInserisci_Click);
            // 
            // BtnVisualizza
            // 
            this.BtnVisualizza.Location = new System.Drawing.Point(171, 83);
            this.BtnVisualizza.Name = "BtnVisualizza";
            this.BtnVisualizza.Size = new System.Drawing.Size(138, 29);
            this.BtnVisualizza.TabIndex = 4;
            this.BtnVisualizza.Text = "Visualizza";
            this.BtnVisualizza.UseVisualStyleBackColor = true;
            this.BtnVisualizza.Click += new System.EventHandler(this.BtnVisualizza_Click);
            // 
            // BtnCerca
            // 
            this.BtnCerca.Location = new System.Drawing.Point(12, 118);
            this.BtnCerca.Name = "BtnCerca";
            this.BtnCerca.Size = new System.Drawing.Size(391, 26);
            this.BtnCerca.TabIndex = 5;
            this.BtnCerca.Text = "Cerca";
            this.BtnCerca.UseVisualStyleBackColor = true;
            this.BtnCerca.Click += new System.EventHandler(this.BtnCerca_Click);
            // 
            // Lblnum
            // 
            this.Lblnum.AutoSize = true;
            this.Lblnum.Location = new System.Drawing.Point(152, 19);
            this.Lblnum.Name = "Lblnum";
            this.Lblnum.Size = new System.Drawing.Size(114, 15);
            this.Lblnum.TabIndex = 6;
            this.Lblnum.Text = "Numero elementi=0";
            // 
            // lblnomeart
            // 
            this.lblnomeart.AutoSize = true;
            this.lblnomeart.Location = new System.Drawing.Point(152, 49);
            this.lblnomeart.Name = "lblnomeart";
            this.lblnomeart.Size = new System.Drawing.Size(251, 15);
            this.lblnomeart.TabIndex = 7;
            this.lblnomeart.Text = "Nomearticolocercato=Nessun articolo cercato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 154);
            this.Controls.Add(this.lblnomeart);
            this.Controls.Add(this.Lblnum);
            this.Controls.Add(this.BtnCerca);
            this.Controls.Add(this.BtnVisualizza);
            this.Controls.Add(this.BtnInserisci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnInserisci;
        private System.Windows.Forms.Button BtnVisualizza;
        private System.Windows.Forms.Button BtnCerca;
        private System.Windows.Forms.Label Lblnum;
        private System.Windows.Forms.Label lblnomeart;
    }
}

