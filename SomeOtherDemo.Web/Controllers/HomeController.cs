using System.Web.Mvc;

namespace SomeOtherDemo.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}
	}
}