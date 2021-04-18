using Dictionary.Data;
using Dictionary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary.Services
{
    public class WordsService : IWordsService
    {
        private readonly ApplicationDbContext db;

        public WordsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public int Add(string word, string lang)
        {
            if (lang == "en")
            {
                db.EnglishWords.Add(new EnglishWord
                {
                    Word = word
                });
                db.SaveChanges();
                return db.EnglishWords.FirstOrDefault(w => w.Word == word).Id;
            }
            else
            {
                db.BulgarianWords.Add(new BulgarianWord
                {
                    Word = word
                });
                db.SaveChanges();
                return db.BulgarianWords.FirstOrDefault(w => w.Word == word).Id;
            }
        }

        public AddBulgarianWordViewModel GetTranslateFromBulgarian(int id) => 
            db.BulgarianWords.Where(w => w.Id == id).Select(w => new AddBulgarianWordViewModel
            {
                Id = id,
                Word = w.Word,
                EnglishWords = w.EnglishWords
            }).FirstOrDefault();

        public AddEnglishWordViewModel GetTranslateFromEnglish(int id) =>
            db.EnglishWords.Where(w => w.Id == id).Select(w => new AddEnglishWordViewModel
            {
                Id = id,
                Word = w.Word,
                BulgarianWords = w.BulgarianWords
            }).FirstOrDefault();

        public int GetWordId(string word, string lang)
        {
            if (lang == "en")
            {
                if (db.EnglishWords.Any(w => w.Word == word))
                {
                    return db.EnglishWords.FirstOrDefault(w => w.Word == word).Id;
                }

                return Add(word, lang);
            }
            else
            {
                if (db.BulgarianWords.Any(w => w.Word == word))
                {
                    return db.BulgarianWords.FirstOrDefault(w => w.Word == word).Id;
                }

                return Add(word, lang);
            }
        }
    }
}
