using CarShop.ViewModels.Users;
using System.Collections.Generic;

namespace CarShop.Services.Users
{
    public interface IUsersService
    {
        public string Login(LoginViewModel viewModel);

        public void Register(RegisterViewModel viewModel);

        public bool UsernameTaken(string username);

        public bool EmailTaken(string email);

        public IEnumerable<string> RegisterValidateErrors(RegisterViewModel viewModel);

        public bool IsMechanic(string id);

        public string HashPassword(string password);
    }
}
