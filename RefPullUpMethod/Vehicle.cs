using System;

namespace Refactoring
{
	public abstract class Vehicle
	{
		public int _sense;
 		public Void Turn (Direction dir)
		{
			_sense = Convert.ToInt32(Direction.Left);
		}
	}
}

