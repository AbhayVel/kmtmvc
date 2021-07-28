using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.filters
{
    public class QDNExceptionFIlter : HandleErrorAttribute
    {
        public Logger logger = LogManager.GetCurrentClassLogger();
        public override void OnException(ExceptionContext filterContext)
        {
            string errorMessage = $"controller: {filterContext.RouteData.Values["Controller"]} - Action : {filterContext.RouteData.Values["Action"]} - Message : {filterContext.Exception.Message} - StackTrace : {filterContext.Exception.StackTrace}";
            logger.Error(errorMessage);

            filterContext.Result = new RedirectResult("/Exception/Index");

            filterContext.ExceptionHandled = true;
            
        }
    }
}