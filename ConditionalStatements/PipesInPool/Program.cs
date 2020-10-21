using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Басейн с обем V има две тръби от които се пълни. Всяка тръба има определен дебит (литрите вода минаващи през една тръба за един час). Работникът пуска тръбите едновременно и излиза за N часа. Напишете програма, която изкарва състоянието на басейна, в момента, когато работникът се върне. 

            //Input

            //•	Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала[1…10000].
            int poolCapacity = int.Parse(Console.ReadLine());
            //•	Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала[1…5000].
            int debitFirstPipe = int.Parse(Console.ReadLine());
            //•	Третият ред съдържа числото P2 – дебит на втората тръба за час– цяло число в интервала[1…5000].
            int debitSecondPipe = int.Parse(Console.ReadLine());
            //•	Четвъртият ред съдържа числото H – часовете които работникът отсъства – реално число в интервала[1.0…24.00]
            double hoursMissing = double.Parse(Console.ReadLine());

            //Calculations
            double litresForMissingHours = hoursMissing * (debitFirstPipe + debitSecondPipe);

            //Output

            //Да се отпечата на конзолата едно от двете възможни състояния:
            //•	До колко се е запълнил басейна и коя тръба с колко процента е допринесла.
            //o   "The pool is {запълненост на басейна в проценти}% full. Pipe 1: {процент вода от първата тръба}%. Pipe 2: {процент вода от втората тръба}%."
            if (litresForMissingHours <= poolCapacity)
            {
                double percentFromFirstPipe = debitFirstPipe * hoursMissing * 100 / litresForMissingHours;
                Console.WriteLine($"The pool is {litresForMissingHours / poolCapacity * 100:F2}% full. Pipe 1: {percentFromFirstPipe:F2}%. Pipe 2: {100 - percentFromFirstPipe:F2}%.");
            }
            //Aко басейнът се е препълнил – с колко литра е прелял за даденото време.
            //o   "For {часовете, които тръбите са пълнили вода} hours the pool overflows with {литрите вода в повече} liters."
            else
            {
                Console.WriteLine($"For {hoursMissing:F2} hours the pool overflows with {litresForMissingHours - poolCapacity:F2} liters.");
            }


        }
    }
}
