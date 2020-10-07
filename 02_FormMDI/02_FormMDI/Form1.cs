using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_FormMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAprif1_Click(object sender, EventArgs e)
        {
            FormFiglia1 f1 = new FormFiglia1();
            f1.Text = "Form Figlia 1";
            f1.MdiParent = this;
            f1.Size = new Size(210, 180);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(50, 50);
            f1.Show();


        }

        private void Btnaprif2_Click(object sender, EventArgs e)
        {
            FormFiglia2 f2 = new FormFiglia2();
            f2.Text = "Form Figlia 2";
            f2.MdiParent = this;
            f2.Size = new Size(210, 180);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(0, 20);
            f2.Show();
        }

        private void Btnaperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sono state aperte" + this.MdiChildren.Length + "Finestre");
            foreach (Form f in this.MdiChildren)
                MessageBox.Show("Finestra" + f.Text + "aperta");
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalEsci f = new ModalEsci();
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLblCiao.Text = "premuto Apri 1";
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLblCiao.Text = "premuto Apri 2";
        }
    }
}
