using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Esercizio_animali
{
	public abstract class AnimaleTerrestre : animale
	{
		public AnimaleTerrestre(string s) : base("")
		{

		}

		public override string vive()
		{
			return "sulla terra ferma";
		}
	}
}
