using System;

namespace State_PPP
{
	interface TurnstileState
	{
		void Coin(Turnstile t);
		void Pass(Turnstile t);
	}

	internal class LockedTurnStileState : TurnstileState
	{
		public void Coin(Turnstile t)
		{
			t.SetUnlocked();
			t.Unlock();
		}

		public void Pass(Turnstile t)
		{
			t.Alarm();
		}
	}

	internal class UnlockedTurnstileState : TurnstileState
	{
		public void Coin(Turnstile t)
		{
			t.ThankYou();
		}

		public void Pass(Turnstile t)
		{
			t.SetLocked();
			t.Lock();
		}
	}

}
