using Decorator.Component;
using System;

namespace Decorator.Decorator
{
	public class Decorator : VisualComponent
	{
		protected VisualComponent _visualComponent;

		public void SetComponent(VisualComponent visualComponent)
		{
			_visualComponent = visualComponent;
		}

		public override void Draw()
		{
			_visualComponent.Draw();
		}
	}
}
