using AbstractFactory.Factory;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			var factory1 = new LinuxFactory();
			var client = new Client(factory1);
		}
	}
}
