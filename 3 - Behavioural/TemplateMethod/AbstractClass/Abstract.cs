using System;

namespace TemplateMethod.AbstractClass
{
	public abstract class Abstract
	{
		public abstract void PrimitiveOperation1();
		public abstract void PrimitiveOperation2();

		public void TemplateMethod()
		{
			PrimitiveOperation1();
			PrimitiveOperation2();
			Console.WriteLine("");
		}
	}
}
