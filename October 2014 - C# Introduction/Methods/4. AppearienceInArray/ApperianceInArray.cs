using System;

// Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

namespace _4.AppearienceInArray
{
    class ApperianceInArray
    {
        static int InArray(int[] arr, int num)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) temp++;
            }

            return temp;
        }

        static void Main()
        {
            int[] array = { 1, 2, 4, 3, 4, 3, 6, 3, 2, 55, 31, 32, 23, 53, 31 };
            int num = 4;

            Console.WriteLine("{0} appears {1} times in the array!", num, InArray(array, num));
        }
    }
}
