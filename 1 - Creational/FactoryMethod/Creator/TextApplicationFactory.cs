using FactoryMethod.AbstractCreator;
using FactoryMethod.AbstractProduct;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class TextApplicationFactory : ApplicationFactory
    {
        public override Document CreateDocument()
        {
            return new TextDocument();
        }
    }
}
