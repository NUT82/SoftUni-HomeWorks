using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която преобразува разстояние между следните 3 мерни единици: mm, cm, m. Използвайте съответствията от таблицата по-долу:
            //входна единица  изходна единица
            //1 meter(m) 1000 millimeters(mm)
            //1 meter(m) 100 centimeters(cm)

            //input
            //•	Първи ред: число за преобразуване - реално число
            double number = double.Parse(Console.ReadLine());
            //•	Втори ред: входна мерна единица - текст
            string inputUnit = Console.ReadLine();
            //•	Трети ред: изходна мерна единица(за резултата) - текст
            string outputUnit = Console.ReadLine();

            //На конзолата да се отпечата резултатът от преобразуването на мерните единици форматиран до третия знак след десетичната запетая.
            double formatNumber = number;
            if (inputUnit == "mm")
            {
                if (outputUnit == "cm")
                {
                    formatNumber = number / 10;
                }
                else if (outputUnit == "m")
                {
                    formatNumber = number / 1000;
                }
            }
            else if (inputUnit == "cm")
            {
                if (outputUnit == "mm")
                {
                    formatNumber = number * 10;
                }
                else if (outputUnit == "m")
                {
                    formatNumber = number / 100;
                }
            }
            else if (inputUnit == "m")
            {
                if (outputUnit == "cm")
                {
                    formatNumber = number * 100;
                }
                else if (outputUnit == "mm")
                {
                    formatNumber = number * 1000;
                }
            }
            Console.WriteLine($"{formatNumber:F3}");
        }
    }
}
