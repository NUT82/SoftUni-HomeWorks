using CarShop.Data;
using CarShop.Data.Models;
using CarShop.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CarShop.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext dbContext;

        public UsersService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public string Login(LoginViewModel viewModel)
        {
            var hashPassword = HashPassword(viewModel.Password);

            return dbContext
                .Users
                .Where(u => u.Username == viewModel.Username && u.Password == hashPassword)
                .Select(u => u.Id)
                .FirstOrDefault();
        }

        public void Register(RegisterViewModel viewModel)
        {
            var user = new User
            {
                Username = viewModel.Username,
                Password = HashPassword(viewModel.Password),
                Email = viewModel.Email,
                IsMechanic = viewModel.UserType == "Mechanic",
            };

            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public IEnumerable<string> RegisterValidateErrors(RegisterViewModel viewModel)
        {
            
            var errorList = new List<string>();

            if (viewModel.Username.Length < 4 || viewModel.Username.Length > 20)
            {
                errorList.Add("Username must be between 4 and 20 characters long.");
            }

            if (String.IsNullOrEmpty(viewModel.Email))
            {
                errorList.Add("Field 'Email' is required.");
            }

            if (viewModel.Password.Length < 5 || viewModel.Password.Length > 20)
            {
                errorList.Add("Password must be between 5 and 20 characters long.");
            }

            if (viewModel.ConfirmPassword != viewModel.Password)
            {
                errorList.Add("Passwords do not much.");
            }

            if (viewModel.UserType != "Mechanic" && viewModel.UserType != "Client")
            {
                errorList.Add("Type of user must be 'Mechanic' or 'Client'.");
            }

            return errorList;
        }

        public bool UsernameTaken(string username)
        {
            return dbContext.Users.Any(u => u.Username == username);
        }

        public bool EmailTaken(string email)
        {
            return dbContext.Users.Any(u => u.Email == email);
        }

        public bool IsMechanic(string id)
        {
            return dbContext.Users.Any(u => u.Id == id && u.IsMechanic);
        }

        public string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return string.Empty;
            }

            // Create a SHA256   
            using var sha256Hash = SHA256.Create();

            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convert byte array to a string   
            var builder = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }

    }
}
