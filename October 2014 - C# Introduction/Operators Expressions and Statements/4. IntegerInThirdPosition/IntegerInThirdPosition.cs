using System;

// Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 => true.

namespace _4.IntegerInThirdPosition
{
    class IntegerInThirdPosition
    {
        static void Main()
        {
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            
            Console.Write("Digit: ");
            int digit = int.Parse(Console.ReadLine());

            Console.WriteLine("The digit from the number {0} on its third position is {1}, Is it equal to {2}? {3}", number, (number / 100) % 10, digit, (number / 100) % 10 == digit ? "True" : "False");
        }
    }
}
