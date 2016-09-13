using Prototype.AbstractPrototype;

namespace Prototype.Prototype
{
	public class MusicalNote : Graphic
	{
		public MusicalNote(string id) : base(id)
		{
		}

		public override Graphic Clone()
		{
			return (Graphic)MemberwiseClone();
		}
	}
}
