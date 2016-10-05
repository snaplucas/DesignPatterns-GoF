using Strategy.ConcreteStrategy;
using Strategy.Context;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			var produto1 = new Produto(new DescontoCartao());
			produto1.DefinirPreco(100);
			var desconto1 = produto1.CalcularDesconto();

			var produto2 = new Produto(new DescontoBoleto());
			produto2.DefinirPreco(100);
			var desconto2 = produto2.CalcularDesconto();
		}
	}
}
