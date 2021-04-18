using Dictionary.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.ViewModels
{
    public class AddBulgarianWordViewModel
    {
        public int Id { get; set; }

        public string Word { get; set; }

        public ICollection<EnglishWordBulgarianWord> EnglishWords { get; set; }
    }
}
