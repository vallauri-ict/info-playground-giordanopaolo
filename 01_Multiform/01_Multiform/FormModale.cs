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
    public partial class FormModale : Form
    {
        public string nome = "";
        public string età = "";

        public FormModale()
        {
            InitializeComponent();
        }

        private void FormModale_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            nome = TxtBNome.Text;
            età = txtBEtà.Text;
        }

        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            nome = "";
            età = "";
        }
    }
}
