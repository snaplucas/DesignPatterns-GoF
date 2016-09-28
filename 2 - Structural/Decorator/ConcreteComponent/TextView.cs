using Decorator.Component;
using System;

namespace Decorator.ConcreteComponent
{
	public class TextView : VisualComponent
	{
		public override void Draw()
		{
			Console.WriteLine("Draw a textview");
		}
	}
}
