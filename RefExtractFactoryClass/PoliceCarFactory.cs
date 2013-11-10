using System;

namespace Refactoring
{
	public class PoliceCarFactory: IPoliceCarFactory
	{
		public PoliceCarFactory ()
		{
		}

		public PoliceCar Create(int milage,bool serviceRequired)
		{
			PoliceCar polCar = new PoliceCar();

			polCar._mileAge = milage;
			polCar.ReadForService = serviceRequired;

			return polCar;
		}
	}
}

