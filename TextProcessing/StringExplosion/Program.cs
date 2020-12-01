using System;
using System.ComponentModel;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine(); //abv>1>1>2>2asdasd

            int strength = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (strength != 0)
                {
                    if (line[i] != '>')
                    {
                        line = line.Remove(i, 1);
                        strength--;
                        i--;
                    }
                    else
                    {
                        strength += int.Parse(line[i + 1].ToString());
                    }
                }
                else if (line[i] == '>')
                {
                    strength = int.Parse(line[i + 1].ToString());
                }

            }

            Console.WriteLine(line);
        }
    }
}
