using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float moneyOfIvanChoHas = float.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            float lightsabersPrice = float.Parse(Console.ReadLine());
            float robesPrice = float.Parse(Console.ReadLine());
            float beltsPrice = float.Parse(Console.ReadLine());
            int neededLightsabers = (int)Math.Ceiling(countStudents * 1.1);
            int freeBelt = countStudents / 6;
            float allEquipmentPrice = neededLightsabers * lightsabersPrice + countStudents * robesPrice + (countStudents - freeBelt) * beltsPrice;

            if (allEquipmentPrice <= moneyOfIvanChoHas)
            {
                Console.WriteLine($"The money is enough - it would cost {allEquipmentPrice:F2}lv.");
            }
            else
            {
                float neededMoney = allEquipmentPrice - moneyOfIvanChoHas;
                Console.WriteLine($"Ivan Cho will need {neededMoney:F2}lv more.");
            }
        }
    }
}
