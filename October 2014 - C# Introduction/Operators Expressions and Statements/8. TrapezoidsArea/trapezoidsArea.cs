using System;

// Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace _8.TrapezoidsArea
{
    class TrapezoidsArea
    {
        static void Main()
        {
            Console.Write("A: ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("B: ");
            float b = float.Parse(Console.ReadLine());

            Console.Write("H: ");
            float h = float.Parse(Console.ReadLine());
            
            Console.WriteLine("The trapezoid's area is: {0}", ( ( a + b ) / 2.0 ) * h );
        }
    }
}
