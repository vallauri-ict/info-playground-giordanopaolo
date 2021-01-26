using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
    class Tonno : PesceDiMare
    {
		public Tonno(string s) : base(s)
		{
			verso = "nulla";
		}

		public override string chi_sei()
		{
			return "un Tonno";
		}
	}
}
