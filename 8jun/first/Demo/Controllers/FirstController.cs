using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{

    //First + COntroller =Class Name 
    public class FirstController : Controller
    {
        // GET: First

        //Method=Action 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult yxz()
        {
            return View();
        }
    }
}