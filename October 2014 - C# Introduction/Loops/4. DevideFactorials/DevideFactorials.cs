using System;
using System.Numerics;

// Write a program that calculates N!/K! for given N and K (1<K<N).

namespace _4.DevideFactorials
{
    class DevideFactorials
    {
        static void Main()
        {
            Console.Write("Please insert K (1<K): ");
            int k = int.Parse(Console.ReadLine());

            bool flag = false;

            if (k <= 1)
            {
                Console.WriteLine("Wrong!");
                flag = true;
            }

            if (!flag)
            {
                Console.Write("Please insert N (1<K<N): ");
                int n = int.Parse(Console.ReadLine());

                if (n <= k)
                {
                    Console.WriteLine("Wrong!");
                    flag = true;
                }

                if (!flag)
                {
                    BigInteger nFactorial = 1;
                    BigInteger kFactorial = 1;

                    for (int i = 2; i <= k; i++)
                    {
                        kFactorial *= i;
                    }

                    for (int i = 2; i <= n; i++)
                    {
                        nFactorial *= i;
                    }
                    Console.WriteLine("The output is: {0}", nFactorial / kFactorial);
                }
            }
        }
    }
}
