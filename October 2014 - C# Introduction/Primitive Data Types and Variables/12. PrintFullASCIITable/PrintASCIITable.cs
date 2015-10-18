using System;

// Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

namespace _12.PrintFullASCIITable
{
    class PrintASCIITable
    {
        static void Main()
        {
            Console.Write("ASCII Table: ");
            Console.WriteLine();

            int min = 0;
            int max = 128;
            for (int i = min; i < max; i++)
            {
                char c = (char)i;
                string display = string.Empty;
                if (char.IsWhiteSpace(c))
                {
                    display = c.ToString();
                    switch (c)
                    {
                        case '\t':
                            display = "\\t";
                            break;
                        case ' ':
                            display = "space";
                            break;
                        case '\n':
                            display = "\\n";
                            break;
                        case '\r':
                            display = "\\r";
                            break;
                        case '\v':
                            display = "\\v";
                            break;
                        case '\f':
                            display = "\\f";
                            break;
                    }
                }
                else if (char.IsControl(c))
                {
                    display = "control";
                }
                else
                {
                    display = c.ToString();
                }
                Console.WriteLine(display.PadLeft(20));
            }
        }
    }
}
