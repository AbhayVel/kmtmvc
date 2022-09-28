using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyEntities
{
	public class PaymentEntity
	{
		public int RecID { get; set; }
		public string CustID { get; set; }
		public string FName { get; set; }
		public string Mname { get; set; }
		public string Lname { get; set; }
		public string CreatedBy { get; set; }
		public string CreatedDt { get; set; }
		public string UpdatedBy { get; set; }
		public string UpdatedDt { get; set; }
		public string Status { get; set; }
		public int Amount { get; set; }

	}

}
