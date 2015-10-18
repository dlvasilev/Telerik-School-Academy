using System;

// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm

namespace _15.AllPrimeNumbers
{
    class AllPrimeNumbers
    {
        static void Main()
        {
            bool[] arr = new bool[10000000];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i < Math.Sqrt(arr.Length); i++)
            {
                if (arr[i])
                {
                    for (int j = i * i; j < arr.Length; j = j + i)
                    {
                        arr[j] = false;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]) Console.Write(i + " ");
            }
        }
    }
}
