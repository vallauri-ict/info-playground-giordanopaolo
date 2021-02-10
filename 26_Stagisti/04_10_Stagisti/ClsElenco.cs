using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_10_Stagisti
{
    sealed class ClsElenco
    {
        List<Studente> lst;

        public ClsElenco()
        {
            lst = new List<Studente>();
        }
        public void inserisci(Studente a)
        {
            lst.Add(a);
        }
        public void visualizzaDgv(DataGridView d)
        {
            d.DataSource = null;
            d.DataSource = lst;
        }

        public int OreAzienda(string nomeA)
        {
            int oreTotAzineda = 0;
            foreach (Studente a in lst)
            {
                if((a is Stagista) && (nomeA == (a as Stagista).Azienda))
                {
                    oreTotAzineda += Convert.ToInt32((a as Stagista).Ore);
                }
            }
            return oreTotAzineda;
        }
        public void Canc()
        {
            if (lst.Count == 0)
                throw new Exception("");
            else lst.RemoveAt(lst.Count - 1);
        }
        public void Canc(int pos)
        {
            pos--;
            if (lst.Count == 0)
            {
                throw new Exception("");
            }
            else if (pos < 0 || pos > lst.Count - 1)
                throw new Exception("");
            else lst.RemoveAt(pos);
        }
    }
}
