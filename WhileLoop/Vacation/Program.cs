using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума. Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.
            //•	Пари нужни за екскурзията - реално число в интервала [1.00.. .25000.00]
            double neededMoney = double.Parse(Console.ReadLine());
            //•	Налични пари - реално число в интервала [0.00... 25000.00]
            double moneySheHave = double.Parse(Console.ReadLine());
            //След това многократно се четат по два реда:
            //•	Вид действие – текст с възможности "spend" и "save".
            //•	Сумата, която ще спести/похарчи - реално число в интервала [0.01… 25000.00]
            int countSpendDays = 0;
            int countOfDays = 0;

            while (countSpendDays != 5 && moneySheHave < neededMoney)
            {
                string spendOrSave = Console.ReadLine();
                double sumOfSpendOrSave = double.Parse(Console.ReadLine());
                countOfDays++;
                if (spendOrSave == "spend")
                {
                    countSpendDays++;
                    moneySheHave -= sumOfSpendOrSave;
                    if (moneySheHave < 0)
                    {
                        moneySheHave = 0;
                    }
                }
                else
                {
                    countSpendDays = 0;
                    moneySheHave += sumOfSpendOrSave;
                }
            }
            //•	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
            if (countSpendDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countOfDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {countOfDays} days.");
            }
            //o	"You can't save the money."
            //o	"{Общ брой изминали дни}"
            //•	Ако Джеси събере парите за почивката на конзолата се изписва:
            //o	"You saved the money for {общ брой изминали дни} days."

        }
    }
}
