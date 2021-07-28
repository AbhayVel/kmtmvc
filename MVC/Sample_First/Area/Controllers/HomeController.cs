using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Area.Controllers
{
    public class HomeController : Controller
    {
        List<string> getUserList()
        {
            var lst = new List<string>();

            lst.Add("Abhay");
            lst.Add("Swati");
            lst.Add("Ashwini");
            lst.Add("neelam");

            return lst;
        }

        List<string> geSubjectList(string user)
        {
            var lst = new List<string>();


            if (user == "Abhay")
            {
                lst.Add("Angular");
                lst.Add("Java");
            } else if (user == "Swati")
            {
                lst.Add("MVC");
                lst.Add("React");
            }

            //lst.Add("Ashwini");
            //lst.Add("neelam");

            return lst;
        }

        public ActionResult Index()
        {
            var lst = getUserList();
            SelectList sl = new SelectList(getUserList());

            SelectList ssl = new SelectList(geSubjectList(lst.FirstOrDefault()));

            ViewBag.userList = sl;

            ViewBag.subjectList = ssl;
            return View();
        }


        public ActionResult ChangeUser(string userList)
        {
            var lst = getUserList();
            SelectList sl = new SelectList(getUserList(), userList);

            SelectList ssl = new SelectList(geSubjectList(userList));

            ViewBag.userList = sl;

            ViewBag.subjectList = ssl;
            return PartialView("ChangeUser");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}