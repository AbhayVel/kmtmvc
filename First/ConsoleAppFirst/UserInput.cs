using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFirst
{
   public class UserInput
    {

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Age { get; set; }

        public string Salaray { get; set; }

        //  Name|Gender|Age|salary

        public override string ToString()
        {
            return Name + "|" + Gender + "|" + Age + "|" + Salaray;
        }
    }
}
