using System;

// Write a program that finds the maximal sequence of equal elements in an array.

namespace _4.MaxEqualElementsInArray
{
    class MaxEqualElementsInArray
    {
        static void Main()
        {
            Console.Write("Number of elements: ");
            int range = int.Parse(Console.ReadLine());
            int bestNum = 0,
                lenght = 0,
                bestLenght = 0;
            int[] arr = new int[range];

            Console.Write("Array[0] = ");
            arr[0] = int.Parse(Console.ReadLine());

            for (int i = 1; i < range; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i - 1] == arr[i])
                {
                    lenght++;
                    if (lenght > bestLenght)
                    {
                        bestLenght = lenght;
                        bestNum = arr[i];
                    }
                }
                else lenght = 1; 
            }


            Console.WriteLine("Maximal sequence of equal elements: ");
            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write("{0} ", bestNum);
            }
        }
    }
}
