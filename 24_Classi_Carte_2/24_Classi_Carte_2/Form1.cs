using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Classi_Carte_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MazzoCarte m = new MazzoCarte();
            Carte c = new Carte("7", "Cuori");
            //m.InserisciCarta(c);
            Carte ca = m.EstraiACaso("Cuori", "7");
            ca.ReadCard();
        }
    }
}
