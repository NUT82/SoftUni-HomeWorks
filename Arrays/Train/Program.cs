using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given a count of wagons in a train n. On the next n lines you will receive how many people are going to get on each wagon. At the end print the whole train and after that, on the next line, the sum of the people in the train. 
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] peopleInWagons = new int[countOfWagons];
            for (int i = 0; i < countOfWagons; i++)
            {
                peopleInWagons[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in peopleInWagons)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine(peopleInWagons.Sum());
        }
    }
}
