using Git.Data;
using Git.ViewModels.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Git.Services
{
    class RepositoriesService : IRepositoriesService
    {
        private readonly ApplicationDbContext dbContext;

        public RepositoriesService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateRepository(string name, string repositoryType, string ownerId)
        {
            Repository repository = new Repository
            {
                Name = name,
                CreatedOn = DateTime.UtcNow,
                IsPublic = repositoryType == "Public" ? true : false,
                OwnerId = ownerId,
            };

            dbContext.Repositories.Add(repository);
            dbContext.SaveChanges();
        }

        public string GetRepositoryName(string id) => dbContext.Repositories.Where(x => x.Id == id).Select(x => x.Name).FirstOrDefault();

        public ICollection<RepositoryViewModel> GetAllPublicRepositories() => dbContext.Repositories.Where(x => x.IsPublic)
                    .Select(r => new RepositoryViewModel
                    {
                        Id = r.Id,
                        Name = r.Name,
                        CreatedOn = r.CreatedOn,
                        OwnerUsername = r.Owner.Username,
                        CommitsCount = r.Commits.Count(),
                    })
                    .ToList();

        public ICollection<RepositoryViewModel> GetUserPrivateRepositories(string ownerId) => dbContext.Repositories.Where(x => !x.IsPublic && x.OwnerId == ownerId)
                    .Select(r => new RepositoryViewModel
                    {
                        Id = r.Id,
                        Name = r.Name,
                        CreatedOn = r.CreatedOn,
                        OwnerUsername = r.Owner.Username,
                        CommitsCount = r.Commits.Count(),
                    })
                    .ToList();

        public ICollection<RepositoryViewModel> GetUserPrivateAndOtherRepositories(string ownerId) => GetUserPrivateRepositories(ownerId).Concat(GetAllPublicRepositories()).ToList();
    }
}
