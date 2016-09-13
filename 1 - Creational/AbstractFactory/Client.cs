using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractWidget;

namespace AbstractFactory
{
	public class Client
	{
		private Window _window;
		private ScrollBar _scrollbar;

		public Client(WidgetFactory factory)
		{
			_window = factory.CreateWindow();
			_scrollbar = factory.CreateScrollBar();
		}
	}
}
