using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Interfaccia_People
{
    class Person : IComparable
    {
        private string nome;
        private string citta;
        public Person(string nome, string citta)
        {
            this.nome = nome;
            this.citta = citta;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Person p = obj as Person;
            return string.Compare(nome, p.nome, true);
        }
        public override string ToString()
        {
            return nome + " " + citta;
        }

    }
}
