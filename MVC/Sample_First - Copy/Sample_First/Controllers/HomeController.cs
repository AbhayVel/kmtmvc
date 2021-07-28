using Sample_First.Models;
using Sample_First.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Sample_First.Controllers
{

    //Name + Controller
    public class HomeController : Base
    {


        //Action
        public ViewOutput<Employee> Index()
        {

            var user = new Employee();

            user.Id = 12;
            user.Name = "Ajay";

            user.Age = 24;
            return MyView(user, "Home", "Index");
        }

        public ViewOutput<Employee> EDIT3()
        {

            var user = new Employee();

            user.Id = 12;
            user.Name = "Ajay";

            user.Age = 24;
            return MyView(user, "Home", "Index");
        }



        [HttpPost]        
        public ViewOutput<Employee> Save(Employee user, User uuser)
        {

            Employee user2 = new Employee();
            User user3 = new User();

             MyModelBinder(Request, user2);
            MyModelBinder(Request, user3);

            return MyView(user, "Home", "Index");
        }


        public void MyModelBinder(HttpRequestBase request,Object obj)
        {
            var output = "";
            foreach (PropertyInfo pro in obj.GetType().GetProperties())
            {
             output +=   request.Form[pro.Name].ToString();
                if (request.Form.AllKeys.Contains(pro.Name))
                {
                    continue;
                }
                if (request.Form.AllKeys.Contains(pro.Name))
                {
                    Console.Write(request.Form.AllKeys.Contains(pro.Name));
                    continue;
                }

                var value = Converts(request.Form[pro.Name].ToString(), Type.GetType( pro.PropertyType.ToString()));
                  pro.SetValue(obj, value);
                  continue;


                //if (pro.PropertyType.Name == "Int32")
                //{
                //    var intData = Convert.ToInt32(request.Form[pro.Name].ToString());
                //    pro.SetValue(obj, intData);
                //    continue;
                //}
                //if (pro.PropertyType.Name == "Decimal")
                //{
                //    var decimalData = decimal.Parse(request.Form[pro.Name].ToString());
                //    pro.SetValue(obj, decimalData);
                //    continue;
                //}
                //if (pro.PropertyType.Name == "Single")
                //{
                //    var floatlData = float.Parse(request.Form[pro.Name].ToString());
                //    pro.SetValue(obj, floatlData);
                //    continue;
                //}
                //if (pro.PropertyType.Name == "Double")
                //{
                //    var doublelData = double.Parse(request.Form[pro.Name].ToString());
                //    pro.SetValue(obj, doublelData);
                //    continue;
                //}
                //else
                //{
                //    var stringData = (request.Form[pro.Name].ToString());
                //    pro.SetValue(obj, stringData);
                //}
                //  if(pro.GetType()==)
                // 


            }


        }



        public dynamic Converts(string value, Type type)
        {
            return Convert.ChangeType(value, type);
        }




        public ViewOutput<User> GetUser()
        {

            var user = new User();

            user.Id = 1;
            user.Name = "Keshav";
            return MyView(user, "Home", "GetUser");
        }


        

        //action
        public string About()
        {
            ViewBag.Message = "Your application description page.";

            return "I am home about";
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}