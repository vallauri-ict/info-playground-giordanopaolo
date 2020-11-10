using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _10_ES_per11_Regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Regex reg;
        private void button1_Click(object sender, EventArgs e)
        {
            reg = new Regex(@"^\D{2}\d{3}\D{2}$");
            if (reg.IsMatch(textBox1.Text))
                MessageBox.Show("OK");
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Non va bene");
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reg = new Regex(@"^\D{8}\d{3}[-?@]$");
            if (reg.IsMatch(textBox1.Text))
                MessageBox.Show("OK");
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Non av bene");
            }
        }
    }
}
