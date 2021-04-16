using Git.ViewModels.Commits;
using System.Collections.Generic;

namespace Git.Services
{
    public interface ICommitsService
    {
        void Create(string description, string respositoryId, string creatorId);

        void Delete(string commitId);

        ICollection<CommitViewModel> GetAllCommits(string userId);
    }
}
