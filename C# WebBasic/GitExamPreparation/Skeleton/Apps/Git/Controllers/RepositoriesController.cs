using Git.Services;
using SUS.HTTP;
using SUS.MvcFramework;

namespace Git.Controllers
{
    class RepositoriesController : Controller
    {
        private readonly IRepositoriesService repositoriesService;

        public RepositoriesController(IRepositoriesService repositoriesService)
        {
            this.repositoriesService = repositoriesService;
        }

        public HttpResponse All()
        {
            var allPublicRepositories = repositoriesService.GetAllPublicRepositories();
            if (!IsUserSignedIn())
            {
                return View(allPublicRepositories);
            }

            var userPrivateAndAllOtherRepositories = repositoriesService.GetUserPrivateAndOtherRepositories(GetUserId());
            return View(userPrivateAndAllOtherRepositories);
        }

        public HttpResponse Create()
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            return View();
        }

        [HttpPost]
        public HttpResponse Create(string name, string repositoryType)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            if (string.IsNullOrEmpty(name) || name.Length < 3 || name.Length > 10)
            {
                return Error("Repository name must be between 3 and 10 characters!");
            }

            repositoriesService.CreateRepository(name, repositoryType, GetUserId());
            return Redirect("/Repositories/All");
        }
    }
}
