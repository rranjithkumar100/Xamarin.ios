using System;

namespace TableView_Libros
{
	public class Libro
	{
		public Libro (int id, string titulo,string autor, int paginasTotal,int paginasLeidas , string imagen)
		{

			this.Id = id;
			this.Titulo = titulo;
			this.Autor = autor;
			this.PaginasLeidas = paginasLeidas;
			this.PaginasTotal = paginasTotal;
			this.Imagen = imagen;
		}

		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Autor { get; set; }
		public int PaginasLeidas { get; set; }
		public int PaginasTotal { get; set; }
		public string Imagen { get; set; }
	}
}

