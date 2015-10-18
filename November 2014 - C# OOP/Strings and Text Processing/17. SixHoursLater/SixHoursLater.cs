using System;
using System.Globalization;

namespace _17.SixHoursLater
{
    class SixHoursLater
    {
        static void Main()
        {
            string str = "05.12.2014 14:51:21";

            DateTime date = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            date = date.AddHours(6.5);

            Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }
}
