using System;

// Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

namespace _12.Matrix
{
    class Matrix
    {
        static void Main()
        {
            Console.Write("Please insert N (0<N<20): ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 20)
            {
                Console.WriteLine("Wrong input!");
                Main();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1 + i; j++)
                {
                    Console.Write("{0}", j.ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
        }
    }
}
