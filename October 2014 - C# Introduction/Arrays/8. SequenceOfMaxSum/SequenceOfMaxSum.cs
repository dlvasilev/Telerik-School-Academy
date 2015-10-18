using System;

// Write a program that finds the sequence of maximal sum in given array.

namespace _8.SequenceOfMaxSum
{
    class SequenceOfMaxSum
    {
        static void Main()
        {
            Console.Write("Number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = arr[0];
            int currentSum = arr[0];
            int start = 0;
            int startTemp = 0;
            int end = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                currentSum += arr[i];
                if (currentSum < arr[i])
                {
                    currentSum = arr[i];
                    startTemp = i;
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = startTemp;
                    end = i;
                }
            }

            Console.Write("The sequence with maximal sum is: ");
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
