using System;
using System.Globalization;

namespace _16.DaysToGo
{
    class DaysToGo
    {

        static int DaysLeft(DateTime biggerDate, DateTime smallerDate)
        {
            int checkBigger = DateTime.Compare(biggerDate, smallerDate); //if the first date is bigger, exchange values
            if (checkBigger == 1)
            {
                DateTime temp = biggerDate;
                biggerDate = smallerDate;
                smallerDate = temp;
            }

            int days = 0;

            for (int i = biggerDate.Year; i < smallerDate.Year; i++) //add the years of every year except the last
            {
                if ((i % 100 != 0 || i % 400 == 0) && i % 4 == 0) //check if the year is a leap year
                {
                    days += 364;
                }
                else
                {
                    days += 365;
                }
            }
            days = (days - biggerDate.DayOfYear) + smallerDate.DayOfYear; //substract the days passed from the first year and add the ones of the second
            return days;

        }

        static void Main()
        {
            string firstDateStr = "27.02.2006"; //not validated. dont break it.
            string secondDateStr = "03.03.2006";
            DateTime firstDate = DateTime.ParseExact(firstDateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(secondDateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            int daysDiffrence = DaysLeft(firstDate, secondDate);
            Console.WriteLine(daysDiffrence);

        }
    }
}
