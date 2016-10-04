using Bridge.Implementor;

namespace Bridge.Abstraction
{
	public abstract class Window
	{
		public WindowImp windowImp;

		public virtual void DrawText()
		{
			windowImp.DevDrawText();
		}

		public virtual void DrawRect()
		{
			windowImp.DevDrawLine();
		}
	}
}
