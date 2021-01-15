using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Classi_Astratte
{
    class Studente
    {
        
        private string Nome { get; set; }

        private string Cognome { get; set; }

        private DateTime datanascita;
        public Studente(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        public string Nomecompleto()
        {
            return Nome + " " + Cognome;
        }
    }
}
