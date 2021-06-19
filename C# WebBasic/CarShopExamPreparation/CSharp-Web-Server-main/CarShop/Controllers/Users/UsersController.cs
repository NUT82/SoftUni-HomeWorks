using CarShop.Services.Users;
using CarShop.ViewModels.Users;
using MyWebServer.Controllers;
using MyWebServer.Results;
using System.Linq;

namespace CarShop.Controllers.Users
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public ActionResult Login()
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/");
            }

            var userId = usersService.Login(viewModel);

            if (userId == null)
            {
                return Error("Username and password do not much.");
            }

            SignIn(userId);
            return Redirect("/Cars/All");
        }

        [Authorize]
        public ActionResult LogOut()
        {
            SignOut();
            return Redirect("/");
        }

        public ActionResult Register()
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel viewModel)
        {
            if (User.IsAuthenticated)
            {
                return Redirect("/");
            }

            if (usersService.UsernameTaken(viewModel.Username))
            {
                return Error("Username already taken.");
            }

            if (usersService.EmailTaken(viewModel.Email))
            {
                return Error("Email already taken.");
            }

            var validateErrors = usersService.RegisterValidateErrors(viewModel);

            if (validateErrors.Any())
            {
                return Error(validateErrors);
            }

            usersService.Register(viewModel);
            return Redirect("/Users/Login");
        }
    }
}
