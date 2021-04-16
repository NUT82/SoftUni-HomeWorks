using Git.Services;
using SUS.HTTP;
using SUS.MvcFramework;
using System.ComponentModel.DataAnnotations;

namespace Git.Controllers
{
    class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public HttpResponse Login()
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public HttpResponse Login(string username, string password)
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            var userId = usersService.GetUserId(username, password);
            if (userId == null)
            {
                return Error("Invalid username or password!");
            }

            SignIn(userId);
            return Redirect("/Repositories/All");
        }

        public HttpResponse Logout()
        {
            if (IsUserSignedIn())
            {
                SignOut();
            }
            
            return Redirect("/");
        }

        public HttpResponse Register()
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public HttpResponse Register(string username, string email, string password, string confirmPassword)
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            if (string.IsNullOrEmpty(username) || username.Length < 5 || username.Length > 20)
            {
                return Error("Username must be between 5 and 20 characters!");
            }

            if (!usersService.IsUsernameAvailable(username))
            {
                return Error("Username is already taken.");
            }

            if (string.IsNullOrEmpty(email) || !new EmailAddressAttribute().IsValid(email))
            {
                return Error("Invalid email address.");
            }

            if (!usersService.IsEmailAvailable(email))
            {
                return Error("User with this email address already exists!");
            }

            if (string.IsNullOrEmpty(password) || password.Length < 6 || password.Length > 20)
            {
                return Error("Password must be between 6 and 20 characters!");
            }

            if (password != confirmPassword)
            {
                return Error("Those passwords didn’t match. Try again!");
            }

            usersService.CreateUser(username, email, password);
            return Redirect("/Users/Login");
        }
    }
}
