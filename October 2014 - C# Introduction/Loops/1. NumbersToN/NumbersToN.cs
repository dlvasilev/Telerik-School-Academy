using System;

// Write a program that prints all the numbers from 1 to N.

namespace _1.NumbersToN
{
    class NumbersToN
    {
        static void Main()
        {
            Console.Write("Number of numbers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
