using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            WrokDayContext wc = new WrokDayContext();

            var lst = wc.Users.ToList();

            var lstD = wc.Department.ToList();

            var lstS = wc.GetSubject(1, "");

            wc.Department.Add(new Department
            {
                Name = "Spring"
            });
            wc.SaveChanges();
            
        }
    }
}
