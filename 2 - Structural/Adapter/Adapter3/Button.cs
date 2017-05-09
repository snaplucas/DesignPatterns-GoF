namespace Adapter.Adapter3
{
	public class Button
	{
		private readonly ButtonListener _buttonListener;
		public Button(ButtonListener buttonListener)
		{
			_buttonListener = buttonListener;
		}

		public void ButtonPressed()
		{
			_buttonListener.ButtonPressed();
		}
	}
}
