using System;

// Write a program that safely compares floating-point numbers with precision of 0.000001.

namespace _3.CompareFloatingPointNumbers
{
    class CompareFloatingPointNumbers
    {
        static void Main()
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Are they equal? ");
            Console.Write(a == b);
        }
    }
}
