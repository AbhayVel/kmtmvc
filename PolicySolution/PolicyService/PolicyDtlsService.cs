using PolicyModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PolicyService
{
    public class PolicyDtlsService
    {
        public List<PolicyDtls> GetList()
        {
            List<PolicyDtls> list = new List<PolicyDtls>();
            {
                list.Add(new PolicyDtls()
                {
                    RecID = 1,
                    CustID= "1",
                    PolicyNo="7696758",
                    PolicyStatus="Active",
                    ProductCode = "23",
                    ProductType = "motor",
                    ProductName = "car",
                    PolicyTerm = "22000",
                    StartDt = "01-09-22",
                    EndDt = "01-09-32",
                    LOB = "1",
                    PremiumAmt = "1000",
                    SumInsured = "2000",
                    AgtCode = "21",
                    ModeOfPremium = "ABC",
                    PolIssuedt = "04-09-25",
                    CurrentStatus = "Active",
                    AnnualPremium = "3000",
                    LastPremiumdt = "233",
                    PremDueDt = "asd",
                    PREMIUM_PAYING_TERM = "gpay",
                    Manager_Code = "322",
                    OFFICE_CD = "5665",
                    CHANNEL_ID = "234",
                    CreatedBy = "Raj",
                    CreatedDt = "54",
                    UpdatedBy = "Raj",
                    UpdatedDt = "04-09-25",
                });
            }
            return list;
        }
    }
}
