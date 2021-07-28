using Sample_First.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Areas.Department.Controllers
{
    public class DepartmentController : Base
    {
        // GET: Department/Department
        public ActionResult Index()
        {
            return View();
        }



    }
}