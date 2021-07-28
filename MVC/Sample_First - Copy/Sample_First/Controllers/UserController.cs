using Sample_First.DataBase;
using Sample_First.Models;
using Sample_First.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{

    //Name + Controller
    public class UserController : Controller
    {





        



        // GET: User

        private List<Employee> GetAll()
        {

            DataEntities2 data = new DataEntities2();
           
            List<Employee> empList = new List<Employee>();

            if (Session["emplist"] == null)
            {
                Session["emplist"] = empList;

                empList.Add(new Employee { Id = 1, Name = "Ajay S", Age = 21 });
                empList.Add(new Employee { Id = 2, Name = "Ajay Y", Age = 20 });
                empList.Add(new Employee { Id = 3, Name = "Sanoj s", Age = 20 });
                empList.Add(new Employee { Id = 4, Name = "Keshav", Age = 20 });
                empList.Add(new Employee { Id = 5, Name = "Rajkapoor", Age = 20 });

                empList.Add(new Employee { Id = 5, Name = "Aniket", Age = 20 });
            }
            else
            {
                empList = Session["emplist"] as List<Employee>;
            }


            return empList;
        }


        private Employee GetById(int id)
        {
            var empList = GetAll();
            var emp = empList.FirstOrDefault(x => x.Id == id);

            return emp;
        }
        public ActionResult Index()
        {

            var empList = GetAll();


            return View(empList);
        }

        public ActionResult Edit(int id)
        {

            var emp = GetById(id);
            return View(emp);
        }


        public ActionResult Edit2(int id)
        {

            var emp = GetById(id);
            return View(emp);
        }


        public ActionResult Save(Employee emp)
        {

            if (ModelState.IsValid)
            {
                var empById = GetById(emp.Id);

                empById.Name = emp.Name;
                empById.Age = emp.Age;
                return RedirectToAction("index");

            }
            else
            {
                return View("Edit", emp);
            }

             

        }
    }
}