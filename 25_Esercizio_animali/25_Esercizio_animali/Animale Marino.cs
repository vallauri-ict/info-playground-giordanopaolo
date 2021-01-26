using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
	public abstract class AnimaleMarino : AnimaleAcquatico
	{
		public AnimaleMarino(string s) : base(s)
		{
			
		}

		public override string vive()
		{
			return "in mare";
		}

		public override string chi_sei()
		{
			return "un animale marino";
		}

		public override string si_muove()
		{
			return "nuotando";
		}
	}
}
