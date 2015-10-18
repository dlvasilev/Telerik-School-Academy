using System;

// Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm

namespace _11.BinarySearchAlgorithm
{
    class BinarySearchAlgorithm
    {
        static void Search(int[] arr, int from, int to, int element)
        {
            if (to <= from)
            {
                Console.WriteLine("Not Found!");
                return;
            }
            else
            {
                int mid = from + (to - from) / 2;
                if (element < arr[mid])
                {
                    Search(arr, from, mid - 1, element);
                }
                else if (element > arr[mid])
                {
                    Search(arr, mid + 1, to, element);
                }
                else
                {
                    Console.WriteLine("Found! Array[{0}] = {1}", mid, element);
                    return;
                }
            }
        }

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

            Console.Write("Search: ");
            int element = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            Search(arr, 0, arr.Length, element);
        }
    }
}
