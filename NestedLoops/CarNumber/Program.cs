using System;

namespace CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поздравления, поради вашите задълбочени знания в сферата на програмирането МВР реши да наеме точно вас за създаването на новата им система за генериране на специални автомобилни номера. Всеки един специален автомобилен номер се състой от четири числа. Условията, които разграничават специалните от обикновените номера са следните: 
            //•	Ако номерът започва с четна цифра, то той трябва да завършва на нечетна цифра и обратното – ако започва с нечетна,  завършва на четна
            //•	Първата цифра от номера е по-голяма от последната
            //•	Сумата от втората и третата цифра трябва да е четно число
            //Входа се състой от две числа - начало и край на интервал, между които трябва да се генерира всяко едно число от номера.

            //1.Първи ред - едноцифрено число - началото на интервала – цяло число в интервала [1…9]
            int startInterval = int.Parse(Console.ReadLine());
            //2.Втори ред - едноцифрено число - края на интервала – цяло число в интервала[1…9]
            int endInterval = int.Parse(Console.ReadLine());

            for (int firstPosition = startInterval; firstPosition <= endInterval; firstPosition++)
            {
                for (int secondPosition = startInterval; secondPosition <= endInterval; secondPosition++)
                {
                    for (int thirdPosition = startInterval; thirdPosition <= endInterval; thirdPosition++)
                    {
                        for (int fourthPosition = startInterval; fourthPosition < firstPosition; fourthPosition++)
                        {
                            if ((firstPosition % 2 == 0 && fourthPosition % 2 != 0) || (firstPosition % 2 != 0 && fourthPosition % 2 == 0))
                            {
                                if ((secondPosition + thirdPosition) % 2 == 0)
                                {
                                    Console.Write($"{firstPosition}{secondPosition}{thirdPosition}{fourthPosition} ");
                                }
                            }
                        }
                    }
                }
            }

            //На конзолата трябва да се отпечатат всички специални номера, разделени с интервал.
        }
    }
}
