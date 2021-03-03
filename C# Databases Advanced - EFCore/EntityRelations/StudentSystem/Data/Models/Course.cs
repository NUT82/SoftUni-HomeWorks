using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            Resources = new HashSet<Resource>();
            HomeworkSubmissions = new HashSet<Homework>();
            StudentsEnrolled = new HashSet<StudentCourse>();
        }
        public int CourseId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        [InverseProperty(nameof(Resource.Course)) ]
        public ICollection<Resource> Resources { get; set; }

        [InverseProperty(nameof(Homework.Course))]
        public ICollection<Homework> HomeworkSubmissions { get; set; }

        [InverseProperty(nameof(StudentCourse.Course))]
        public ICollection<StudentCourse> StudentsEnrolled { get; set; }
    }
}
