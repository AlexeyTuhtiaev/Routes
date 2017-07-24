using Routes.Dal.Entities;
using Routes.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Routes.Web.Controllers
{
    public class RouteController : Controller
    {
        IRouteRepository repositiry;

        public RouteController(IRouteRepository repo)
        {
            repositiry = repo;
        }

        // GET: Route
        public ActionResult ShowRoute(int Id)
        {
            return View(repositiry.GetById(Id));
        }

        public JsonResult GetMarkers(int Id)
        {
            List<RoutesMarker> markers = repositiry.GetRouteMarkers(Id).ToList();
            return Json(markers,JsonRequestBehavior.AllowGet);
        }
    }
}