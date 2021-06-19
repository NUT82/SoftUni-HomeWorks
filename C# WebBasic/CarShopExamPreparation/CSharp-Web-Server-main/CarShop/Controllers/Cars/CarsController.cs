using CarShop.Services.Cars;
using CarShop.Services.Users;
using CarShop.ViewModels.Cars;
using MyWebServer.Controllers;
using MyWebServer.Results;
using System.Linq;

namespace CarShop.Controllers.Cars
{
    public class CarsController : Controller
    {
        private readonly ICarsService carsService;
        private readonly IUsersService usersService;

        public CarsController(ICarsService carsService, IUsersService usersService)
        {
            this.carsService = carsService;
            this.usersService = usersService;
        }

        [Authorize]
        public ActionResult All()
        {
            var model = carsService.GetAllCars(User.Id);

            return View(model);
        }

        [Authorize]
        public ActionResult Add()
        {
            if (usersService.IsMechanic(User.Id))
            {
                return Unauthorized();
            }

            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Add(AddCarViewModel viewModel)
        {
            if (usersService.IsMechanic(User.Id))
            {
                return Unauthorized();
            }

            var validateErrors = carsService.AddCarValidateErrors(viewModel);
            if (validateErrors.Any())
            {
                return Error(validateErrors);
            }

            carsService.AddCar(viewModel, User.Id);

            return Redirect("/Cars/All");
        }
    }
}
