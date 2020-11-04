using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons. The input holds two lines: the number of people n and the capacity p of the elevator.
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(1.0 * numberOfPeople / capacityOfElevator));
        }
    }
}
