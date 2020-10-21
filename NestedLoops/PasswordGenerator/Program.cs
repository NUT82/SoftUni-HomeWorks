using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете две цели числа n и l, въведени от потребителя, и генерира по азбучен ред всички възможни  пароли, които се състоят от следните 5 символа:
            //•	Символ 1: цифра от 1 до n.
            //•	Символ 2: цифра от 1 до n.
            //•	Символ 3: малка буква измежду първите l букви на латинската азбука.
            //•	Символ 4: малка буква измежду първите l букви на латинската азбука.
            //•	Символ 5: цифра от 1 до n, по-голяма от първите 2 цифри.
            const string first9SmallLetters = "abcdefghi";
            const string first9Numbers = "123456789";
            //Входът се чете от конзолата и се състои от две цели числа n и l в интервала[1…9], по едно на ред.
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int symbol1 = 0; symbol1 < number1; symbol1++)
            {
                for (int symbol2 = 0; symbol2 < number1; symbol2++)
                {
                    for (int symbol3 = 0; symbol3 < number2; symbol3++)
                    {
                        for (int symbol4 = 0; symbol4 < number2; symbol4++)
                        {
                            for (int symbol5 = symbol1 + 1; symbol5 < number1; symbol5++)
                            {
                                if (symbol5 > symbol2)
                                {
                                    string password = "";
                                    password += first9Numbers[symbol1];
                                    password += first9Numbers[symbol2];
                                    password += first9SmallLetters[symbol3];
                                    password += first9SmallLetters[symbol4];
                                    password += first9Numbers[symbol5];
                                    password += " ";
                                    Console.Write(password);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
