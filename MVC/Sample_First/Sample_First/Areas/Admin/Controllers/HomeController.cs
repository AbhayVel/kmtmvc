using Sample_First.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Areas.Admin.Controllers
{
    public class HomeController : Base
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }



    }
}