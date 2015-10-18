using System;
using System.Numerics;

// Write a program to calculate the Nth Catalan number by given N.

namespace _9_10.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Please insert N: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger twiceNFactorial = 1;
            BigInteger nPlusOneFactorial = 1;
            BigInteger nFactorial = 1;

            for (int i = 2; i <= n*2; i++)
            {
                twiceNFactorial *= i;
            }

            for (int i = 2; i <= n+1; i++)
            {
                nPlusOneFactorial *= i;
            }

            for (int i = 2; i <= n; i++)
            {
                nFactorial *= i;
            }

            Console.WriteLine("The output is: {0}", twiceNFactorial / (nPlusOneFactorial * nFactorial));

        }
    }
}
