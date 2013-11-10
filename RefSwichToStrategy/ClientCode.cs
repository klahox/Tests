using System;

namespace Refactoring
{
	public class ClientCode
	{

		public decimal CalculateShipping (State estado)
		{
			ShippingInfoStrategy info = new ShippingInfoStrategy ();
			return info.CalculateShippingAmount(estado);
		}
	}
}

