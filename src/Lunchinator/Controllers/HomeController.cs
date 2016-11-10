using Microsoft.AspNetCore.Mvc;

namespace SM.Lunchinator.Controllers
{
	public class HomeController : Controller
    {
		// ----==== PAGES ====---------------------------------------------------------------------

		public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

		// ----==== PRIVATE ====---------------------------------------------------------------------

		private string Title { get { return ViewData["Title"] as string; } set { ViewData["Title"] = value; } }
	}
}