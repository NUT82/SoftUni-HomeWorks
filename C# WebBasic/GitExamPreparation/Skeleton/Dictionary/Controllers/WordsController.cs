using Dictionary.Services;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Dictionary.Controllers
{
    public class WordsController : Controller
    {
        private readonly IWordsService wordsService;

        public WordsController(IWordsService wordsService)
        {
            this.wordsService = wordsService;
        }

        public HttpResponse Add()
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            return View();
        }

        [HttpPost]
        public HttpResponse Add(string word)
        {
            if (!IsUserSignedIn())
            {
                return Redirect("/Users/Login");
            }

            if (Regex.IsMatch(word, @"^[A-Za-z ]+$")) //english word
            {
                var id = wordsService.GetWordId(word, "en");
                return Redirect("/Words/AddEnglishWord?id=" + id);
            }
            else if (Regex.IsMatch(word, @"^[А-Яа-я ]+$")) //bulgarian word
            {
                var id = wordsService.GetWordId(word, "bg");
                return Redirect("/Words/AddBulgarianWord?id=" + id);
            }
            else
            {
                return Error($"{word} must consist only of Bulgarian or only English letters.");
            }
        }

        public HttpResponse AddEnglishWord(int id)
        {
            var model = wordsService.GetTranslateFromEnglish(id);
            return View(model);
        }

        public HttpResponse AddBulgarianWord(int id)
        {
            var model = wordsService.GetTranslateFromBulgarian(id);
            return View(model);
        }
    }
}
