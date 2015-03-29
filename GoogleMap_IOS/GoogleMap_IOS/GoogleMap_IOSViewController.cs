using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Google.Maps;
using MonoTouch.CoreLocation;

namespace GoogleMap_IOS
{
	public partial class GoogleMap_IOSViewController : UIViewController
	{

		//Definimos una variable de tipo MapView
		MapView mapView;

		public GoogleMap_IOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}


		public override void LoadView ()
		{
			base.LoadView ();

			//Definimos una cámara y le indicamos el punto inicial donde queremos que
			//nuestro mapa aparezca así como el zoom 
			CameraPosition camera = CameraPosition.FromCamera (21.121694,-101.6641149, 12);

			//Le asignamos la cámara a nuestra variable mapView
			mapView = MapView.FromCamera (RectangleF.Empty, camera);
			mapView.MyLocationEnabled = true;

			//Definimos un Marcador para nuestro mapa
			var xamMarker = new Marker () {
				Title = "Marcador",
				Snippet = "Cuerpo del marcador",
				Position = new CLLocationCoordinate2D (21.121694,-101.6641149),
				Map = mapView
			};


			//Personalizamos la imagen de nuestro marcador
			xamMarker.Icon=UIImage.FromBundle ("p_n");

			this.View = mapView;


		}

		#endregion
	}
}

