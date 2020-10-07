namespace _02_FormMDI
{
    partial class ModalEsci
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
            this.Btnsi = new System.Windows.Forms.Button();
            this.BtnNO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btnsi
            // 
            this.Btnsi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btnsi.Location = new System.Drawing.Point(21, 40);
            this.Btnsi.Name = "Btnsi";
            this.Btnsi.Size = new System.Drawing.Size(75, 23);
            this.Btnsi.TabIndex = 0;
            this.Btnsi.Text = "!!!!!!!!!!!!!!SI";
            this.Btnsi.UseVisualStyleBackColor = true;
            // 
            // BtnNO
            // 
            this.BtnNO.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnNO.Location = new System.Drawing.Point(115, 40);
            this.BtnNO.Name = "BtnNO";
            this.BtnNO.Size = new System.Drawing.Size(75, 23);
            this.BtnNO.TabIndex = 1;
            this.BtnNO.Text = "!!!!!!!!!!!!!SI";
            this.BtnNO.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnNO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure about that?";
            // 
            // ModalEsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 136);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNO);
            this.Controls.Add(this.Btnsi);
            this.Name = "ModalEsci";
            this.Text = "ModalEsci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnsi;
        private System.Windows.Forms.Button BtnNO;
        private System.Windows.Forms.Label label1;
    }
}