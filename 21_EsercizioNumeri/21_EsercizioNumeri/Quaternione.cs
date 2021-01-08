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

        public Quaternione() : base()
        {

        }
        public Quaternione(double immaginario) : base(immaginario)
        {

        }
        public Quaternione(double immaginario, double reale) : this(immaginario, reale, 0)
        {

        }
        public Quaternione(double immaginario, double reale, double j) : this(immaginario, reale, j, 0)
        {

        }
        public Quaternione(double immaginario, double reale, double j, double k) : base(reale, immaginario)
        {
            J = j;
            K = k;
        }
        public double Modulo()
        {
            double somma = Math.Pow(Reale, 2) + Math.Pow(Immaginario, 2) + Math.Pow(J, 2) + Math.Pow(K, 2);
            return Math.Sqrt(somma);
        }
    }
}
