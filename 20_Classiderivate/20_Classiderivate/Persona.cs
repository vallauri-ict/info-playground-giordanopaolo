using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Classiderivate
{
    
    class Persona
    {
        private string nome, cognome, sesso;
        private int eta;
        private void setAtt(string nome, string cognome, int eta, string sesso)
        {
            this.sesso = sesso;
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }
        public string getnome()
        {
            return this.nome;
        }
        public string getcognome()
        {
            return this.cognome;
        }
        public string getsesso()
        {
            return this.sesso;
        }
        public int geteta()
        {
            return this.eta;
        }
    }
}
