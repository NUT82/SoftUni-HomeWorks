using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        string firstDate;
        string secondDate;
        long difference;

        public static long DaysBetween(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);
            firstDate = firstDate.Replace(' ', '.');
            secondDate = secondDate.Replace(' ', '.');
            return DateAndTime.DateDiff(DateInterval.Day, dateOne, dateTwo);
        }
    }
}
