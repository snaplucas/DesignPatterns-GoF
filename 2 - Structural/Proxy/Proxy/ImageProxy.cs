using Proxy.Subject;
using Proxy.RealSubject;

namespace Proxy.Proxy
{
	public class ImageProxy : Graphic
	{
		private Image image;
		private string fileName;
		private string extend;
		public override void Draw()
		{
			if (image == null)
			{
				LoadImage();
			}
			image.Draw();
		}

		public override string GetExtent()
		{
			if (image == null)
			{
				return extend;
			}
			return image.GetExtent();

		}

		public override void Load()
		{
		}

		public override void Store()
		{
		}

		private void LoadImage()
		{
			image = new Image();
		}
	}
}
