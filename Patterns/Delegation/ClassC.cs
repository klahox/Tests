using System;

namespace Refactoring
{
	public class ClassC:InterfaceI
	{
	InterfaceI _Inter = null;

		public ClassC (InterfaceI inter)
		{
			_Inter = inter;
		}


		public string andar()
		{
			return _Inter.andar();
		}

		public string dormir()
		{
			return _Inter.dormir();
		}

		public string comer()
		{
			return _Inter.comer();
		}
	}
}

