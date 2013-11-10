using System;

namespace Refactoring
{
	public class AccountInterest
	{
		public BankAccount _BankAccount { get; set;}

		public AccountInterest (BankAccount ba)
		{
			_BankAccount=ba;
		}

		public double InterestRate {
			get { return this.CalculateIntersetRate ();}
		}

		public double CalculateIntersetRate()
		{
			if(_BankAccount._CreditScore > 800)
				return 0.03;

			if(_BankAccount._AccountAge > 10)
				return 0.02;

			return 0.05;
		}
	}
}

