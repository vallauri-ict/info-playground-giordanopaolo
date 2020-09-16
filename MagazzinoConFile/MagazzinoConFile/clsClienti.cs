using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MagazzinoConFile
{
    class clsClienti
    {
        internal static bool controllaCliente(string lastCod, string codCl, string cognome, string nome, string città)
        {
            if (codCl == null || string.Compare(codCl, lastCod) <= 0)
            {
                MessageBox.Show("Codice cliente mancante o errato");
                return false;
            }
            else
            {
                if (cognome == null || nome == null || città == "")
                {
                    MessageBox.Show("Dati mancanti");
                    return false;
                }
                else
                    return true;
                }
            }

        internal static string inserisciRecord(string nf, string codCl, string cognome, string nome, string città)
        {
            string s = codCl + " " + cognome + " " + nome + " " + città;
            StreamWriter sw = new StreamWriter(nf, true);  //farò una append in fondo al file del nuovo record 
            sw.WriteLine(s);
            sw.Flush();  //serve per essere sicuri che il record sia stato scritto in MM
            sw.Close();
            return codCl;
        }
    }
    
}
