using Demo.Models;
using Demo.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    //Home + Controller 
    //Name + Controller --> 
    public class HomeController : Base
    {
        public ActionResult Index()
        {            

            Employee emp = new Employee();
            emp.Id = 12;
            emp.FirstName = "Shubham";
            emp.LastName  = "";
            emp.Age = 12;

           // KmiView<Employee> km = new KmiView<Employee>(emp,@"D:\kmi\8jun\first\Demo\Home_Index.html");
            return View(emp);
        }

        public ActionResult Save()
        {
           
            Employee emp = new Employee();
            TryUpdateModel(emp);
            return View("Index", emp);
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