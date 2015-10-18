using System;

// Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 => false.

namespace _10.BitAtPosition
{
    class BitAtPosition
    {
        static void Main()
        {
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Position (counting from 0): ");
            int position = int.Parse(Console.ReadLine());

            int i = 1;
            int mask = i << position;

            Console.WriteLine("Reprezenting the number in binary: {0}", Convert.ToString(number, 2));

            Console.WriteLine("The bit at position {0} (counting from 0) is: {1}", position, (mask & number) != 0 ? 1 : 0);
        }
    }
}
