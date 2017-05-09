using FactoryMethod.AbstractCreator;
using FactoryMethod.AbstractProduct;
using FactoryMethod.Creator;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			ApplicationFactory factory = new TextApplicationFactory();
			Document document = factory.CreateDocument();

			var factory2 = new ImageApplicationFactory();
			var document2 = factory2.CreateDocument();

			var factory3 = new DocumentFactory("Text");

			var textDocument = factory3.CreateDocument();
		}
	}
}
