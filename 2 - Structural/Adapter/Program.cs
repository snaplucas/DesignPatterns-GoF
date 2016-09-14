using Adapter.Adapter1;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			Target target = new Adapter1.Adapter();
			target.Request();
		}
	}
}
