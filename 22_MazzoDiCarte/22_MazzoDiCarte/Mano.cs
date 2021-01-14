using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_MazzoDiCarte
{
    class Mano : Mazzo
    {
        public List<Carta> mano = new List<Carta>();
        public Mano()
        {
            mano.Clear();
        }
        public void Leggi()
        {
            foreach (var i in mano)
            {
                i.ReadCard();
            }
        }
        public void Gioca(Mazzo m)
        {
            mano.Add(m.Estrai());
        }


    }
}
