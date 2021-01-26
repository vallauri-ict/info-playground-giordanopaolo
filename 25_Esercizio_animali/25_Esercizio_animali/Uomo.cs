using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
    class Uomo : Bipede
    {
		public Uomo(string s) : base(s)
		{
			verso = "parla";
		}

		public override string vive()
		{
			return "in un condominio";
		}

		public override string chi_sei()
		{
			return "un Homo sapiens";
		}
	}
}
