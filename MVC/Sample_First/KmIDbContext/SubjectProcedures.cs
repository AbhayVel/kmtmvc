using CheckDatabaseFromEF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmIDbContext
{
 public static  class SubjectProcedures
    {

        public static  List<Subject> GetSubject(this WorkdayContext w, int id)
        {
            //   var idParameter = new SqlParameter("Id", id);

            var idParameter = new SqlParameter("id", id);
          


            //  var data = ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department>("dbo.AddUpdateDepartment", idParameter, nameParameter).ToList();
            var data = w.Database.SqlQuery<Subject>("dbo.GetSubject @id ", idParameter).ToList();

            return data;


            // return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<dynamic>("AddUpdateDepartment", idParameter, nameParameter);
        }
    }
}
