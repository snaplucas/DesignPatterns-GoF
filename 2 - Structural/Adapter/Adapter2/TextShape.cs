namespace Adapter.Adapter2
{
	public class TextShape : Shape
	{
		private TextView _textView = new TextView();

		public override string BoundingBox()
		{
			return _textView.GetExtend();
		}
	}
}
