using System;

namespace Refactoring
{
	public class MainExtractFactory
	{
		public static void ISNotMain (string[] args)
		{

			PoliceCarFactory factory = new PoliceCarFactory();

			PoliceCarController controller = new PoliceCarController(factory);

			PoliceCar  pc = controller.New(233,true);

			Console.WriteLine(pc.ReadForService +" - "+pc._mileAge);


			Console.Read();

		}
	}
}

