using Prototype.AbstractPrototype;

namespace Prototype.Prototype
{
	public class Staff : Graphic
	{
		public Staff(string id) : base(id)
		{
		}

		public override Graphic Clone()
		{
			return (Graphic)MemberwiseClone();
		}
	}
}
