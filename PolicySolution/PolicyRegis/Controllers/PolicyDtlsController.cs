using Microsoft.AspNetCore.Mvc;
using PolicyService;

namespace PolicyRegis.Controllers
{
    public class PolicyDtlsController : Controller
    {
        public IActionResult Index()
        {
            var PolicyService = new PolicyDtlsService();
            var lst = PolicyService.GetList();
            return View(lst);
        }
    }
}
