using System;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClass
{
	public class Ale : Cerveja
	{
		public override void Fermentacao()
		{
			Console.WriteLine("Temperatura entre 15 e 24 graus");
		}
	}
}
