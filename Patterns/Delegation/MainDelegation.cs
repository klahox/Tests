using System;

namespace Refactoring
{
	class MainDelegation
	{
		public static void MainTest (string[] args)
		{

			ClassC C = new ClassC(new ClassA());

			Console.WriteLine(C.andar());
			Console.WriteLine(C.comer());
			Console.WriteLine(C.dormir());

			Console.ReadLine();

		}
	}
}

