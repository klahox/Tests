using System;

namespace Refactoring
{
	public class SonyFactory: IFactoryProducts
	{
		public SonyFactory ()
		{
		}

	 	public ILaptop CreateLaptop()
		{
			return new SonyLaptop();
		}
		public IMobile CreateMobile()
		{
			return new SonyMobile();
		}
		public ITablet CreateTable()
		{
			return new SonyTablet();

		}
	}
}

