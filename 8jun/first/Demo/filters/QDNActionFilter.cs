using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.filters
{
    public class QDNActionFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        DateTime StartDateTime; // = DateTime.Now;
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            DateTime EndDateTime = DateTime.Now;
            string timeTaken = (EndDateTime - StartDateTime).TotalMilliseconds.ToString();
            logger.Info($"controller: {filterContext.RouteData.Values["Controller"]} - Action : {filterContext.RouteData.Values["Action"]} - TimeTaken : {timeTaken}");
            filterContext.HttpContext.Response.Headers.Add("TimeTaken", (EndDateTime - StartDateTime).TotalMilliseconds.ToString());

        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

           
            StartDateTime = DateTime.Now;
        }
    }
}