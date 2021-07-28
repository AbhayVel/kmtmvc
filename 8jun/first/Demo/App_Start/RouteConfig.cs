using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Demo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "tv",
            //    url: "tv/{controller}/{action}/{id}",
            //    defaults: new { controller = "other", action = "Index", id = UrlParameter.Optional }
            //);

            //routes.MapRoute(
            //    name: "mobile",
            //    url: "mobile/{controller}/{action}/{id}",
            //    defaults: new { controller = "other", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
