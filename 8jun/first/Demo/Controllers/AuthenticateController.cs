using KMISMEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Security;
using KMISMModels;

namespace Demo.Controllers
{
    public class AuthenticateController : Base
    {
        
        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            var httpCookies = filterContext.HttpContext.Request.Cookies["SessionUser"];
            if (httpCookies == null || string.IsNullOrEmpty(httpCookies.Value))
            {
                filterContext.Result = new RedirectResult("/Login/Index");
                return;
            }
            else
            {

                var encrptedString = httpCookies.Value;
                var fa = FormsAuthentication.Decrypt(encrptedString);

                if(fa.Expired || string.IsNullOrEmpty( fa.UserData))
                {
                    filterContext.Result = new RedirectResult("/Login/Index");
                    return;
                }
                var loginUserString = fa.UserData;
             var loginUser=   JsonConvert.DeserializeObject<LoginUser>(loginUserString);

              var loginUserModel=  new LoginUserModel();
                loginUserModel.Identity = loginUser;
                filterContext.HttpContext.User = loginUserModel as IPrincipal;
                return;
            }
            if (filterContext.HttpContext.Session["UserName"] == null)
            {
                 filterContext.Result = new RedirectResult("/Login/Index");
            } else
            {
                filterContext.HttpContext.User = filterContext.HttpContext.Session["UserName"] as IPrincipal;
            }
        }
        
        protected override void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            
        }


    }
}