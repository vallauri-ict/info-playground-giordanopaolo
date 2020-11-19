using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_EsercizioPila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct Containe
        {
            public string Cod;
            public string peso;
            public string tara;
        }
        Stack<Containe> container = new Stack<Containe>();
        private void button1_Click(object sender, EventArgs e)
        {
            Containe c;
            c.Cod = cod.Text;
            c.peso = peso.Text;
            c.tara = tara.Text;
            container.Push(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(container.Count != 0)
            {
                Containe c = container.Peek();
                MessageBox.Show("Cod" + c.Cod + "\nPeso:" + c.peso + "\nTara:" + c.tara);
                container.Pop();
            }
            else MessageBox.Show("non ci sono più container");


        }
    }
}
