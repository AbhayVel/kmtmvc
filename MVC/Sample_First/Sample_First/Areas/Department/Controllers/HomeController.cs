using Sample_First.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckDatabaseFromEF;
using KmiEntities;
namespace Sample_First.Areas.Department.Controllers
{
    public class HomeController : Base
    {
        // GET: Department/Home
        public ActionResult Index()
        {
            WorkdayContext workdayContext = new WorkdayContext();

            var data=workdayContext.Departments.ToList();
            List<SelectListItem> sIL = new List<SelectListItem>();
             foreach(var d in data)
            {
                sIL.Add(new SelectListItem() { Text = d.Name, Value = d.Id.ToString() });
            }

            ViewBag.DeptList = sIL;
            return View();
        }



        [HttpPost]
        public ActionResult getUser(int DeptList)
        {
            WorkdayContext workdayContext = new WorkdayContext();
            var userData = workdayContext.Users.Where(x=>x.Dept_Id==DeptList).ToList();
            List<SelectListItem> userList = new List<SelectListItem>();
            foreach (var d in userData)
            {
                userList.Add(new SelectListItem() { Text = d.FirstName, Value = d.Id.ToString() });
            }

            ViewBag.userList = userList;
            return PartialView("userList");
        }

    }
}