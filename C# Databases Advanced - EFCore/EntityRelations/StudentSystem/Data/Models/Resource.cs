using System;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        public ResourceTypes ResourceType { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public enum ResourceTypes
        {
            Video = 1,
            Presentation = 2,
            Document = 3,
            Other = 4
        }
    }
}
