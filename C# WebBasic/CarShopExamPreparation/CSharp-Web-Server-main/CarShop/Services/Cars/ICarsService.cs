using CarShop.ViewModels.Cars;
using CarShop.ViewModels.Issues;
using System.Collections.Generic;

namespace CarShop.Services.Cars
{
    public interface ICarsService
    {
        public void AddCar(AddCarViewModel viewModel, string userId);

        public void AddIssue(AddIssueViewModel viewModel);

        public void FixIssue(string issueId);

        public void DeleteIssue(string issueId);

        public bool IsOwner(string carId, string userId);

        public bool HasUnfixedIssue(string carId);

        public IEnumerable<CarViewModel> GetAllCars(string userId);

        public CarIssuesViewModel GetCarIssues(string carId);

        public IEnumerable<string> AddCarValidateErrors(AddCarViewModel viewModel);
    }
}
