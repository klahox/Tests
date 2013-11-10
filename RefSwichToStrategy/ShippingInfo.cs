using System;

namespace Refactoring
{
	public class ShippingInfo
	{
		public ShippingInfo ()
		{
		}

		public decimal CalculateShippingAmount (State shipToState)
		{
			switch (shipToState) {

			case State.Alaska:
				return GetAlaskaShippingAmount();
			case State.Albania:
				return GetAlbaniaShippingAmount();
			case State.France:
				return GetFranceShippingAmount();
			default:
				return 0m;
			}
		}

		public decimal GetAlaskaShippingAmount()
		{
			return 0.05m;
		}

		public decimal GetAlbaniaShippingAmount()
		{
			return 23m;
		}

		public decimal GetFranceShippingAmount()
		{
			return 22m;
		}
	}
}

