using AbstractFactory.AbstractWidget;

namespace AbstractFactory.AbstractFactory
{
	public abstract class WidgetFactory
	{
		public abstract Window CreateWindow();
		public abstract ScrollBar CreateScrollBar();
	}
}
