using System;

namespace Volleyball
{
    class Program
    {
        static void Main()
        {
            //Влади е студент, живее в София и си ходи от време на време до родния град.Той е много запален по волейбола, но е зает през работните дни и играе волейбол само през уикендите и в празничните дни.Влади играе в София всяка събота, когато не е на работа и не си пътува до родния град, както и в 2 / 3 от празничните дни.Той пътува до родния си град h пъти в годината, където играе волейбол със старите си приятели в неделя. Влади не е на работа 3 / 4 от уикендите, в които е в София. Отделно, през високосните години Влади играе с 15 % повече волейбол от нормалното.Приемаме, че годината има точно 48 уикенда, подходящи за волейбол.
            const int countOfWeekends = 48;
            //  Напишете програма, която изчислява колко пъти Влади е играл волейбол през годината.Закръглете резултата надолу до най - близкото цяло число(например 2.15  2; 9.95  9).

            //Входните данни се въвеждат от потребителя, в следния вид: 
            //•	Първият ред съдържа думата "leap"(високосна година) или "normal"(невисокосна).
            string leapOrNormalYear = Console.ReadLine();
            //•	Вторият ред съдържа цялото число p – брой празници в годината(които не са събота и неделя).
            double countOfHolidays = int.Parse(Console.ReadLine());
            //•	Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.
            double countOfWeekendsInHometown = int.Parse(Console.ReadLine());
            double countOfWeekendsInSofia = countOfWeekends - countOfWeekendsInHometown;
            double countOfPlay = countOfWeekendsInSofia * 3 / 4 + countOfHolidays * 2 / 3;
            countOfPlay += countOfWeekendsInHometown;
            if (leapOrNormalYear == "leap")
            {
                countOfPlay += countOfPlay * 0.15;
            }
            Console.WriteLine(Math.Floor(countOfPlay));
        }
    }
}
