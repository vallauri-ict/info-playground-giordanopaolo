using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_10_Stagisti
{
    class Stagista : Studente
    {
        public Stagista(string az, string ore, string nome, char sezione, string specializzazione, string classe, string cognome, string citta) : base(nome,  sezione,  specializzazione,  classe,  cognome,  citta)
        {
            this.azienda = az;
            this.ore = ore;
        }
        #region attr
        private string azienda;
        private string ore;

        internal string Azienda { get => azienda; set => azienda = value; }
        internal string Ore { get 

                 {
                    return ore.ToString();
                 } 
                 set
                 {
                    if (Convert.ToInt32(value) < 1)
                        throw new Exception("numero non valido");
                    else ore = value;
                 } 
        }

        #endregion
        public override string Visualizza()
        {
            return base.Visualizza() + " " + this.ore + " " + this.azienda;
        }
    }
}
