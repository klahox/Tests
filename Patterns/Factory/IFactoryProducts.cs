using System;

namespace Refactoring
{
	public interface IFactoryProducts
	{
	 	ILaptop CreateLaptop();
		IMobile CreateMobile();
		ITablet CreateTable();

	}
}

