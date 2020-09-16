using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MagazzinoConFile
{
    class clsArticoli
    {
        internal static bool controllaArticolo(string lastCod, string codArt, string nomeArt, string azienda, string prezzo, string giacenza, string scorta, string codForn)
        {
            if (codArt == null || string.Compare(codArt, lastCod) <= 0)
            {
                MessageBox.Show("Codice articolo mancante o errato");
                return false;
            }
            else
            {
                if (nomeArt == null || azienda == null || prezzo == "" || giacenza == ""||scorta==""||codForn=="")
                {
                    MessageBox.Show("Dati mancanti");
                    return false;
                }
                else
                {
                    int pre;
                    if ((!int.TryParse(prezzo, out pre)) || (Convert.ToInt32(prezzo) <= 0))
                    {
                        MessageBox.Show("Prezzo non valido");
                        return false;
                    }
                    else
                    {
                        int gia;
                        if ((!int.TryParse(giacenza, out gia)) || (Convert.ToInt32(giacenza) <= 0))
                        {
                            MessageBox.Show("Giacenza non valida");
                            return false;
                        }
                        else
                        {
                            int sco;
                            if ((!int.TryParse(scorta, out sco)) || (Convert.ToInt32(scorta) <= 0))
                            {
                                MessageBox.Show("Scorta non valida");
                                return false;
                            }
                            else
                                return true;
                        }
                    }
                }
            }
        }

        internal static bool verificaAggiornaGiacenza(string nf, string codArt, int qta)
        {
            return true;
        }

        internal static string inserisciRecord(string nf, string codArt, string nomeArt, string azienda, string prezzo, string giacenza, string scorta, string codForn)
        {
            string s = codArt + " " + nomeArt + " " + azienda + " " + prezzo + " " + giacenza + " " + scorta + " " + codForn;
            StreamWriter sw = new StreamWriter(nf, true);  //farò una append in fondo al file del nuovo record 
            sw.WriteLine(s);
            sw.Flush();  //serve per essere sicuri che il record sia stato scritto in MM
            sw.Close();
            return codArt;
        }
    }
}
