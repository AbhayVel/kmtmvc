//using ConsoleAppFirst;
//using Sample_First.Filters;
//using Sample_First.Models;
//using Sample_First.Output;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace Sample_First.Controllers
//{

   

//    //Name + Controller
//    public class UserController : Base
//    {

       


//        private List<Employee> GetAll()
//        {
//            List<Employee> empList = new List<Employee>();

//            //for(var i = 0; i < 100000; i++)
//            //{
//            //    Console.WriteLine(i.ToString());
//            //}

             

//            if (Session["emplist"] == null)
//            {
//                Session["emplist"] = empList;

//                empList.Add(new Employee { Id = 1, Name = "Ajay S", Age = 21 });
//                empList.Add(new Employee { Id = 2, Name = "Ajay Y", Age = 20 });
//                empList.Add(new Employee { Id = 3, Name = "Sanoj s", Age = 20 });
//                empList.Add(new Employee { Id = 4, Name = "Keshav", Age = 20 });
//                empList.Add(new Employee { Id = 5, Name = "Rajkapoor", Age = 20 });

//                empList.Add(new Employee { Id = 5, Name = "Aniket", Age = 20 });
//            }
//            else
//            {
//                empList = Session["emplist"] as List<Employee>;
//            }


//            return empList;
//        }


//        private Employee GetById(int id)
//        {
//            var empList = GetAll();
//            var emp = empList.FirstOrDefault(x => x.Id == id);

//            //var count = empList.Where(x => x.Id == id - id).Count();

//            //var k = 12 / count;

//            //   Utility.FileReadLines(path);
//            return emp;
//        }

//        public ActionResult Index()
//        {

//            var empList = GetAll();


//            return View(empList);
//        }

           
//        [KMI3ActionFilter]
//        public ActionResult Edit(int id)
//        {

//            //try
//            //{
//            //    // step 1-- > EXception

//            //}


////step 2


//            //step 3


//            //step 4



//            var emp = GetById(id);
//            return View(emp);
//        }


//        public ActionResult Edit2(int id)
//        {

//            var emp = GetById(id);
//            return View(emp);
//        }


//        //[ActionName("Search")]
//        //[HttpPost]
//        //[HttpGet]

//        [AcceptVerbs("Get","Post")]
//        public ActionResult searchList()
//        {
//            if (ViewBag.Data != null)
//            {

//            }
//            Employee emp = new Employee();
//            if(Session["EmpSearch"] != null && Session["EmpSearch"] is Employee)
//            {
//                emp = Session["EmpSearch"] as Employee;
//            }
//            //  return View(empList);

//            return PartialView("Search", emp);
//        }

//        [HttpPost]
//        public ActionResult Search(Employee emp)
//        {
//            ViewBag.Data = emp;
//            Session["EmpSearch"] = emp;
//            var empList = GetAll();

//            empList = empList.Where(X => X.Id == emp.Id).ToList();
//          //  return View(empList);

//            return View("index", empList);
//        }


//        public ActionResult Save(Employee emp)
//        {

//            if (ModelState.IsValid)
//            {
//                var empById = GetById(emp.Id);

//                empById.Name = emp.Name;
//                empById.Age = emp.Age;
//                return RedirectToAction("index");

//            }
//            else
//            {
//                return View("Edit", emp);
//            }

             

//        }
//    }
//}