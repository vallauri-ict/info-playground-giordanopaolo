using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Classi_Carte_2
{
    class Carte
    {
        public string seme;
        public string valore;
        public Carte(){}
        public Carte(string valore, string seme)
        {
            Valore = valore;
            Seme = seme;
        }

        public string[] val = { "asso", "2", "3", "4", "5", "6", "7", "fante", "regina", "re" };

        public string[] semi = { "cuore", "picche", "fiore", "quadri" };

        public string Valore
        {
            get => valore; set
            {
                bool esc = false;
                for (int i = 0; i < val.Length; i++)
                {
                    if (value == val[i])
                    {
                            valore = value;
                            esc = true;
                            break;
                    }
                }
                if (esc == false)
                    throw new Exception("Valore non valido");
            }
        }

        public void ReadCard()
        {
            System.Windows.Forms.MessageBox.Show("La tua carta è il " + valore.ToString() + " di " + seme);
        }

        public string Seme { get => seme; set {
                if (value == "Cuori" || value == "Picche" || value == "Fiori" || value == "Quadri")
                    seme = value;
                else throw new Exception("Seme non valido");
            } 
        }


    }
}
