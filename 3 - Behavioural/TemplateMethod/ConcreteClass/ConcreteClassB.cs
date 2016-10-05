using System;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClass
{
	public class ConcreteClassB : Abstract
	{
		public override void PrimitiveOperation1()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
		}
		public override void PrimitiveOperation2()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
		}

	}
}
