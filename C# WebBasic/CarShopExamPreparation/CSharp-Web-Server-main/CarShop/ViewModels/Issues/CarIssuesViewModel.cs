using System.Collections.Generic;

namespace CarShop.ViewModels.Issues
{
    public class CarIssuesViewModel
    {
        public string Id { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public bool IsMechanic { get; set; }

        public IEnumerable<IssueViewModel> Issues { get; set; }
    }
}
