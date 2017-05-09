using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Generalization realization = new Realization();
			realization.FindSolution();

			Console.WriteLine("---");

			Generalization specialization = new Specialization();
			specialization.FindSolution();

			Console.ReadKey();
		}
	}
}
