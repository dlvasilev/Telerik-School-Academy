using System;

// Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

namespace _5.BiggerElement
{
    class BiggerElement
    {
        static int bigElement(int[] arr, int index)
        {
            if (index >= 0 && index < arr.Length)
            {
                return (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) ? 1 : 0;
            }
            else
            {
                return -1;
            }
        }

        static void Main()
        {
            int[] arr = { 1, 2, 4, 3, 7, 4, 31, 6, 4, 4, 32, 4, 3, 3, 4, 42, 3, 4, 42, 67, 543, 324, 425, 63, 31, 35, 634, 43 };
            int index = 7;

            switch (bigElement(arr, index))
            {
                case 1:
                    Console.WriteLine("The element is bigger than its neighbours!");
                    break;
                case 0:
                    Console.WriteLine("The element isnt bigger than its neightbours!");
                    break;
                case -1:
                    Console.WriteLine("There is no such element");
                    break;
            }
        }
    }
}
