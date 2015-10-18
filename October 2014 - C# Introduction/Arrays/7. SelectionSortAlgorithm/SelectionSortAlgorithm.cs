using System;

// Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

namespace _7.SelectionSortAlgorithm
{
    class SelectionSortAlgorithm
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

            int min = int.MaxValue;
            int minIndex = 0;
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }
                temp = arr[i];
                arr[i] = min;
                arr[minIndex] = temp;
                min = int.MaxValue;
            }

            Console.WriteLine("The array after being sorted is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
