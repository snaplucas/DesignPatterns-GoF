using Strategy.Strategy;
using Strategy.Context;

namespace Strategy.ConcreteStrategy
{
	public class DescontoCartao : IDesconto
	{
		public double CalcularDesconto(Produto produto)
		{
			return produto.Preco * 0.85;
		}
	}
}
