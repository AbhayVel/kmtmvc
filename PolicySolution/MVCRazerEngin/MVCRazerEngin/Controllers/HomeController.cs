using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRazerEngin.Models;
namespace MVCRazerEngin.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            Employee e = new Employee();
            return View(e);
        }
        public ActionResult Home()
        {
            CustomRazor.GeneratedCSfile(@"c:\Users\CTHG3BS\Documents\Visual Studio 2013\Projects\MVCRazerEngin\MVCRazerEngin\Views\Home\Home.cshtml");
            return View();
        }
        public ActionResult Temp()
        {
            CustomRazor.generateNewFile(RouteData.Values["controller"].ToString(),RouteData.Values["action"].ToString());

            return View();
        }
    }
}