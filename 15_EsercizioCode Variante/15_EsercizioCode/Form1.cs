using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_EsercizioCode
{
    public partial class Form1 : Form
    {
        double max = 0;
        double min = 55;
        public Form1()
        {
            InitializeComponent();
        }
        public struct Pazienti
        {
            public string Nome;
            public string Età;
            public string colore;
        }
        Queue<Pazienti> codaRossa = new Queue<Pazienti>();
        Queue<Pazienti> codaGialla = new Queue<Pazienti>();
        Queue<Pazienti> codaVerde = new Queue<Pazienti>();
        Queue<Pazienti> codaBianca = new Queue<Pazienti>();
        List<double> temperature = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            Pazienti p = new Pazienti();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
                MessageBox.Show("ATTENZIONE:\nMANCANO DEI DATI");
            p.Nome = textBox1.Text;
            p.colore = comboBox1.Text;
            p.Età = textBox2.Text;
            temperature.Add(Convert.ToDouble(textBox3.Text));
            switch(comboBox1.Text)
            {
                case "Rosso":
                    codaRossa.Enqueue(p);
                    break;
                case "Giallo":
                    codaGialla.Enqueue(p);
                    break;
                case "Verde":
                    codaVerde.Enqueue(p);
                    break;
                case "Bianco":
                    codaBianca.Enqueue(p);
                    break;
            }
            if (Convert.ToDouble(textBox3.Text) > max)
                max = Convert.ToDouble(textBox3.Text);
            if (Convert.ToDouble(textBox3.Text) < min)
                min = Convert.ToDouble(textBox3.Text);


        }
        private void BtnCura(object sender, EventArgs e)
        {
            if (codaRossa.Count != 0)
                codaRossa.Dequeue();
            else if (codaGialla.Count != 0)
                codaGialla.Dequeue();
            else if (codaVerde.Count != 0)
                codaVerde.Dequeue();
            else if (codaBianca.Count != 0)
                codaBianca.Dequeue();
            else MessageBox.Show("non ci più appestati");

        }
        private void BTNCONTA(object sender, EventArgs e)
        {
            MessageBox.Show("Massimo:" + max.ToString());
            MessageBox.Show("Minimo:" + min.ToString());
        }

    }
}
