using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_2
{
	public class Specialization : Generalization
	{
		protected override void stepThr()
		{
			Console.WriteLine("Specialization.stepThr");
		}

		protected override void stepTwo()
		{
			Console.WriteLine("Specialization.stepTwo");
		}
	}
}
