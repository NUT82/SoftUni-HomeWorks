using System;

namespace ChangeBureau
{
    class Program
    {
        static void Main(string[] args)
        {
            //Преди време Петър си е купил биткойн. Сега ще ходи на екскурзия из Европа и ще му трябва евро. Освен биткойн има и китайски юанa. Той иска да обмени парите си в евро за екскурзията. Напишете програма, която да пресмята колко евро може да купи спрямо следните валутни курсове:
            //•	1 биткойн = 1168 лева.
            const double oneBitcoinInLv = 1168;
            //•	1 китайски юан = 0.15 долара.
            const double oneChineseYuanInDollars = 0.15;
            //•	1 долар = 1.76 лева.
            const double oneDollarInLv = 1.76;
            //•	1 евро = 1.95 лева.
            const double oneEuroInLv = 1.95;
            //Обменното бюро има комисионна от 0 до 5 процента от крайната сума в евро.
            double resultAfterChange = 0;

            //•	На първия ред – броят биткойни. Цяло число в интервала [0…20]
            int bitcoins = int.Parse(Console.ReadLine());
            //•	На втория ред – броят китайски юана. Реално число в интервала [0.00… 50 000.00]
            double chineseYuan = double.Parse(Console.ReadLine());
            //•	На третия ред – комисионната. Реално число в интервала [0.00 ... 5.00]
            double commission = double.Parse(Console.ReadLine());

            double changeBitcoinInEuro = bitcoins * oneBitcoinInLv / oneEuroInLv;
            double changeYuanInEuro = chineseYuan * oneChineseYuanInDollars * oneDollarInLv / oneEuroInLv;
            resultAfterChange = changeBitcoinInEuro + changeYuanInEuro;
            resultAfterChange -= resultAfterChange * commission / 100;

            //На конзолата да се отпечата 1 число - резултатът от обмяната на валутите. Резултатът да се форматира до втората цифра след десетичната запетая.
            Console.WriteLine($"{resultAfterChange:F2}");
        }
    }
}
