namespace _07_Metodo_Singleton
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
            this.btncreaclasse = new System.Windows.Forms.Button();
            this.lblval = new System.Windows.Forms.Label();
            this.TxtValore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncreaclasse
            // 
            this.btncreaclasse.Location = new System.Drawing.Point(203, 113);
            this.btncreaclasse.Name = "btncreaclasse";
            this.btncreaclasse.Size = new System.Drawing.Size(75, 23);
            this.btncreaclasse.TabIndex = 0;
            this.btncreaclasse.Text = "Crea Classe";
            this.btncreaclasse.UseVisualStyleBackColor = true;
            this.btncreaclasse.Click += new System.EventHandler(this.btncreaclasse_Click);
            // 
            // lblval
            // 
            this.lblval.AutoSize = true;
            this.lblval.Location = new System.Drawing.Point(-49, -50);
            this.lblval.Name = "lblval";
            this.lblval.Size = new System.Drawing.Size(117, 15);
            this.lblval.TabIndex = 1;
            this.lblval.Text = "Iserisci un valore qui:";
            // 
            // TxtValore
            // 
            this.TxtValore.Location = new System.Drawing.Point(81, 113);
            this.TxtValore.Name = "TxtValore";
            this.TxtValore.Size = new System.Drawing.Size(100, 23);
            this.TxtValore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iserisci un val";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtValore);
            this.Controls.Add(this.lblval);
            this.Controls.Add(this.btncreaclasse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreaclasse;
        private System.Windows.Forms.Label lblval;
        private System.Windows.Forms.TextBox TxtValore;
        private System.Windows.Forms.Label label1;
    }
}

