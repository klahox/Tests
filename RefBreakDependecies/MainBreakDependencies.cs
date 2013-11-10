using System;

namespace Refactoring
{
	public class MainBreakDependencies
	{
		public static void IsNotMain (string[] args)
		{

			AnimalFeedingServices svc = new AnimalFeedingServices();
			svc.FoodBowlEmpty = true;
			Console.WriteLine(svc.Feed());

			AnimalFeedingServiceAfter svcAfter = new AnimalFeedingServiceAfter(new FeederService());

			Console.WriteLine(svcAfter.Feed());

			Console.Read();

		}
	}
}

