﻿using System;

namespace ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Провокирани от сватбата си, Михаела и Иван решават да предоставят нова услуга на клиенти на ресторанта си, а именно вечеря за запознанства - "Предизвикай Сватбата". Напишете програма, която отпечатва всички възможни срещи на клиентите на ресторанта. При настаняване всеки мъж и всяка жена получават талончета с поредни номера стартирайки от 1. Ако бъдат заети всички маси, програмата трябва да приключи. Всяка маса има две места.

            //•	Броя клиенти мъже - цяло число в интервала [1...100]
            int mans = int.Parse(Console.ReadLine());
            //•	Броя клиенти жени - цяло число в интервала [1...100]
            int womans = int.Parse(Console.ReadLine());
            //•	Максималният брой маси - цяло число в интервала [1...100]
            int maxTables = int.Parse(Console.ReadLine());

            for (int i = 1; i <= mans; i++)
            {
                for (int a = 1; a <= womans; a++)
                {
                    Console.Write($"({i} <-> {a}) ");
                    maxTables -= 1;
                    if (maxTables <= 0)
                    {
                        break;
                    }
                }
                if (maxTables <= 0)
                {
                    break;
                }
            }

            //На конзолата се принтират на един ред, разделени с интервал всички срещи в следният формат:
            //•	({№ клиент} <-> {№ клиент}) ({№ клиент} <-> {№ клиент}) ...

        }
    }
}
