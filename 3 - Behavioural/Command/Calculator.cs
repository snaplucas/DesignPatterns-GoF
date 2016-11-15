using System;

namespace Command
{
	public class Calculator
	{
		private int _curr;
		public void Operation(char @operator, int operand)
		{
			switch (@operator)
			{
				case '+': _curr += operand; break;
				case '-': _curr -= operand; break;
				case '*': _curr *= operand; break;
				case '/': _curr /= operand; break;
			}
			Console.WriteLine(
			  "Valor atual = {0,3} (dado {1} {2})",
			  _curr, @operator, operand);
		}
	}
}
