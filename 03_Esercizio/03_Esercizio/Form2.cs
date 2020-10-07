using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Esercizio
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int n = 0;
        public Form2(int n)
        {
            InitializeComponent();
            this.n = n;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (n != 0)
                MessageBox.Show(n.ToString());
        }
    }
}
