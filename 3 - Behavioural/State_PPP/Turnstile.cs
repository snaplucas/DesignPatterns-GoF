namespace State_PPP
{
	public class Turnstile
	{
		internal static TurnstileState lockedState = new LockedTurnStileState();
		internal static TurnstileState unlockedState = new UnlockedTurnstileState();
		internal TurnstileState state = unlockedState;

		private TurnstileController _turnstileController;

		public Turnstile(TurnstileController turnstilecontroller)
		{
			_turnstileController = turnstilecontroller;
		}

		public void Coin()
		{
			state.Coin(this);
		}

		public void Pass()
		{
			state.Pass(this);
		}

		public void SetLocked()
		{
			state = lockedState;
		}

		public void SetUnlocked()
		{
			state = unlockedState;
		}

		public bool IsLocked()
		{
			return state == lockedState;
		}

		public bool IsUnlocked()
		{
			return state == unlockedState;
		}

		internal void ThankYou()
		{
			_turnstileController.Thankyou();
		}

		internal void Alarm()
		{
			_turnstileController.Alarm();

		}

		internal void Lock()
		{
			_turnstileController.Lock();

		}

		internal void Unlock()
		{
			_turnstileController.Unlock();
		}

	}
}