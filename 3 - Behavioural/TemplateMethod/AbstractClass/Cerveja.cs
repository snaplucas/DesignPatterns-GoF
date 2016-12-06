using System;

namespace TemplateMethod.AbstractClass
{
	public abstract class Cerveja
	{
		public abstract void Fermentacao();

		public void PrepararCerveja()
		{
			Mosturacao();

			Filtracao();

			Fermentacao();
		}

		private void Mosturacao()
		{
			Console.WriteLine("Mosturação");
		}

		private void Filtracao()
		{
			Console.WriteLine("Filtração");
		}
	}
}
