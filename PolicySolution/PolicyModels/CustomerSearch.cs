using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PolicyModels
{
    public class CustomerSearch
    {
        public int CurrentPage { get; set; } = 1;
        public int RowPerPage { get; set; } = 5;
        public int RowCount { get; set; }
        public int PageCount { get; set; }
        public string ColumnName { get; set; }
        public string OrderBy { get; set; }
        public string RecIDSearch { get; set; }
        public string CustIDSearch { get; set; }
        public string FNameSearch { get; set; }

        public string LnameSearch { get; set; }

        public IEnumerable<CustomerDetails> GetOrderBy(IEnumerable<CustomerDetails> Customers)
        {
            if (ColumnName == null)
            {
                ColumnName = "id";
            }
            if (OrderBy == null)
            {
                OrderBy = "desc";
            }

            if ("id".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
                {
                    Customers = Customers.OrderByDescending(x => x.RecID);
                }
                else
                {
                    Customers = Customers.OrderBy(x => x.RecID);
                }
            }
            if ("CustID".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
                {
                    Customers = Customers.OrderByDescending(x => x.CustID);
                }
                else
                {
                    Customers = Customers.OrderBy(x => x.CustID);
                }
            }

            if ("CustomerName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
                {
                    Customers = Customers.OrderByDescending(x => x.FName);
                }
                else
                {
                    Customers = Customers.OrderBy(x => x.FName);
                }
            }

            return Customers;
        }
        public IEnumerable<CustomerDetails> GetWhere(IEnumerable<CustomerDetails> Customers)
        {


            if (!string.IsNullOrWhiteSpace(RecIDSearch))
            {
                int RectId = 0;
                var isParse = int.TryParse(RecIDSearch, out RectId);
                if (isParse)
                {
                    Customers = Customers.Where(x => x.RecID == RectId);
                }

            }
            if (!string.IsNullOrWhiteSpace(CustIDSearch))
            {
                Customers = Customers.Where(x => x.CustID.Equals(CustIDSearch));

            }

            if (!string.IsNullOrWhiteSpace(FNameSearch))
            {
                Customers = Customers.Where(x => x.FName.Contains(FNameSearch));

            }
            return Customers;
        }


        public IEnumerable<CustomerDetails> GetPagination(IEnumerable<CustomerDetails> Customers)
        {

            RowCount = Customers.Count();

            PageCount = (int)Math.Ceiling(RowCount / (RowPerPage * 1.0d));

            if (PageCount < CurrentPage)
            {
                CurrentPage = 1;
            }

            int skip = (CurrentPage - 1) * RowPerPage;


            /*
			 * skip , take 
			 */
            return Customers.Skip(skip).Take(RowPerPage);
        }

    }
}
