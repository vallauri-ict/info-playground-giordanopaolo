using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _11_esvalidazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valido = true;
            Regex regcono = new Regex(@"^[A-Z].");//corretto, fa sia cognome e nome
            if (!regcono.IsMatch(TxtNome.Text))
            {
                txtCognome.Text = "";
                MessageBox.Show("il nome Non va bene");
                valido = false;
            }
            if (!regcono.IsMatch(txtCognome.Text))
            {
                txtCognome.Text = "";
                MessageBox.Show("il cognome Non va bene");
                valido = false;
            }
            Regex regmail = new Regex(@"^.+@.+\..{2,4}$");//(@".(?=.*[@]).(?=.*[.]).");corretto
            if (!regmail.IsMatch(Txtmail.Text))
            {
                txtCognome.Text = "";
                MessageBox.Show("la mail Non va bene");
                valido = false;
            }
            Regex regpsw = new Regex(@"(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}");//corretto
            if (!regpsw.IsMatch(txtpass.Text))
            {
                txtCognome.Text = "";
                MessageBox.Show("la password Non va bene");
                valido = false;
            }
            Regex regcap = new Regex(@"^\d{5}$");//funge
            if (!regcap.IsMatch(txtcap.Text))
            {
                txtCognome.Text = "";
                MessageBox.Show("il cap Non va bene");
                valido = false;
            }
            if (txtindirizzo.Text == "")
            {
                txtCognome.Text = "";
                //MessageBox.Show("L'indirizzo Non va bene");
                valido = false;
            }
            if (txtcittà.Text == "")
            {
                txtCognome.Text = "";
                MessageBox.Show("La citta Non va bene");
                valido = false;
            }
            Regex regcodicefiscale = new Regex(@"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]");
            if (!regcodicefiscale.IsMatch(txtcodfiscale.Text))
            {
                txtCognome.Text = "";
                MessageBox.Show("Il codice fiscale Non va bene");
                valido = false;
            }
            if (txtuser.Text == "")
            {
                txtCognome.Text = "";
                MessageBox.Show("La citta Non va bene");
                valido = false;
            }
            if (valido)
                Utenti.ToString(txtCognome.Text, TxtNome.Text, Txtmail.Text, txtcap.Text, txtindirizzo.Text, txtcittà.Text, txtcodfiscale.Text, txtuser.Text, txtpass.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
