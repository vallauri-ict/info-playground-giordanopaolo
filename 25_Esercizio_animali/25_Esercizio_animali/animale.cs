using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
	public abstract class animale
	{
		private string nome;

		protected string verso;

		public abstract string si_muove();

		public abstract string vive();

		public abstract string chi_sei();

		public animale(string s)
		{
			nome = s;
		}

		public void mostra()
		{
            System.Windows.Forms.MessageBox.Show(nome + ", " + chi_sei() + ", " + verso + ", si muove " + si_muove() + " e vive " + vive());
		}
	}
}
