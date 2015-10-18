using System;
using System.Numerics;

// Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

namespace _10.CalculateNFactorial
{
    class CalculateNFactorial
    {
        static void Main()
        {
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            CalcFactorial(arr);
        }

        static void CalcFactorial(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                BigInteger factorial = Factorial(i);
                Console.WriteLine(factorial);
            }
        }

        static BigInteger Factorial(int n)
        {
            BigInteger fact = n;
            while (n > 0)
            {
                fact *= n;
                n--;
            }
            return fact;
        }
    }
}
