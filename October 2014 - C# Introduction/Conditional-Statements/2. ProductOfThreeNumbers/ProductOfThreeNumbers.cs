using System;

// Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

namespace _2.ProductOfThreeNumbers
{
    class ProductOfThreeNumbers
    {
        static void Main()
        {
            Console.Write("First number: ");
            int firstN = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int secondN = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            int thirdN = int.Parse(Console.ReadLine());

            if (firstN > 0 && secondN > 0 && thirdN > 0)
            {
                Console.WriteLine("The product will be with + sign");
            }
            else if (firstN < 0 && secondN < 0 && thirdN > 0)
            {
                Console.WriteLine("The product will be with + sign");
            }
            else if (firstN > 0 && secondN < 0 && thirdN < 0)
            {
                Console.WriteLine("The product will be with + sign");
            }
            else if (firstN < 0 && secondN > 0 && thirdN < 0)
            {
                Console.WriteLine("The product will be with + sign");
            }
            else
            {
                Console.WriteLine("The product will be with - sign");
            }
        }
    }
}
