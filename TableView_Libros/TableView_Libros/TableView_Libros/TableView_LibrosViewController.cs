using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Collections.Generic;

namespace TableView_Libros
{
	public partial class TableView_LibrosViewController : UIViewController
	{
		public TableView_LibrosViewController (IntPtr handle) : base (handle)
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

			//Personalizamos nuestra TabletView y el separador de cada celda
			tvLibros.AutoresizingMask = UIViewAutoresizing.All;

			tvLibros.SeparatorColor = UIColor.FromRGB(127, 106, 0);
			tvLibros.SeparatorEffect = UIBlurEffect.FromStyle(UIBlurEffectStyle.Light);
			tvLibros.SeparatorInset.InsetRect(new RectangleF(10, 0, tvLibros.Bounds.Width, 2f));
			tvLibros.SeparatorStyle = UITableViewCellSeparatorStyle.DoubleLineEtched;

			//Inicializamos una lista de elementos tipo libro y le agregamos estos
			List<Libro> libros = new List<Libro>();
			libros.Add(new Libro(1,"FROST BURNED","PATRICIA BRIGGS",350,100,"img1.jpg"));
			libros.Add(new Libro(2,"INFIERNO","DAN BROWN",430,70,"img2.jpg"));
			libros.Add(new Libro(3,"COLD VENGEANCE","PRESTON & CHILD",280,20,"img3.jpg"));
			libros.Add(new Libro(4,"BONES", "JAN BURKE",480,150,"img4.jpg"));
			libros.Add(new Libro(5,"ALEX CROSS","JAMES PATTERSON",410,52,"img5.jpg"));
			libros.Add(new Libro(6,"BATMAN YEAR ONE","FRANK MILLER, DAVID MAZZUCCHELLI",150,72,"img6.jpg"));
			libros.Add(new Libro(7,"CALLING THE DEAD","MARILYN MEREDITH",368,20,"img7.jpg"));
			libros.Add(new Libro(8,"FOOL ME TWICE","MICHAEL BRANDMAN",288,210,"img8.jpg"));
			libros.Add(new Libro(9,"A QUESTOF HEROES","MORGAN RICE",450,110,"img9.jpg"));
			libros.Add(new Libro(10,"FEVER MOON","KAREN MARIE MONING",560,230,"img10.jpg"));


			//Inicializamos nuestro DataSource Personalizado y le pasamos nuestro listado de libros.
			tvLibros.Source = new TableSourceLibro(libros);


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

		#endregion
	}
}

