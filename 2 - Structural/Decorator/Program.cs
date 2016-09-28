using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			var textView = new TextView();
			var scrollDecorator = new ScrollDecorator();
			scrollDecorator.SetComponent(textView);
			scrollDecorator.Draw();
		}
	}
}
