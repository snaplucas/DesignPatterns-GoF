namespace Composite.Component
{
	public abstract class Graphic
	{
		public string Name;

		public Graphic(string name)
		{
			Name = name;
		}

		public abstract void Add(Graphic p);
		public abstract void Remove(Graphic p);
		public abstract void Draw();
	}
}
