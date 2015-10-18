using System;
using System.Numerics;

// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci

namespace _7.FibbonaciToN
{
    class FibbonaciToN
    {
        static void Main()
        {
            Console.Write("Fibbonaci to: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger a = 0;
            Console.Write(" {0} ", 0);

            BigInteger b = 1;
            Console.Write(" {0} ", 1);

            BigInteger temp;

            for (int i = 1; i <= n-2; i++)
            {
                temp = a + b;
                a = b;
                b = temp;

                Console.Write(" {0} ", temp);
            }
        }
    }
}
