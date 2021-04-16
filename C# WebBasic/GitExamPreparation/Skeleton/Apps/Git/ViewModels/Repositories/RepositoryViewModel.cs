using Git.Data;
using System;
using System.Collections.Generic;

namespace Git.ViewModels.Repositories
{
    public class RepositoryViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public string OwnerUsername { get; set; }

        public int CommitsCount { get; set; }
    }
}
