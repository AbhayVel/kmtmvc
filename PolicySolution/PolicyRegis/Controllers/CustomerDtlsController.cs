using Microsoft.AspNetCore.Mvc;
using PolicyService;

namespace PolicyRegis.Controllers
{
    public class CustomerDtlsController : Controller
    {
        public IActionResult Index()
        {
            var CustService = new CustomerDtlsService();
            var lst = CustService.GetList();
            return View(lst);
        }
    }
}
