using State.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public void Request()
		{
			_state.Handle(this);
		}
	}
}
