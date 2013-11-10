using System;
using System.Collections;
using System.Collections.Generic;
namespace RefExtractMethodObject
{
	public class Order
	{
		private IEnumerable<OrderItem> _OrderItems { get; set; }
		private IList<decimal> _Discounts { get; set; }
		private decimal _TAX {get; set;}

		public Order (IEnumerable<OrderItem> oi,
		              IList<decimal> dis,
		              decimal tax)
		{
			_OrderItems = oi;
			_Discounts = dis;
			_TAX = tax;
		}

		public decimal calculate ()
		{
			decimal subTotal = 0m;

			foreach (OrderItem oi in _OrderItems) {

				subTotal += oi.Price;
			}

			foreach (decimal dis in _Discounts) {

				subTotal -= dis;
			}

			decimal subTax = subTotal *_TAX;

			return subTotal + subTax;

		}
	}
}

