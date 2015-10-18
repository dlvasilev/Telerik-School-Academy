using System;

// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
// Test Number = 56;

namespace _13.ExchangeBitValues
{
    class ExchangeBitValues
    {

        static uint BitValues(uint number, short position)
        {
            uint mask = (uint)1 << position;
            uint bitValue = number & mask;

            return bitValue >> position;
        }

        static uint ChangeBitValues(uint number, short position, uint value)
        {
            if (value == 1)
            {
                uint mask = (uint)1 << position;
                return number | mask;
            }
            else
            {
                uint mask = (uint)~(1 << position);
                return number & mask;
            }
        }

        static void Main()
        {
            Console.Write("Number: ");
            uint number = uint.Parse(Console.ReadLine());

            Console.WriteLine("Before: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

            uint bitThree = BitValues(number, 3);
            uint bitFour = BitValues(number, 4);
            uint bitFive = BitValues(number, 5);

            uint bitTwentyFour = BitValues(number, 24);
            uint bitTwentyFive = BitValues(number, 25);
            uint bitTwentySix = BitValues(number, 26);

            number = ChangeBitValues(number, 3, bitTwentyFour);
            number = ChangeBitValues(number, 24, bitThree);

            number = ChangeBitValues(number, 4, bitTwentyFive);
            number = ChangeBitValues(number, 25, bitFour);

            number = ChangeBitValues(number, 5, bitTwentySix);
            number = ChangeBitValues(number, 26, bitFive);

            Console.WriteLine("After: {0}", Convert.ToString(number, 2).PadLeft(32, '0'));

        }
    }
}
