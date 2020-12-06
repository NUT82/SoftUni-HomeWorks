using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string pattern = @".*?(([@#$^])\2{5,9}).*?";
            foreach (string ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    string leftSide = ticket.Substring(0, 10);
                    string rightSide = ticket.Substring(10);
                    Match matchLeftSide = Regex.Match(leftSide, pattern);
                    Match matchRightSide = Regex.Match(rightSide, pattern);
                    if (matchLeftSide.Success && matchRightSide.Success 
                        && matchLeftSide.Groups[1].Value[0] == matchRightSide.Groups[1].Value[0])
                    {
                        int min = Math.Min(matchLeftSide.Groups[1].Length, matchRightSide.Groups[1].Length);
                        if (min == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - 10{matchLeftSide.Groups[1].Value[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{matchLeftSide.Groups[1].Value[0]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
