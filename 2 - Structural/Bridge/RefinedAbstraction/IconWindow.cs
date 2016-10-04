using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction
{
	public class IconWindow : Window
	{
		public override void DrawRect()
		{
			base.DrawRect();
		}

		public void DrawBorder()
		{
			DrawRect();
			DrawText();
		} 
	}
}
