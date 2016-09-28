using System;

namespace Decorator.ConcreteDecorator
{
	public class ScrollDecorator : Decorator.Decorator
	{
		public override void Draw()
		{
			base.Draw();
			Console.WriteLine("Draw a scroll");
		}
	}
}
