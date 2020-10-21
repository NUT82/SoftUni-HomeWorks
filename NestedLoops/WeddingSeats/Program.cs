using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            //Младоженците искат да направят списък кой на кое място ще седи на сватбената церемония. Местата са разделени на различни сектори. Секторите са главните латински букви като започват от A. Във всеки сектор има определен брой редове. От конзолата се чете броят на редовете в първия сектор (A), като във всеки следващ сектор редовете се увеличават с 1. На всеки ред има определен брой места - тяхната номерация е представена с малките латински букви. Броя на местата на нечетните редове се прочита от конзолата, а на четните редове местата са с 2 повече.
            string allPlaces = "abcdefghijklmnopqrstuvwxyz";
            string allSectors = allPlaces.ToUpper();
            int allPlacesCount = 0;
            //•	Последния сектор от секторите - символ (B-Z)
            string lastSector = Console.ReadLine();
            //•	Броят на редовете в първия сектор - цяло число (1-100)
            int countRowsInFirstSector = int.Parse(Console.ReadLine());
            //•	Броят на местата на нечетен ред - цяло число (1-24)
            int countPlacesOnOddRow = int.Parse(Console.ReadLine());

            for (int sector = 0; sector <= allSectors.IndexOf(lastSector); sector++)
            {
                for (int row = 1; row <= countRowsInFirstSector + sector; row++)
                {
                    if (row % 2 == 0)
                    {
                        for (int place = 0; place < countPlacesOnOddRow + 2; place++)
                        {
                            Console.WriteLine($"{allSectors[sector]}{row}{allPlaces[place]}");
                            allPlacesCount++;
                        }
                    }
                    else
                    {
                        for (int place = 0; place < countPlacesOnOddRow; place++)
                        {
                            Console.WriteLine($"{allSectors[sector]}{row}{allPlaces[place]}");
                            allPlacesCount++;
                        }
                    }
                }
            }
            Console.WriteLine(allPlacesCount);
            //Да се отпечата на конзолата всяко място на отделен ред по следния формат:
            //{сектор}{ред}{място}
            //Накрая трябва да отпечата броя на всички места.

        }
    }
}
