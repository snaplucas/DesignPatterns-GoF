using State.Context;
using State.State;

namespace State.ConcreteState
{
	public class StateWorking : MachineState
	{
		public override void Handle(Machine machine)
		{
			if (machine.DaysWorking > 10)
			{
				machine.State = new StateStopped();
			}
			else
			{
				machine.State = new StateWorking();
			}

		}
	}
}
