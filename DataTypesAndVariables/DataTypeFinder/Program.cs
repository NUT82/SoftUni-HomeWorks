using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*You will receive an input until you receive "END". Find what data type is the input. Possible data types are:
            •	Integer 
            •	Floating point 
            •	Characters
            •	Boolean
            •	Strings
            Print the result in the following format: "{input} is {data type} type" */

            var input = Console.ReadLine();
            while (input != "END")
            {
                int intNum = 0;
                double doubleNum = 0;
                string dataType = "string";
                if (int.TryParse(input, out intNum))
                {
                    dataType = "integer";
                }
                else if (double.TryParse(input, out doubleNum))
                {
                    dataType = "floating point";
                }
                else if (input.Length == 1)
                {
                    dataType = "character";
                }
                else if (input.ToLower() == "true" || input.ToLower() == "false")
                {
                    dataType = "boolean";
                }

                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }
    }
}
