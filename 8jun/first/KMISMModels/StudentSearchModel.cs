using KMISMEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMModels
{

    public class IsNumeric : ValidationAttribute
    {

        public override bool IsValid(object value)
        {

            if (value == null)
            {
                return true;
            }

            var str = value.ToString();

          return  str.ToCharArray().All(x => char.IsNumber(x));

            
        }

    }
  public  class StudentSearchModel : BaseSearchModel
    {

      public  StudentSearchModel()
        {
            

        }
       


        [IsNumeric]
    
     
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Doj { get; set; }


        public string Age { get; set; }

        public string AgeGte { get; set; }

        public string AgeLte { get; set; }


        public List<Student> StudentList { get; set; }
        //public string ColumnName { get; set; }


        //   string columnName, string orderBy

        public List<Student> GetWhere(List<Student> students)
        {
            IEnumerable<Student> studentsList = students;
            if (!string.IsNullOrEmpty(FirstName))
            {
                studentsList = studentsList.Where(x =>!string.IsNullOrEmpty(x.FirstName) && x.FirstName.ToLower().Contains(FirstName.ToLower()));
            }


            if (!string.IsNullOrEmpty(LastName))
            {
                studentsList = studentsList.Where(x => x.LastName.Contains(LastName));
            }

            if (!string.IsNullOrEmpty(AgeGte))
            {
                studentsList = studentsList.Where(x => x.Age >= KMISMUtility.Utility.ConverData(AgeGte, "System.Int32"));
            }

            if (!string.IsNullOrEmpty(AgeLte))
            {
                studentsList = studentsList.Where(x => x.Age <= KMISMUtility.Utility.ConverData(AgeLte, "System.Int32"));
            }



            return studentsList.ToList();
        }


        public IQueryable<Student> GetOrderBy(IQueryable<Student> students)
        {

            if ("asc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
            {
                return GetOrderByAsc(students);
            } else
            {
                return GetOrderByDesc(students);
            }
             
        }



        public override string GetOrderBy()
        {

            string orderByString = "";

            if ("asc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
            {
                orderByString = " asc ";
            }
            else
            {
                orderByString = " desc ";
            }

            if ("Id".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                orderByString = " order by s.Id " + orderByString;
            } else
            {
                orderByString =" order by " + ColumnName + orderByString;
            }

            return orderByString;
        }

      

        public string GetWhere()
        {
            string where = " Where 1=1 ";
            if (!string.IsNullOrEmpty(FirstName))
            {
                where += " and   FirstName like '%" + FirstName.Replace("'", "''") + "%' ";
            }
            if (!string.IsNullOrEmpty(LastName))
            {
                where += " and  LastName like '%" + LastName.Replace("'", "''") + "%' ";
            }
            if (!string.IsNullOrEmpty(AgeGte))
            {
                where += " and  Age >=" + AgeGte.Replace("'", "''") + " ";
            }
            if (!string.IsNullOrEmpty(AgeLte))
            {
                where += "  and Age <=" + AgeLte.Replace("'", "''") + " ";
            }
            return where;
        }




        public IQueryable<Student> GetWhere(IQueryable<Student> students)
        {
            IQueryable<Student> studentsList = students;
            if (!string.IsNullOrEmpty(FirstName))
            {
                studentsList = studentsList.Where(x => !string.IsNullOrEmpty(x.FirstName) && x.FirstName.ToLower().Contains(FirstName.ToLower()));
            }


            if (!string.IsNullOrEmpty(LastName))
            {
                studentsList = studentsList.Where(x => x.LastName.Contains(LastName));
            }

            if (!string.IsNullOrEmpty(AgeGte))
            {
                int ageGte = int.Parse(AgeGte);
                studentsList = studentsList.Where(x => x.Age >= ageGte);
            }

            if (!string.IsNullOrEmpty(AgeLte))
            {
                int ageLte = int.Parse(AgeGte);
                studentsList = studentsList.Where(x => x.Age <= ageLte);
            }
            return studentsList;
        }



        private IQueryable<Student> GetOrderByDesc(IQueryable<Student> students)
        {

            if ("Id".Equals(ColumnName,StringComparison.OrdinalIgnoreCase ))
            {
                students= students.OrderByDescending(x => x.Id);
            }

            if ("FirstName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                students = students.OrderByDescending(x => x.FirstName);
            }

            if ("LastName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                students = students.OrderByDescending(x => x.LastName);
            }

            return students;

        }
            private IQueryable<Student> GetOrderByAsc(IQueryable<Student> students)
        {
            if ("Id".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                students = students.OrderBy(x => x.Id);
            }

            if ("FirstName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                students = students.OrderBy(x => x.FirstName);
            }

            if ("LastName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                students = students.OrderBy(x => x.LastName);
            }

            return students;
        }



        

    }
}
