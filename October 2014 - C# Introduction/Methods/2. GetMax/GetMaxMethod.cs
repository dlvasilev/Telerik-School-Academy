using System;

// Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

namespace _2.GetMax
{
    class GetMaxMethod
    {
        static int GetMax(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static void Main()
        {
            Console.Write("First number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            int c = int.Parse(Console.ReadLine());

            int temp = GetMax(b, c);

            int max = GetMax(a, temp);

            Console.WriteLine("The greatest number is: {0}", max);
        }
    }
}
