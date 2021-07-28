using KMISMEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMDBContext
{
   public partial class StudentDBContext :DbContext
    {
        public DbSet<Student> StudentDbSet { get; set; }
        public DbSet<Subject> SubjectDbSet { get; set; }

        public DbSet<LoginUser> LoginUserDbSet { get; set; }
        public DbSet<Department> DepartmentDbSet { get; set; }
        public StudentDBContext() : base("name=studentsEntities")
        {
            this.Configuration.ProxyCreationEnabled = false;
             this.Configuration.AutoDetectChangesEnabled = false;
            Database.SetInitializer<StudentDBContext>(null);
        }
          
    }

   
}
 
