using FactoryMethod.AbstractProduct;

namespace FactoryMethod.AbstractCreator
{
    public abstract class ApplicationFactory
    {
        public abstract Document CreateDocument();
    }
}
