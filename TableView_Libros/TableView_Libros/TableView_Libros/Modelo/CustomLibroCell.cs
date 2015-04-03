using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Drawing;

namespace TableView_Libros
{
	public class CustomLibroCell: UITableViewCell
	{

		UIImageView Imagen;//Imagen de la portada
		UILabel Titulo,Autor, Paginas;//Etiquetas 
		UIProgressView Progreso;//Indicador de progreso de lo leido

		public CustomLibroCell (NSString cellid): base (UITableViewCellStyle.Default,cellid)
		{
			//Establecemos el color de seleccion de nuestra celda
			SelectionStyle = UITableViewCellSelectionStyle.Gray;

			//Establecemos el color de fondo de nuestra celda
			ContentView.BackgroundColor = UIColor.FromRGB (224, 223, 213);

			//Inicializamos el imagenview 
			Imagen = new UIImageView ();

			//Inicializamos las etiquetas de nuestra celda, aplciamos algunos estilos en el tipo de letra 
			//y cambiamos el color

			Titulo = new UILabel (){ 
				Font= UIFont.FromName("Helvetica-Bold",12f),
				BackgroundColor=UIColor.Clear
			};

			Autor = new UILabel (){ 
				Font= UIFont.FromName("Helvetica",10f),
				BackgroundColor=UIColor.Clear
			};

			Paginas = new UILabel (){ 
				Font= UIFont.FromName("Helvetica",8f),
				TextColor=UIColor.FromRGB(150,148,143),
				BackgroundColor=UIColor.Clear
			};

			//Inicializamos nuestro ProgressView y le establecemos un color personalizado
			Progreso = new UIProgressView (){ 
				ProgressTintColor=UIColor.FromRGB (239, 196, 17)

			};

			//Agregamos todas la vistas inicializadas a nuestra celda
			ContentView.AddSubviews (new UIView[]{Titulo,Autor,Imagen,Progreso,Paginas});



		}

		//Metodo que utilizaremos para asignarle el valor a las vistas
		public void UpdateCell(Libro lb){
			//Asignamos la portada del libro
			Imagen.Image = UIImage.FromFile ("Imagenes/" + lb.Imagen);

			//Titulo
			Titulo.Text = lb.Titulo;

			//Autor
			Autor.Text = lb.Autor;

			//Paginas
			Paginas.Text = "Pag. Leidas " + lb.PaginasLeidas.ToString () + " de " + lb.PaginasTotal.ToString ();

			//Establecemos el porcentaje de progreso, la vista maneja de 0 a 1.
			float porcentaje = 0.0f;
			porcentaje =(float) lb.PaginasLeidas / (float)lb.PaginasTotal;
			Progreso.Progress = porcentaje;


		}

		//Sobre escribimos este método para establecer la posición y tamaño de las vistas
		//que agregamos
		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			Imagen.Frame = new RectangleF(5, 7, 60, 90);
			Titulo.Frame = new RectangleF(75, 8, ContentView.Bounds.Width, 25);
			Autor.Frame = new RectangleF(75, 30, ContentView.Bounds.Width, 20);
			Progreso.Frame= new RectangleF(75, 60, ContentView.Bounds.Width-90, 80);
			Paginas.Frame = new RectangleF(75, 65, ContentView.Bounds.Width, 25);

		}


	}
}

