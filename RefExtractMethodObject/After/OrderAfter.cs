using System;
using System.Collections.Generic;

namespace RefExtractMethodObject
{
	public class OrderAfter
	{
		public IEnumerable<OrderItem> _OrderItems { get; set; }
		public IList<decimal> _Discounts { get; set; }
		public decimal _TAX {get; set;}

		public OrderAfter (IEnumerable<OrderItem> oi,
		              IList<decimal> dis,
		              decimal tax)
		{
			_OrderItems = oi;
			_Discounts = dis;
			_TAX = tax;
		}


		public decimal Calculate()
		{
			return new OrderCalculator(this).Calculate();
		}
	}
}

