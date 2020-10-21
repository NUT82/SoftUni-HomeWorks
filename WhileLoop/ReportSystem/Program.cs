using System;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //На благотворително събитие плащанията за закупените продукти винаги се редуват: плащане в брой и плащане с карта. Установени са следните правила за заплащане:
            //•	Ако продуктът надвишава 100лв., за него не може да се плати в брой
            //•	Ако продуктът е на цена под 10лв., за него не може да се плати с кредитна карта
            //Програмата приключва или след като получим команда "End" или след като средствата бъдат събрани.

            //•	Сумата, която се очаква да бъде събрана от продажбите - цяло число в интервала [1 ... 10000]
            int expectedSum = int.Parse(Console.ReadLine());
            //На всеки следващ ред, до получаване на командата "End" или докато не се съберат нужните средства: цените на предметите, които ще бъдат закупени -цяло число в интервала[1... 500]
            string input = Console.ReadLine();
            int currPrice = 0;
            int countTransaction = 0;
            int countCashTransaction = 0;
            int countCardTransaction = 0;

            int cashSum = 0;
            int cardSum = 0;

            while (input != "End")
            {
                currPrice = int.Parse(input);
                countTransaction++;
                if ((countTransaction % 2 == 0 && currPrice < 10) || (countTransaction % 2 != 0 && currPrice > 100))
                {
                    Console.WriteLine("Error in transaction!");
                }
                else
                {
                    Console.WriteLine("Product sold!");
                    if (countTransaction % 2 == 0)
                    {
                        cardSum += currPrice;
                        countCardTransaction++;
                    }
                    else
                    {
                        cashSum += currPrice;
                        countCashTransaction++;
                    }
                }
                if (cardSum + cashSum >= expectedSum)
                {
                    Console.WriteLine($"Average CS: {(double)(cashSum) / (double)(countCashTransaction):F2}");
                    Console.WriteLine($"Average CC: {(double)(cardSum) / (double)(countCardTransaction):F2}");
                    break;
                }
                input = Console.ReadLine();
            }

            //ри успешна транзакция: "Product sold!"
            //•	При неуспешна транзакция: "Error in transaction!"
            //•	Ако сумата на всички закупени продукти надвиши или достигне очакваната сума, програмата трябва да приключи и на конзолата да се изпишат два реда:
            //o	"Average CS: {средно плащане в кеш на човек}"
            //o	"Average CC: {средно плащане с карта на човек}" 
            //Плащанията трябва да бъдат форматирани до втората цифра след десетичния знак.
            //•	При получаване на команда "End", да се изпише един ред:
            //o	"Failed to collect required money for charity."
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
