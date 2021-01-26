using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Classi_Carte_2
{
    class MazzoCarte
    {
        private Carte[] vet = new Carte[40];
        List<Carte> collectionappoggio = new List<Carte>();
        private string[] semi = new string[] { "Cuori", "Picche", "Quadri", "Fiori" };

        public MazzoCarte()
        {
            int seme = 0;
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Carte carta = new Carte();
                    carta.Valore = carta.val[j];
                    carta.Seme = carta.semi[seme - 1];
                    vet[k++] = carta;
                }
            }
            for (int i = 0; i < 40; i++)
            {
                collectionappoggio.Add(vet[i]);
            }
        }

        public void mescola()
        {
            collectionappoggio.Clear();
            Random r = new Random();
            List<int> aus = new List<int>();
            foreach (var i in vet)
            {
                int ris;
                int h;
                do
                {
                    h = r.Next(0, 40);
                    ris = aus.Find(bf => bf == h);
                } while (ris != 0);
                aus.Add(h);
                collectionappoggio.Add(vet[h]);
            }
        }

        public void InserisciCarta(Carte c)
        {
            Carte ris = collectionappoggio.Find(bf => bf == c);
            if (ris != null)
                System.Windows.Forms.MessageBox.Show("non puoi, la carta è già presente");
            else collectionappoggio.Add(c);
        }

        public Carte EstraiACaso(string seme, string valore)
        {
            Carte c = new Carte(valore, seme);
            Carte ris = 
            collectionappoggio.Find(bf => bf.seme == c.seme 
                                    && bf.valore == c.valore);//faccio così perchè se facessi bf == c visto che sono 2 oggetti confronterebbe gli indirizzi
            if(ris == null)///se non c'è
            {
                Random r = new Random();
                int h = r.Next(0, collectionappoggio.Count);
                c = collectionappoggio[h];
                collectionappoggio.Remove(collectionappoggio[h]);
                return c;
            }
            else
            {
                collectionappoggio.Remove(c);
                return c;
            }
            
        }

        public Carte EstraiPrima()///funge
        {
            Carte c = collectionappoggio[0];
            collectionappoggio.Remove(collectionappoggio[0]);
            return c;
        }
    }
}
