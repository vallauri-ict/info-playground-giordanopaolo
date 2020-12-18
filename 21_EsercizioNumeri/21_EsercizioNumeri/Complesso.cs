using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EsercizioNumeri
{
    class Complesso
    {
        private double immaginario;
        private double reale;
        public Complesso():this(1)
        {

        }
        public Complesso(double immaginario):this(1,immaginario)
        {

        }
        public Complesso(double reale,double immaginario)
        {
            Immaginario = immaginario;
            Reale = reale;
        }

        
        public double Immaginario { get => immaginario; set => immaginario = value; }
        
        public double Reale { get => reale; set => reale = value; }
        public void Modulo()
        {

        }
        public void Coniugato()
        {

        }
    }
}
