using System;

namespace MatchTickets
{
    class Program
    {
        static void Main()
        {
            //Когато пуснали билетите за Евро 2016, група запалянковци решили да си закупят. Билетите имат две категории с различни цени:

            //•	VIP – 499.99 лева.
            //•	Normal – 249.99 лева.
            const double priceVipTicket = 499.99;
            const double priceNormalTicket = 249.99;

            //Запалянковците имат определен бюджет, а броят на хората в групата определя какъв процент от бюджета трябва да се задели за транспорт: 
            //•	От 1 до 4 – 75 % от бюджета.
            //•	От 5 до 9 – 60 % от бюджета.
            //•	От 10 до 24 – 50 % от бюджета.
            //•	От 25 до 49 – 40 % от бюджета.
            //•	50 или повече – 25 % от бюджета.
            double budgetForTransport = 0.25;
            // Напишете програма, която да пресмята дали с останалите пари от бюджета могат да си купят билети за избраната категория. И колко пари ще им останат или ще са им нужни.

            //input
            //•	На първия ред е бюджетът – реално число в интервала[1 000.00... 1 000 000.00]
            double setBudget = double.Parse(Console.ReadLine());
            //•	На втория ред е категорията – "VIP" или "Normal"
            string categoryOfTicket = Console.ReadLine();
            double priceOfTickets = priceNormalTicket;
            if (categoryOfTicket == "VIP")
            {
                priceOfTickets = priceVipTicket;
            }
            //•	На третия ред е броят на хората в групата – цяло число в интервала[1... 200]
            int peopleInGroup = int.Parse(Console.ReadLine());

            if (peopleInGroup <= 4)
            {
                budgetForTransport = 0.75;
            }
            else if (peopleInGroup <= 9)
            {
                budgetForTransport = 0.6;
            }
            else if (peopleInGroup <= 24)
            {
                budgetForTransport = 0.5;
            }
            else if (peopleInGroup <= 49)
            {
                budgetForTransport = 0.4;
            }
            budgetForTransport *= setBudget;
            double neededBudget = priceOfTickets * peopleInGroup + budgetForTransport;
            double diferenceBudget = Math.Abs(setBudget - neededBudget);

            //output
            //•	Ако бюджетът е достатъчен:
            if (setBudget >= neededBudget)
            {
                Console.WriteLine($"Yes! You have {diferenceBudget:F2} leva left.");
            }
            //o   "Yes! You have {останалите пари на групата} leva left."
            //•	Ако бюджетът НЕ Е достатъчен:
            else
            {
                Console.WriteLine($"Not enough money! You need {diferenceBudget:F2} leva.");
            }
            //o   "Not enough money! You need {сумата, която не достига} leva."
            //Сумите трябва да са форматирани с точност до два знака след десетичната запетая.

        }
    }
}
