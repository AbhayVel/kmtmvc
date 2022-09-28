using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolicyModels
{
	public class PymntDtlsSearch
	{
		public int CurrentPage { get; set; } = 1;
		public int RowPerPage { get; set; } = 5;

		public int RowCount { get; set; }

		public int PageCount { get; set; }
		public string ColumnName { get; set; }

		public string OrderBy { get; set; }
		public string RecIDSearch { get; set; }
		public string CustomerIDSearch { get; set; }

		public string CustomerNameSearch { get; set; }

		public IEnumerable<Payment> GetOrderBy(IEnumerable<Payment> payments)
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
					payments = payments.OrderByDescending(x => x.RecID);
				}
				else
				{
					payments = payments.OrderBy(x => x.RecID);
				}
			}
			if ("CustomerID".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
			{
				if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
				{
					payments = payments.OrderByDescending(x => x.CustID);
				}
				else
				{
					payments = payments.OrderBy(x => x.CustID);
				}
			}

			if ("CustomerName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
			{
				if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
				{
					payments = payments.OrderByDescending(x => x.FName);
				}
				else
				{
					payments = payments.OrderBy(x => x.FName);
				}
			}

			return payments;
		}


		public IEnumerable<Payment> GetWhere(IEnumerable<Payment> payments)
		{


			if (!string.IsNullOrWhiteSpace(RecIDSearch))
			{
				int RectId = 0;
				var isParse = int.TryParse(RecIDSearch, out RectId);
				if (isParse)
				{
					payments = payments.Where(x => x.RecID == RectId);
				}

			}
			if (!string.IsNullOrWhiteSpace(CustomerIDSearch))
			{
				payments = payments.Where(x => x.CustID.Equals(CustomerIDSearch));

			}

			if (!string.IsNullOrWhiteSpace(CustomerNameSearch))
			{
				payments = payments.Where(x => x.CustID.Contains(CustomerNameSearch));

			}

			return payments;
		}


		public IEnumerable<Payment> GetPagination(IEnumerable<Payment> payments)
		{

			RowCount = payments.Count();

			PageCount = (int)Math.Ceiling(RowCount / (RowPerPage * 1.0d));

			if (PageCount < CurrentPage)
			{
				CurrentPage = 1;
			}

			int skip = (CurrentPage - 1) * RowPerPage;


			return payments.Skip(skip).Take(RowPerPage);
		}

	}

}
