using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Classiderivate
{
    class Studente : Persona
    {
        List<int> voti = new List<int>();
        public double Media()
        {
            int sommaVoti = 0;
            foreach (var item in voti)
            {
                sommaVoti += item;
            }
            return (double)sommaVoti * voti.Count;
        }
    }
}
