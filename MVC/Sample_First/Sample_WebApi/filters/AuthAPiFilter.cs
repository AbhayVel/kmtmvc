using KmiEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using static KmiUtitlity.EncryptDecrypt;

namespace Sample_WebApi.filters
{
    public class AuthAPiFilter : System.Web.Http.Filters.AuthorizationFilterAttribute
    {
        public String  Role { get; set; }
        public override void OnAuthorization(HttpActionContext actionContext)
        {
           var header= actionContext.Request.Headers.FirstOrDefault(x => x.Key == "token");

            var value = header.Value;
            if (value == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized); //Added this line
                return;
            }
            string s = value.FirstOrDefault();

            var userencstring = CryptoEngine.Decrypt(s, "sbab-3hn8-sqoy19");
            LoginUser loginUser = JsonConvert.DeserializeObject<LoginUser>(userencstring);


           
            if ((DateTime.Now - loginUser.LogginTime).TotalMinutes > 20)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                return;
            }
            actionContext.RequestContext.Principal = new UserPrinsiple { Identity = loginUser };
            base.OnAuthorization(actionContext);

        }
    }
}

/*
 * 
 * 
 * 
 * filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(
               new
               {
                   controller = "Authorize",
                   action = "Index",
                   Id = 2
               }));*/