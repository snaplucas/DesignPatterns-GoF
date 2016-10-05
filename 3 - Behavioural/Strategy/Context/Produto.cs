using Strategy.Strategy;

namespace Strategy.Context
{
	public class Produto
	{
		private readonly IDesconto _desconto;
		public int Preco { get; private set; }

		public Produto(IDesconto desconto)
		{
			_desconto = desconto;
		}

		public void DefinirPreco(int preco)
		{
			Preco = preco;
		}

		public double CalcularDesconto()
		{
			return _desconto.CalcularDesconto(this);
		}
	}
}
