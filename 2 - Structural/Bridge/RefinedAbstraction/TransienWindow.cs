using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction
{
	public class TransienWindow : Window
	{
		public override void DrawText()
		{
			base.DrawText();
		}
		public void DrawCloseBox()
		{
			DrawRect();
		}
	}
}
