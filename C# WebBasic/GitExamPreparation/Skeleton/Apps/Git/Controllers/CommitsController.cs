using Git.Services;
using Git.ViewModels.Commits;
using SUS.HTTP;
using SUS.MvcFramework;

namespace Git.Controllers
{
    public class CommitsController : Controller
    {
        private readonly IRepositoriesService repositoriesService;
        private readonly ICommitsService commitsService;

        public CommitsController(IRepositoriesService repositoriesService, ICommitsService commitsService)
        {
            this.repositoriesService = repositoriesService;
            this.commitsService = commitsService;
        }

        public HttpResponse All()
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            var model = commitsService.GetAllCommits(GetUserId());
            return View(model);
        }

        public HttpResponse Create(string id)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            CommitCreateViewModel commitCreateViewModel = new CommitCreateViewModel
            {
                Id = id,
                Name = repositoriesService.GetRepositoryName(id)
            };

            return View(commitCreateViewModel);
        }

        [HttpPost]
        public HttpResponse Create(string description, string id)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            if (string.IsNullOrEmpty(description) || description.Length < 5)
            {
                return Error("Commit description must be more than 5 characters!");
            }

            commitsService.Create(description, id, GetUserId());
            return Redirect("/Repositories/All");
        }

        public HttpResponse Delete(string id)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            commitsService.Delete(id);
            return Redirect("/Commits/All");
        }
    }
}
