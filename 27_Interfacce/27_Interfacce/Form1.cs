using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_Interfacce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconnetti_Click(object sender, EventArgs e)
        {
            con.connetti("pippo");
        }
        MyComponent con;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new MyComponent();
        }

        private void btnDisocnnetti_Click(object sender, EventArgs e)
        {
            con.disconnetti("pippo");
        }

        private void btnstato_Click(object sender, EventArgs e)
        {
            con.stato();
        }
    }
}
