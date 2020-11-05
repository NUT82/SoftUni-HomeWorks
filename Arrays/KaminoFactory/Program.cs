using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //You should select the sequence with the longest subsequence of ones. If there are several sequences with same length of subsequence of ones, print the one with the leftmost starting index, if there are several sequences with same length and starting index, select the sequence with the greater sum of its elements.

            //input
            //•	The first line holds the length of the sequences – integer in range [1…100];
            int lengthOfSequences = int.Parse(Console.ReadLine());
            //•	On the next lines until you receive "Clone them!" you will be receiving sequences (at least one) of ones and zeroes, split by "!" (one or several).
            string input = Console.ReadLine();
            int bestSequenceIndex = lengthOfSequences - 1;
            int bestSequenceSum = 0;
            int maxCountOfSequencesOfOne = 0;
            int countOfInput = 0;
            int bestSequenceLine = 0;
            int[] bestSequence = new int[lengthOfSequences];
            while (input != "Clone them!")
            {
                countOfInput++;
                int[] currSequence = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int countOfCurrSequencesOfOne = 0;
                int maxCountOfCurrSequencesOfOne = 0;
                int currSequenceIndex = 0;
                for (int i = 0; i < currSequence.Length; i++)
                {
                    if (currSequence[i] == 1)
                    {
                        countOfCurrSequencesOfOne++;
                        if (countOfCurrSequencesOfOne > maxCountOfCurrSequencesOfOne)
                        {
                            maxCountOfCurrSequencesOfOne = countOfCurrSequencesOfOne;
                            currSequenceIndex = i - maxCountOfCurrSequencesOfOne + 1;
                        }
                    }
                    else
                    {
                        countOfCurrSequencesOfOne = 0;
                    }
                }

                int currSequenceSum = currSequence.Sum();
                if (countOfInput == 1)
                {
                    bestSequenceSum = currSequenceSum;
                    bestSequenceIndex = currSequenceIndex;
                    maxCountOfSequencesOfOne = maxCountOfCurrSequencesOfOne;
                    bestSequence = currSequence;
                    bestSequenceLine = countOfInput;
                }

                if (maxCountOfCurrSequencesOfOne > maxCountOfSequencesOfOne)
                {
                    maxCountOfSequencesOfOne = maxCountOfCurrSequencesOfOne;
                    bestSequence = currSequence;
                    bestSequenceLine = countOfInput;
                    bestSequenceIndex = currSequenceIndex;
                }
                else if (maxCountOfCurrSequencesOfOne == maxCountOfSequencesOfOne)
                {
                    if (currSequenceIndex < bestSequenceIndex)
                    {
                        bestSequenceIndex = currSequenceIndex;
                        bestSequenceLine = countOfInput;
                        bestSequence = currSequence;
                    }
                    else if (currSequenceIndex == bestSequenceIndex)
                    {
                        if (currSequenceSum > bestSequenceSum)
                        {
                            bestSequenceSum = currSequenceSum;
                            bestSequenceLine = countOfInput;
                            bestSequence = currSequence;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            //output
            //The output should be printed on the console and consists of two lines in the following format:
            //"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
            //"{DNA sequence, joined by space}"
            Console.WriteLine($"Best DNA sample {bestSequenceLine} with sum: {bestSequence.Sum()}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
