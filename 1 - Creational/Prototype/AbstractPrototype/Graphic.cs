namespace Prototype.AbstractPrototype
{
	public abstract class Graphic
	{
		private string _id;

		public Graphic(string id)
		{
			this._id = id;
		}

		public string Id
		{
			get { return _id; }
		}

		public abstract Graphic Clone();
	}
}
