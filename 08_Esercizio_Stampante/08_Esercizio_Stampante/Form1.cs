using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Esercizio_Stampante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct stampante
        {
            public string stampa;
            public string pc;//dal quale viene la richiesta di stampa
        }
        Queue<stampante> coda = new Queue<stampante>();
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            stampante st = new stampante();
            st.stampa = txtSTAMPA.Text;
            st.pc = txtPC.Text;
            coda.Enqueue(st);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (i == 0)
                MessageBox.Show("La coda è vuota");
            else
            {
                coda.Dequeue();
                i--;
            }
            
        }
    }
}
