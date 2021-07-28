using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmiEntities
{
   public class UserSearch
    {

        public UserSearch()
        {
            OrderByColumnName = "Id";
            OrderBy = "asc";




        }

        public int PageNumber { get; set; }
        public List<SearchClass> SearchClassList { get; set; }


        [Display(Name ="First Name")]
        public String FirstNameSearch { get; set; }

        public String LastNameSearch { get; set; }

        public String AgeFromSearch { get; set; }

        public String AgeToSearch { get; set; }

        public string Dept_id { get; set; }
        public string DepartmentSearch { get; set; }

        public string OrderByColumnName { get; set; }


        public string OrderBy { get; set; }
        public string GetPageString()
        {
            if (PageNumber == 0)
            {
                PageNumber = 1;
            }
            var orderByString = " OFFSET     "+ (((PageNumber -1)*2)).ToString()+ " ROWS FETCH NEXT 2 rows only";

            return orderByString;
        }

        public string GetOrderByString()
        {

            if (string.IsNullOrEmpty(OrderByColumnName))    
            {
                OrderByColumnName = "id";
            }

            if(!(OrderBy=="desc" || OrderBy == "asc"))
            {
                OrderBy = "asc";
            }
            var orderByString = " Order By " + OrderByColumnName + " " + OrderBy;

            return orderByString;
        }

            public string GetSearchString()
        {
            var searchString = "Where 1= 1 ";
            if (!String.IsNullOrEmpty(FirstNameSearch))
            {
                searchString = searchString + " and  u.FirstName like '%" + FirstNameSearch.Replace("'", "''") + "%'";
            }

            if (!String.IsNullOrEmpty(LastNameSearch))
            {
                searchString = searchString + " and  u.LastName like '%" + LastNameSearch.Replace("'", "''") + "%'";
            }

            if (!String.IsNullOrEmpty(AgeToSearch))
            {
                searchString = searchString + " and u.Age <=" + AgeToSearch;
            }

            if (!String.IsNullOrEmpty(AgeFromSearch))
            {
                searchString = searchString + " and u.Age >=" + AgeFromSearch;
            }

            if (!String.IsNullOrEmpty(AgeToSearch))
            {
                searchString = searchString + " and u.Age <=" + AgeToSearch;
            }

            if (!String.IsNullOrEmpty(DepartmentSearch))
            {
                searchString = searchString + " and  d.DepartmentSearch like '%" + DepartmentSearch.Replace("'", "''") + "%'";

            }



            return searchString;
        }

    }
}
