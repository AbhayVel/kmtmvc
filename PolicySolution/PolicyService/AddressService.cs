using PolicyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyService
{
	public class AddressService
	{
	public List<Address>	GetList()
		{
			List<Address> list = new List<Address>();

			list.Add(new Address()
			{
				RecID = 1,
				CustomerID = "12",
				CustomerName="Usha"	,
				Address1 = "aaa",
				Address2 ="address2",
				Address3 ="Socity",
				District ="Thane",
				State =	"MH" ,
				Pincode ="40013"

			});

			list.Add(new Address()
			{
				RecID =2,
				CustomerID = "12",
				CustomerName = "Raj",
				Address1 = "bbb",
				Address2 = "Zddress2",
				Address3 = "aSocity",
				District = "uThane",
				State = "MH",
				Pincode = "40013"

			});


			list.Add(new Address()
			{
				RecID = 3,
				CustomerID = "13",
				CustomerName = "Pankaj",
				Address1 = "ccc",
				Address2 = "mZddress2",
				Address3 = "haSocity",
				District = "tuThane",
				State = "MH",
				Pincode = "40013"

			});

			return list;
		}
	}
}
