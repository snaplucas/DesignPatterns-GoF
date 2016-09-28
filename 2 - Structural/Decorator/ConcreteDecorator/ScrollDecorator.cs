using System;
using Decorator.Component;

namespace Decorator.ConcreteDecorator
{
	public class ScrollDecorator : Decorator.Decorator
	{
		public ScrollDecorator(VisualComponent visualComponent) 
			: base(visualComponent)
		{
		}

		public override void Draw()
		{
			base.Draw();
			Console.WriteLine("Draw a scroll");
		}

		public void ScrollTo()
		{
			Console.WriteLine("Scrolling...");
		}
	}
}
