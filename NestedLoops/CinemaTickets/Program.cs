using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от продадените билети: студентски(student), стандартен(standard) и детски(kid), за всички прожекции. Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.

            //input
            //•	На първия ред до получаване на командата "Finish" - име на филма – текст
            //•	На втори ред – свободните места в салона за всяка прожекция – цяло число [1 … 100]
            //•	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
            //o	Типа на закупения билет - текст ("student", "standard", "kid")
            int ticketsToCurrFilm = 0;
            int countOfStudentTickets = 0;
            int countOfStandardTickets = 0;
            int countOfKidTickets = 0;
            int TotalFreeTickets = 0;

            string filmName = Console.ReadLine();
            while (filmName != "Finish")
            {
                int freeTickets = int.Parse(Console.ReadLine());
                string typeOfTicket = Console.ReadLine();
                while (typeOfTicket != "End")
                {
                    switch (typeOfTicket)
                    {
                        case "student":
                            countOfStudentTickets++;
                            break;
                        case "standard":
                            countOfStandardTickets++;
                            break;
                        case "kid":
                            countOfKidTickets++;
                            break;
                        default:
                            break;
                    }
                    if (countOfKidTickets + countOfStandardTickets + countOfStudentTickets - ticketsToCurrFilm == freeTickets)
                    {
                        break;
                    }
                    typeOfTicket = Console.ReadLine();
                }
                Console.WriteLine($"{filmName} - {(countOfKidTickets + countOfStandardTickets + countOfStudentTickets - ticketsToCurrFilm) * 100 / (double)freeTickets:F2}% full.");
                ticketsToCurrFilm = countOfKidTickets + countOfStandardTickets + countOfStudentTickets;
                TotalFreeTickets = +freeTickets;
                filmName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {countOfKidTickets + countOfStandardTickets + countOfStudentTickets}");
            Console.WriteLine($"{countOfStudentTickets * 100 / (double)(countOfKidTickets + countOfStandardTickets + countOfStudentTickets):F2}% student tickets.");
            Console.WriteLine($"{countOfStandardTickets * 100 / (double)(countOfKidTickets + countOfStandardTickets + countOfStudentTickets):F2}% standard tickets.");
            Console.WriteLine($"{countOfKidTickets * 100 / (double)(countOfKidTickets + countOfStandardTickets + countOfStudentTickets):F2}% kids tickets.");

            //output
            //•	След всеки филм да се отпечата, колко процента от кино залата е пълна
            //"{името на филма} - {процент запълненост на залата}% full."
            //•	При получаване на командата "Finish" да се отпечатат четири реда:
            //o	"Total tickets: {общият брой закупени билети за всички филми}"
            //o	"{процент на студентските билети}% student tickets."
            //o	"{процент на стандартните билети}% standard tickets."
            //o	"{процент на детските билети}% kids tickets."

        }
    }
}
