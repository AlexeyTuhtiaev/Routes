using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routes.Dal.Entities
{
    class RoutesContext : DbContext
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        ///// <param name="name"> имя строки подключения </param>
        public RoutesContext(string name) : base(name)
        {
            Database.SetInitializer(new RoutesContextInitializer());
        }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RoutesMarker> RoutesMarkers { get; set; }
    }

    class RoutesContextInitializer : DropCreateDatabaseAlways<RoutesContext>
    {
        protected override void Seed(RoutesContext context)
        {
            List<WayPoint> wayPoints1 = new List<WayPoint> {
                new WayPoint { WayPointID =1, Point ="Минск, Беларусь"},
                new WayPoint { WayPointID =2, Point ="Могилев, Могилевская область, Беларусь"}
            };

            List<RoutesMarker> routesMarkers1 = new List<RoutesMarker> {
                new RoutesMarker {Title="Ресторан", Content ="Описание ресторана",
                    GeoLat = "53.917959",GeoLong = "27.596525", Icon="https://maps.google.com/mapfiles/kml/shapes/parking_lot_maps.png"},
                new RoutesMarker {Title="Библиотека", Content ="Описание Библиотеки",
                    GeoLat = "53.930914",GeoLong = "27.645416", Icon="https://maps.google.com/mapfiles/kml/shapes/library_maps.png"}
            };

            List<Route> routes = new List<Route> {
                new Route { RouteID = 1, RouteEnterTupe = "Simple",TravelType="WALKING",WayPoints=wayPoints1,
                    OriginPoint ="Брест, Брестская область, Беларусь",DestinationPoint="Гомель, Гомельская область, Беларусь",
                Description="Некоторое описание маршрута Брест Некоторое описание маршрута Некоторое описание маршрута ",
                RoutesMarker=routesMarkers1},
                new Route { RouteID = 2, RouteEnterTupe = "Simple",TravelType="DRIVING",
                    OriginPoint ="Гродно, Гродненская область, Беларусь",DestinationPoint="Минск, Беларусь" ,
                Description="Некоторое описание маршрута Гродно Некоторое описание маршрута Некоторое описание маршрута "},
                new Route { RouteID = 3, RouteEnterTupe = "Simple",TravelType="WALKING",
                    OriginPoint ="Витебск, Витебская область, Беларусь",DestinationPoint="Минск, Беларусь" ,
                Description="Некоторое описание маршрута Витебск Некоторое описание маршрута Некоторое описание маршрута "}
            };



            context.Routes.AddRange(routes);
            context.SaveChanges();
        }
    }
}
