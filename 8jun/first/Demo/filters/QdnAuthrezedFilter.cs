using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Demo.filters
{
    public class QdnAuthrizedFilter : FilterAttribute, IAuthorizationFilter
    {
        public string Role { get; set; }


        public bool Check { get; set; }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
         var user=   filterContext.HttpContext.User;
            if (!user.IsInRole(Role))
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(
              new  {
                  COntroller="Unauth",
                  Action ="Index"
                }));
            }
        }
    }
}