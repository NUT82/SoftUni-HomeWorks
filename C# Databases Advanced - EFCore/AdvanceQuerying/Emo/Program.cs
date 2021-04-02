using System;
using System.Numerics;

namespace Emo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как се казваш?");

            string name= Console.ReadLine();

            Console.WriteLine("Кога си роден?");

            string dateOfBirth = Console.ReadLine();

            Console.Clear();
            
            var age = DateTime.Now - DateTime.Parse(dateOfBirth);

            Console.WriteLine($"Здр {name} на {age.Hours} часове :)");
            Console.WriteLine($"Здр {name} на {age.Minutes} минути :)");
            Console.WriteLine($"Здр {name} на {age.TotalDays:F0} дни :)");  
            Console.WriteLine($"Здр {name} на {age.TotalDays / 31:F0} месеца :)");  
            Console.WriteLine($"Здр {name} на {age.TotalDays / 365:F0} години :)");

            Console.WriteLine("избере мъж или жена");
            Console.WriteLine("1. Мъж");
            Console.WriteLine("1. ");
           string pol = Console.ReadLine();
        }
    }
}
