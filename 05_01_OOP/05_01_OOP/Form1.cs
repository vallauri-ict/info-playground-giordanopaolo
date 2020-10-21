using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_01_OOP
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        private void btncrea_Click(object sender, EventArgs e)
        {
            /*r.b = Convert.ToInt32(textBox1.Text);
            r.h = Convert.ToInt32(textBox2.Text);
            Rectangle t;
            t = r;
            MessageBox.Show("base:" + r.b.ToString() + "\naltezza:" + r.h.ToString());
            MessageBox.Show("base:" + t.b.ToString() + "\naltezza:" + t.h.ToString());
            */
            Rectangle r = new Rectangle(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            r.Colore = Color.Orange;
            MessageBox.Show(r.getsides());
        }


    }
}
