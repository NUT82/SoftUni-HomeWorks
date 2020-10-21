using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете n-на брой числа, въведени от потребителя, и пресмята сумата, минимума и максимума на числата на четни и нечетни позиции (броим от 1). Когато няма минимален / максимален елемент, отпечатайте "No". 
            //Изходът да се форматира в следния вид:
            //"OddSum=" + {сума на числата на нечетни позиции},
            //"OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            //"OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            //"EvenSum=" + { сума на числата на четни позиции },
            //"EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}
            //Всяко число трябва да е форматирано до втория знак след десетичната запетая.
            int countOfReadNumbers = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMin = 0;
            double evenMin = 0;
            double oddMax = 0;
            double evenMax = 0;
            
            for (int i = 1; i <= countOfReadNumbers; i++)
            {
                double inputNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += inputNumber;
                    if (inputNumber > evenMax || i == 2)
                    {
                        evenMax = inputNumber;
                    }
                    if (inputNumber < evenMin || i == 2)
                    {
                        evenMin = inputNumber;
                    }
                }
                else
                {
                    oddSum += inputNumber;
                    if (inputNumber > oddMax || i == 1)
                    {
                        oddMax = inputNumber;
                    }
                    if (inputNumber < oddMin || i == 1)
                    {
                        oddMin = inputNumber;
                    }
                }
            }
            //"OddSum=" + {сума на числата на нечетни позиции},
            Console.WriteLine($"OddSum={oddSum:F2},");
            //"OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            //"OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            if (countOfReadNumbers < 1)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            //"EvenSum=" + { сума на числата на четни позиции },
            Console.WriteLine($"EvenSum={evenSum:F2},");
            //"EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            //"EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}
            if (countOfReadNumbers < 2)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
