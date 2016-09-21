using Composite.Composite;
using Composite.Leaf;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			Picture picture_1 = new Picture("Image");
			picture_1.Add(new Line("Line"));
			picture_1.Add(new Rectangle("Rectangle"));

			Picture picture_2 = new Picture("New Image");
			picture_2.Add(new Line("Line 2"));
			picture_2.Add(new Rectangle("Rectangle 2"));

			Line line = new Line("Single Line");

			picture_1.Add(line);
			picture_1.Add(picture_2);
		}
	}
}
