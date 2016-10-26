using TemplateMethod.ConcreteClass;

namespace TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var lager = new Lager();
			lager.PrepararCerveja();

			var ale = new Ale();
			ale.PrepararCerveja();
		}
	}
}
