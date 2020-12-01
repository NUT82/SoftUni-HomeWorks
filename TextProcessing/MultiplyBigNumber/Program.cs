using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int multiplyNumber = int.Parse(Console.ReadLine());
            int onMind = 0;
            StringBuilder result = new StringBuilder();
            if (multiplyNumber == 0 || bigNumber == "")
            {
                result.Append("0");
            }
            else
            {
                foreach (var number in bigNumber.Reverse())
                {
                    int currDigit = int.Parse(number.ToString());
                    int multiplyCurrDigit = currDigit * multiplyNumber + onMind;
                    if (multiplyCurrDigit > 9)
                    {
                        onMind = multiplyCurrDigit / 10;
                        multiplyCurrDigit %= 10;
                    }
                    else
                    {
                        onMind = 0;
                    }
                    result.Insert(0, multiplyCurrDigit);
                }

                if (onMind != 0)
                {
                    result.Insert(0, onMind);
                }
            }

            Console.WriteLine(result);
        }
    }
}
