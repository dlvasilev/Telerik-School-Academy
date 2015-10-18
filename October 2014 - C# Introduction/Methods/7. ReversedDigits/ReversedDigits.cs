using System;

// Write a method that reverses the digits of given decimal number.

namespace _7.ReversedDigits
{
    class ReversedDigits
    {
        static int ReverseDigits(int num)
        {
            int rNum = 0;

            while (num > 0)
            {
                rNum = rNum * 10 + num % 10;
                num /= 10;
            }

            return rNum;
        }

        static void Main()
        {
            Console.Write("Insert number: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The number {0} revesed is {1}", num, ReverseDigits(num));
        }
    }
}
