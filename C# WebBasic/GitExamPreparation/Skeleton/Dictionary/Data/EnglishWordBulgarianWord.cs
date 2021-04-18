using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Data
{
    public class EnglishWordBulgarianWord
    {
        public EnglishWordBulgarianWord()
        {
            UserTranslateWords = new HashSet<UserTranslateWord>();
        }

        public int Id { get; set; }

        public int BulgarianWordId { get; set; }

        public BulgarianWord BulgarianWord { get; set; }

        public int EnglishWordId { get; set; }

        public EnglishWord EnglishWord { get; set; }

        public bool IsChecked { get; set; }

        public ICollection<UserTranslateWord> UserTranslateWords { get; set; }
    }
}
