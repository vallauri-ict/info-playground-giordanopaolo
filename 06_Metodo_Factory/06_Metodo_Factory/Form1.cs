using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Metodo_Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            Quadrato q;
            if (txtLatoQuad.Text != "")
                try
                {
                    q = Quadrato.creaquadrato(Convert.ToInt32(txtLatoQuad.Text));
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            else MessageBox.Show("Compilare il campo!!!!");
        }
    }
}
