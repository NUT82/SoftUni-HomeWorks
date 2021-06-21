﻿using MyWebServer.Controllers;
using MyWebServer.Http;

namespace CarShop.Controllers.Home
{
    public class HomeController : Controller
    {
        public HttpResponse Index()
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/Cars/All");
            }

            return View();
        }
    }
}
