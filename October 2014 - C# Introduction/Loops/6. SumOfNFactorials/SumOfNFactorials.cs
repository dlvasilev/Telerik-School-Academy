using System;
using System.Numerics;

// Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

namespace _6.SumOfNFactorials
{
    class SumOfNFactorials
    {
        static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            BigInteger sum = new BigInteger(1.0m);
            BigInteger tempFactorial = 1;
            BigInteger tempN = 1;


            Console.Write("S = 1");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    tempFactorial *= j;
                }

                for (int g = 1; g <= i; g++)
                {
                    tempN *= x;
                }

                sum = tempFactorial / tempN;

                Console.Write(" + {0}/{1}", tempFactorial, tempN);

                tempFactorial = 1;
                tempN = 1;
            }

            Console.WriteLine(" = {0}", sum);
        }
    }
}
