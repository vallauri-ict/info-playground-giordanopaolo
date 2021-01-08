using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_EsercizioNumeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            Complesso c;
            if (txtreale.Text == "" && txtQuaternione.Text != "")
            {
                c = new Complesso(Convert.ToDouble(txtQuaternione.Text));
            }
            else if (txtreale.Text != "" && txtQuaternione.Text != "")
            {
                c = new Complesso(Convert.ToDouble(txtreale.Text), Convert.ToDouble(txtQuaternione.Text));
            }
            else
            {
                c = new Complesso();
            }
            MessageBox.Show(c.Modulo().ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quaternione q = new Quaternione(Convert.ToDouble(txtreale.Text), 
                                            Convert.ToDouble(txtQuaternione.Text), 
                                            Convert.ToDouble(txtJ.Text), 
                                            Convert.ToDouble(txtK.Text));
            MessageBox.Show(q.Modulo().ToString());
        }
    }
}
