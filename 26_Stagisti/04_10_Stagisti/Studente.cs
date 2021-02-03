using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_10_Stagisti
{
    class Studente : Persona
    {
        #region Proprietà

        private static int progressivo = 0;
        private readonly string matricola;
        private char classe;
        private char sezione;
        private string specializzazione;

        public char Classe
        {
            get => classe;
            set
            {
                classe = value;
            }
        }

        public char Sezione
        {
            get => sezione;
            set
            {
                sezione = value;
            }
        }

        public string Specializzazione
        {
            get => specializzazione;
            set
            {
                specializzazione = value;
            }
        }

        #endregion

        public Studente(string nome, char sezione, string specializzazione, string classe, string cognome, string citta) 
            : base(nome, cognome, citta)
        {
            Classe = Convert.ToChar(classe);
            Specializzazione = specializzazione;
            Sezione = Convert.ToChar(sezione);
            progressivo++;
            matricola = "A" + progressivo.ToString().PadLeft(5, '0');


        }

        public override string Visualizza()
        {
            return matricola + " " + Nome + " " + Cognome + " " + Citta + " " + Sezione + " " + Specializzazione;
        }
    }
}
