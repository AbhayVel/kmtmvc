using Microsoft.AspNetCore.Mvc;

namespace PolicyRegis.Controllers
{
    public class demoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
