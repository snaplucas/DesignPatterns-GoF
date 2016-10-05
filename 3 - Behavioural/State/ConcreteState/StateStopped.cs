using System;
using State.Context;
using State.State;

namespace State.ConcreteState
{
	public class StateStopped : MachineState
	{
		public override void Handle(Machine machine)
		{
			machine.State = new StateStopped();
		}
	}
}
