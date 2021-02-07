using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box.ToString());
            }
        }
    }
}
