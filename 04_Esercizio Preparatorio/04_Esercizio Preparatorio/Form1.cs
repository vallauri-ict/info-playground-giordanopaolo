using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Esercizio_Preparatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiUscita f = new FormDiUscita();
            if (DialogResult.Cancel == f.ShowDialog())
                this.Close();
            
        }

        private void secondariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Secondaria f = new Secondaria(textBox1, textBox2);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MdiChildren[0].Close();
            FormDiDialoghi f = new FormDiDialoghi(textBox1, textBox2);
            f.MdiParent = this;
            f.Show();
        }

        private void figliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            FormDiDialoghi f = new FormDiDialoghi(textBox1, textBox2);
            f.MdiParent = this;
            f.Show();
        }

        private void dinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formdinamica f = new formdinamica();
            f.Show();
        }

        private void modaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formmodale f = new formmodale();
            f.MdiParent = this;
            f.Show();
        }
    }
}
