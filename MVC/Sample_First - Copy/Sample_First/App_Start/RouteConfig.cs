using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sample_First
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

          //  routes.MapRoute(
          //      name: "DefaultCKYC",
          //      url: "ckyc/{controller}/{action}/{id}",
          //      defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          //  );


          //  routes.MapRoute(
          //     name: "DefaultCKYCRegistration",
          //     url: "ckyc/registration/{controller}/{action}/{id}",
          //     defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          // );


          //  routes.MapRoute(
          //    name: "DefaultCKYC-Registration",
          //    url: "ckyc-registration/{controller}/{action}/{id}",
          //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          //);
          //  routes.MapRoute(
          //       name: "Defaultcrm",
          //       url: "crm/{controller}/{action}/{id}",
          //       defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          //   );

            

          //  routes.MapRoute(
          //      name: "Defaultartl",
          //      url: "artl/{controller}/{action}/{id}",
          //      defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          //  );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
