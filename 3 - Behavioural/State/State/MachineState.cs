using State.Context;

namespace State.State
{
	public abstract class MachineState
	{
		public abstract void Handle(Machine machine);
	}
}
