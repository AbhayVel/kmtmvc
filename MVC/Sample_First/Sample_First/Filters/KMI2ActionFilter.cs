using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Filters
{
    public class KMI2ActionFilter : ActionFilterAttribute
    {

        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public DateTime StartResult { get; set; }
        public DateTime EndResult { get; set; }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            End = DateTime.Now;


            filterContext.HttpContext.Response.Write("I am in OnActionExecuted2 <br>");

            filterContext.HttpContext.Response.Headers.Add("ActionTime2", (End - Start).TotalMilliseconds.ToString());
        }
        //
        // Summary:
        //     Called before the action method is invoked.
        //
        // Parameters:
        //   filterContext:
        //     Information about the current request and action.
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("I am in OnActionExecuting2 <br>");
            Start = DateTime.Now;
        }



        //
        // Summary:
        //     Called after the action result that is returned by an action method is executed.
        //
        // Parameters:
        //   filterContext:
        //     Information about the current request and action result.
        

        private void LogInDataBase(string controllerName, string ActionName, string message, string stackTrace)
        {

        }
    }
}