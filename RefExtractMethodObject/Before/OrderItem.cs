using System;

namespace RefExtractMethodObject
{
	public class OrderItem
	{
		public decimal Price { get; private set; }

		public OrderItem(decimal price)
		{
			Price =price;
		}
	}
}

