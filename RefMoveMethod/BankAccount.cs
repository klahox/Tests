using System;

namespace Refactoring
{
	public class BankAccount
	{

		public int _AccountAge { get; private set; }
		public int _CreditScore { get; private set; }
		public AccountInterest _AccountInterst{ get; private set;}

		public BankAccount (int accountAge,int creditScore,AccountInterest ai)
		{
			_AccountAge = accountAge;
			_CreditScore = creditScore;
			_AccountInterst = ai;
		}



	}
}

