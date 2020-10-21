using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main()
        {
            //Студент трябва да отиде на изпит в определен час (например в 9:30 часа). Той идва в изпитната зала в даден час на пристигане (например 9:40). Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това. Ако е пристигнал по-рано повече от 30 минути, той е подранил. Ако е дошъл след часа на изпита, той е закъснял. Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял и с колко часа или минути е подранил или закъснял.

            //input
            //•	Първият ред съдържа час на изпита – цяло число от 0 до 23.
            int hourOfExam = int.Parse(Console.ReadLine());
            //•	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
            int minuteOfExam = int.Parse(Console.ReadLine());
            //•	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
            int hourOfArive = int.Parse(Console.ReadLine());
            //•	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
            int minuteOfArive = int.Parse(Console.ReadLine());

            int hoursInMinutesAfterMidnightOfExam = hourOfExam * 60;
            int hoursInMinutesAfterMidnightOfArive = hourOfArive * 60;

            int diferenceInMinutes = hoursInMinutesAfterMidnightOfExam + minuteOfExam - (hoursInMinutesAfterMidnightOfArive + minuteOfArive);

            

            //output
            //На първият ред отпечатайте:
            //•	“Late”, ако студентът пристига по-късно от часа на изпита.
            //•	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
            //•	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
            if (diferenceInMinutes < 0)
            {
                Console.WriteLine("Late");
            }
            else if (diferenceInMinutes <= 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }
            string diferenceInOutputFormat = "";
            if (Math.Abs(diferenceInMinutes) >= 60)
            {
                if (Math.Abs(diferenceInMinutes) % 60 < 10)
                {
                    diferenceInOutputFormat = Math.Abs(diferenceInMinutes) / 60 + ":0" + Math.Abs(diferenceInMinutes) % 60 + " hours";
                }
                else
                {
                    diferenceInOutputFormat = Math.Abs(diferenceInMinutes) / 60 + ":" + Math.Abs(diferenceInMinutes) % 60 + " hours";
                }
            }
            else
            {
                diferenceInOutputFormat = Math.Abs(diferenceInMinutes) % 60 + " minutes";
            }
            //Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
            if (diferenceInMinutes != 0)
            {
                if (diferenceInMinutes > 0)
                {
                    Console.WriteLine($"{diferenceInOutputFormat} before the start");
                }
                else
                {
                    Console.WriteLine($"{diferenceInOutputFormat} after the start");
                }
            }
            //•	“mm minutes before the start” за идване по - рано с по-малко от час.
            //•	“hh: mm hours before the start” за подраняване с 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:05”.
            //•	 “mm minutes after the start” за закъснение под час.
            //•	“hh: mm hours after the start” за закъснение от 1 час или повече.Минутите винаги печатайте с 2 цифри, например “1:03”.

        }
    }
}
