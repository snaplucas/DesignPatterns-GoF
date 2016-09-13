using Builder.AbstractBuilder;

namespace Builder.Builders
{
    public class ASCIIConverter : TextConverter
    {
        private Product _product = new Product();
        public override void ConvertCharacter()
        {
            _product.Add("Convert character to ASCII");
        }

        public override void ConvertFontChange()
        {
            _product.Add("Covnert font to ASCII");
        }

        public override void ConvertParagraph()
        {
            _product.Add("Convert paragraph to ASCII");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
}
