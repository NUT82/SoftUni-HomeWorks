using System;
using System.Linq;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            const int employeesCount = 3;
            int[] productivity = new int[employeesCount];

            for (int i = 0; i < employeesCount; i++)
            {
                productivity[i] = int.Parse(Console.ReadLine()); //1..100
            }
            int peopleCount = int.Parse(Console.ReadLine()); //0..10000

            int time = (int)Math.Ceiling(peopleCount * 1.0 / productivity.Sum());
            int breakTime = time / 3;

            if (time % 3 == 0 && breakTime > 0)
            {
                breakTime--;
            }

            Console.WriteLine($"Time needed: {time + breakTime}h.");
        }
    }
}
