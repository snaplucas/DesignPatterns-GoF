namespace Adapter.Adapter1
{
	public class Adapter : Target
	{
		private Adaptee _adaptee = new Adaptee();

		public override void Request()
		{
			_adaptee.SpecificRequest();
		}
	}
}
