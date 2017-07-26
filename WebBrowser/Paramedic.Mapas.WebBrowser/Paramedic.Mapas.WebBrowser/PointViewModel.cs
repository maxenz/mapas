using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramedic.Mapas.WebBrowser
{
    public class PointViewModel
    {
        public double La { get; set; }
        public double Lo { get; set; }
        public int Id { get; set; }

        public PointViewModel(double latitude, double longitude)
        {
            this.La = latitude;
            this.Lo = longitude;            
        }
    }
}
