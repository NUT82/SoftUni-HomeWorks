using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough" от лектора си. При всяка решена задача той получава оценка. Програмата трябва да приключи прочитането на данни при команда "Enough" или ако Марин получи определения брой незадоволителни оценки.
            //Незадоволителна е всяка оценка, която е по-малка или равна на 4.
            string input = "";
            string prevInput = "";
            int currGrade = 0;
            int badGradesCounter = 0;
            double sumAllGrades = 0;
            double countOfProblems = 0;
            //•	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
            int countAllowedBadGrade = int.Parse(Console.ReadLine());
            //•	След това многократно се четат по два реда:
            //o	Име на задача - текст (низ)
            //o	Оценка - цяло число в интервала [2…6]
            while (input != "Enough" || badGradesCounter < countAllowedBadGrade)
            {
                input = Console.ReadLine();
                if (input == "Enough")
                {
                    Console.WriteLine($"Average score: {sumAllGrades / countOfProblems:F2}");
                    Console.WriteLine($"Number of problems: {countOfProblems}");
                    Console.WriteLine($"Last problem: {prevInput}");
                    break;
                }
                else
                {
                    currGrade = int.Parse(Console.ReadLine());
                    if (currGrade <= 4)
                    {
                        badGradesCounter++;
                    }
                    countOfProblems++;
                    sumAllGrades += currGrade;
                    prevInput = input;
                }
                if (badGradesCounter == countAllowedBadGrade)
                {
                    Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                    break;
                }
            }

            //•	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 
            //o	"Average score: {средна оценка}"
            //o	"Number of problems: {броя на всички задачи}"
            //o	"Last problem: {името на последната задача}"
            //•	Ако получи определеният брой незадоволителни оценки:
            //o	"You need a break, {брой незадоволителни оценки} poor grades."
            //Средната оценка да бъде форматирана до втория знак след десетичната запетая. 

        }
    }
}
