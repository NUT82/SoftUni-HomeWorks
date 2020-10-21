using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Курсът "Train the trainers" е към края си и финалното оценяване наближава. Вашата задача е да помогнете на журито което ще оценява презентациите, като напишете програма в която да изчислява средната оценка от представянето на всяка една презентация от даден студент, а накрая средният успех от всички тях.
            //От конзолата на първият ред се прочита броят на хората в журито n - цяло число в интервала [1…20]
            //След това на отделен ред се прочита името на презентацията - текст
            //За всяка една презентация на нов ред се четат n - на брой оценки - реално число в интервала [2.00…6.00]
            //След изчисляване на средната оценка за конкретна презентация, на конзолата се печата
            // "{името на презентацията} - {средна оценка}."
            //След получаване на команда "Finish" на конзолата се печата "Student's final assessment is {среден успех от всички презентации}." и програмата приключва.
            //Всички оценки трябва да бъдат форматирани до втория знак след десетичната запетая.
            double peopleInJury = double.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            double sumAllGrades = 0;
            int countOfPresentation = 0;
            while (nameOfPresentation != "Finish")
            {
                double sumCurrPresentationGrades = 0;
                for (int i = 0; i < peopleInJury; i++)
                {
                    double currGrade = double.Parse(Console.ReadLine());
                    sumCurrPresentationGrades += currGrade;
                }
                Console.WriteLine($"{nameOfPresentation} - {sumCurrPresentationGrades / peopleInJury:F2}.");
                sumAllGrades += sumCurrPresentationGrades;
                countOfPresentation++;
                nameOfPresentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {sumAllGrades / (countOfPresentation * peopleInJury):F2}.");
        }
    }
}
