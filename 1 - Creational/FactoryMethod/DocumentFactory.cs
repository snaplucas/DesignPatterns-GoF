using System;
using FactoryMethod.AbstractCreator;
using FactoryMethod.AbstractProduct;
using FactoryMethod.Product;

namespace FactoryMethod
{
    public class DocumentFactory : Application
    {
        private readonly string _type;
        public DocumentFactory(string type)
        {
            _type = type;
        }
        public override Document CreateDocument()
        {
            switch (_type)
            {
                case "Text":
                    return new TextDocument();
                case "Image":
                    return new ImageDocument();
                default:
                    return new TextDocument();
            }
        }
    }
}
