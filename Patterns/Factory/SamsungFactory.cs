using System;

namespace Refactoring
{
	public class SamsungFactory: IFactoryProducts
	{
		public SamsungFactory ()
		{
		}

	 	public ILaptop CreateLaptop()
		{
			return new SamsungLaptop();
		}
		public IMobile CreateMobile()
		{
			return new SamsungMobile();
		}
		public ITablet CreateTable()
		{
			return new SamsungTablet();
		}


	}
}

