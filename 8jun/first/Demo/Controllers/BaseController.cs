using Demo.utility;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class Base : Controller
    {
         

        public Logger logger = LogManager.GetCurrentClassLogger();
        dynamic GetDefaultValue(Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }

         dynamic ConverData(string str, string type)
        {
            Type ty = Type.GetType(type);
            try
            {
                //Type t = Nullable.GetUnderlyingType(ty) ?? ty;

                return Convert.ChangeType(str, ty);
            }

            catch (Exception ex)
            {

                return GetDefaultValue(ty);
            }
        }


        public void KUpdateMode(object obj)
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            foreach (string key in Request.QueryString)
            {
                d.Add(key, Request.QueryString[key]);
            }

            SetValue(obj, d);

        }

      public   void SetValue(object obj, Dictionary<string, string> keyValuePairs)
        {
            Type type = obj.GetType();
            int i = 0;
            foreach (var item in keyValuePairs)
            {
                var propertyInfo = type.GetProperty(item.Key);
                if (propertyInfo != null)
                {
                    propertyInfo.SetValue(obj, ConverData(item.Value, propertyInfo.PropertyType.ToString()));
                }

            }
        }
        public IKmiView KView(Object model, string fileName)
        {
            var km = new KmiView<Object>(model, @"D:\kmi\8jun\first\Demo\" + fileName + ".html");
            km.Execute();

            return km;
        }



        DateTime StartDateTime; // = DateTime.Now;
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            DateTime EndDateTime = DateTime.Now;
            double timeTaken = (EndDateTime - StartDateTime).TotalMilliseconds;
            filterContext.HttpContext.Response.Headers.Add("TimeTaken", (EndDateTime - StartDateTime).TotalMilliseconds.ToString());


            if(timeTaken > 1500)
            {
                logger.Info($"controller: {filterContext.RouteData.Values["Controller"]} - Action : {filterContext.RouteData.Values["Action"]} - TimeTaken : {timeTaken}");
            }

        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            StartDateTime = DateTime.Now;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            string errorMessage = $"controller: {filterContext.RouteData.Values["Controller"]} - Action : {filterContext.RouteData.Values["Action"]} - Message : {filterContext.Exception.Message} - StackTrace : {filterContext.Exception.StackTrace}";
            logger.Error(errorMessage);

            filterContext.Result = new RedirectResult("/Exception/Index");

            filterContext.ExceptionHandled = true;

        }
    }
}