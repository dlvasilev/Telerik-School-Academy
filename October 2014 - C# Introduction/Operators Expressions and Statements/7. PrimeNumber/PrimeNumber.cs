using System;

// Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

namespace _7.PrimeNumber
{
    class PrimeNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            bool prime = true;

            for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number%i == 0)
                {
                    prime = false;
                }
            }

            Console.WriteLine("The number {0} is{1}", number, prime ? " prime" : "n't prime");
        }
    }
}
