using System;

namespace _11.PrintNumInDiffSystems
{
    class PrintNumInDiffSystems
    {
        static void Main()
        {
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number); //decimal

            Console.WriteLine("{0,15:X}", number); //hex

            Console.WriteLine("{0,15:P}", number); //percentage

            Console.WriteLine("{0,15:E}", number); //scientific notation

        }
    }
}
