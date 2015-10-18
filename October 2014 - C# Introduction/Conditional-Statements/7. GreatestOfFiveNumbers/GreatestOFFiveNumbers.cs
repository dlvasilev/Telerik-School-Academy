using System;

// Write a program that finds the greatest of given 5 variables.

namespace _7.GreatestOfFiveNumbers
{
    class GreatestOFFiveNumbers
    {
        static void Main()
        {
            Console.Write("First number: ");
            int firstN = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int secondN = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            int thirdN = int.Parse(Console.ReadLine());

            Console.Write("Fourth number: ");
            int fourthN = int.Parse(Console.ReadLine());

            Console.Write("Fifth number: ");
            int fifthN = int.Parse(Console.ReadLine());

            int biggestN = firstN;

            if (secondN > biggestN)
            {
                biggestN = secondN;
            }
            if (thirdN > biggestN)
            {
                biggestN = thirdN;
            }
            if (fourthN > biggestN)
            {
                biggestN = fourthN;
            }
            if (fifthN > biggestN)
            {
                biggestN = fifthN;
            }

            Console.WriteLine("The biggest number is: {0}", biggestN);
        }
    }
}
