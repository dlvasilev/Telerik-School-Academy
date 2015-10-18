using System;

// Write a program that finds the biggest of three integers using nested if statements.

namespace _3.BiggestOfThreeNestedIfs
{
    class BiggestOfThreeNEstesdIfs
    {
        static void Main()
        {
            Console.Write("First number: ");
            int firstN = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int secondN = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            int thirdN = int.Parse(Console.ReadLine());

            int biggestN = firstN;

            if (secondN > biggestN)
            {
                biggestN = secondN;

                if (thirdN > biggestN)
                {
                    biggestN = thirdN;
                }
            }

            Console.WriteLine("The biggest is: {0}", biggestN);
        }
    }
}
