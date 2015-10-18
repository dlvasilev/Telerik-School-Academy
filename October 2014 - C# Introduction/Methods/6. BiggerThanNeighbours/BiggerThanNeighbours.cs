using System;

// Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.

namespace _6.BiggerThanNeighbours
{
    class BiggerThanNeighbours
    {
        static int bigElement(int[] arr, int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                return (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) ? index : 0;
            }
            else
            {
                return -1;
            }
        }

        static void Main()
        {
            int[] arr = { 1, 2, 4, 3, 7, 4, 31, 6, 4, 4, 32, 4, 3, 3, 4, 42, 3, 4, 42, 67, 543, 324, 425, 63, 31, 35, 634, 43 };


            int temp = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                temp = bigElement(arr, i);
                if (temp > 0)
                {
                    Console.WriteLine("The first element bigger than its neighbours is: array[{0}] = {1}", i, arr[i]);
                    break;
                }
            }

            if (temp == -1) Console.WriteLine("There is no element in the array that is bigger than its neighbours!");
        }
    }
}
