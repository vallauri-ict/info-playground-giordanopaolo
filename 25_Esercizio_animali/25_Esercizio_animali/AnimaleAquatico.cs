using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
	public abstract class AnimaleAcquatico : animale
	{
		public AnimaleAcquatico(string s) : base(s)
		{

		}

		public override string vive()
		{
			return "nell'acqua";
		}

		public override string chi_sei()
		{
			return "un animale acquatico";
		}
	}
}
