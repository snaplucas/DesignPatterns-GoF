using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractWidget;
using AbstractFactory.Widget;

namespace AbstractFactory.Factory
{
	public class LinuxFactory : WidgetFactory
	{
		public override ScrollBar CreateScrollBar()
		{
			return new LinuxScrollBar();
		}

		public override Window CreateWindow()
		{
			return new LinuxWindow();
		}
	}
}
