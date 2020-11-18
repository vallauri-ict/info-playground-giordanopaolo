using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Esercizio_in_classe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct dizionario
        {
            public int Key;
            public string nomearticolo;
        }
        Dictionary<int, dizionario> diz = new Dictionary<int, dizionario>();
        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            dizionario d;
            d.Key = Convert.ToInt32(textBox1.Text);
            d.nomearticolo = textBox2.Text;
            diz.Add(Convert.ToInt32(textBox1.Text), d);
        }

        private void BtnVisualizza_Click(object sender, EventArgs e)
        {
            Lblnum.Text = "Numero elementi=" + diz.Count;
        }

        private void BtnCerca_Click(object sender, EventArgs e)
        {
            lblnomeart.Text = "Nome articolo cercato=" + diz[Convert.ToInt32(textBox1.Text)].nomearticolo;
        }
    }
}
