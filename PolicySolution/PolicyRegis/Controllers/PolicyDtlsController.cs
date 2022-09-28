using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using PolicyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyRegis.Controllers
{
    public class PolicyDtlsController : Controller
    {




        [HttpPost]
        [HttpGet]
        public IActionResult Index(PolicySearch policySearch)
        {
        
            var PolService = new PolicyDtlsService();
            IEnumerable<PolicyDtls> lst = PolService.GetList();
            lst = policySearch.GetWhere(lst);
            lst = policySearch.GetOrderBy(lst);
            lst = policySearch.GetPagination(lst);
            ViewBag.policySearch = policySearch;
            return View(lst.ToList());
        }

        public IActionResult page1()
        {
            PolicyDtls poldtls = new PolicyDtls();
            return View(poldtls);
        }
        [HttpPost]
        public async Task<IActionResult> Save( PolicyDtls policyDtl)
        {
            PolicyDtls policyDtlsdata = new PolicyDtls();
            await TryUpdateModelAsync(policyDtlsdata);

           if(ModelState.IsValid)
            {
                return Redirect("/PolicyDtls/index");
            }
           else
            {
                return View("Page1", policyDtlsdata);
            }
           
        }
    }
}
