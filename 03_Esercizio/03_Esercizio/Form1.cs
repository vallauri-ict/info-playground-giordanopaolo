using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Esercizio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone apri Fomr 2";
            Form2 f = new Form2();
            f.Show();
        }

        private void apriForm2ConNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone apri Fomr 2 con n";
            Form2 f = new Form2(8);
            f.Show();
        }

        private void apriForm2ContestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone apri Fomr 2 con figli";
            Form2 formtextbox = new Form2();
            formtextbox.Text = "Form Padre";
            formtextbox.Show();
            FormFiglia form = new FormFiglia();
            formtextbox.AddOwnedForm(form);//congratulazione è appena nata un form femmina
            form.Text = "Form Figlia";
            form.Show();
        }

        private void apriFormModaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Premuto ok");
                TxtBNomefm.Text = fm.nome;
                txtBEtàfm.Text = fm.età;

            }
            else
            {
                MessageBox.Show("Premuto annulla");
                TxtBNomefm.Text = "";
                txtBEtàfm.Text = "";
            }
        }
    }
}
