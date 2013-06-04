using System.Configuration;
using System.Web.Mvc;

namespace SomeOtherDemo.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			bool setting;
			ViewBag.DiscloseDeploymentMethod = bool.TryParse(ConfigurationManager.AppSettings["Disclose deployment method"], out setting) && setting;
			return View();
		}
	}
}