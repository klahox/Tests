using System;

namespace Refactoring
{
	public class EstrategiaBorradoPorCapas:EstrategiaBorrado
	{
		public EstrategiaBorradoPorCapas ()
		{
		}

		public override string Borrado ()
		{
			return string.Format ("[EstrategiaBorradoPorCapas]");
		}
	}
}

