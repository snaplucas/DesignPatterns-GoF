using State.State;
using System;

namespace State.Context
{
	public class Machine
	{
		private MachineState _state;

		public Machine(MachineState state)
		{
			_state = state;
		}

		public MachineState State
		{
			get { return _state; }
			set
			{
				_state = value;
				Console.WriteLine("State: " +
				_state.GetType().Name);
			}
		}

		public int DaysWorking { get; set; }

		public void Request()
		{
			_state.Handle(this);
		}
	}
}
