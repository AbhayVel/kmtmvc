using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PolicyModels
{
    public class PolicySearch
    {
        public int CurrentPage { get; set; } = 1;
        public int RowPerPage { get; set; } = 5;
        public int RowCount { get; set; }
        public int PageCount { get; set; }
        public string ColumnName { get; set; }
        public string OrderBy { get; set; }
        public string RecIDSearch { get; set; }
        public string CustIDSearch { get; set; }
        public string Policyname { get; set; }
        public IEnumerable<PolicyDtls> GetOrderBy(IEnumerable<PolicyDtls> Policies)
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
                    Policies = Policies.OrderByDescending(x => x.RecID);
                }
                else
                {
                    Policies = Policies.OrderBy(x => x.RecID);
                }
            }
            if ("CustID".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
                {
                    Policies = Policies.OrderByDescending(x => x.CustID);
                }
                else
                {
                    Policies = Policies.OrderBy(x => x.CustID);
                }
            }

            if ("CustomerName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
            {
                if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
                {
                    Policies = Policies.OrderByDescending(x => x.Policyname);
                }
                else
                {
                    Policies = Policies.OrderBy(x => x.Policyname);
                }
            }

            return Policies;
        }
        public IEnumerable<PolicyDtls> GetWhere(IEnumerable<PolicyDtls> Policies)
        {


            if (!string.IsNullOrWhiteSpace(RecIDSearch))
            {
                int RectId = 0;
                var isParse = int.TryParse(RecIDSearch, out RectId);
                if (isParse)
                {
                    Policies = Policies.Where(x => x.RecID == RectId);
                }

            }
            if (!string.IsNullOrWhiteSpace(CustIDSearch))
            {
                Policies = Policies.Where(x => x.CustID.Equals(CustIDSearch));

            }

            if (!string.IsNullOrWhiteSpace(Policyname))
            {
                Policies = Policies.Where(x => x.Policyname.Contains(Policyname));

            }
            return Policies;
        }


        public IEnumerable<PolicyDtls> GetPagination(IEnumerable<PolicyDtls> Policies)
        {

            RowCount = Policies.Count();

            PageCount = (int)Math.Ceiling(RowCount / (RowPerPage * 1.0d));

            if (PageCount < CurrentPage)
            {
                CurrentPage = 1;
            }

            int skip = (CurrentPage - 1) * RowPerPage;


            /*
			 * skip , take 
			 */
            return Policies.Skip(skip).Take(RowPerPage);
        }

    }
}
