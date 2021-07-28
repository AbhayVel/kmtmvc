using CheckDatabaseFromEF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmIDbContext
{
 public static  class DepartmentProcedures
    {

        public static  List<Department> AddUpdateDepartment(this WorkdayContext w, Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new SqlParameter("Id", id) :
                new SqlParameter("Id", 0);

            var nameParameter = name != null ?
                new SqlParameter("name", name) :
                new SqlParameter("name", "");


            //  var data = ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department>("dbo.AddUpdateDepartment", idParameter, nameParameter).ToList();
            var data = w.Database.SqlQuery<Department>("dbo.AddUpdateDepartment @id , @name", idParameter, nameParameter).ToList();

            return data;


            // return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dynamic>("AddUpdateDepartment", idParameter, nameParameter);
        }
    }
}
