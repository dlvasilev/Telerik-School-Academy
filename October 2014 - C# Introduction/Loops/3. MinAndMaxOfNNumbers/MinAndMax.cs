using System;

// Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

namespace _3.MinAndMaxOfNNumbers
{
    class MinAndMax
    {
        static void Main()
        {
            Console.Write("How much number? ");
            int range = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter now {0} integers: ", range);
            int[] array = new int[range];

            for (int i = 0; i < range; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = array[0];
            int max = array[0];

            for (int i = 0; i < range; i++)
            {
                if (min > array[i]) min = array[i];
                else if (max < array[i]) max = array[i];
            }

            Console.WriteLine("Min: {0}  Max: {1}", min, max);
        }
    }
}
