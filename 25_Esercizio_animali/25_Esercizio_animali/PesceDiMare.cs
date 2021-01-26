using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
    class PesceDiMare : AnimaleMarino
    {
		public PesceDiMare(string s) : base(s)
		{
			verso = "non fa versi";
		}

		public override string chi_sei()
		{
			return "un pesce";
		}

		public override string si_muove()
		{
			return "nuotando";
		}
	}
}
