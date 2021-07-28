using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreator
{

   public enum Conditions
    {
        Yes=1,
        No=0
    }
   public class Employee
    {
        const int data = 4;
        int _id;

        public int Id { get => _id; set => _id = value; }
    }
}
