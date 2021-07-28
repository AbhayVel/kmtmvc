using KMISMEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            List<Department> lstDepartment = new List<Department>();

            lstDepartment.Add(new Department
            {
                Id = 1,
                Name = "Angular"
            });

            lstDepartment.Add(new Department
            {
                Id = 2,
                Name = "React"
            });

            lstDepartment.Add(new Department
            {
                Id = 3,
                Name = "MVC"
            });
            return View(lstDepartment);
        }
    }
}