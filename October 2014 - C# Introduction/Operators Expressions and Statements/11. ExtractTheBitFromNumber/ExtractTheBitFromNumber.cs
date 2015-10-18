using System;

// Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

namespace _11.ExtractTheBitFromNumber
{
    class ExtractTheBitFromNumber
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

            int bit = (mask & number) != 0 ? 1 : 0;

            Console.WriteLine("The bit is: {0}", bit);
        }
    }
}
