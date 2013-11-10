using System;

namespace Refactoring
{
	public interface IPoliceCarFactory
	{
		PoliceCar Create(int milage,bool serviceRequired);
	}
}

