using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
    class Bipede : animale
    {
		public Bipede(string s) : base(s)
		{

		}

		public override string vive()
		{
			return "";
		}

		public override string chi_sei()
		{
			return "un Bipede";
		}

		public override string si_muove()
		{
			return "Camminando su due piedi";
		}
	}
}
