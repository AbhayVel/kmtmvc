using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Areas.Department.Controllers
{
    public class HomeDeptController : Controller
    {
        // GET: Department/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult aboutus()
        {
            return View("Index");
        }
    }
}