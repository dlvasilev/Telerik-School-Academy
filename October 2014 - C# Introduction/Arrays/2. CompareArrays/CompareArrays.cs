using System;

// Write a program that reads two arrays from the console and compares them element by element.

namespace _2.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Number of elements in the arrays: ");
            int range = int.Parse(Console.ReadLine());

            int[] firstArray = new int[range];
            int[] secondArray = new int[range];

            Console.WriteLine("Insert the elements for the first array: ");
            for (int i = 0; i < range; i++)
            {
                Console.Write("firstArray[{0}] = ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insert the elements for the second array: ");
            for (int i = 0; i < range; i++)
            {
                Console.Write("secondArray[{0}] = ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Comparing the elements in the arrays...");

            for (int i = 0; i < range; i++)
            {
                Console.WriteLine("firstArray[{0}] = {1} {3} secondArray[{0}] = {2}", i, firstArray[i], secondArray[i], (firstArray[i] > secondArray[i]) ? ">" : "<");
            }
        }
    }
}
