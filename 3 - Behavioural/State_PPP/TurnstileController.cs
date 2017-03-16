using System;

namespace State_PPP
{
	public class TurnstileController
	{

		public void Thankyou()
		{
			Console.WriteLine("Thank you!");
		}

		public void Alarm()
		{
			Console.WriteLine("BEEP");

		}

		public void Lock()
		{
			Console.WriteLine("Locking");

		}

		public void Unlock()
		{
			Console.WriteLine("Unlocking");
		}
	}
}