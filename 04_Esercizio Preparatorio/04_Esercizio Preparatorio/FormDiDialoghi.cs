using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Esercizio_Preparatorio
{
    public partial class FormDiDialoghi : Form
    {
        public FormDiDialoghi()
        {
            InitializeComponent();
        }
        TextBox aus1 = new TextBox();
        TextBox aus2 = new TextBox();

        public FormDiDialoghi(TextBox txt1, TextBox txt2)
        {
            InitializeComponent();
            aus1 = txt1;
            aus2 = txt2;
            textBox1.Text = txt1.Text;
            textBox2.Text = txt2.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            aus1.Text = textBox1.Text;
            aus2.Text = textBox2.Text;
        }
    }
}
