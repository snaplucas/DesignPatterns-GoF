using System;
using Decorator.Component;

namespace Decorator.ConcreteDecorator
{
	public class BorderDecorator : Decorator.Decorator
	{
		public BorderDecorator(VisualComponent visualComponent) 
			: base(visualComponent)
		{
		}

		public override void Draw()
		{
			base.Draw();
			Console.WriteLine("Draw a border");
		}
	}
}
