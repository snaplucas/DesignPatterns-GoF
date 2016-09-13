using Builder.Builders;
using Builder.Director;

namespace Builder
{
    class Program
	{
		static void Main(string[] args)
		{
            var rtfReader = new RTFReader();

            var asciiBuilder = new ASCIIConverter();
            var textWidgetBuilder = new TextWidgetConverter();

            rtfReader.ParseRTF(asciiBuilder);
            var ascText = asciiBuilder.GetResult();

            rtfReader.ParseRTF(textWidgetBuilder);
            var textWidget = textWidgetBuilder.GetResult();
		}
	}
}
