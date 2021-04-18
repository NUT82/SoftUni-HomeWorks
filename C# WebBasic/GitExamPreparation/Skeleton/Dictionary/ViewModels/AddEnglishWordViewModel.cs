using Dictionary.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.ViewModels
{
    public class AddEnglishWordViewModel
    {
        public int Id { get; set; }

        public string Word { get; set; }

        public ICollection<EnglishWordBulgarianWord> BulgarianWords { get; set; }
    }
}
