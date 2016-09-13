using FactoryMethod.AbstractCreator;
using FactoryMethod.AbstractProduct;
using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public class ImageApplication : Application
    {
        public override Document CreateDocument()
        {
            return new ImageDocument();
        }
    }
}
