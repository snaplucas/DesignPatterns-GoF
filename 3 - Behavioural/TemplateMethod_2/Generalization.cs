using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_2
{
	public abstract class Generalization
	{
		public void FindSolution()
		{
			stepOne();
			stepTwo();
			stepThr();
			stepFor();
		}
		private void stepOne()
		{
			Console.WriteLine("Generalization.stepOne");
		}
		protected abstract void stepTwo();
		protected abstract void stepThr();

		void stepFor()
		{
			Console.WriteLine("Generalization.stepOne");
		}
	}
}
