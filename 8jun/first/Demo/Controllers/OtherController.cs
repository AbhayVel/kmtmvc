using Demo.Models;
using Demo.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class OtherController : Base
    {
        // GET: Other
        public IKmiView Index()
        {
            Person p = new Person();
            p.Id = 1;
            p.Name = "Shubham";
            p.Salary = 50000;


            return KView(p, "Other_Index");
        }

        public IKmiView Save()
        {
            Person p = new Person();
            KUpdateMode(p);

            return KView(p, "Other_Index");
        }
    }
}