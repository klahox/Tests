using System;

namespace Refactoring
{
	public class EstrategiaBorradoRapido:EstrategiaBorrado
	{
		public EstrategiaBorradoRapido ()
		{
		}

		public override string Borrado()
		{
			return string.Format ("[EstrategiaBorradoRapido]");
		}
	}
}

