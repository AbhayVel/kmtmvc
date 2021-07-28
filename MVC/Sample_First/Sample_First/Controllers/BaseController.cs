using KmiEntities;
using Newtonsoft.Json;
using Sample_First.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Security;

namespace Sample_First.Controllers
{
    public class Base : Controller
    {


        
        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            // filterContext.Principal = null;


            //if (filterContext.HttpContext.Session["userDetail"] != null && Session["userDetail"] is LoginUser)
            //{

            //    LoginUser loginUser = Session["userDetail"] as LoginUser;
            //    //loginUser.IsAuthenticated = true;
            //    filterContext.Principal = new UserPrinsiple { Identity = loginUser };

            //}
            //else
            //{

            //    filterContext.Result = new HttpUnauthorizedResult();
            //}


            if (filterContext.HttpContext.Request.Cookies["userRole"] != null)
            {
                var encstring = filterContext.HttpContext.Request.Cookies["userRole"].Value;
                var decryptedTicket = FormsAuthentication.Decrypt(encstring);
                LoginUser loginUser = JsonConvert.DeserializeObject<LoginUser>(decryptedTicket.UserData);
                //loginUser.IsAuthenticated = true;
                filterContext.Principal = new UserPrinsiple { Identity = loginUser };

            }
            else
            {

                filterContext.Result = new HttpUnauthorizedResult();
            }



            //if (Session["userDetail"] == null)
            //{
            //    filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(
            //   new
            //   {
            //       controller = "Login",
            //       action = "Index"
            //   }));
            //}

        }

        protected override void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {

            var loginUser = filterContext.HttpContext.User;

            if (loginUser == null || loginUser.Identity.IsAuthenticated==false)
            {
              filterContext.Result = new RedirectToRouteResult( "Default",  new System.Web.Routing.RouteValueDictionary(
               new
               {
                   controller = "Login",
                   action = "Index",
                   Id = 2 
               }));
            }

            //if (Session["userDetail"] == null)
            //{
            //    filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(
            //   new
            //   {
            //       controller = "Login",
            //       action = "Index",
            //       Id = 2
            //   }));
            //}
        }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public DateTime StartResult { get; set; }
        public DateTime EndResult { get; set; }

        private dynamic GetPageViewBag()
        {
            ControllerBase controller = this;
            while (controller.ControllerContext.IsChildAction)  //traverse hierachy to get root controller
            {
                controller = controller.ControllerContext.ParentActionViewContext.Controller;
            }
            return controller.ViewBag;
        }

        //protected override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    End = DateTime.Now;


        //    filterContext.HttpContext.Response.Write("I am in OnActionExecuted <br>");

        //    filterContext.HttpContext.Response.Headers.Add("ActionTime", (End - Start).TotalMilliseconds.ToString());
        //}
        ////
        //// Summary:
        ////     Called before the action method is invoked.
        ////
        //// Parameters:
        ////   filterContext:
        ////     Information about the current request and action.
        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    filterContext.HttpContext.Response.Write("I am in OnActionExecuting <br>");
        //    Start = DateTime.Now;
        //}



        ////
        //// Summary:
        ////     Called after the action result that is returned by an action method is executed.
        ////
        //// Parameters:
        ////   filterContext:
        ////     Information about the current request and action result.
        //protected override void OnResultExecuted(ResultExecutedContext filterContext)
        //{

        //   EndResult = DateTime.Now;
        //    filterContext.HttpContext.Response.Headers.Add("RsultTime", (EndResult - StartResult).TotalMilliseconds.ToString());

        //    filterContext.HttpContext.Response.Write("I am in OnResultExecuted <br>");
        //}

        //protected override void OnResultExecuting(ResultExecutingContext filterContext)
        //{

        //    StartResult = DateTime.Now;
        //    filterContext.HttpContext.Response.Write("I am in OnResultExecuting <br>");
        //}

        private void LogInDataBase(string controllerName, string ActionName, string message, string stackTrace)
        {

        }
        // GET: User

        protected override void OnException(ExceptionContext filterContext)
        {

            //LogInDataBase(filterContext.RouteData.Values["controller"].ToString(), filterContext.RouteData.Values["action"].ToString(), filterContext.Exception.Message, filterContext.Exception.StackTrace);

            //filterContext.ExceptionHandled = true;


            //// filterContext.Result = new RedirectResult("/Exception/index");

            //filterContext.Result = new ViewResult { ViewName = "Exception" };

        }

        public ViewOutput<T> MyView<T>(T model,string controllerName , string actionName)
        {
            return new ViewOutput<T>(model, controllerName, actionName);
        }

        public ViewOutput<T> MyView<T>(T model, string viewPath)
        {
            return new ViewOutput<T>(model, viewPath);
        }
    }
}