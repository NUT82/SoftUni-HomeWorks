using System;
using System.Runtime.InteropServices.ComTypes;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Шеф на компания забелязва че все повече служители прекарват  време в сайтове, които ги разсейват.  
            //За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си. Според сайта се налагат различни глоби:
            //•	"Facebook" -> 150 лв.
            //•	"Instagram" -> 100 лв.
            //•	"Reddit" -> 50 лв.

            //input
            //•	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
            int openTabs = int.Parse(Console.ReadLine());
            //•	Заплата - число в интервала [700...1500]
            double salary = double.Parse(Console.ReadLine());
            //След това n – на брой пъти се чете име на уебсайт – текст
            for (int i = 1; i <= openTabs; i++)
            {
                string nameOfWebSite = Console.ReadLine();
                switch (nameOfWebSite)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                    default:
                        break;
                }
                if (salary <= 0)
                {
                    i = openTabs + 1;
                    Console.WriteLine("You have lost your salary.");
                }
                else if (i == openTabs)
                {
                    Console.WriteLine($"{salary:F0}");
                }
            }
        }
    }
}
