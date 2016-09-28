using System;

namespace Decorator.ConcreteDecorator
{
	public class BorderDecorator : Decorator.Decorator
	{
		public override void Draw()
		{
			base.Draw();
			Console.WriteLine("Draw a border");
		}
	}
}
