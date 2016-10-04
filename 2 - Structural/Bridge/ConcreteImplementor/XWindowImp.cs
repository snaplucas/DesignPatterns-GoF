using Bridge.Implementor;
using System;

namespace Bridge.ConcreteImplementor
{
	public class XWindowImp : WindowImp
	{
		public override void DevDrawLine()
		{
			Console.WriteLine("Draw Xwindow Line");
		}

		public override void DevDrawText()
		{
			Console.WriteLine("Draw Xwindow Text");
		}
	}
}
