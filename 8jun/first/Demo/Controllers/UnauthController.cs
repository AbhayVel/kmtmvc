using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class UnauthController : Controller
    {
        // GET: Unauth
        public ActionResult Index()
        {
            return View();
        }
    }
}