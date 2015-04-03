// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace TableView_Libros
{
	[Register ("TableView_LibrosViewController")]
	partial class TableView_LibrosViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tvLibros { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (tvLibros != null) {
				tvLibros.Dispose ();
				tvLibros = null;
			}
		}
	}
}
