using Prototype.Prototype;
using System;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			var p1 = new Staff("I");
			var c1 = (Staff)p1.Clone();
			Console.WriteLine("Cloned: {0}", c1.Id);
	}
		}
}
