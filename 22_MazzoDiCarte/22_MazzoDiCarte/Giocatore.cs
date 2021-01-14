using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_MazzoDiCarte
{
    class Giocatore : Mano
    {
        private string nome;
        private Mano mano;
        private Mano prese;
        public Giocatore()
        {
            nome = "Paolo";
            mano = null;
            prese = null;
        }
        void Lettura()
        {
            mano.Leggi();
        }
        void Prese()
        {
            prese.Leggi();
        }
        public void Gioca(Mazzo m)
        {
            mano.mano.Add(m.Estrai());
        }
    }
}
