namespace Singleton
{
	public class Singleton
	{
		private static Singleton _instance;

		protected Singleton()
		{
		}
		public static Singleton GetInstance()
		{
			_instance = _instance ?? new Singleton();

			return _instance;
		}
	}
}