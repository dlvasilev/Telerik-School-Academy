using System;
using System.Collections.Generic;

// Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

namespace _9.MaxElementFromGivenIndex
{
    class MaxElementFromGivenIndex
    {
        static void Main()
        {
            int[] myArray = { 2, 12, 5, 1231, 1, 3140, 212, 231, 64, 12, 3 };
            Stack<int> stack = new Stack<int>();
            Sort(myArray, stack);

            Console.WriteLine("Descending sort:");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ascending sort:");
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Sort(int[] myArray, Stack<int> stack)
        {
            int max = 0;
            int maxIndex;

            for (int i = 0; i < myArray.Length; i++)
            {
                max = FindMax(myArray, i);
                maxIndex = Array.IndexOf(myArray, max);
                Swap(ref myArray[i], ref myArray[maxIndex]);
                stack.Push(myArray[i]);
            }
        }

        static void Swap(ref int x, ref int y)
        {
            x ^= y;
            y ^= x;
            x ^= y;
        }

        private static int FindMax(int[] myArray, int pos)
        {
            int max = 0;

            for (int i = pos; i < myArray.Length; i++)
            {
                if (myArray[i] > max) max = myArray[i];
            }

            return max;
        }
    }
}
