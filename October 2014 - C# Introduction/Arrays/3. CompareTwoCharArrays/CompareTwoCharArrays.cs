using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

namespace _3.CompareTwoCharArrays
{
    class CompareTwoCharArrays
    {
        static void Main()
        {
            Console.Write("Number of chars to compare: ");
            int range = int.Parse(Console.ReadLine());

            char[] firstArray = new char[range];
            char[] secondArray = new char[range];

            for (int i = 0; i < range; i++)
            {
                Console.WriteLine("firstArray[{0}] = ", i);
                firstArray[i] = char.Parse(Console.ReadLine());
                Console.WriteLine("secondArray[{0}] = ", i);
                secondArray[i] = char.Parse(Console.ReadLine());

                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("secondArray is first");
                } 
                else if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("firstArray is first");
                }
            }
        }
    }
}
