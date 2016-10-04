using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstraction;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			var window = new IconWindow();
			window.windowImp = new PMWindowImp();
			window.DrawBorder();

			window.windowImp = new XWindowImp();
			window.DrawBorder();
		}
	}
}
