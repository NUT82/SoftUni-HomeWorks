using Dictionary.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary.Services
{
    public interface IWordsService
    {
        int Add(string word, string lang);

        int GetWordId(string word, string lang);

        AddBulgarianWordViewModel GetTranslateFromBulgarian(int id);

        AddEnglishWordViewModel GetTranslateFromEnglish(int id);
    }
}
