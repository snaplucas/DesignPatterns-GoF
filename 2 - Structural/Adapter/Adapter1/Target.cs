using System;

namespace Adapter.Adapter1
{
	public class Target
	{
		public virtual void Request()
		{
			Console.WriteLine("Request");
		}
	}
}
