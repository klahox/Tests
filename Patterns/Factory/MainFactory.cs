using System;

namespace Refactoring
{
	public class MainFactory
	{
		public static void NotMain (string[] args)
		{

			SamsungFactory samFactory = new SamsungFactory();
			Console.WriteLine(samFactory.CreateLaptop().LaptopScreen());

			Console.WriteLine(samFactory.CreateMobile().MobileUsability());

			Console.WriteLine(samFactory.CreateTable().TabletDisgn());

			SonyFactory sonFactory = new SonyFactory();

			Console.WriteLine(sonFactory.CreateLaptop().LaptopScreen());

			Console.WriteLine(sonFactory.CreateMobile().MobileUsability());

			Console.WriteLine(sonFactory.CreateTable().TabletDisgn());
			Console.Read();

		}
	}
}

