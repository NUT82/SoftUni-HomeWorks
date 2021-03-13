using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split();
            while (text[0] != "End")
            {
                Citizen citizen = new Citizen(text[0], text[1], int.Parse(text[2]));

                IResident resident = citizen;
                IPerson person = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());

                text = Console.ReadLine().Split();
            }
        }
    }
}
