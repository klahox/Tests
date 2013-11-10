using System;

namespace Refactoring
{
	public class MainSingelton
	{
		public static void Main (string[] args)
		{

			Locker single = Locker.GetSingletonLocker();

	

			Console.WriteLine(single._whoAmI);

			Console.Read();

		}
	}
}

