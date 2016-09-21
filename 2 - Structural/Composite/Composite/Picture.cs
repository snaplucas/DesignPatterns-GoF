using Composite.Component;
using System;
using System.Collections.Generic;

namespace Composite.Composite
{
	public class Picture : Graphic
	{
		public List<Graphic> _children = new List<Graphic>();

		public Picture(string name)
			: base(name)
		{
		}

		public override void Add(Graphic component)
		{
			_children.Add(component);
		}

		public override void Remove(Graphic component)
		{
			_children.Remove(component);
		}

		public override void Draw()
		{
			// rules for draw a picture, using lines and rectangles (and whatever it may need)
			Console.WriteLine("Draw a Picture");
		}
	}
}
