using Demo.filters;
using KMISMWebApi.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KMISMWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            GlobalConfiguration.Configuration.EnableCors(corsAttr);
            GlobalConfiguration.Configure(WebApiConfig.Register);
           
            FIlterApiConfig.RegisterGlobalFilters(GlobalConfiguration.Configuration.Filters);
           // GlobalConfiguration.Configuration.Filters.Add();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
