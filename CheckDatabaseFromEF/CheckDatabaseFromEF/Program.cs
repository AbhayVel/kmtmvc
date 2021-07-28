using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDatabaseFromEF
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkdayEntities we = new WorkdayEntities();


            var userList = we.Users.OrderBy(X => X.FirstName).Skip(0).Take(2).ToList();

            Console.WriteLine("I am in First Page");;
            for(var i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(userList[i].FirstName +" " +  userList[i].Department.Name);
            }


            userList = we.Users.OrderBy(X => X.FirstName).Skip(2).Take(2).ToList();
            Console.WriteLine("I am in Sec Page"); ;
            for (var i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(userList[i].FirstName + " " + userList[i].Department.Name);
            }

            userList = we.Users.OrderBy(X => X.FirstName).Skip(4).Take(2).ToList();
            Console.WriteLine("I am in thr Page"); ;
            for (var i = 0; i < userList.Count; i++)
            {
                Console.WriteLine(userList[i].FirstName + " " + userList[i].Department.Name);
            }
            // var dept=    we.AddUpdateDepartment(0, "Javascript");
            Console.ReadLine();
        }
    }
}
