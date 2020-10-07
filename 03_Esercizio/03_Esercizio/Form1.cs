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
            Form2 formtextbox = new Form2();
            formtextbox.Text = "Form Padre";
            formtextbox.Show();
            FormFiglia form = new FormFiglia();
            this.AddOwnedForm(form);//congratulazione è appena nata un form femmina
            form.Text = "Form Figlia";
            form.Show();
        }
    }
}
