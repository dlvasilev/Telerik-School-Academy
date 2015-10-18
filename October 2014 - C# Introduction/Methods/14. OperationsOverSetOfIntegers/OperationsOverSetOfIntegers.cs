using System;

// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.

namespace _14.OperationsOverSetOfIntegers
{
    class OperationsOverSetOfIntegers
    {
        static int Min(int[] numbers)
        {
            int min = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min) min = num;
            }
            return min;
        }

        static int Max(int[] numbers)
        {
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num > max) max = num;
            }
            return max;
        }

        static double Avegrage(int[] numbers)
        {
            return ((double)Sum(numbers) / numbers.Length);
        }

        static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers) sum += num;

            return sum;
        }

        static decimal Product(int[] numbers)
        {
            decimal product = 1;

            foreach (int num in numbers) product *= (decimal)num;
            return product;
        }

        static void Main()
        {
            int[] arr = { 11, 5, 103, 1003, 89, 999 };

            Console.WriteLine("Min: " + Min(arr));
            Console.WriteLine("Max: " + Max(arr));
            Console.WriteLine("Sum: " + Sum(arr));
            Console.WriteLine("Avg: " + Avegrage(arr));
            Console.WriteLine("Product: " + Product(arr));
        }
    }
}
