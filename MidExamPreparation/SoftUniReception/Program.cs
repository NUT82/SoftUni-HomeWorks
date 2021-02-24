using System;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            const int breakHour = 3;

            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int allEmployee = employeeOne + employeeTwo + employeeThree;
            
            int neededTimeWhithoutBreak = (int)Math.Ceiling(students * 1.0 / allEmployee);

            int breakTime = neededTimeWhithoutBreak / breakHour;

            if (neededTimeWhithoutBreak % breakHour == 0 && breakTime > 0)
            {
                breakTime--;
            }

            Console.WriteLine($"Time needed: {neededTimeWhithoutBreak + breakTime}h.");
        }
    }
}
