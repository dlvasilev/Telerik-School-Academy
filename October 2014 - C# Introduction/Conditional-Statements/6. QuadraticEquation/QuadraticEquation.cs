using System;

// Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0 and calculates and prints its real roots.

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Quadratic equation ax2+bx+c=0 !");

            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());

            float D = b * b - 4 * a * c;

            if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("The number of real roots is infinity");
            }
            else if (a == 0 && b == 0 && c != 0)
            {
                Console.WriteLine("There are no any real roots");
            }
            else if (a == 0 && b != 0)
            {
                float x1 = -(c / b);
                Console.WriteLine("The equation is linear. The real root is: {0}", x1);
            }
            else if (D == 0)
            {
                float x1 = (float)(b / (2 * a));
                Console.WriteLine("There is only one root: {0}", x1);
            }
            else if (D < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
            else if (D > 0)
            {
                float x1 = (float)((-b - Math.Sqrt(D)) / (2 * a));
                float x2 = (float)((-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("The real roots are: {0} and {1}", x1, x2);
            }
            else
            {
                Console.WriteLine("There are no any real roots");
            }
        }
    }
}
