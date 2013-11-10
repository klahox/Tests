using System;
using System.Collections.Generic;

namespace RefExtractMethodObject
{
	public class OrderCalculator
	{

		private IEnumerable<OrderItem> _OrderItems { get; set; }
		private IList<decimal> _Discounts { get; set; }
		private decimal _TAX {get; set;}
		private decimal _SubTotal { get; set; }

		public OrderCalculator (OrderAfter order)
		{
			_OrderItems = order._OrderItems;
			_Discounts = order._Discounts;
			_TAX = order._TAX;

		}

		public decimal Calculate()
		{
			Fx_CalculateSubTotal();
			Fx_CalculateDiscounts();
			Fx_CalculateTaxes();

			return _SubTotal;
		}


		public void Fx_CalculateSubTotal ()
		{

			foreach (OrderItem oi in _OrderItems) {

				_SubTotal += oi.Price;
			}
		}

		public void Fx_CalculateDiscounts ()
		{
			foreach (decimal dis in _Discounts) {

				_SubTotal -= dis;
			}
		}

		public void Fx_CalculateTaxes()
		{
			_SubTotal += _SubTotal * _TAX;
		}
	}
}

