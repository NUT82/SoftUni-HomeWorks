using System;
using System.Collections.Generic;
using System.Text;

namespace Git.Controllers
{
    using SUS.HTTP;
    using SUS.MvcFramework;

    public class HomeController : Controller
    {
        [HttpGet("/")]
        public HttpResponse Index()
        {
            if (IsUserSignedIn())
            {
                return Redirect("/Repositories/All");
            }

            return View();
        }
    }
}
