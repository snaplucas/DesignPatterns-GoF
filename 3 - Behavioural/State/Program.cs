using State.ConcreteState;
using State.Context;

namespace State
{
	class Program
	{
		static void Main(string[] args)
		{
			var machine = new Machine(new StateWorking());
			machine.Request();
			machine.Request();
			machine.DaysWorking = 15;
			machine.Request();
		}
	}
}
