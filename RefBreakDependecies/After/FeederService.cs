using System;

namespace Refactoring
{
	public class FeederService :IFeederService
	{
		public FeederService ()
		{
		}

		public string ReplenishFood()
		{
			return Feeder.ReplenishFood();
		}
	}
}

