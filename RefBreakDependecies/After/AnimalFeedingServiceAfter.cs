using System;

namespace Refactoring
{
	public class AnimalFeedingServiceAfter
	{
		IFeederService _FeederService;
		bool FeedBowlEmpty { get; set; }

		public AnimalFeedingServiceAfter (IFeederService feederService)
		{
			_FeederService = feederService;
		}

		public string Feed ()
		{
			string ret = "Nothing to eat";

			if (FeedBowlEmpty) {
				ret = _FeederService.ReplenishFood ();
			}

			return ret;
		}
	}
}

