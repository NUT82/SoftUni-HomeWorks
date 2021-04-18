using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dictionary.Data
{
    public class EnglishWord
    {
        public EnglishWord()
        {
            BulgarianWords = new HashSet<EnglishWordBulgarianWord>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Word { get; set; }

        public ICollection<EnglishWordBulgarianWord> BulgarianWords { get; set; }
    }
}
