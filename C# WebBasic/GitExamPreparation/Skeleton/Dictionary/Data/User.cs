using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dictionary.Data
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
            UserTranslateWords = new HashSet<UserTranslateWord>();
        }

        public string Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<UserTranslateWord> UserTranslateWords { get; set; }
    }
}
