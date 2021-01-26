using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
    class Pinguino : Uccello
    {
		public Pinguino(string s) : base(s)
		{
			verso = "non fa versi";
		}

		public override string vive()
		{
			return "al polo";///mi sembra più giusto che vive in un nido su un albero
		}

		public override string chi_sei()
		{
			return "un pinguino";
		}

		public override string si_muove()
		{
			return "Camminando perchè non vola";
		}
	}
}
