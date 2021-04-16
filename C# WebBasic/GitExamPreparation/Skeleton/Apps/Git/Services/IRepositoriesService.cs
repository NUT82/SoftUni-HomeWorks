using Git.ViewModels.Repositories;
using System.Collections.Generic;

namespace Git.Services
{
    public interface IRepositoriesService
    {
        void CreateRepository(string name, string repositoryType, string ownerId);

        public string GetRepositoryName(string id);

        ICollection<RepositoryViewModel> GetAllPublicRepositories();

        ICollection<RepositoryViewModel> GetUserPrivateRepositories(string ownerId);

        ICollection<RepositoryViewModel> GetUserPrivateAndOtherRepositories(string ownerId);
    }
}
