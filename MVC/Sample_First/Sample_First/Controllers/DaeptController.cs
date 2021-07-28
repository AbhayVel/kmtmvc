using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{
    public class DaeptController : Base
    {
        // GET: Daept
        public ActionResult Index()
        {

            var user = Session["UserName"];
            return View();
        }
    }
}