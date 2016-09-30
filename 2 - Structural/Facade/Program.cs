namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			var facade = new Facade.Facade();
			facade.DoWork_A();
			facade.DoWork_B();
		}
	}
}
