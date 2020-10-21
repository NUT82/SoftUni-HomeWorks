using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalTitles
{
    class Program
    {
        static void Main()
        {
            //Да се напише конзолна програма, която прочита възраст (реално число) и пол ('m' или 'f'), въведени от потребителя, и отпечатва обръщение измежду следните:
            //•	"Mr." – мъж (пол 'm') на 16 или повече години
            //•	"Master" – момче (пол 'm') под 16 години
            //•	"Ms." – жена (пол 'f') на 16 или повече години
            //•	"Miss" – момиче (пол 'f') под 16 години

            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            if (age >= 16)
            {
                if (sex == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else
            {
                if (sex == "m")
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
