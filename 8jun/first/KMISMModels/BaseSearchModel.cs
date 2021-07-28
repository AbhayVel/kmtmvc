using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMISMModels
{
   public class BaseSearchModel
    {

        public BaseSearchModel()
        {
            Pagination = new Pagination();
            Pagination.RowPerPage = 3;
        }
        public Pagination Pagination { get; set; }

        string _columnName;
        string _orderBy;


        [Key]
        public string ColumnName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_columnName))
                {
                    return "Id";
                }
                else
                {
                    return _columnName;
                }

            }
            set { _columnName = value; }
        }

        [Key]
        public string OrderBy
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_orderBy))
                {
                    return "asc";
                }
                else
                {
                    return _orderBy;
                }

            }
            set
            {
                _orderBy = value;
            }
        }


        public string GetPages()
        {
            if (Pagination.IsAll)
            {
                return " ";
            }
            return "Offset " + (Pagination.RowPerPage * (Pagination.CurrentPage - 1)).ToString() + "   Rows FETCH FIRST " + Pagination.RowPerPage + " ROWS ONLY";
        }

        public virtual string GetOrderBy()
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

            
            orderByString = " order by " + ColumnName + orderByString;
           




            return orderByString;
        }

    }
}
