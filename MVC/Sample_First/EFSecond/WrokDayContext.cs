using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSecond
{
  public partial class WrokDayContext : DbContext
    {

        public WrokDayContext() : base(@"Data Source=DESKTOP-C0FBNF9\SQLEXPRESS;Initial Catalog=Workday;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework")
        {

        }

        public DbSet<UserData> Users { get; set; }

        public DbSet<Department> Department { get; set; }


    //    public DbSet<Subject> Subject { get; set; }
       

       
    }
}
