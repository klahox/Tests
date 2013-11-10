using System;

namespace Refactoring
{
	public class AnimalFeedingServices
	{
		public bool FoodBowlEmpty { get; set; }

		public string Feed ()
		{
			string nothing = "Nothing to eat";

			if (FoodBowlEmpty) {
				nothing= Feeder.ReplenishFood();
			}

			return nothing;
		}
	}
}

