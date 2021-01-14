using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_MazzoDiCarte
{
    class Mazzo : Carta
    {
        private Carta[] collection = new Carta[40];
        List<Carta> collectionappoggio = new List<Carta>();
        private string[] semi = new string[] { "Ori", "Bastoni", "Spade", "Coppe"};

        public Mazzo() : base(1,"")
        {
            int aus = 0;
            int k=0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                    collection[k++] = new Carta((j + 1), semi[aus]);
                aus++;
            }
        }
        public void mescola()
        {
            Random r = new Random();
            List<int> aus = new List<int>();
            foreach (var i in collection)
            {
                int ris;
                int h;
                do
                {
                    h = r.Next(0, 40);
                    ris = aus.Find(bf => bf == h);
                } while (ris != 0);
                aus.Add(h);
                collectionappoggio.Add(collection[h]);
            }
        }
        public Carta Estrai()
        {
            Random r = new Random();
            int h = r.Next(0, 40);
            Carta c = collectionappoggio[h];
            collectionappoggio.Remove(collectionappoggio[h]);
            return c;
        }
    }
}
