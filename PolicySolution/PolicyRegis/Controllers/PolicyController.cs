using Microsoft.AspNetCore.Mvc;

namespace PolicyRegis.Controllers
{
	public class PolicyController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Detail()
		{
			return View();
		}
	}
}
