using System;

// Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

namespace _1.IfBiggerChange
{
    class IfBiggerChange
    {
        static void Main()
        {
            Console.Write("First number: ");
            int firstN = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int secondN = int.Parse(Console.ReadLine());

            if (secondN > firstN)
            {
                int temp = firstN;
                firstN = secondN;
                secondN = temp;
                Console.WriteLine("Second number is bigger then the first... So I changed them...");
            }
            else
            {
                Console.WriteLine("The first number is bigger then the second...");
            }

            Console.WriteLine("First: {0} Second: {1}", firstN, secondN);
        }
    }
}
