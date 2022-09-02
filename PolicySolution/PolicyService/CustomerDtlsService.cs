using System;
using System.Collections.Generic;
using System.Text;
using PolicyModels;

namespace PolicyService
{
    public class CustomerDtlsService
    {
        public List<CustomerDetails>  GetList()
        {
            List<CustomerDetails> list = new List<CustomerDetails>();
            {
                list.Add(new CustomerDetails()
                {
                    RecID = 1,
                    CustID = "Cust1",
                    FName = "Sarthak",
                    Mname = "Sandeep",
                    Lname = "Thikekar",
                    DOB = "02-10-2001",
                    MobNo = "9769126960",
                    TelNo = "123456789",
                    EmailId1 = "thikekarsarthak@gmail.com",
                    EmailId2 = "thikekarsarthak0210@gmail.com",
                    PanNo = "BUJPT9176Q",
                    MotherName = "vaishali",
                    QualificationDetails = "Fail",
                    MaritalStatus = "single",
                    NomineeName = "ABCD",
                    NomineeAge = "21",
                    NomineeContNo = "1234567890",
                    CreatedBy = "Sarthak",
                    CreatedDt = "02-09-2022",
                    UpdatedBy = "Sarthak",
                    UpdatedDt = "02-09-2022",
                    Status = "Alive"
                });
                list.Add(new CustomerDetails()
                {
                    RecID = 2,
                    CustID = "Cust2",
                    FName = "gSarthak",
                    Mname = "fSandeep",
                    Lname = "hThikekar",
                    DOB = "02-10-2001",
                    MobNo = "9769126960",
                    TelNo = "123456789",
                    EmailId1 = "thikekarsarthak@gmail.com",
                    EmailId2 = "thikekarsarthak0210@gmail.com",
                    PanNo = "BUJPT9176Q",
                    MotherName = "vaishali",
                    QualificationDetails = "Fail",
                    MaritalStatus = "single",
                    NomineeName = "ABCD",
                    NomineeAge = "21",
                    NomineeContNo = "1234567890",
                    CreatedBy = "Sarthak",
                    CreatedDt = "02-09-2022",
                    UpdatedBy = "Sarthak",
                    UpdatedDt = "02-09-2022",
                    Status = "Alive"
                });
            }
            return list;
        }
    }
}
