using Routes.Dal.Entities;
using Routes.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routes.Dal.Repositories
{
    public class RouteRepository : IRouteRepository
    {

        RoutesContext context;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name"> имя строки подключения </param>
        public RouteRepository(string name)
        {
            context = new RoutesContext(name);
        }

        public void Create(Route t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Route> Find(Func<Route, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Route> GetAll()
        {
           return context.Routes;
        }

        public Task<Route> GetAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Route GetById(int Id)
        {
            var r = context.Routes.Include("WayPoints").Where(item => item.RouteID == Id);
            return r.FirstOrDefault();
        }

        public IEnumerable<RoutesMarker> GetRouteMarkers(int Id)
        {
          return  context.RoutesMarkers.Where(item => item.RouteID == Id);
        }

        public void Update(Route t)
        {
            throw new NotImplementedException();
        }
    }
}
