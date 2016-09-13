using FactoryMethod.AbstractCreator;
using FactoryMethod.AbstractProduct;
using FactoryMethod.Creator;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Application factory = new TextApplication();
			Document document = factory.CreateDocument();

			var factory2 = new ImageApplication();
			var document2 = factory2.CreateDocument();

			var factory3 = new DocumentFactory("Text");

			var textDocument = factory3.CreateDocument();
		}
	}
}
