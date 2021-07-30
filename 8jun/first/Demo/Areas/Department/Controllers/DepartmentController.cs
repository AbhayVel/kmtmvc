using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Areas.Department.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department/Department
        public ActionResult Index()
        {
            return View();
        }
    }
}