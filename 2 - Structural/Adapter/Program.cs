using Adapter.Adapter1;
using Adapter.Adapter2;
using Adapter.Adapter3;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			Target target = new Adapter1.Adapter();
			target.Request();

			Shape shape = new TextShape();
			string text = shape.BoundingBox();

			Button button = new Button(new ButtonDialerAdapter(1234));
			button.ButtonPressed();
		}
	}
}
