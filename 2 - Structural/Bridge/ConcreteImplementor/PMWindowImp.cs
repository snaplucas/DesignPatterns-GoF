using Bridge.Implementor;
using System;

namespace Bridge.ConcreteImplementor
{
	public class PMWindowImp : WindowImp
	{
		public override void DevDrawLine()
		{
			Console.WriteLine("Draw PMWindow Line");
		}

		public override void DevDrawText()
		{
			Console.WriteLine("Draw PMWindow Text");
		}
	}
}
