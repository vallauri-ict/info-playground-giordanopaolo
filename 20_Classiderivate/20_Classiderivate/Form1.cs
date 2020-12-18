using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20_Classiderivate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Studente> lstStudenti = new List<Studente>();
        private void button1_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s.setAtt(txtnome.Text, txtcognome.Text, Convert.ToInt32(txteta.Text), txtsesso.Text);
            lstStudenti.Add(s);
            listStudenti.Items.Add(s.getcognome());
        }



        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Studente i in lstStudenti)
            {
                if (i.getcognome() == listStudenti.SelectedItems[0].Text)
                    i.voti.Add(Convert.ToInt32(TxtVoto.Text));
            }
        }

        private void btnVisulizza_Click(object sender, EventArgs e)
        {
            Studente s = new Studente();
            s = lstStudenti.Find(stud => stud.getcognome() == listStudenti.SelectedItems[0].Text);
            MessageBox.Show("Lo studente " + s.getcognome() + " " + s.getnome() + " ha " + s.geteta() + " anni e ha preso " + s.Media());
        }
    }
}
