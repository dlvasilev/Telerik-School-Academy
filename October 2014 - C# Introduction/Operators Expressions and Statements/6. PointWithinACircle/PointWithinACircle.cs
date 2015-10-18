using System;

// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

namespace _6.PointWithinACircle
{
    class PointWithinACircle
    {
        static void Main()
        {
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            int cirleRadius = 5;

            Console.WriteLine(x * x + y * y <= cirleRadius * cirleRadius ? "The point is within the circle" : "The point outside the circle");
        }
    }
}
