using Sample_First.Models;
using Sample_First.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{

    //Name+ controller
    public class SalesController : Base
    {
        // GET: Sales
        public ActionResult Index()
        {

             
            return View(); 
        }
    }
}