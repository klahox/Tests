using System;
using System.Diagnostics.Contracts;

namespace Refactoring
{
	public class PoliceCarController
	{

		public IPoliceCarFactory _IPoliceCarFactory { get; set; }


		public PoliceCarController (IPoliceCarFactory policeCarfactory)
		{


			_IPoliceCarFactory = policeCarfactory;
		}

		public PoliceCar New( int a, bool b)
		{
			//Disagn By Contract
			Contract.Assert(a < 0,"Hello World");
			return _IPoliceCarFactory.Create(a,b);
		}


	}
}

