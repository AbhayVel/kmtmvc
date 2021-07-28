using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Demo.filters
{
    public class QdnAuthrizedApiFilter : System.Web.Http.AuthorizeAttribute
    {
        public string Role { get; set; }


        public bool Check { get; set; }

    //    public override void OnAuthorization(HttpActionContext actionContext)
        public override void OnAuthorization(HttpActionContext filterContext)
        {


            var user = filterContext.RequestContext.Principal;
            if (user==null || !user.IsInRole(Role))
            {
                filterContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                filterContext.Response.Content = new StringContent("You are not auhorzied");
                filterContext.Response.ReasonPhrase = "Unauthorized";

            }
        }
    }
}