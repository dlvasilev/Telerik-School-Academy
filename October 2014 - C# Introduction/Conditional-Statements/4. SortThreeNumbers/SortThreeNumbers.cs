using System;

// Sort 3 real values in descending order using nested if statements.

namespace _4.SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main()
        {
            Console.Write("First number: ");
            int firstN = int.Parse(Console.ReadLine());

            Console.Write("Second number: ");
            int secondN = int.Parse(Console.ReadLine());

            Console.Write("Third number: ");
            int thirdN = int.Parse(Console.ReadLine());

            int temp;

            if (firstN < secondN)
            {
                temp = firstN;
                firstN = secondN;
                secondN = temp;

                if (secondN < thirdN)
                {
                    temp = secondN;
                    secondN = thirdN;
                    thirdN = temp;

                    if (firstN < secondN)
                    {
                        temp = firstN;
                        firstN = secondN;
                        secondN = temp;
                    }
                }
            }
            else
            {
                if (secondN < thirdN)
                {
                    temp = secondN;
                    secondN = thirdN;
                    thirdN = temp;

                    if (firstN < secondN)
                    {
                        temp = firstN;
                        firstN = secondN;
                        secondN = temp;
                    }
                }
            }

            Console.WriteLine("First: {0} Second: {1} Third: {2}", firstN, secondN, thirdN);
        }
    }
}
