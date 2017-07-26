using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paramedic.Mapas.WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            PointViewModel latLng = new PointViewModel(-34.633242, -58.524616);
            PointViewModel latLng2 = new PointViewModel(-34.623037, -58.498825);
            List<PointViewModel> list = new List<PointViewModel>();
            list.Add(latLng);
            list.Add(latLng2);
            string jsonified = JsonConvert.SerializeObject(list);

            //this.browser.Navigate(@"C:\Users\Maxo\Desktop\Paramedic\Mapas\WebBrowser\Paramedic.Mapas.WebBrowser\Paramedic.Mapas.WebBrowser\mapa.html");
            this.browser.Navigate(@"C:\Users\Maxo\Desktop\Paramedic\Mapas\Visualizador de puntos\index.html?p=" + jsonified);

        }

        private void btnCleanMap_Click(object sender, EventArgs e)
        {
            InvokeScript("cleanMap");
        }

        private void btnSavePolygon_Click(object sender, EventArgs e)
        {
            try
            {
                dynamic polygon = InvokeScript("savePolygon");
                List<LatLng> result = JsonConvert.DeserializeObject<List<LatLng>>(polygon);
                foreach (LatLng latLng in result)
                {
                    Console.WriteLine(string.Format("Latitud: {0}, Longitud: {1}", latLng.Latitude, latLng.Longitude));
                }
            }
            catch (Exception exception)
            {
                var ex = exception;
            }
        }

        private void btnEditPolygon_Click(object sender, EventArgs e)
        {
            List<LatLng> polygon = new List<LatLng>();
        }

        private void btnNewPolygon_Click(object sender, EventArgs e)
        {
            Polygon polygon = new Polygon();
            polygon.Name = "Poligono 1 ";

            polygon.Vertices.Add(new LatLng(-34.7483136544061, -58.9616674804688));
            polygon.Vertices.Add(new LatLng(-35.1417514358818, -58.5456733398436));
            polygon.Vertices.Add(new LatLng(-34.5606586997037, -58.2833061523438));
            polygon.Vertices.Add(new LatLng(-34.474794023348, -58.7474340820313));
            polygon.Vertices.Add(new LatLng(-34.5845361250046, -58.9410681152344));

            JsonSerializer jsonSerializer = new JsonSerializer();
            var jsonPolygon = JsonConvert.SerializeObject(polygon);

            InvokeScript("newPolygon", new object[] { jsonPolygon });

        }

        private object InvokeScript(string name, object[] parameters = null)
        {
            return this.browser.Document.InvokeScript(name, parameters);
        }
    }
}
