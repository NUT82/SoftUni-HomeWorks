using System;
using System.Collections.Generic;
using System.Linq;

namespace DepositsGetBet365
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Deposit> deposits = new List<Deposit>();
            string[] lineOfFile = System.IO.File.ReadAllLines("input.txt");

            for (int i = 0; i < lineOfFile.Length; i += 5)
            {
                string type = lineOfFile[i];
                double.TryParse(lineOfFile[i + 1].Split()[0].Replace(".", string.Empty).Replace(',', '.'), out double currMoney);
                string[] currCard = lineOfFile[i + 2].Split();
                string[] currReferenceNumber = lineOfFile[i + 3].Split();
                DateTime currDateAndTime = DateTime.Parse(lineOfFile[i + 4]);
                string typeOfTrans = currCard[0];
                if (typeOfTrans != "Теглене")
                {
                    currMoney *= -1;
                }
                Deposit currDeposit = new Deposit(typeOfTrans, currMoney, currCard[currCard.Length - 1], currReferenceNumber[currReferenceNumber.Length - 1], currDateAndTime);
                deposits.Add(currDeposit);
            }


            Dictionary<string, Deposit> unicalDeposits = new Dictionary<string, Deposit>();
            foreach (var item in deposits)
            {
                Deposit currDeposit = new Deposit(item.Type, item.Money, item.Card, item.ReferenceNumber, item.DateAndTime);
                if (!unicalDeposits.ContainsKey(item.ReferenceNumber))
                {
                    unicalDeposits.Add(item.ReferenceNumber, currDeposit);
                }
                else
                {
                    Console.WriteLine("Дублиран залог");
                }
            }

            Console.WriteLine("Въведете 1 за добавяне, 2 за справка или 0 за изход");
            string command = Console.ReadLine();
            while (command != "0")
            {
                switch (command)
                {
                    case "1":
                        //TODO: Добавяне на нов депозит или теглене
                        break;
                    case "2":
                        Console.WriteLine("Въведете месец и година (мм.гггг-мм.гггг) или END за изход:");
                        string date = Console.ReadLine();

                        while (date != "END")
                        {
                            string[] dates = date.Split("-");
                            int starMonth = int.Parse(dates[0].Split(".")[0]);
                            int starYear = int.Parse(dates[0].Split(".")[1]);
                            int endMonth = int.Parse(dates[1].Split(".")[0]);
                            int endYear = int.Parse(dates[1].Split(".")[1]);
                            double sum = 0;
                            foreach (var item in unicalDeposits.Where(m => m.Value.DateAndTime.Month >= starMonth && m.Value.DateAndTime.Year >= starYear &&
                                                                           m.Value.DateAndTime.Month <= endMonth && m.Value.DateAndTime.Year <= endYear))
                            {
                                //Console.WriteLine(Math.Abs(item.Value.Money) + " " + item.Value.Type);
                                sum += item.Value.Money;
                            }
                            Console.WriteLine($"Общо за избрания период ({date}): {sum:F2} лв.");
                            Console.WriteLine("Въведете месец и година (мм.гггг-мм.гггг) или END за изход:");
                            date = Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Грешна команда!");
                        break;
                }

                Console.WriteLine("Въведете 1 за добавяне, 2 за справка или 0 за изход");
                command = Console.ReadLine();
            }
        }
    }

    public class Deposit
    {
        public string Type { get; set; }
        public double Money { get; set; }
        public string Card { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime DateAndTime { get; set; }

        public Deposit(string type, double money, string card, string referenceNumber, DateTime dateTime)
        {
            Type = type;
            Money = money;
            Card = card;
            ReferenceNumber = referenceNumber;
            DateAndTime = dateTime;
        }
    }
}
