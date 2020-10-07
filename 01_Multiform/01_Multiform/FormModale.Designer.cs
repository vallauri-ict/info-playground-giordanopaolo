namespace _01_Multiform
{
    partial class FormModale
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAnnulla = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtBNome = new System.Windows.Forms.TextBox();
            this.txtBEtà = new System.Windows.Forms.TextBox();
            this.LblEtà = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAnnulla
            // 
            this.BtnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAnnulla.Location = new System.Drawing.Point(12, 265);
            this.BtnAnnulla.Name = "BtnAnnulla";
            this.BtnAnnulla.Size = new System.Drawing.Size(273, 173);
            this.BtnAnnulla.TabIndex = 0;
            this.BtnAnnulla.Text = "Annulla";
            this.BtnAnnulla.UseVisualStyleBackColor = true;
            this.BtnAnnulla.Click += new System.EventHandler(this.BtnAnnulla_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(505, 265);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(283, 173);
            this.BtnOk.TabIndex = 1;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(13, 13);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(36, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "nome:";
            // 
            // TxtBNome
            // 
            this.TxtBNome.Location = new System.Drawing.Point(56, 13);
            this.TxtBNome.Name = "TxtBNome";
            this.TxtBNome.Size = new System.Drawing.Size(100, 20);
            this.TxtBNome.TabIndex = 3;
            // 
            // txtBEtà
            // 
            this.txtBEtà.Location = new System.Drawing.Point(56, 39);
            this.txtBEtà.Name = "txtBEtà";
            this.txtBEtà.Size = new System.Drawing.Size(100, 20);
            this.txtBEtà.TabIndex = 5;
            // 
            // LblEtà
            // 
            this.LblEtà.AutoSize = true;
            this.LblEtà.Location = new System.Drawing.Point(13, 39);
            this.LblEtà.Name = "LblEtà";
            this.LblEtà.Size = new System.Drawing.Size(22, 13);
            this.LblEtà.TabIndex = 4;
            this.LblEtà.Text = "età";
            // 
            // FormModale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBEtà);
            this.Controls.Add(this.LblEtà);
            this.Controls.Add(this.TxtBNome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnAnnulla);
            this.Name = "FormModale";
            this.Text = "FormModale";
            this.Load += new System.EventHandler(this.FormModale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnnulla;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtBNome;
        private System.Windows.Forms.TextBox txtBEtà;
        private System.Windows.Forms.Label LblEtà;
    }
}