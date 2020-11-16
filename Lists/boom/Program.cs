namespace SafePasswordsGenerator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            int passwordsCount = 0;

            for (int i = 35; ;)
            {
                if (i > 55)
                {
                    i = 35;
                }
                for (int j = 64; ;)
                {
                    if (j > 96)
                    {
                        j = 64;
                    }
                    for (int k = 1; ; k++)
                    {
                        for (int m = 1; ; m++)
                        {
                            if (k > a || m > b || passwordsCount == maxPasswords)
                            {
                                break;
                            }
                            passwordsCount++;
                            Console.Write($"{Convert.ToChar(i)}{Convert.ToChar(j)}{k}{m}{Convert.ToChar(j)}{Convert.ToChar(i)}|");
                            i++;
                            j++;
                        }
                    }
                }
            }
        }
    }
}