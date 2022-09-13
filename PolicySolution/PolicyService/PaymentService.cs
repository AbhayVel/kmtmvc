using PolicyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyService
{
	public class PaymentService
	{
		public List<Payment> GetPaymentList()
		{
			List<Payment> list = new List<Payment>();

			list.Add(new Payment()
			{
				RecID = 1,
				CustID = "Cust1",
				FName = "Rahul",
				Mname = "Ramesh",
				Lname = "Patil",
				CreatedBy = "Rishikesh",
				CreatedDt = "12-09-2012",
				UpdatedBy = "Rakesh",
				UpdatedDt = "12-09-2022",
				Status = "Alive",
				Amount = 10000,
			});

			list.Add(new Payment()
			{
				RecID = 2,
				CustID = "Cust2",
				FName = "Rakesh",
				Mname = "Ram",
				Lname = "Yadav",
				CreatedBy = "Rishikesh",
				CreatedDt = "12-10-2012",
				UpdatedBy = "Rahul",
				UpdatedDt = "12-09-2022",
				Status = "Alive",
				Amount = 60000,
			});
			list.Add(new Payment()
			{
				RecID = 3,
				CustID = "Cust3",
				FName = "Raju",
				Mname = "Ramesh",
				Lname = "Pawar",
				CreatedBy = "Rishikesh",
				CreatedDt = "12-11-2012",
				UpdatedBy = "Rakesh",
				UpdatedDt = "12-09-2022",
				Status = "Alive",
				Amount = 40000,
			});
			list.Add(new Payment()
			{
				RecID = 4,
				CustID = "Cust4",
				FName = "Nimesh",
				Mname = "Kartik",
				Lname = "Tripathi",
				CreatedBy = "Rishikesh",
				CreatedDt = "12-03-2015",
				UpdatedBy = "Rakesh",
				UpdatedDt = "12-09-2022",
				Status = "Alive",
				Amount = 80000,
			});

			return list;
		}
	}
}
