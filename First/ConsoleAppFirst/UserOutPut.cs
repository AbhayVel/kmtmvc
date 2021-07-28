using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
  public  class UserOutPut
    {
        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public decimal Salaray { get; set; }

        public override string ToString()
        {
            return Title + "|" + FirstName + "|" + LastName + "|" + Gender + "|" + Age.ToString() + "|" + Salaray.ToString();
        }
    }
}
