using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
namespace AsyncXamarin
{
	public partial class AsyncXamarinViewController : UIViewController
	{
		double SizeImg;
		public AsyncXamarinViewController () : base ("AsyncXamarinViewController", null)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			btnServicio.TouchUpInside += ArchivoServicio;
			btnXML.TouchUpInside += ArchivoXML;
			btnJSON.TouchUpInside += ArchivoJSON;
			btnImagen.TouchUpInside += ArchivoImagen;
		}
		async void ArchivoServicio(object sender, EventArgs e)
		{
			lblStatusServicio.Text = "Descargando de Servicio WEB ...";
			VistaServicio.Text = "Cargando SOAP/WSDL \n";
			var Resultado = await DescargaWSDL ();
			lblStatusServicio.Text = "Tamaño WSDL: " + Resultado;
		}
		async void ArchivoXML(object sender, EventArgs e)
		{
			lblStatusXML.Text = "Descargando XML ...";
			VistaXML.Text = "Cargando XML \n";
			var Resultado = await DescargaXML ();
			lblStatusXML.Text = "Tamaño XML: " + Resultado;
		}
		async void ArchivoJSON(object sender, EventArgs e)
		{
			lblStatusJSON.Text = "Descargando JSON ...";
			VistaJSON.Text = "Cargando JSON \n";
			var Resultado = await DescargaJSON ();
			lblStatusJSON.Text = "Tamaño JSON: " + Resultado;
		}
		async void ArchivoImagen(object sender, EventArgs e)
		{
			lblStatusImagen.Text = "Descargando Imagen ...";
			var ruta = await DescargaImagen ();
			Imagen.Image = UIImage.FromFile (ruta);
			lblStatusImagen.Text = "Tamaño Imagen: " + SizeImg;
		}
		public async Task<int> DescargaWSDL()
		{
			var httpClient = new HttpClient ();
			Task<string> dimension = httpClient.GetStringAsync 
				("http://www.w3schools.com/WebServices/TempConvert.asmx?WSDL");
			VistaServicio.Text += "Sigue en Descarga \n";
			string dim = await dimension;
			int x = dim.Length;
			VistaServicio.Text += "Descargando el WSDL \n";
			VistaServicio.Text += dim;
			return x;
		}
		public async Task<int> DescargaXML()
		{
			var httpClient = new HttpClient ();
			Task<string> dimension = httpClient.GetStringAsync 
				("https://dl.dropboxusercontent.com/u/95408124/Actividades.xml");
			VistaXML.Text += "Sigue en Descarga \n";
			string dim = await dimension;
			int x = dim.Length;
			VistaXML.Text += "Descargando el XML \n";
			VistaXML.Text += dim;
			return x;
		}
		public async Task<int> DescargaJSON()
		{
			var httpClient = new HttpClient ();
			Task<string> dimension = httpClient.GetStringAsync 
				("http://congresorest.appspot.com/diputado/");
			VistaJSON.Text += "Sigue en Descarga \n";
			string dim = await dimension;
			int x = dim.Length;
			VistaJSON.Text += "Descargando el JSON \n";
			VistaJSON.Text += dim;
			return x;
		}
		public async Task<string> DescargaImagen()
		{
			WebClient client = new WebClient ();
			byte[] imageData = await client.DownloadDataTaskAsync
				("https://dl.dropboxusercontent.com/u/95408124/foto1.jpg");
			string documentspath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			string localfilename = "foto1.jpg";
			string localpath = Path.Combine (documentspath, localfilename);
			File.WriteAllBytes (localpath, imageData);
			SizeImg = new System.IO.FileInfo (localpath).Length;
			return localpath;
		}
	}
}

