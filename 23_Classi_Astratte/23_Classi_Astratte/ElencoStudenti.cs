using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Classi_Astratte
{
    class ElencoStudenti : Report
    {
        List<Studente> lststud = new List<Studente>();
        public string stampa = "";
        protected override void printBody()
        {
            foreach (var item in lststud)
            {
                stampa += item.Nomecompleto() + "\n";
            }
        }
        protected override void printFooter()
        {
            stampa += "FOOTER STAMPA STUDENTI\n";
        }
        protected override void printHeader()
        {
            stampa += "INTESTAZIONE STAMPA STUDENTI\n";
        }
        public ElencoStudenti()
        {
            lststud.Add(new Studente("Andrea", "Giaccardi"));
            lststud.Add(new Studente("Andrea", "Giaccardi"));
        }
    }
}
