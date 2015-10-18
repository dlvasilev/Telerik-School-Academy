using System;

// Write a program that finds the maximal increasing sequence in an array. 

namespace _5.MaxIncreasingSequence
{
    class MaxIncreasingSequence
    {
        static void Main()
        {
            Console.Write("Number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int maxCount = 0;
            int currentCount = 1;
            int sequenceStart = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    if (arr[i] > arr[i - 1])
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
                        sequenceStart = i + 1 - maxCount;
                    }
                }
            }

            Console.Write("The maximal increasing sequence of elements is: ");
            for (int i = sequenceStart; i < sequenceStart + maxCount; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
