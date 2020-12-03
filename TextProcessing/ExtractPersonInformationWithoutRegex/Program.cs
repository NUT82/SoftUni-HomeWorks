using System;

namespace ExtractPersonInformationWithoutRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string line = Console.ReadLine();
                string name = line.Substring(line.IndexOf('@') + 1, line.IndexOf('|') - (line.IndexOf('@') + 1));
                string age = line.Substring(line.IndexOf('#') + 1, line.IndexOf('*') - (line.IndexOf('#') + 1));
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
