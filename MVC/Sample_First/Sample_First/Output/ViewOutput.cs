using ConsoleAppFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Output
{
    public class ViewOutput<T>  : ActionResult
    {
        public T Model { get; set; }
        public string  ViewPath { get; set; }

        public ViewOutput(T model)
        {
            this.Model = model;
            this.ViewPath = null;
        }

        public ViewOutput(T model, string viewPath)
        {
            this.Model = model;
            this.ViewPath = viewPath;
        }

        public ViewOutput(T model, string controllerName, string actionName)
        {
            this.Model = model;
            this.ViewPath = @"D:\kmi\MVC\Sample_First\Sample_First\myView\" + controllerName + @"\" +actionName +".html";
        }

        public override string ToString()
        {
            var strArray = Utility.FileReadLines(this.ViewPath);
            var output = Utility.ReplaceValueFromObject(strArray, this.Model);

            var str = "";
            foreach (var s in output)
            {
                str += s;
            }

            return str;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (this.ViewPath == null)
            {
                var controllerName = context.RouteData.Values["controller"];
                var actionName = context.RouteData.Values["action"];
                this.ViewPath = @"D:\kmi\MVC\Sample_First\Sample_First\myView\" + controllerName + @"\" + actionName + ".html";

            }

            var output = this.ToString();
            context.HttpContext.Response.ContentType = "text/HTML";
            context.HttpContext.Response.ClearContent();
            context.HttpContext.Response.Write(output);
            //   context.HttpContext.Response.End();

        }
    }
}