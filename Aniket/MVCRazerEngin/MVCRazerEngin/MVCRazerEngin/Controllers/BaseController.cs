using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazerEngin.Controllers
{
    public class Base : Controller
    {
        // GET: Base
        public ActionResult Index()
        {
            return View();
        }

        public KmiWebViewPage<dynamic> KmiView()
        {
            //Reflection Object 
            return null;
        }
    }
}