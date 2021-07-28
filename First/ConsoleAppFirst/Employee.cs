using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
  public  class Employee  
    {

        public static dynamic count;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public dynamic Address { get; set; }

        public dynamic GetName()
        {

            dynamic d = "a";
            return d;
        }


    }



    public class Person  
    {
        public int Age { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        
    }
}
