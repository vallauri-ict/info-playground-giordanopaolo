namespace _12_Uso_delle_liste
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
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnvisualizza = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.BtnfindAll = new System.Windows.Forms.Button();
            this.txtfind = new System.Windows.Forms.TextBox();
            this.btnaddobj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(58, 13);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 23);
            this.txtTitolo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Autore";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(58, 42);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 23);
            this.txtAutore.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(58, 71);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 23);
            this.TxtID.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnvisualizza
            // 
            this.btnvisualizza.Location = new System.Drawing.Point(90, 115);
            this.btnvisualizza.Name = "btnvisualizza";
            this.btnvisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnvisualizza.TabIndex = 2;
            this.btnvisualizza.Text = "Visualizza";
            this.btnvisualizza.UseVisualStyleBackColor = true;
            this.btnvisualizza.Click += new System.EventHandler(this.btnviusalizza_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(10, 240);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // BtnfindAll
            // 
            this.BtnfindAll.Location = new System.Drawing.Point(91, 240);
            this.BtnfindAll.Name = "BtnfindAll";
            this.BtnfindAll.Size = new System.Drawing.Size(75, 23);
            this.BtnfindAll.TabIndex = 2;
            this.BtnfindAll.Text = "find all";
            this.BtnfindAll.UseVisualStyleBackColor = true;
            this.BtnfindAll.Click += new System.EventHandler(this.btn_click);
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(21, 213);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(137, 23);
            this.txtfind.TabIndex = 3;
            // 
            // btnaddobj
            // 
            this.btnaddobj.Location = new System.Drawing.Point(9, 159);
            this.btnaddobj.Name = "btnaddobj";
            this.btnaddobj.Size = new System.Drawing.Size(75, 23);
            this.btnaddobj.TabIndex = 2;
            this.btnaddobj.Text = "Add obj";
            this.btnaddobj.UseVisualStyleBackColor = true;
            this.btnaddobj.Click += new System.EventHandler(this.btnaddobj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "visual obj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnvisualizzaobj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnaddobj);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.BtnfindAll);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnvisualizza);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnvisualizza;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button BtnfindAll;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.Button btnaddobj;
        private System.Windows.Forms.Button button1;
    }
}

