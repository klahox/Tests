using System;
using System.Collections;
using System.Collections.Generic;

namespace Refactoring
{
	public class ShippingInfoStrategy
	{
	  private IDictionary<State,IShippingCalculation> _ShippingCalculation {
			get;
			set;
		}
		public ShippingInfoStrategy ()
		{

			_ShippingCalculation = new Dictionary<State, IShippingCalculation>()
			{

				{ State.Alaska,new AlascaShippingCalculation()},
				{ State.Albania,new AlbaniaShippingCalculation()},
				{ State.France, new FranceShippingCalculation()},
				{State.Senegal , new SenegalShippingCalculation()},
				{State.Spain, new SpainShippingCalculation()}
			};
		}

		public decimal CalculateShippingAmount(State shipToState)
		{

			return _ShippingCalculation[shipToState].Calculate();
		}
	}
}

