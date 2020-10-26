using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte age = byte.Parse(Console.ReadLine());
            string result = string.Empty;
            if (age >= 66)
            {
                result = "elder";
            }
            else if (age >= 20)
            {
                result = "adult";
            }
            else if (age >= 14)
            {
                result = "teenager";
            }
            else if (age >= 3)
            {
                result = "child";
            }
            else if (age >= 0)
            {
                result = "baby";
            }
            else
            {
                result = "error";
            }
            Console.WriteLine(result);
        }
    }
}
