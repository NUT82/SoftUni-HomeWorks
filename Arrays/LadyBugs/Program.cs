using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //•	On the first line you will receive an integer - the size of the field
            int sizeOfField = int.Parse(Console.ReadLine()); // •	The size of the field will be in the range [0 … 1000]
            if (sizeOfField == 0)
            {
                return;
            }
            int[] fieldOfLadybugs = new int[sizeOfField];
            //•	On the second line you will receive the initial indexes of all ladybugs separated by a blank space. The given indexes may or may not be inside the field range
            int[] initialIndexesOfLadybugs = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            for (int i = 0; i < sizeOfField; i++)
            {
                if (initialIndexesOfLadybugs.Contains(i))
                {
                    fieldOfLadybugs[i] = 1;
                }
            }
            //•	On the next lines, until you get the "end" command you will receive commands in the format: "{ladybug index} {direction} {fly length}"
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] currCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladyBugIndex = int.Parse(currCommand[0]);
                int direction = 1; //if direction is "right"
                if (currCommand[1] == "left")
                {
                    direction = -1; //if direction is "left" 1 1 1
                }
                int flyLength = int.Parse(currCommand[2]) * direction;
                
                if ((fieldOfLadybugs.Length > ladyBugIndex && ladyBugIndex >= 0) && fieldOfLadybugs[ladyBugIndex] == 1)
                {
                    fieldOfLadybugs[ladyBugIndex] = 0;
                    int newLadyBugIndex = ladyBugIndex + flyLength;
                    while (fieldOfLadybugs.Length > newLadyBugIndex && newLadyBugIndex >= 0)
                    {
                        if (fieldOfLadybugs[newLadyBugIndex] == 1)
                        {
                            newLadyBugIndex += flyLength;
                        }
                        else
                        {
                            fieldOfLadybugs[newLadyBugIndex] = 1;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            //output
            //•	Print the all cells within the field in format: "{cell} {cell} … {cell}"
            //o	If a cell has ladybug in it, print '1'
            //o	If a cell is empty, print '0' 
            if (fieldOfLadybugs.Length != 0)
            {
                Console.WriteLine(string.Join(" ", fieldOfLadybugs));
            }
        }
    }
}
