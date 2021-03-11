using System;
using System.Collections.Generic;
using System.Linq;

namespace SubLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int i = 1; i <= numbers.Length; i++)
            {
                Combinations(i, numbers);
            }
            

        }

        static void Combinations(int count, int[] array)
        {
            //Първоначално си правим масив съдържащ възможните индекси
            int[] positions = new int[count];
            for (int i = 0; i < count; i++)
            {
                positions[i] = i;
            }
            
            //Почваме от последния индекс
            int currIndex = count - 1;
            while (true)
            {
                //правим си лист с текущата комбинация от елементи
                List<int> result = new List<int>();
                foreach (var index in positions)
                {
                    result.Add(array[index]);
                    
                }

                //отпечатваме листа само ако сумата на елементите му е 0
                if (result.Sum() == 0)
                {
                    Console.WriteLine(string.Join(", ", result));
                }

                //увеличаваме текущия индекс с 1
                positions[currIndex]++;
                if (positions[currIndex] > array.Length - 1 - (count - currIndex - 1)) // ако е стигнал максималния за тази позиция
                {
                    currIndex--; //местим се един индекс на ляво
                    if (currIndex < 0 || array.Length == count) // ако сме излезли от масива или сме в случая при само 1 комбинация излизаме от while цикъла
                    {
                        break;
                    }
                    positions[currIndex]++; //увеличаваме текущия индекс с 1
                    int offsetIndex = count - currIndex - 1; //смятаме колко сме на ляво за да се върнем до най десния възможен
                    for (int i = 0; i < offsetIndex; i++)
                    {
                        positions[currIndex + 1] = positions[currIndex] + 1; //следващия индекс сетваме на сегашния + 1
                        if (positions[currIndex + 1] <= array.Length - 1 - (count - currIndex - 1)) //ако не сме стигнали максимума му
                        {
                            currIndex++;
                        }
                    }
                }
            }
        }
    }
}
