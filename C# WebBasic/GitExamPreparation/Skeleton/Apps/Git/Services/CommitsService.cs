using Git.Data;
using Git.ViewModels.Commits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Git.Services
{
    public class CommitsService : ICommitsService
    {
        private readonly ApplicationDbContext dbContext;

        public CommitsService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(string description, string respositoryId, string creatorId)
        {
            Commit commit = new Commit
            {
                Description = description,
                RepositoryId = respositoryId,
                CreatedOn = DateTime.UtcNow,
                CreatorId = creatorId
            };

            dbContext.Commits.Add(commit);
            dbContext.SaveChanges();
        }

        public void Delete(string commitId)
        {
            var commit = dbContext.Commits.Find(commitId);
            dbContext.Commits.Remove(commit);
            dbContext.SaveChanges();
        }

        public ICollection<CommitViewModel> GetAllCommits(string userId) =>
            dbContext.Commits.Where(x => x.CreatorId == userId)
                    .Select(c => new CommitViewModel
                    {
                        Id = c.Id,
                        Description = c.Description,
                        CreatedOn = c.CreatedOn,
                        RepositoryName = c.Repository.Name
                    }).ToList();
    }
}
