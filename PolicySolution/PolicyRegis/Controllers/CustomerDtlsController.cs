using Microsoft.AspNetCore.Mvc;
using PolicyModels;
using PolicyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyRegis.Controllers
{
    public class CustomerDtlsController : Controller
    {
        [HttpPost]
        [HttpGet]
        public IActionResult Index(CustomerSearch customerSearch)
        {
            var CustService = new CustomerDtlsService();
            IEnumerable<CustomerDetails> lst = CustService.GetList();
            lst = customerSearch.GetWhere(lst);
            lst = customerSearch.GetOrderBy(lst);
            lst = customerSearch.GetPagination(lst);
            ViewBag.customerSearch = customerSearch;
            return View(lst.ToList());
        }
        public IActionResult Add()
        {
            CustomerDetails cusdtls = new CustomerDetails();
            return View(cusdtls);
        }

        [HttpPost]
        public async Task <IActionResult> Save(CustomerDetails custdt)
        {
            CustomerDetails custdtls = new CustomerDetails();
            await TryUpdateModelAsync(custdtls);
            if(ModelState.IsValid)
            {
                return Redirect("/CustomerDtls/index");
            }
            else
            {
                return View("Add", custdtls);
            }
        }
    }
}
