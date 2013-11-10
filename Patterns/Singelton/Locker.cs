using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.CSharp;
using System.Reflection;

namespace Refactoring
{
	public class Locker
	{
		private static Locker _singelton;
		public string _whoAmI = "Klajdi";
		private Locker()
		{
		}


	

		public  static Locker GetSingletonLocker ()
		{
			if (_singelton != null) {

				return _singelton;

			} else {

				_singelton = new Locker();
				return _singelton;
			}
		}
	}
}

