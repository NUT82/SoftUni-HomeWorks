﻿using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence is calculated from the sum of the two previous elements. The first two elements are 1, 1. Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34…
            //The following sequence can be generated with an array, but that’s easy, so your task is to implement recursively.
            //So if the function GetFibonacci(n) returns the n’th Fibonacci number we can express it using GetFibonacci(n) = GetFibonacci(n - 1) + GetFibonacci(n - 2).
            //However, this will never end and in a few seconds a StackOverflow Exception is thrown.In order for the recursion to stop it has to have a “bottom”. The bottom of the recursion is GetFibonacci(2) should return 1 and GetFibonacci(1) should return 1.

            //input
            //•	On the only line in the input the user should enter the wanted Fibonacci number.
            int indexOfWantedFibonacciNumber = int.Parse(Console.ReadLine());

            //output
            //•	The output should be the n’th Fibonacci number counting from 1.
            Console.WriteLine(GetFibonacci(indexOfWantedFibonacciNumber));

        }

        private static int GetFibonacci(int indexOfWantedFibonacciNumber)
        {
            int result = 1;
            if (indexOfWantedFibonacciNumber > 2)
            {
                result = GetFibonacci(indexOfWantedFibonacciNumber - 1) + GetFibonacci(indexOfWantedFibonacciNumber - 2);
            }
            return result;
        }
    }
}
