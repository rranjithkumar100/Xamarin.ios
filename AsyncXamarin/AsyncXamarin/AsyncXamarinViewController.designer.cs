// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace AsyncXamarin
{
	[Register ("AsyncXamarinViewController")]
	partial class AsyncXamarinViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnImagen { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnJSON { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnServicio { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnXML { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIImageView Imagen { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblStatusImagen { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblStatusJSON { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblStatusServicio { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblStatusXML { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView VistaJSON { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView VistaServicio { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView VistaXML { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Imagen != null) {
				Imagen.Dispose ();
				Imagen = null;
			}

			if (VistaXML != null) {
				VistaXML.Dispose ();
				VistaXML = null;
			}

			if (VistaServicio != null) {
				VistaServicio.Dispose ();
				VistaServicio = null;
			}

			if (VistaJSON != null) {
				VistaJSON.Dispose ();
				VistaJSON = null;
			}

			if (btnImagen != null) {
				btnImagen.Dispose ();
				btnImagen = null;
			}

			if (btnXML != null) {
				btnXML.Dispose ();
				btnXML = null;
			}

			if (btnJSON != null) {
				btnJSON.Dispose ();
				btnJSON = null;
			}

			if (btnServicio != null) {
				btnServicio.Dispose ();
				btnServicio = null;
			}

			if (lblStatusJSON != null) {
				lblStatusJSON.Dispose ();
				lblStatusJSON = null;
			}

			if (lblStatusImagen != null) {
				lblStatusImagen.Dispose ();
				lblStatusImagen = null;
			}

			if (lblStatusServicio != null) {
				lblStatusServicio.Dispose ();
				lblStatusServicio = null;
			}

			if (lblStatusXML != null) {
				lblStatusXML.Dispose ();
				lblStatusXML = null;
			}
		}
	}
}
