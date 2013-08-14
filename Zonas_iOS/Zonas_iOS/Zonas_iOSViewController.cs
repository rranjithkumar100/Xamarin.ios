using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FlyoutNavigation;
using MonoTouch.Dialog;
namespace Zonas_iOS
{
	public partial class Zonas_iOSViewController : UIViewController
	{
		public Zonas_iOSViewController () : base ("Zonas_iOSViewController", null)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var Navegacion = new FlyoutNavigationController 
			{
				NavigationRoot = new RootElement("Navegacion")
				{
					new Section ("Secciones")
					{
						new StringElement ("Imagen 1"),
						new StringElement ("Imagen 2"),
						new StringElement ("Imagen 3"),
						new StringElement ("Imagen 4"),
					}
				},
				ViewControllers = new []
				{
					new UIViewController{ View=new UIImageView{Image = UIImage.FromFile ("Imagen1.jpg")}},
					new UIViewController{ View=new UIImageView{Image = UIImage.FromFile ("Imagen2.jpg")}},
					new UIViewController{ View=new UIImageView{Image = UIImage.FromFile ("Imagen3.jpg")}},
					new UIViewController{ View=new UIImageView{Image = UIImage.FromFile ("Imagen4.jpg")}},
				},
			};
			Navegacion.ToggleMenu();
			View.AddSubview(Navegacion.View);
		}
	}
}

