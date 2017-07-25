using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Routes.Dal.Entities
{
    public class Route
    {
        public int RouteID { get; set; }

        [Display(Name ="Способ ввода маршрута")]
        public string RouteEnterTupe { get; set; }//способ ввода маршрута (ручной\автоматический)
        public string TravelType { get; set; }
        public string OriginPoint { get; set; }
        public string DestinationPoint { get; set; }
        public string Description { get; set; }

        public virtual List<WayPoint> WayPoints { get; set; }
        public List<RoutesMarker> RoutesMarker { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }
    }
}
