using System;
using System.Collections.Generic;

namespace Command
{
	public class User
	{
		private readonly Calculator _calculator = new Calculator();
		private readonly List<Commander> _commands = new List<Commander>();
		private int _current;

		public void Compute(char @operator, int operand)
		{
			Commander command = new CalculatorCommand(
			  _calculator, @operator, operand);
			command.Execute();

			_commands.Add(command);
			_current++;
		}

		public void Redo(int levels)
		{
			Console.WriteLine("\n---- Retornando {0} níveis ", levels);
			for (var i = 0; i < levels; i++)
			{
				if (_current >= _commands.Count - 1) continue;
				var command = _commands[_current++];
				command.Execute();
			}
		}

		public void Undo(int levels)
		{
			Console.WriteLine("\n---- Desfazendo {0} níveis ", levels);
			for (var i = 0; i < levels; i++)
			{
				if (_current <= 0) continue;
				var command = _commands[--_current];
				command.UnExecute();
			}
		}
	}
}
