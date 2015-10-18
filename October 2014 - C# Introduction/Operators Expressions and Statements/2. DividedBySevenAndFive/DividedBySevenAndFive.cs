using System;

// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

namespace _2.DividedBySevenAndFive
{
    class DividedBySevenAndFive
    {
        static void Main()
        {
            bool flag = false;
            int number = int.Parse(Console.ReadLine());

            if (number % 7 == 0 && number % 5 == 0)
            {
                flag = true;
            }

            Console.WriteLine("The number is divided by 7 and 5 in the same time without reminder = {0}", flag);
        }
    }
}
