using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            double allPeople = 0;
            int musalaPeople = 0;
            int monblanPeople = 0;
            int kilimadjaroPeople = 0;
            int k2People = 0;
            int everestPeople = 0;

            int countOfGroups = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfGroups; i++)
            {
                int peopleInCurrGroup = int.Parse(Console.ReadLine());
                allPeople += peopleInCurrGroup;
                if (peopleInCurrGroup <= 5)
                {
                    musalaPeople += peopleInCurrGroup;
                }
                else if (peopleInCurrGroup <= 12)
                {
                    monblanPeople += peopleInCurrGroup;
                }
                else if (peopleInCurrGroup <= 25)
                {
                    kilimadjaroPeople += peopleInCurrGroup;
                }
                else if (peopleInCurrGroup <= 40)
                {
                    k2People += peopleInCurrGroup;
                }
                else
                {
                    everestPeople += peopleInCurrGroup;
                }
            }
            Console.WriteLine($"{musalaPeople * 100 / allPeople:F2}%");
            Console.WriteLine($"{monblanPeople * 100 / allPeople:F2}%");
            Console.WriteLine($"{kilimadjaroPeople * 100 / allPeople:F2}%");
            Console.WriteLine($"{k2People * 100 / allPeople:F2}%");
            Console.WriteLine($"{everestPeople * 100 / allPeople:F2}%");
        }
    }
}
