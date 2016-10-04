using Proxy.Subject;
using System;

namespace Proxy.RealSubject
{
	public class Image : Graphic
	{
		public override void Draw()
		{
			Console.WriteLine("Draw image");
		}

		public override string GetExtent()
		{
			return null;
		}

		public override void Load()
		{
		}

		public override void Store()
		{
		}
	}
}
