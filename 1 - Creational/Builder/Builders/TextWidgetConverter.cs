using Builder.AbstractBuilder;

namespace Builder.Builders
{
    public class TextWidgetConverter : TextConverter
    {
        private Product _product = new Product();
        public override void ConvertCharacter()
        {
            _product.Add("Convert Character to TextWidget");
        }

        public override void ConvertFontChange()
        {
            _product.Add("Convert font to TextWidget");
        }

        public override void ConvertParagraph()
        {
            _product.Add("Convert paragraph to TextWidget");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
