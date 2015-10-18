using System;

// Write an expression that checks if given integer is odd or even.

namespace _1.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} is {1}", number, number%2 == 0 ? "even" : "odd");
        }
    }
}
