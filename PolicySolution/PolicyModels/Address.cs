using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyModels
{
	public class Address
	{
		public int RecID { get; set; }
		public string CustomerID { get; set; }

		public string CustomerName { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Address3 { get; set; }
		public string District { get; set; }
		public string Pincode { get; set; }
		public string State { get; set; }
		public string Type { get; set; }
		public string CreatedBy { get; set; }
		public string CreatedDt { get; set; }
		public string UpdatedBy { get; set; }
		public string UpdatedDt { get; set; }
	}
}
