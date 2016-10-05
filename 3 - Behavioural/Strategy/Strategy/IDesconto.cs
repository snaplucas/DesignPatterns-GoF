using Strategy.Context;

namespace Strategy.Strategy
{
	public interface IDesconto
	{
		double CalcularDesconto(Produto produto);
	}
}
