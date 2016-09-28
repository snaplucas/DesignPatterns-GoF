using Decorator.Component;
using System;

namespace Decorator.Decorator
{
	public abstract class Decorator : VisualComponent
	{
		private readonly VisualComponent _visualComponent;

		public Decorator(VisualComponent visualComponent)
		{
			_visualComponent = visualComponent;
		}

		public override void Draw()
		{
			_visualComponent.Draw();
		}
	}
}
