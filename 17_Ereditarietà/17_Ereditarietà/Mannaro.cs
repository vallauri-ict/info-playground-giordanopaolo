using System;
using System.Collections.Generic;
using System.Text;

namespace _17_Ereditarietà
{
    class Mannaro : Mostro
    {
        protected bool mutato;
        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }
        public double Valore()
        {
            return (mutato)? 2 * base.Valore():base.Valore();
        }
        public string Verso()
        {
            return (mutato) ? verso : base.verso;
        }
        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
