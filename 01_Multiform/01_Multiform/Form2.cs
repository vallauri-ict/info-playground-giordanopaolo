using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Multiform
{
    public partial class Form2 : Form
    {
        private int n;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }
        private TextBox txt1;
        public Form2(TextBox txt1)
        {
            InitializeComponent();
            this.txt1 = txt1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = ok.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(n.ToString());
        }

        private void btnFormFiglia_Click(object sender, EventArgs e)
        {
            FormFiglia form = new FormFiglia();
            this.AddOwnedForm(form);//congratulazione è appena nata un form femmina
            form.Show();
        }
    }
}
