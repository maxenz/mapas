using System.Collections.Generic;
using System.Security.Permissions;

namespace Paramedic.Mapas.WebBrowser
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class Polygon
    {
        #region Properties

        public string Name { get; set; }

        public List<LatLng> Vertices { get; set; }

        #endregion

        #region Constructors

        public Polygon() {
            this.Vertices = new List<LatLng>();
        }

        #endregion
    }
}
