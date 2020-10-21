using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //За даден период от време, всеки ден в болницата пристигат пациенти за преглед. Тя разполага първоначално със 7 лекари. Всеки лекар може да преглежда само по един пациент на ден, но понякога има недостиг на лекари, затова останалите пациенти се изпращат в други болници. Всеки трети ден, болницата прави изчисления и ако броят на непрегледаните пациенти е по-голям от броя на прегледаните, се назначава още един лекар. Като назначаването става преди да започне приемът на пациенти за деня.
            //Напишете програма, която изчислява за дадения период броя на прегледаните и непрегледаните пациенти.
            int doctorsCount = 7;
            //input
            //•	На първия ред – периода, за който трябва да направите изчисления. Цяло число в интервала [1 ... 1000]
            int periodDays = int.Parse(Console.ReadLine());
            //•	На следващите редове(равни на броят на дните) – броя пациенти, които пристигат за преглед за текущия ден. Цяло число в интервала[0…10 000]
            int examinedPacient = 0;
            int notExaminedPacient = 0;

            for (int i = 1; i <= periodDays; i++)
            {
                int pacientsCount = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (notExaminedPacient > examinedPacient)
                    {
                        doctorsCount++;
                    }
                }
                if (pacientsCount >= doctorsCount)
                {
                    examinedPacient += doctorsCount;
                    notExaminedPacient += pacientsCount - doctorsCount;
                }
                else
                {
                    examinedPacient += pacientsCount;
                }
            }
            //output
            //•	На първия ред: "Treated patients: {брой прегледани пациенти}."
            Console.WriteLine($"Treated patients: {examinedPacient}.");
            //•	На втория ред: "Untreated patients: {брой непрегледани пациенти}."
            Console.WriteLine($"Untreated patients: {notExaminedPacient}.");
        }
    }
}
