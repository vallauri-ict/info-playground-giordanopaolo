using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct libro
        {
            public string titolo;
            public string autore;
        }
        public int i = 0;
        Dictionary<int, libro> dizionarioLibri = new Dictionary<int, libro>();
        private void button1_Click(object sender, EventArgs e)
        {
            libro l;
            l.titolo = textBox1.Text;
            l.autore = textBox2.Text;
            dizionarioLibri.Add(i, l);
            i++;
        }
        private void btnVisDizionario_Click(object sender, EventArgs e)
        {
            foreach (libro l in dizionarioLibri.Values)
                MessageBox.Show(l.titolo + " " + l.autore);
        }
    }
}
