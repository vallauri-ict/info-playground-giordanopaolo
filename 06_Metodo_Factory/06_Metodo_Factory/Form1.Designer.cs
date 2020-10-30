namespace _06_Metodo_Factory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLatoQuad = new System.Windows.Forms.TextBox();
            this.btnQuad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci il lato del quandrato";
            // 
            // txtLatoQuad
            // 
            this.txtLatoQuad.Location = new System.Drawing.Point(178, 13);
            this.txtLatoQuad.Name = "txtLatoQuad";
            this.txtLatoQuad.Size = new System.Drawing.Size(100, 23);
            this.txtLatoQuad.TabIndex = 1;
            // 
            // btnQuad
            // 
            this.btnQuad.Location = new System.Drawing.Point(285, 12);
            this.btnQuad.Name = "btnQuad";
            this.btnQuad.Size = new System.Drawing.Size(110, 38);
            this.btnQuad.TabIndex = 2;
            this.btnQuad.Text = "Crea Quadrato";
            this.btnQuad.UseVisualStyleBackColor = true;
            this.btnQuad.Click += new System.EventHandler(this.btnQuad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuad);
            this.Controls.Add(this.txtLatoQuad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLatoQuad;
        private System.Windows.Forms.Button btnQuad;
    }
}

