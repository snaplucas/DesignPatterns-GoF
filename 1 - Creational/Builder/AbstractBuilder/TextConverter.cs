namespace Builder.AbstractBuilder
{
    public abstract class TextConverter
    {
        public abstract void ConvertCharacter();
        public abstract void ConvertFontChange();
        public abstract void ConvertParagraph();
        public abstract Product GetResult();
    }
}
