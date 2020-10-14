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

        public void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone apri Fomr 2";
            Form2 f = new Form2();
            f.Show();
        }

        public void apriForm2ConNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone apri Fomr 2 con n";
            Form2 f = new Form2(8);
            f.Show();
        }

        public void apriForm2ContestoToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void apriFormModaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone apri Fomr Moadale";
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Premuto ok");
                TxtBNomefm.Text = fm.Nome;
                txtBEtàfm.Text = fm.Età;

            }
            else
            {
                MessageBox.Show("Premuto annulla");
                TxtBNomefm.Text = "";
                txtBEtàfm.Text = "";
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void apriFomrFigliaMidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone apri Form figlia mid";
            FormFiglia f1 = new FormFiglia();
            f1.Text = "Form Figlia 1";
            f1.MdiParent = this;
            f1.Size = new Size(210, 180);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(50, 50);
            f1.Show();
        }

        private void cOSAÈAPERTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tstl.Text = "ha premuto bottone cosa è aperto";
            MessageBox.Show("sono state aperte" + this.MdiChildren.Length + "Finestre");
            foreach (Form f in this.MdiChildren)
                MessageBox.Show("Finestra" + f.Text + "aperta");
        }
    }
}
