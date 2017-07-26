using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserWithSearchBar
{
	public partial class Form1 : Form
	{

		#region Properties

		public string _MapPath { get; set; }

		#endregion

		#region Constructors

		public Form1()
		{
			InitializeComponent();
		}

		#endregion

		#region Private Methods

		private void Form1_Load(object sender, EventArgs e)
		{
			_MapPath = string.Format("{0}\\mapa.html", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName);
			this.webBrowser.Navigate(_MapPath);
		}

		#endregion

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic direction = this.webBrowser.Document.InvokeScript("saveLocation");
				MapReference reference = JsonConvert.DeserializeObject<MapReference>(direction);
				MessageBox.Show(string.Format("Latitud: {0}, Longitud: {1}, Nombre: {2}, Dirección: {3}",
					reference.Lat,
					reference.Lng,
					reference.Name,
					reference.Address));
			}
			catch (Exception exception)
			{
				var ex = exception;
			}
		}
	}
}
