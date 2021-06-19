using MyWebServer.Controllers;
using MyWebServer.Results;

namespace CarShop.Controllers.Home
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/Cars/All");
            }

            return View();
        }
    }
}
