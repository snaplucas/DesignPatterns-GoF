using Facade.Subsystem;

namespace Facade.Facade
{
	public class Facade
	{
		private readonly SubSystemOne _one;
		private readonly SubSystemTwo _two;
		private readonly SubSystemThree _three;
		private readonly SubSystemFour _four;

		public Facade()
		{
			_one = new SubSystemOne();
			_two = new SubSystemTwo();
			_three = new SubSystemThree();
			_four = new SubSystemFour();
		}

		public void DoWork_A()
		{
			_one.DoWorkOne();
			_two.DoWorkTwo();
			_three.DoWorkThree();
		}

		public void DoWork_B()
		{
			_three.DoWorkThree();
			_four.DoWorkFour();
		}
	}
}
