using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			_MapPath = string.Format("{0}\\mapa.html?location={1}",
				Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName,
				"San Martin 2020, San Luis Capital, San Luis"
				);
			this.webBrowser.Navigate(_MapPath);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic direction = this.webBrowser.Document.InvokeScript("saveLocation");
				MapReference reference = JsonConvert.DeserializeObject<MapReference>(direction);
				MessageBox.Show(string.Format("Latitud: {0}, Longitud: {1}, Dirección: {2}",
					reference.Lat,
					reference.Lng,
					reference.Address));
			}
			catch (Exception exception)
			{
				var ex = exception;
			}
		}

		#endregion
	}
}
