using System;

// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).

namespace _1.PrintName
{
    class PrintName
    {
        static void HelloName(string name)
        {
            Console.WriteLine("Hello {0}!", name);
        }


        static void Main()
        {
            Console.Write("Hello I am your computer! Whats your name? ");
            string name = Console.ReadLine();

            HelloName(name);
        }
    }
}
