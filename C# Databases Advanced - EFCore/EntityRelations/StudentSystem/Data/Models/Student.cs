using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            HomeworkSubmissions = new HashSet<Homework>();
            CourseEnrollments = new HashSet<StudentCourse>();
        }
        public int StudentId { get; set; }

        
        public DateTime? Birthday { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        [InverseProperty(nameof(Homework.Student))]
        public ICollection<Homework> HomeworkSubmissions { get; set; }

        [InverseProperty(nameof(StudentCourse.Student))]
        public ICollection<StudentCourse> CourseEnrollments { get; set; }
    }
}
