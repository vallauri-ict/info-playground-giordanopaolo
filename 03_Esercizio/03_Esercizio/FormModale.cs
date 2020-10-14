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
    public partial class FormModale : Form
    {
        public FormModale()
        {
            InitializeComponent();
        }
        public string Nome = "";
        public string Età = "";
        public void FormModale_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nome = "";
            Età = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nome = nome.Text;
            Età = età.Text;
        }
    }
}
