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
    public partial class Secondaria : Form
    {
        public Secondaria()
        {
            InitializeComponent();
        }
        TextBox aus1 = new TextBox();
        TextBox aus2 = new TextBox();

        public Secondaria(TextBox txt1,TextBox txt2)
        {
            InitializeComponent();
            aus1 = txt1;
            aus2 = txt2;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " " + textBox2.Text);
            aus1.Text = textBox1.Text;
            aus2.Text = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Annullamento");
            aus1.Text = "";
            aus2.Text = "";
            this.Close();
        }
    }
}
