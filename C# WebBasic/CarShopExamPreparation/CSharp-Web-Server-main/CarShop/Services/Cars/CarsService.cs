using CarShop.Data;
using CarShop.Data.Models;
using CarShop.Services.Users;
using CarShop.ViewModels.Cars;
using CarShop.ViewModels.Issues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CarShop.Services.Cars
{
    public class CarsService : ICarsService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IUsersService usersService;

        public CarsService(ApplicationDbContext dbContext, IUsersService usersService)
        {
            this.dbContext = dbContext;
            this.usersService = usersService;
        }

        public IEnumerable<CarViewModel> GetAllCars(string userId)
        {
            var cars = dbContext.Cars.AsQueryable();

            if (usersService.IsMechanic(userId))
            {
                cars = cars.Where(c => c.Issues.Any(i => !i.IsFixed));
            }
            else
            {
                cars = cars.Where(c => c.OwnerId == userId);
            }

            return cars.Select(c => new CarViewModel
            {
                Id = c.Id,
                Model = c.Model,
                PictureUrl = c.PictureUrl,
                PlateNumber = c.PlateNumber,
                Year = c.Year,
                FixedIssues = c.Issues.Where(i => i.IsFixed).Count(),
                RemainingIssues = c.Issues.Where(i => !i.IsFixed).Count(),
            }).ToList();
            
        }

        public void AddIssue(AddIssueViewModel viewModel)
        {
            var issue = new Issue
            {
                Description = viewModel.Description,
                CarId = viewModel.CarId,
                IsFixed = false,
            };

            dbContext.Issues.Add(issue);
            dbContext.SaveChanges();
        }

        public void AddCar(AddCarViewModel viewModel, string userId)
        {
            var car = new Car
            {
                Model = viewModel.Model,
                OwnerId = userId,
                PictureUrl = viewModel.Image,
                PlateNumber = viewModel.PlateNumber,
                Year = viewModel.Year,
            };

            dbContext.Cars.Add(car);
            dbContext.SaveChanges();
        }

        public IEnumerable<string> AddCarValidateErrors(AddCarViewModel viewModel)
        {

            var errorList = new List<string>();

            if (viewModel.Model.Length < 5 || viewModel.Model.Length > 20)
            {
                errorList.Add("Model must be between 5 and 20 characters long.");
            }

            if (!Regex.IsMatch(viewModel.PlateNumber, @"[A-Z]{2}[0-9]{4}[A-Z]{2}"))
            {
                errorList.Add("PlateNumber must be in format 'AA1111AA'.");
            }

            if (String.IsNullOrEmpty(viewModel.Year.ToString()))
            {
                errorList.Add("Field 'Year' is required.");
            }

            if (String.IsNullOrEmpty(viewModel.Image))
            {
                errorList.Add("Field 'Image' is required.");
            }

            return errorList;
        }

        public CarIssuesViewModel GetCarIssues(string carId)
        {
            return dbContext.Cars.Where(c => c.Id == carId).Select(c => new CarIssuesViewModel
            {
                Model = c.Model,
                Year = c.Year,
                Id = c.Id,
                Issues = c.Issues.Select(i => new IssueViewModel
                {
                    Id = i.Id,
                    Description = i.Description,
                    IsFixed = i.IsFixed ? "Yes" : "Not yet",
                })
            }).FirstOrDefault();
        }

        public void FixIssue(string issueId)
        {
            var issue = dbContext.Issues.Where(i => i.Id == issueId).FirstOrDefault();
            issue.IsFixed = true;
            dbContext.SaveChanges();
        }

        public void DeleteIssue(string issueId)
        {
            var issue = dbContext.Issues.Where(i => i.Id == issueId).FirstOrDefault();
            dbContext.Issues.Remove(issue);
            dbContext.SaveChanges();
            
        }

        public bool IsOwner(string carId, string userId)
        {
            return dbContext.Cars.Any(c => c.Id == carId && c.OwnerId == userId);
        }

        public bool HasUnfixedIssue(string carId)
        {
            return dbContext.Cars.Any(c => c.Id == carId && c.Issues.Any(i => !i.IsFixed));
        }
    }
}
