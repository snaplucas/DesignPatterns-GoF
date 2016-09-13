using Builder.AbstractBuilder;

namespace Builder.Director
{
    public class RTFReader
    {
        public void ParseRTF(TextConverter txtConverter)
        {
            txtConverter.ConvertCharacter();
            txtConverter.ConvertFontChange();
            txtConverter.ConvertParagraph();
        }
    }
}
