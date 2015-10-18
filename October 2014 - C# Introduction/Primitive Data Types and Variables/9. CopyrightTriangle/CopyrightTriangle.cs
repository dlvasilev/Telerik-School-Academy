using System;

// Write a program that prints an isosceles triangle of 9 copyright symbols ©. Note: the © symbol may be displayed incorrectly.

namespace _9.CopyrightTriangle
{
    class CopyrightTriangle
    {
        static void Main()
        {
            char copyright = (char)0xA9;
            Console.WriteLine("Nice triangle: ");
            Console.WriteLine();
            for (int i = 1; i < 4; i++)
            {
                string row = "";
                for (int spaces = 7-i; spaces > 0; spaces--)
                {
                    row += " ";
                }
                for (int ii = 1;  ii <= (2 * i) - 1; ii++)
                {
                    row += copyright;
                }
                Console.WriteLine(row);
            }
            Console.WriteLine();
        }
    }
}
