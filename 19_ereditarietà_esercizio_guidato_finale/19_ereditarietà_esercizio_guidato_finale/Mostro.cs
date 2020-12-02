using System;
using System.Collections.Generic;
using System.Text;

namespace _19_ereditarietà_esercizio_guidato_finale
{
    public class Mostro
    {
        public string nome;
        public Mostro(): this("Mostro")
        {

        }
        public Mostro(string nome)
        {
            this.nome = nome;
        }
        public void Rivela()
        {
            System.Windows.Forms.MessageBox.Show(nome);
        }
    }
}
