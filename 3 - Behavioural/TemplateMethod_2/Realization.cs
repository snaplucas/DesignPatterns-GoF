using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_2
{
	public class Realization : Generalization
	{
		protected override void stepThr()
		{
			Console.WriteLine("Realization.stepThr");
		}

		protected override void stepTwo()
		{
			Console.WriteLine("Realization.stepThr");
		}
	}
}
