using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PolicyModels
{
    public class AddressSearch
    {
		public string ColumnName { get; set; }

		public string OrderBy { get; set; }
		public string RecIDSearch { get; set; }
		public string CustomerIDSearch { get; set; }

		public string CustomerNameSearch { get; set; }

		public IEnumerable<Address> GetOrderBy(IEnumerable<Address> addresses)
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
					addresses = addresses.OrderByDescending(x => x.RecID);
				}
				else
				{
					addresses = addresses.OrderBy(x => x.RecID);
				}
			}
			if ("CustomerID".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
			{
				if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
				{
					addresses = addresses.OrderByDescending(x => x.CustomerID);
				}
				else
				{
					addresses = addresses.OrderBy(x => x.CustomerID);
				}
			}

			if ("CustomerName".Equals(ColumnName, StringComparison.OrdinalIgnoreCase))
			{
				if ("desc".Equals(OrderBy, StringComparison.OrdinalIgnoreCase))
				{
					addresses = addresses.OrderByDescending(x => x.CustomerName);
				}
				else
				{
					addresses = addresses.OrderBy(x => x.CustomerName);
				}
			}

			return addresses;
		}


		public IEnumerable<Address> GetWhere(IEnumerable<Address> addresses)
		{
			 

			if (!string.IsNullOrWhiteSpace(RecIDSearch))
			{
				int RectId =0;
				var isParse=int.TryParse(RecIDSearch, out RectId);
				if (isParse)
				{
					addresses = addresses.Where(x => x.RecID== RectId);
				}

			}
			if (!string.IsNullOrWhiteSpace(CustomerIDSearch))
			{			 
					addresses = addresses.Where(x => x.CustomerID.Equals(CustomerIDSearch));
				
			}

			if (!string.IsNullOrWhiteSpace(CustomerNameSearch))
			{
				addresses = addresses.Where(x => x.CustomerName.Contains(CustomerNameSearch));

			}

			return addresses;
		}


	}
}
