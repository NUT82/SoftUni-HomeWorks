using System;
using System.Runtime.InteropServices.ComTypes;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            //Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден. Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си. Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня и когато постигне целта си да се изписва "Goal reached! Good job!"  и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
            //Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се прибира.След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."
            string input = Console.ReadLine();
            int stepsGoal = 10000;
            int currSteps = 0;

            while (input != "Going home" && stepsGoal > 0)
            {
                currSteps = int.Parse(input);
                stepsGoal -= currSteps;
                if (stepsGoal > 0)
                {
                input = Console.ReadLine();
                }
            }
            if (input == "Going home")
            {
                stepsGoal -= int.Parse(Console.ReadLine());

            }
            if (stepsGoal < 0)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{Math.Abs(stepsGoal)} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(stepsGoal)} more steps to reach goal.");
            }
        }
    }
}
