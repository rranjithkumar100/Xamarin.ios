using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace TableView_Libros
{
	public class TableSourceLibro: UITableViewSource 
	{
		List<Libro> tableItems_libros;//Listado de libros
		NSString cellIdentifier = new NSString("TableCell");//Indicador de nuestra celda

		//Constructor de nuestro datasource el cual le pasamos un listado de los libros.
		public TableSourceLibro (List<Libro> libros)
		{
			tableItems_libros = libros;
		}

		//Regresamos el numero de elementos que tiene nuestro datasource
		public override int RowsInSection (UITableView tableview, int section)
		{
			return tableItems_libros.Count;
		}

		//Se llama cual se da un click en la celda, y muestra el titulo del libro seleccionado
		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView("Usted Selecciono:"
				, tableItems_libros[indexPath.Row].Titulo, null, "OK", null).Show();

			tableView.DeselectRow (indexPath, true);
		}

		//Construye la celda de nuestro TabletView
		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			//Definimos nuestra variable que hace referencia ha nuestra celda personalizada
			//de igual forma usamos el tableView.DequeueReusableCell  para reciclar
			//la celda que se encuentra en memoria 
			CustomLibroCell cell = tableView.DequeueReusableCell (cellIdentifier) as CustomLibroCell;

			//Si la celda no estaba guardada en la memoria, la inicializamos
			if (cell == null) {
				cell = new CustomLibroCell (cellIdentifier);
			}

			//Llamamos al método UpdateCell de nuestra celda personalizada
			//y le pasamos el libro que le corresponde de acuerdo al indice de la celda
			cell.UpdateCell (tableItems_libros [indexPath.Row] );

			//Regresamos la celda personalizada
			return cell;

		}

		//Establecemos la altura de nuestra celda
		public override float GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{

			return 104f;
		}

	}
}

