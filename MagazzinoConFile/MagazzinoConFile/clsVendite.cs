using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MagazzinoConFile
{
    class clsVendite
    {
        internal static bool controllaVendita(string codArt, string codCl, int qta, string nf)
        {
            if (codArt == "" || codCl == "")
            {
                MessageBox.Show("Dati mancanti");
                return false;
            }
            else
            {
                if (clsArticoli.verificaAggiornaGiacenza(nf, codArt, qta))
                    return true;
                else
                {
                    MessageBox.Show("Giacenza insufficiente");
                    return false;
                }
            }
        }

        internal static void inserisciRecord(string nf, ref string lastCod, string codArt, string codCl, int qta)
        {
            //genero il nuovo codice progressivo
            string x = lastCod.Substring(1);
            int xx = Convert.ToInt32(x) + 1;
            lastCod= "V" + xx.ToString();
            string s = lastCod + " " + codArt + " " + codCl + " " + qta.ToString()+ " "+ DateTime.Now.ToShortDateString();
            StreamWriter sw = new StreamWriter(nf, true);  //farò una append in fondo al file del nuovo record 
            sw.WriteLine(s);
            sw.Flush();  //serve per essere sicuri che il record sia stato scritto in MM
            sw.Close();
        }
    }
}
