using System;

namespace Refactoring
{
	class MainClass
	{
		public static void MainTwo (string[] args)
		{

			ClientCode cl = new ClientCode();

			Console.WriteLine(cl.CalculateShipping(State.Albania));

			Console.WriteLine(cl.CalculateShipping(State.Alaska));


			Console.WriteLine(cl.CalculateShipping(State.France));

			Console.WriteLine(cl.CalculateShipping(State.Senegal));

			Console.Read();

		}
	}
}
