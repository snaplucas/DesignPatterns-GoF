using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractWidget;
using AbstractFactory.Widget;

namespace AbstractFactory.Factory
{
	public class MacFactory : WidgetFactory
	{
		public override ScrollBar CreateScrollBar()
		{
			return new MacScrollBar();
		}

		public override Window CreateWindow()
		{
			return new MacWindow();
		}
	}
}
