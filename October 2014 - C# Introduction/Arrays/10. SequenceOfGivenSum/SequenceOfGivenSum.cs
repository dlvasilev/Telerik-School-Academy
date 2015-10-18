using System;

// Write a program that finds in given array of integers a sequence of given sum S (if present).

namespace _10.SequenceOfGivenSum
{
    class SequenceOfGivenSum
    {
        static void Main()
        {
            Console.Write("Number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.Write("Sum: ");
            int s = int.Parse(Console.ReadLine());
            int sum = 0;
            bool flag = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        flag = true;
                        Console.Write("The following sequence has the sum of {0}: ", s);
                        for (int print = i; print <= j; print++)
                        {
                            Console.Write("{0} ", arr[print]);
                        }
                        Console.WriteLine();
                    }
                }
                sum = 0;
            }

            if (!flag)
            {
                Console.WriteLine("There is no sequnce with the sum of {0}!", s);
            }
        }
    }
}
