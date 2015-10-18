using System;

// Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

namespace _6.KElementsMaxSum
{
    class KElementsMaxSum
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

            Console.Write("Number of elements to sum: ");
            int k = int.Parse(Console.ReadLine());
            int maxSum = int.MinValue;
            int currentSum = 0;
            int firstOfSequence = 0;

            for (int i = 0; i < n + 1 - k; i++)
            {
                for (int add = 0; add < k; add++)
                {
                    currentSum += arr[i + add];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstOfSequence = i;
                }
                currentSum = 0;
            }

            Console.Write("The {0} elements with maximum sum are: ", k);
            for (int index = firstOfSequence; index < firstOfSequence + k; index++)
            {
                Console.Write("{0} ", arr[index]);
            }
        }
    }
}
