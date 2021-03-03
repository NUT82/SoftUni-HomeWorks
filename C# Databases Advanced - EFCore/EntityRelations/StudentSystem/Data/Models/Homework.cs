﻿using System;
using System.ComponentModel.DataAnnotations;

namespace P01_StudentSystem.Data.Models
{
    public class Homework
    {
        public int HomeworkId { get; set; }

        [Required]
        public string Content { get; set; }

        public ContentTypes ContentType { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

        public DateTime SubmissionTime { get; set; }

        public enum ContentTypes
        {
            Application = 1,
            Pdf = 2,
            Zip = 3
        }
    }
}
