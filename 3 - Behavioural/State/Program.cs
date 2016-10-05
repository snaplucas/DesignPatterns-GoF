using State.ConcreteState;
using State.Context;

namespace State
{
	class Program
	{
		static void Main(string[] args)
		{
			var c = new Machine(new StateWorking());

			c.Request();
			c.Request();
			c.Request();
		}
	}
}
