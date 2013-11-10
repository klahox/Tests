using System;
using System.Collections.Generic;
using System.Collections;
namespace RefExtractMethodObject
{
	public class MainExtractMethodObject
	{


		public static void NotMain (string[] args)
		{
			Console.WriteLine("Before Refactoring");

			IEnumerable<OrderItem> OrderItems =
				new List<OrderItem>
			{
				new OrderItem(3),
				new OrderItem(45),
				new OrderItem(54),
				new OrderItem(22)
			};


			IList<decimal> Discounts = 
				new List<decimal>
			{
				7m,45m,1m
			};

			decimal TAX = 23m;

			Order aOrder = new Order(OrderItems,Discounts,TAX);

			Console.WriteLine(aOrder.calculate());

			Console.WriteLine("After Refactoring");

		
			OrderAfter after = new OrderAfter(OrderItems,Discounts,TAX);


			Console.WriteLine(after.Calculate());

			Console.Read();

		}
	}
}

