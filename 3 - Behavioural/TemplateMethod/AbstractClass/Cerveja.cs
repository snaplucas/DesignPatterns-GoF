using System;

namespace TemplateMethod.AbstractClass
{
	public abstract class Cerveja
	{
		public abstract void Fermentar();

		public void PrepararCerveja()
		{
			AdicionarMalte();
			Fermentar();
			AdiconarLupulo();
		}

		private void AdicionarMalte()
		{

		}

		private void AdiconarLupulo()
		{

		}
	}
}
