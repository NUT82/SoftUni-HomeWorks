using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Data
{
    public class UserTranslateWord
    {
        public string UserId { get; set; }

        public User User { get; set; }

        public int TranslateWordId { get; set; }

        public EnglishWordBulgarianWord TranslateWord { get; set; }
    }
}
