using System;

// Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

namespace _5.ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            Console.Write("Insert number: ");
            int number = int.Parse(Console.ReadLine());

            int i = 1;
            int numMask = i << 3;

            Console.WriteLine("The number in binary is: {0}", Convert.ToString(number, 2));
            Console.WriteLine("The third bit (counting from 0) is: {0}", (numMask & number) != 0 ? 1 : 0);
        }
    }
}
