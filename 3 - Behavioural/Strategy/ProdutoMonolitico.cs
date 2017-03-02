namespace Strategy
{
	public class ProdutoMonolitico
	{
		public double Preco { get; private set; }

		public void DefinirPreco(int preco)
		{
			Preco = preco;
		}

		public void CalcularDesconto(Desconto tipoDesconto)
		{
			if (tipoDesconto == Desconto.Cartao)
			{
				// calcula desconto cartão
				Preco *= 0.8;
			}
			if (tipoDesconto == Desconto.Boleto)
			{
				// calcula desconto boleto
				Preco *= 0.9;
			}
		}
	}

	public enum Desconto
	{
		Cartao,
		Boleto
	}
}