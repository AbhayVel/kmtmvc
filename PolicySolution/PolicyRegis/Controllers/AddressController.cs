using Microsoft.AspNetCore.Mvc;
using PolicyService;

namespace PolicyRegis.Controllers
{
	public class AddressController : Controller
	{
		public IActionResult Index()
		{
			var adService = new AddressService();
			var lst= adService.GetList();
			return View(lst);
		}
	}
}
