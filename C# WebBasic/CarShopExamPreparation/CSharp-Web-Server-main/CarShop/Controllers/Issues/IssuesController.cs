using CarShop.Services.Cars;
using CarShop.Services.Users;
using CarShop.ViewModels.Issues;
using MyWebServer.Controllers;
using MyWebServer.Results;

namespace CarShop.Controllers.Issues
{
    public class IssuesController : Controller
    {
        private readonly ICarsService carsService;
        private readonly IUsersService usersService;

        public IssuesController(ICarsService carsService, IUsersService usersService)
        {
            this.carsService = carsService;
            this.usersService = usersService;
        }

        [Authorize]
        public ActionResult CarIssues(string carId)
        {
            var carIssues = carsService.GetCarIssues(carId);
            carIssues.IsMechanic = usersService.IsMechanic(User.Id);

            if (carIssues.IsMechanic && !carsService.HasUnfixedIssue(carId))
            {
                return Unauthorized();
            }

            if (!carIssues.IsMechanic && !carsService.IsOwner(carId, User.Id))
            {
                return Unauthorized();
            }

            return View(carIssues);
        }

        [Authorize]
        public ActionResult Add(string carId)
        {
            if (usersService.IsMechanic(User.Id) && !carsService.HasUnfixedIssue(carId))
            {
                return Unauthorized();
            }

            if (!usersService.IsMechanic(User.Id) && !carsService.IsOwner(carId, User.Id))
            {
                return Unauthorized();
            }

            var model = new AddIssueViewModel
            {
                CarId = carId,
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Add(AddIssueViewModel viewModel)
        {
            if (!usersService.IsMechanic(User.Id) && !carsService.IsOwner(viewModel.CarId, User.Id))
            {
                return Unauthorized();
            }

            if (viewModel.Description.Length < 5)
            {
                return Error("Description must be at least 5 characters long.");
            }

            carsService.AddIssue(viewModel);
            return Redirect($"/Issues/CarIssues?carId={viewModel.CarId}");
        }

        [Authorize]
        public ActionResult Fix(string carId, string issueId)
        {
            if (!usersService.IsMechanic(User.Id))
            {
                return Unauthorized();
            }

            carsService.FixIssue(issueId);
            return Redirect($"/Issues/CarIssues?carId={carId}");
        }

        [Authorize]
        public ActionResult Delete(string carId, string issueId)
        {
            if (!usersService.IsMechanic(User.Id) && !carsService.IsOwner(carId, User.Id))
            {
                return Unauthorized();
            }

            carsService.DeleteIssue(issueId);
            return Redirect($"/Issues/CarIssues?carId={carId}");
        }
    }
}
