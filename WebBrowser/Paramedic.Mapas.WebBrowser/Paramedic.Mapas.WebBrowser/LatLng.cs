namespace Paramedic.Mapas.WebBrowser
{
    public class LatLng
    {
        #region Properties
        public double Latitude { get; set; }

        public double Longitude { get; set; }
        #endregion

        #region Constructors

        public LatLng(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        #endregion
    }
}
