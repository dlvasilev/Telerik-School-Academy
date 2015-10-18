using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _19.ExtractDates
{
    class ExtractDates
    {
        static void Main(string[] args)
        {
            string format = "dd.MM.yyyy";

            string text = "fasjfaskfa 10.01.2015 fsafsafaf fsafaff fs 05.03.2051";

            foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
            {

                string extractedToString = Convert.ToString(extracted);

                DateTime date = DateTime.ParseExact(extractedToString, format, CultureInfo.InvariantCulture);

                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
