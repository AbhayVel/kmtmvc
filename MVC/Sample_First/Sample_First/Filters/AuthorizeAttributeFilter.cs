using KmiEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Filters
{
    public class AuthorizeAttributeFilter : AuthorizeAttribute
    {

        public string Data { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            var strArray = Data.Split(',').Select(x => x.Trim().ToLower()).ToArray();

            var LoginUser = (httpContext.User as UserPrinsiple).LoginUser;
            return strArray.Contains(LoginUser.Role.Trim().ToLower());

        }
         
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(
               new
               {
                   controller = "Authorize",
                   action = "Index",
                   Id = 2
               }));

        }
    }
}