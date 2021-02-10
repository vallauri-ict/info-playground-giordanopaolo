using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_10_Stagisti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsElenco lst;

        private void Form1_Load(object sender, EventArgs e)
        {
            lst = new ClsElenco();
        }

        private void btmCrea_Click(object sender, EventArgs e)
        {
            Studente stu;
            if(Convert.ToInt32(txtOre.Text.Trim()) == 0)
            {
                stu = new Studente(txtNome.Text, Convert.ToChar(cmbSezione.Text), cmbSpec.Text, 
                                   cmbClasse.Text, txtCognome.Text, txtCitta.Text);
            }
            else
            {
                stu = new Stagista(cmbAzienda.Text, txtOre.Text, txtNome.Text, Convert.ToChar(cmbSezione.Text),
                                   cmbSpec.Text, cmbClasse.Text, txtCognome.Text, txtCitta.Text);
                btmCerca.Enabled = true;
            }
            lst.inserisci(stu);
            lst.visualizzaDgv(dgvStag);
            Clear();
        }

        private void Clear()
        {
            foreach (Control t in Controls)
            {
                if(t is TextBox)
                {
                    (t as TextBox).Text = "";
                }
                if (t is ComboBox)
                    (t as ComboBox).SelectedIndex = -1;
            }
        }

        private void btmCerca_Click(object sender, EventArgs e)
        {
            string az = cmbAzienda.SelectedItem.ToString();
            int ore = lst.OreAzienda(az);
            if (ore != 0)
                MessageBox.Show("Gli stagisti hanno effettuato ore: " + ore.ToString());
        }

        private void btmElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value == -1)
                {
                    lst.Canc();
                    numericUpDown1.Maximum--;
                }
                int pos = Convert.ToInt32(numericUpDown1.Value);
                if (pos >= 0)
                {
                    lst.Canc(pos);
                    numericUpDown1.Maximum--;
                }
                lst.visualizzaDgv(dgvStag);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
