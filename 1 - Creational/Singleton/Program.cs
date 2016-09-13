using System;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			Singleton singleton_1 = Singleton.GetInstance();
			Singleton singleton_2 = Singleton.GetInstance();

			if (singleton_1 == singleton_2)
			{
				Console.WriteLine("Os objetos são a mesma instancia");
			}
		}
	}
}
