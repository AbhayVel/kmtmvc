using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.filters
{
    public class QDNREsultFilter : FilterAttribute, IResultFilter
    {
      //  public Logger logger = LogManager.GetCurrentClassLogger();
        DateTime StartDateTime; // = DateTime.Now;

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            DateTime EndDateTime = DateTime.Now;
            string timeTaken = (EndDateTime - StartDateTime).TotalMilliseconds.ToString();

            if(filterContext.Result is ViewResultBase)
            {
           //     logger.Info($" In Result   view: {((System.Web.Mvc.ViewResultBase)filterContext.Result).ViewName}  controller: {filterContext.RouteData.Values["Controller"]} - Action : {filterContext.RouteData.Values["Action"]} - TimeTaken : {timeTaken}");
            } else
            {
           //     logger.Info($" In Result  controller: {filterContext.RouteData.Values["Controller"]} - Action : {filterContext.RouteData.Values["Action"]} - TimeTaken : {timeTaken}");

            }
            filterContext.HttpContext.Response.Headers.Add("TimeTaken", (EndDateTime - StartDateTime).TotalMilliseconds.ToString());

        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            StartDateTime = DateTime.Now;
        }
    }
}