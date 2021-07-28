using Sample_First.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{
    public class Base : Controller
    {

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