using Adapter.Adapter1;
using Adapter.Adapter2;

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
		}
	}
}
