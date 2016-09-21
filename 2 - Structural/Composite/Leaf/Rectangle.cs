using Composite.Component;
using System;

namespace Composite.Leaf
{
	public class Rectangle : Graphic
	{
		public Rectangle(string nome) : base(nome)
		{
		}

		public override void Add(Graphic p)
		{
			throw new NotImplementedException();
		}

		public override void Remove(Graphic p)
		{
			throw new NotImplementedException();
		}

		public override void Draw()
		{
			Console.WriteLine("Draw a Rectangle");
		}
	}
}
