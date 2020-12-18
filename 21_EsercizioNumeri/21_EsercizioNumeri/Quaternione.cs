using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EsercizioNumeri
{
    class Quaternione : Complesso
    {
        private double j, k;

        public double J { get => j; set => j = value; }

        public double K { get => k; set => k = value; }
        public Quaternione():this(1)
        {

        }
        public Quaternione(double immaginario) : this(1,1)
        {

        }
        public Quaternione(double immaginario,double reale) : this(1,1,1)
        {

        }
        public Quaternione(double immaginario, double reale,double j) : this(1, 1, 1, 1)
        {

        }
        public Quaternione(double immaginario, double reale, double j,double k) 
        {

        }
    }
}
