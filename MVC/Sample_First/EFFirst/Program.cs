using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkdayEntities we = new WorkdayEntities();



            var lst = we.GetSubject(1,"");
            //we.Entities.Add(new Entity
            //{
            //    name = "phone"
            //});

         //var entity=   we.Entities.Where(x => x.id == 3).FirstOrDefault();
         //   //  entity.name = "Phone2";

         //   we.Entities.Remove(entity);
         //   we.SaveChanges();


        }
    }
}
