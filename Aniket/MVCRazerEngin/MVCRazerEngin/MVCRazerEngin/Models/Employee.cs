using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCRazerEngin.Models
{
    public class Employee
    {
        [DisplayName("ID :")]
        public int id { get; set; }
        [DisplayName("Name :")]
        public string name { get; set; }
        [DisplayName("Address : ")]
        public string address { get; set; }
        [DisplayName("Salary : ")]
        public int salary { get; set; }
    }
}