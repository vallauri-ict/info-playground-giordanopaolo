using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
    class Uccello : animale
    {
		public Uccello(string s) : base(s)
		{
			verso = "cinguetta";
		}

		public override string vive()
		{
			return "in un nido su un albero";
		}

		public override string chi_sei()
		{
			return "un Uccello";
		}

		public override string si_muove()
		{
			return "Volando";
		}
	}
}
