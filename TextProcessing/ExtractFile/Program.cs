using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();
            string fileName = fullPath.Substring(fullPath.LastIndexOf('\\') + 1);
            Console.WriteLine($"File name: {fileName.Split('.')[0]}");
            Console.WriteLine($"File extension: {fileName.Split('.')[1]}");
        }
    }
}
