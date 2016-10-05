using Strategy.Strategy;
using Strategy.Context;

namespace Strategy.ConcreteStrategy
{
	public class DescontoBoleto : IDesconto
	{
		public double CalcularDesconto(Produto produto)
		{
			return produto.Preco * 0.9;
		}
	}
}
