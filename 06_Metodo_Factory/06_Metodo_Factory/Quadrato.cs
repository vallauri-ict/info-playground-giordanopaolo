using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Metodo_Factory
{
    class Quadrato
    {
        private int lato;
        public static Quadrato creaquadrato(int lato)
        {
            if (lato <= 0)
                throw new Exception("Il lato del quadrato deve essere > 0");
            else return new Quadrato(lato);
        }
        private Quadrato(int lato)
        {
            this.lato = lato;
        }
    }
}
