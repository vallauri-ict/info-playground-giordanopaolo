using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Metodo_Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreaclasse_Click(object sender, EventArgs e)
        {
            singleton s = singleton.Getsingleton(Convert.ToInt32(TxtValore.Text));
            MessageBox.Show("Valore si s = " + s.val);
            singleton s1 = singleton.Getsingleton(0);
            MessageBox.Show("Valore di s1 = " + s1.val);
            MessageBox.Show("Valore si s = " + s.val);


        }
    }
}
