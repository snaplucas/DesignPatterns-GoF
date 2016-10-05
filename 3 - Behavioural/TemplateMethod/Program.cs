using TemplateMethod.ConcreteClass;

namespace TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var aA = new ConcreteClassA();
			aA.TemplateMethod();

			var aB = new ConcreteClassB();
			aB.TemplateMethod();
		}
	}
}
