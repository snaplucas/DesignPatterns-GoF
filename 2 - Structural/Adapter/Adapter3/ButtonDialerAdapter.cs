namespace Adapter.Adapter3
{
	public class ButtonDialerAdapter : ButtonListener
	{
		private int _digit;
		private Dialer _dialer = new Dialer();

		public ButtonDialerAdapter(int digit)
		{
			_digit = digit;
		}
		public void ButtonPressed()
		{
			_dialer.dial(_digit);
		}
	}
}
