using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_Interfaccia_People
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Person[] vect = new Person[] { new Person("Mario Rossi", "Cuneo"),
                                       new Person("Enrico Alessandrini", "Fossano"),
                                       new Person("Ettore Scemo", "SaviCity"),
                                       new Person("Giordy Anddicapattto", "SaviNord")};
        


        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var item in vect)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
            Array.Sort(vect);
            s = "";
            foreach (var item in vect)
            {
                s += item.ToString() + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
