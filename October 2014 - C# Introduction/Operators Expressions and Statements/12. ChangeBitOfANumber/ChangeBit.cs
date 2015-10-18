using System;

// We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.

namespace _12.ChangeBitOfANumber
{
    class ChangeBit
    {
        static void Main()
        {
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Position (counting from 0): ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Bit Value (0 or 1): ");
            int value = int.Parse(Console.ReadLine());

            int mask = 1 << position;

            Console.WriteLine("In the beginning the number {0} represented in binary: {1}", number, Convert.ToString(number, 2).PadLeft(8, '0'));

            if ((mask & number) != 0)
            {
                number &= ~(1 << position);
            }
            else
            {
                number |= (1 << position);
            }

            Console.WriteLine("In the end the number {0} represented in binary: {1}", number, Convert.ToString(number, 2).PadLeft(8, '0'));
        }
    }
}
