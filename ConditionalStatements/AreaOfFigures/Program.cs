using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle). На първия ред на входа се чете вида на фигурата(square, rectangle, circle или triangle).
            //•	Ако фигурата е квадрат, на следващия ред се чете едно число -дължина на страната му.
            //•	Ако фигурата е правоъгълник, на следващите два реда четат две числа -дължините на страните му.
            //•	Ако фигурата е кръг, на следващия ред чете едно число - радиусът на кръга.
            //•	Ако фигурата е триъгълник, на следващите два реда четат две числа -дължината на страната му и дължината на височината към нея.
            //Резултатът да се закръгли до 3 цифри след десетичната точка.
            string typeOfFigure = Console.ReadLine();

            if (typeOfFigure == "square")
            {
                double sqareSide = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sqareSide * sqareSide:F3}");
            }
            else if (typeOfFigure == "rectangle")
            {
                double rectangleSide1 = double.Parse(Console.ReadLine());
                double rectangleSide2 = double.Parse(Console.ReadLine());
                Console.WriteLine($"{rectangleSide1 * rectangleSide2:F3}");
            }
            else if (typeOfFigure == "circle")
            {
                double circleRadius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{circleRadius * circleRadius * Math.PI:F3}");
            }
            else if (typeOfFigure == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                Console.WriteLine($"{triangleSide * triangleHeight / 2:F3}");
            }

        }
    }
}
