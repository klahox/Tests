using System;

namespace Refactoring
{
	public class EstrategiaBorradoLimpio:EstrategiaBorrado
	{
		public EstrategiaBorradoLimpio ()
		{
		}

		public override string Borrado()
		{
			return string.Format ("[EstrategiaBorradoLimpio]");
		}
	}
}

