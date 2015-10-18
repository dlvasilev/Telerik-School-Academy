using System;

// We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.

namespace _9.SumOfSomeSubset
{
    class SumOfSomeSubset
    {
        static void Main()
        {
            Console.WriteLine("Please enter 5 integers: ");
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int localSum = 0;
            int bestLength = 1;
            int startIndex = 0;

            bool existingSequence = false;

            Array.Sort(array);

            for (int i = 0; i < 5 - 1; i++)
            {
                int length = 1;
                localSum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    localSum += array[j];
                    length++;
                    if (localSum == 0)
                    {
                        existingSequence = true;
                        startIndex = i;
                        bestLength = length;
                        break;
                    }
                }
            }

            if (existingSequence == true)
            {
                Console.Write("Sum found in sequence: {");
                for (int i = 0, index = startIndex; i < bestLength; i++, index++)
                {
                    if (i == bestLength - 1)
                    {
                        Console.Write(array[index]);
                        break;
                    }
                    Console.Write(array[index] + " ");
                }
                Console.Write("}");
                Console.WriteLine();
            }

            else if (existingSequence == false)
            {
                Console.WriteLine("No sequence have sum of 0");
                return;
            }
        }
    }
}
