using System;
using System.Collections;
using System.Collections.Generic;
namespace Refactoring
{
	public class Order
	{

		private List<string> _orderList = new List<string>();
		private int _total = 0;


		public List<string> OrderList {
			get{ return _orderList;}
		}

		public void AddOrder(string newOrder)
		{
			_orderList.Add(newOrder);
			_total += 1;
		}

		public void RemoveOrder (string orderToRemove)
		{

			string foundOrder = _orderList.Find(o => o.Equals(orderToRemove));
			if (foundOrder != null) {

				_total -= 1;
				_orderList.Remove(orderToRemove);
			}
		}
	}
}

