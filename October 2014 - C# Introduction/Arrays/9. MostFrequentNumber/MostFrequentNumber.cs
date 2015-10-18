using System;

// Write a program that finds the most frequent number in an array.

namespace _9.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main()
        {
            Console.Write("Number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxCount = int.MinValue;
            int currentCount = 1;
            int number = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int index = 1; index < n; index++)
            {
                if (arr[index] == arr[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    number = arr[index];
                }
            }

            if (n == 1)
            {
                maxCount = 1;
                number = arr[0];
            }
            Console.WriteLine("The most frequent number {0} is found {1} times!", number, maxCount);
        }
    }
}
