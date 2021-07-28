using CheckDatabaseFromEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{
    public class DeptController : Base
    {
        // GET: Dept
        public ActionResult Index()
        {

            WorkdayContext workdayContext = new WorkdayContext();

            var data = workdayContext.Departments.ToList();
            List<SelectListItem> sIL = new List<SelectListItem>();
            foreach (var d in data)
            {
                sIL.Add(new SelectListItem() { Text = d.Name, Value = d.Id.ToString() });
            }

            ViewBag.DeptList = sIL;
            return View("Index");
        }



        public ActionResult ChangeDet(string DeptList)
        {
            int id = Convert.ToInt32(DeptList);
            WorkdayContext workdayContext = new WorkdayContext();
            var data = workdayContext.Users.Where(x => x.Dept_Id == id).ToList();
            List<SelectListItem> sIL = new List<SelectListItem>();
            foreach (var d in data)
            {
                sIL.Add(new SelectListItem() { Text = d.FirstName, Value = d.Id.ToString() });
            }

            ViewBag.UserList = sIL;

            return PartialView();
        }


    }
}